function UsuarioActual() {
    $.get('/AjaxData/ObtenerNombreUsuario').done(function (data) {
        $("#usuarioActivo").html('¡Bienvenido <em>' + data + '<em>!');
    }).fail();
}

function CargarLista() {
    $.get('/AjaxData/Listar').done(function (data) {
        $.each(data, function () {
            $("#datosTabla").append(
                '<tr>'
                + '<td>' + this.Id + '</td>'
                + '<td>' + this.Nombre + '</td>'
                + '<td>' + this.Creador + '</td>'
                + '<td>' + this.Aparicion + '</td>'
                + '<td>' + this.Tipado + '</td>'
                + '<td>' + this.Extension + '</td>'
                + '<tr>'
            );
        });
    }).fail();
}