// all of the custom jQuery code
$(document).ready(function(){
    
    // click 
    $('p').click(function() {
        console.log('paragraph clicked');
        // this refers to the element(p) that was clicked
        var paraText = $(this).text();
        console.log(paraText);
        $(this).text('Hello World!');
    })
    // text
})