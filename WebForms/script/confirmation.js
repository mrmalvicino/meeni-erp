document.querySelector(".danger-button").addEventListener("click", function (event) {
    if (!confirm("¿Estás seguro de que querés realizar esta acción?")) {
        event.preventDefault();
    }
});
