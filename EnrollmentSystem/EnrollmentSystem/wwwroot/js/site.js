// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).on('click', '.overlay', function () {
    $("#sidebarIco").toggleClass('fa-indent fa-outdent');
    $('#sidebar, #side-content, .overlay').removeClass('active');
});

$(document).on('click', '#sidebarCollapse', function () {
    $("#sidebarIco").toggleClass('fa-outdent fa-indent');
    $('#sidebar, #side-content, .overlay').toggleClass('active');
});
