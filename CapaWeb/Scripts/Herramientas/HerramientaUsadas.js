function ObtenerUrl() {
    var loc = window.location;
    var pathName = loc.pathname.substring(0, loc.pathname.lastIndexOf('/') + 1);    
    return loc.href.substring(0, loc.href.length - ((loc.pathname + loc.search + loc.hash).length - pathName.length));
    
}

function host() {
    return location.host;
}

function protocolo() {
    return location.protocol;
}
function urlLocal() {
    var x = protocolo() + "//" + host();
    return x;
}