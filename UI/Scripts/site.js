jQuery(document).ready(function () {
    var sidenav = $('.side-nav-wrapper'),
		sidenavTrigger = $('.sidenav-trigger');
 
    $('#current-user-dropdown').dropdown();


    $(".menu-trigger").on('click', function (event) {
        event.preventDefault();
        $(".menu-trigger, .app-header-menu").toggleClass('menu-is-visible');
    });

    sidenavTrigger.on('click', function (event) {
        event.preventDefault();
        $([sidenav, sidenavTrigger]).toggleClass('nav-is-visible');
    });

    $(".sidenav-fold-trigger").on('click', function (event) {  //use a class, since your ID gets mangled
        $('.app').toggleClass("sidenav-is-folded");      //add the class to the clicked element
    });

    //click on item and show submenu
    $('.has-children > a').on('click', function (event) {
        //var mq = checkMQ(),
        selectedItem = $(this);
        //if (mq == 'mobile' || mq == 'tablet') {
        event.preventDefault();
        if (selectedItem.parent('li').hasClass('selected')) {
            selectedItem.parent('li').removeClass('selected');
        } else {
            sidenav.find('.has-children.selected').removeClass('selected');
            //accountInfo.removeClass('selected');
            selectedItem.parent('li').addClass('selected');
        }
        //}
    });

    //sidenav.children('ul').menuAim({
    //    activate: function (row) {
    //        $(row).addClass('hover');
    //    },
    //    deactivate: function (row) {
    //        $(row).removeClass('hover');
    //    },
    //    exitMenu: function () {
    //        sidenav.find('.hover').removeClass('hover');
    //        return true;
    //    },
    //    submenuSelector: ".has-children",
    //});

});