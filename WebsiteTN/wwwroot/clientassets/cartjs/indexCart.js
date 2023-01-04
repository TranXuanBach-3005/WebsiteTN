$(function () {
    function loadHeaderCart() {
        $('#miniCart').load("/AjaxSoucre/HeaderCart");
        $('#numberCart').load("/AjaxSoucer/NumberCart");
    }
    $(".removerCart").click(function () {
        var productId = $(this).attr("data-id");
        $.ajax({
            url: "api/cart/remove",
            type: "POST",
            dataType: "JSON",
            data: { productId: productId },
            success: function (result) {
                if (result.success) {
                    loadHeaderCart();
                    location.reload();
                }
            },
            error: function (rs) {
                alert("Remove Cart Error");
            }
        });
    });
    $(".cartItem").click(function () {
        var productId = $(this).attr("data-id");
        var quantity = parseInt($(this).val());
        $.ajax({
            url: "api/cart/update",
            type: "POST",
            dataType: "JSON",
            data: {
                productId: productId,
                quantity: quantity
            },
            success: function (result) {
                if (result.success) {
                    loadHeaderCart();
                    window.location = 'cart.html';
                }
            },
            error: function (rs) {
                alert("Update Cart Error");
            }
        });
    });
});