var global = urlLocal();
$(document).ready(function () {   
    
    $("#btnOk").click(function () {
        var usuario = $("#login-username").val();
        var pass = $("#login-password").val();        
        var paramentros = {
            "usuario": usuario,            "pass":pass
        };
        $.ajax({
            url: global+'//' +'Login/ValidarUsuario',     
            type: 'POST',
            cache: false,
            async: false,
            data: paramentros,
            dataType: "json",
            success: function (data) {
              
                if (data.Exito == true) {
                    window.location = global + '/' + 'Home/Index';                   
                    
                }
                else {
                    alert(data.Mensaje);
                }
                

            },
            error: errorHandler = function (xhr, errorType, exception) {
                alert(exception + xhr.statusText);
            }
        });

    });
});
function quitarCaracter(cadena, caracter) {
    alert(cadena);
    
    while (cadena.includes(caracter)) {
        cadena = cadena.replace(caracter, "");
    }
    
    return cadena;
}
function getAbsolutePath() {
    var loc = window.location;
    var pathName = loc.pathname.substring(0, loc.pathname.lastIndexOf('/') + 1);
    return loc.href.substring(0, loc.href.length - ((loc.pathname + loc.search + loc.hash).length - pathName.length));
}
function obtenerUrl() {
    var url = window.location;


    /*
    for (var i = 0; i<= arra.length; i++) {
        if (i == arra.length - 1) {
            arra[i] = arra[i].replace("#", "");
            alert(arra[i]);
        }
    }*/

    //url = quitarCaracter(url, "#");
    

}

