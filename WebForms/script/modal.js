window.showModal = function () {
    const modalDiv = document.getElementById("modalDiv");
    if (modalDiv) {
        modalDiv.style.display = "block";
    }
};

window.closeModal = function () {
    const modalDiv = document.getElementById("modalDiv");
    if (modalDiv) {
        modalDiv.style.display = "none";
    }
};

window.onclick = function (event) {
    const modalDiv = document.getElementById("modalDiv");
    if (event.target === modalDiv) {
        modalDiv.style.display = "none";
    }
};