function cabinetView(container) {

    function imageCenter() {

        var imgWidth = $(container + " .photoWrapper img").width();

        $(container + " .photoWrapper img").css({ "left": -imgWidth / 2 });
    }

    return ({
        init: function () {

            imageCenter();
        }
    })
}

$(document).ready(function () {

    var CabinetView = cabinetView(".cabinet").init();
})

