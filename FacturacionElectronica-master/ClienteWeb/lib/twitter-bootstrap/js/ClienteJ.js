$('#btnSeleccionar').click(function () {
    $('#ddlBuscarCliente').html('');
    $post(this.baseURI+"clientej/")
}
    )



selClientej = function (RUC_CJ, Razon_Social) {
    $('#myModal').val(RUC_CJ);
    $('#myModal').val(Razon_Social);
}