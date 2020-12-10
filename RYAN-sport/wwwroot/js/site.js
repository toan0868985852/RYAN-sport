var swiper = new Swiper(".swiper-container", {
    slidesPerView: 1,
    loop: true,
    autoplay: {
        delay: 2500,
        disableOnInteraction: false,
    },
    pagination: {
        el: ".swiper-pagination",
        clickable: true,
    },
    navigation: {
        nextEl: ".swiper-button-next",
        prevEl: ".swiper-button-prev",
    },
});

filterSelection("all");

function filterSelection(c) {
    var x, y, i, j;
    x = document.getElementsByClassName("image");
    y = document.getElementsByClassName("tab");

    for (j = 0; j < y.length; j++) {
        RemoveClass(y[j], "show");
        if (y[j].className.indexOf(c) > -1) {
            AddClass(y[j], "show");
        }

        if (c == "all") {
            c = "";
        }

        for (i = 0; i < x.length; i++) {
            RemoveClass(x[i], "show");
            if (x[i].className.indexOf(c) > -1) {
                AddClass(x[i], "show");
            }
        }
    }

    function AddClass(element, name) {
        element.classList.add(name);
    }

    function RemoveClass(element, name) {
        element.classList.remove(name);
    }
}

window.addEventListener('scroll', function (){
    var header = document.querySelector("header");
    header.classList.toggle('sticky', window.scrollY > 300)
})
