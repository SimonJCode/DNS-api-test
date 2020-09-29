// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

async function GetSecret() {
    var domain = document.getElementById("domainValue").value;
    var port = document.getElementById("portValue").value;

    const response = await fetch("http://" + domain + ":" + port + "/api/v1/secret")
        .then(res => res.json())
        .then(res => alert(res.secret))
}