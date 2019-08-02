function UsuarioActual() {
    $.get('/AjaxData/ObtenerNombreUsuario').done(function (u) {
        $("#usuarioActivo").html('¡Bienvenido <em>' + u + '<em>!');
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
                + '<td><button class="btn btn-primary" onclick=edicion(' + this.Id + ')>Editar</button></td>'
                + '<tr>'
            );
        });
    }).fail();
}

function Crear() {
    var nombre = $("#Nombre").val();
    var tipado = $("#Tipado").val();
    var extension = $("#Extension").val();
    var aparicion = $("#Aparicion").val();
    var creador = $("#Creador").val();

    var obj = { Nombre: nombre, Tipado: tipado, Extension: extension, Aparicion: aparicion, Creador: creador };

    $.post('/AjaxData/Crear', obj).done(function () {
        location.href = '/Home/Index';
    }).fail();
}

function Obtener() {
    // Get saved data from sessionStorage
    let myId = sessionStorage.getItem('myId');
    var url = '/AjaxData/Obtener/' + myId;
    $.get(url).done(function (obj) {
        $("#Id").val(obj.Id);
        $("#Nombre").val(obj.Nombre);
        $("#Tipado").val(obj.Tipado);
        $("#Extension").val(obj.Extension);
        $("#Aparicion").val(obj.Aparicion);
        $("#Creador").val(obj.Creador);
    }).fail();
}

function edicion(id) {
    sessionStorage.setItem('myId', id);
    location.href = '/Home/Editar';
}

function Editar() {
    var id = $("#Id").val();
    var nombre = $("#Nombre").val();
    var tipado = $("#Tipado").val();
    var extension = $("#Extension").val();
    var aparicion = $("#Aparicion").val();
    var creador = $("#Creador").val();

    var obj = { Id: id, Nombre: nombre, Tipado: tipado, Extension: extension, Aparicion: aparicion, Creador: creador };

    $.post('/AjaxData/Editar', obj).done(function () {
        location.href = '/Home/Index';
    }).fail();
}
