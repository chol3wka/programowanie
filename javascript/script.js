$(function(){
     
$('.link').css({
    'color': 'black',
    'text-decoration':'none',
});
$('[href="#"]').attr('href','https://wikipedia.org')

$('.link:gt(2)').css({
    'color': 'red',
    'text-decoration':'none',
});


let $zmiana = $('li').eq(2).html();
$('li').eq(2).remove();
$('ul').prepend('<li>' + $zmiana + '</li>');


});