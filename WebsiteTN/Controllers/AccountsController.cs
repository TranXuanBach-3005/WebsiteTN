using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebsiteTN.Extension;
using WebsiteTN.Helpper;
using WebsiteTN.Models;
using WebsiteTN.ModelViews;

namespace WebsiteTN.Controllers
{
    [Authorize]
    public class AccountsController : Controller
    {

        private readonly DataDbContext _context;
        private readonly INotyfService _notyfService;
        public AccountsController(DataDbContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult ValidatePhone(string Phone)
        {
            try
            {
                var customer = _context.Customers.AsNoTracking()
                                                 .SingleOrDefault(x => x.Phone.ToLower() == Phone.ToLower());
                if (customer != null)
                {
                    return Json(data: "Số điện thoại:" + Phone + "đã tồn tại");
                }
                return Json(data: true);
            }
            catch (Exception)
            {
                return Json(data: true);
            }
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult ValidateEmail(string Email)
        {
            try
            {
                var customer = _context.Customers.AsNoTracking()
                                                 .SingleOrDefault(x => x.Email.ToLower() == Email.ToLower());
                if (customer != null)
                {
                    return Json(data: "Số điện thoại:" + Email + "đã tồn tại");
                }
                return Json(data: true);
            }
            catch (Exception)
            {
                return Json(data: true);
            }
        }
        [HttpGet]
        [Route("dashboard.html")]
        public IActionResult Dashboard()
        {
            var accountId = HttpContext.Session.GetString("CustomerId");
            if (accountId != null)
            {
                var costomer = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CustomerId == Convert.ToInt32(accountId));
                if (costomer != null)
                {
                    var listOrder = _context.Orders.Include(x => x.TransactStatus)
                                                   .AsNoTracking()
                                                   .Where(x => x.CustomerId == costomer.CustomerId)
                                                   .OrderByDescending(x => x.OrderDate)
                                                   .ToList();
                    ViewBag.Orders = listOrder;
                    return View(costomer);
                }
            }
            return RedirectToAction("Login");
        }
        [HttpGet]
        [AllowAnonymous]
        [Route("dang-ky.html", Name = "Register")]
        public IActionResult RegisterAccount()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [Route("dang-ky.html", Name = "Register")]
        public async Task<IActionResult> RegisterAccount(RegisterVm registerVm)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string salt = Utilities.GetRandomKey();
                    Customer customer = new Customer
                    {
                        FullName = registerVm.FullName,
                        Phone = registerVm.Phone,
                        Email = registerVm.Email.Trim().ToLower(),
                        Password = (registerVm.Password + salt.Trim()).ToMD5(),
                        Active = true,
                        Salt = salt,
                        CreateDate = DateTime.Now
                    };
                    try
                    {
                        _context.Add(customer);
                        await _context.SaveChangesAsync();
                        //lưu sessioncuar mật khẩu
                        HttpContext.Session.SetString("CustomerId", customer.CustomerId.ToString());
                        var accountId = HttpContext.Session.GetString("CustomerId");
                        //Identity
                        var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, customer.FullName),
                            new Claim("CustomerId", customer.CustomerId.ToString())
                        };
                        ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "login");
                        ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                        await HttpContext.SignInAsync(claimsPrincipal);
                        return RedirectToAction("Dashboard", "Accounts");
                    }
                    catch (Exception ex)
                    {
                        return RedirectToAction("RegisterAccount", "Accounts");
                    }
                }
                else
                {
                    return View(registerVm);
                }
            }
            catch
            {
                return View(registerVm);
            }
        }
        [HttpGet]
        [AllowAnonymous]
        [Route("/dang-nhap.html", Name = "Login")]
        public IActionResult Login()
        {
            var accountId = HttpContext.Session.GetString("CustomerId");
            if (accountId != null)
            {
                return RedirectToAction("Dashboard", "Accounts");
            }
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [Route("/dang-nhap.html", Name = "Login")]
        public async Task<IActionResult> Login(LoginVm loginVm, string returnUrl)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool isEmail = Utilities.IsValidEmail(loginVm.UserName);
                    if (!isEmail) return View(loginVm);
                    var account = _context.Customers.AsNoTracking().SingleOrDefault(x => x.Email.Trim() == loginVm.UserName);
                    if (account == null) return RedirectToAction("RegisterAccount");
                    string password = (loginVm.Password + account.Salt.Trim()).ToMD5();
                    if (account.Password != password)
                    {
                        _notyfService.Warning("Sai mật khẩu");
                        return View(loginVm);
                    }
                    if (account.Active == false)
                    {
                        return RedirectToAction("ThongBao", "Accounts");
                    }
                    //Lưu session mk
                    HttpContext.Session.SetString("CustomerId", account.CustomerId.ToString());
                    var accountId = HttpContext.Session.GetString("CustomerId");

                    var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, account.FullName),
                            new Claim("CustomerId", account.CustomerId.ToString())
                        };
                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "login");
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                    await HttpContext.SignInAsync(claimsPrincipal);
                    if (string.IsNullOrEmpty(returnUrl))
                    {
                        _context.Customers.Attach(account);
                        account.LastLogin = DateTime.Now;
                        _context.Entry(account).Property(x => x.LastLogin).IsModified = true;
                        _context.SaveChanges();
                        return RedirectToAction("Dashboard", "Accounts");
                    }
                    else
                    {
                        return Redirect(returnUrl);
                    }
                }
            }
            catch (Exception ex)
            {
                return RedirectToAction("RegisterAccount", "Accounts");
            }
            return View(loginVm);
        }
        [HttpPost]
        public IActionResult ChangePassword(ChangePasswordViewModel viewModel)
        {
            try
            {
                var accountId = HttpContext.Session.GetString("CustomerId");
                if (accountId == null)
                {
                    return RedirectToAction("Login", "Accounts");
                }
                if (ModelState.IsValid)
                {
                    var account = _context.Customers.Find(Convert.ToInt32(accountId));
                    if (account == null)
                    {
                        return RedirectToAction("Login", "Accounts");
                    }
                    else
                    {
                        var pass = (viewModel.PasswordNow.Trim() + account.Salt.Trim()).ToMD5();
                        string passwordNew = (viewModel.Password.Trim() + account.Salt.Trim()).ToMD5();
                        account.Password = passwordNew;
                        _context.Update(account);
                        _context.SaveChanges();
                        _notyfService.Success("Đổi mật khẩu thành công");
                        return RedirectToAction("Dashboard", "Accounts");
                    }
                }
            }
            catch
            {
                _notyfService.Error("Đổi mật khẩu không thành công");
                return RedirectToAction("Dashboard", "Accounts");
            }
            _notyfService.Error("Thay đổi mật khẩu không thành công");
            return RedirectToAction("Dashboard", "Accounts");
        }
        [HttpGet]
        [Route("dang-xuat.html", Name ="Logout")]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            HttpContext.Session.Remove("CustomerId");
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
