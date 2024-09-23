const sidebarSection = $('.sidebar-section');

$(() => {

})

$('#sidebar-button').click(() => {
    
    sidebarSection.hasClass('collapsed') ? sidebarSection.removeClass('collapsed') : sidebarSection.addClass('collapsed')



    // if(sidebarSection.hasClass('collapsed')){
    //     sidebarSection.removeClass('collapsed')
    // }
    // else{
    //     sidebarSection.addClass('collapsed')
    // }

})