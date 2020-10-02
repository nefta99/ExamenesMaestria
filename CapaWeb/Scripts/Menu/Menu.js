var global = urlLocal();
$(document).ready(function () {
    $("#ACerrar").click(function () {
        cerrarSession();
    });
    llenarMenu();

});

function cerrarSession() {
    var paramentros = {
        "opt": "cerrarSession"
    };
    $.ajax({
        url: '../Clases/Remo/remoto.php',
        type: 'POST',
        cache: false,
        async: false,
        data: paramentros,
        dataType: "json",
        success: function (data) {

            window.location = data.ur;

        },
        error: errorHandler = function (xhr, errorType, exception) {
            console.log(exception + xhr.statusText);
        }
    });
}

function llenarMenu() {
    var usuario = $("#hdfusuario").val();
    var paramentros = {
        "opt": "CrearMenu",
        "user": usuario
    };
    $.ajax({
        url: global + '//' +'Home/VerTipoUsuario',
        type: 'POST',
        cache: false,
        async: true,
        data: paramentros,
        dataType: "json",
        success: function (data) {
            
            var html = '';
            if (data.TipoUsuario == "Administrador") {
                /*
                html += '<li><a href="' + data.url + 'Materias.php">Materias</a></li>';
                html += '<li><a href="' + data.url + 'Capitulos.php">Capitulos</a></li>';
                html += '<li><a href="' + data.url + 'Preguntas.php" >Preguntas</a></li>';
                html += '<li><a href="' + data.url + 'Examenes.php" >Examenes</a></li>';
                html += '<li><a href="' + data.url + 'Resultados.php">Resultados</a></li>';
                html += '<li><a href="' + data.url + 'Usuarios.php" >Usuarios</a></li>';
                */            
                html += '<li><a href="' + data.url + '/Materias/Index">Materias</a></li>';
                html += '<li><a href="' + data.url + '/Capitulo/Index">Capitulos</a></li>';
                html += '<li><a href="' + data.url + '/Pregunta/Index" >Preguntas</a></li>';
                html += '<li><a href="' + data.url + '/Examen/Index" >Examenes</a></li>';
                html += '<li><a href="' + data.url + '/Resultado/Index">Resultados</a></li>';
                html += '<li><a href="' + data.url + '/Usuario/Index" >Usuarios</a></li>';

            } else {
                //usuario con perfil de alumno
                /*
                html += '<li><a href="' + data.url + 'Examenes.php" >Examenes</a></li>';
                html += '<li><a href="' + data.url + 'Resultados.php">Resultados</a></li>';
                */
                html += '<li><a href="' + data.url + '/Examen/Index" >Examenes</a></li>';
                html += '<li><a href="' + data.url + '/Resultado/Index">Resultados</a></li>';

            }

            $("#crearmenu").append(html);

        },
        error: errorHandler = function (xhr, errorType, exception) {
            console.log(exception + xhr.statusText);
        }
    });
}
