$(document).ready(function () {
    $("#more_filter").click(function () {
        $("#hided").toggleClass("hidden");
    });
});

function myFunction(x) {
    x.classList.toggle("fa-solid");
}

(function () {
    'use strict';

    let style = document.createElement('style');
    style.innerHTML = '*{ user-select: none !important; }';

    document.body.appendChild(style);
})();

