$(document).ready(function () {
    $(function () {
        $(".add-to-cart").click(function () {
            var productId = $('#productId').val();
            var quantity = $('#txtQuantity').val();
            $.ajax({
                url: '/api/cart/add',
                type: "POST",
                dataType: "json",
                data: {
                    productId: productId,
                    quantity: quantity
                },
                success: function (response) {
                    if (response.result == 'Redirect') {
                        window.location = response.url;
                    }
                    else {
                        loadHeaderCart(); //Add Product success
                        location.reload();
                    }
                    console.log(response);
                },
                error: function (error) {
                    alert("There was an error posting the data to the server: " + error.responseText);
                }
            });
        });
    });
    function loadHeaderCart() {
        $('#miniCart').load("/AjaxContent/HeaderCart");
        $('#numberCart').load("/AjaxContent/NumberCart");
    }
});