var kisilistesi = [];
var kisiekle=function()
    {
    var kisi = {};
    kisi.ad = get("txtadsoyad").value;
    if (kisi.ad == "")
    {
        alert("uygun formatta isim giriniz")
    }
    else 
    {
        kisi.email = get("txtemail").value;
        alert("uygun formatta isim giriniz")
        }
    kisi.bilgileri = function () {
        return kisi.ad + " " + kisi.email;
    }
    kisilistesi.push(kisi);
    get("kisiler").innerHTML += kisi.bilgileri() + "</br>";
}
function get(elementID) {
    return document.getElementById(elementID);
}