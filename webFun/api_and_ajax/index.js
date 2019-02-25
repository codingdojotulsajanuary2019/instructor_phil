$(document).ready(function(){
    // $.get()
    // $.post()
    $.ajax({
        method: 'get',
        url: 'https://pokeapi.co/api/v2/pokemon/5',
        // data: send post data
        dataType: 'json',
        success: function(res) {
            // get the info form the request
            console.log(res);
            $('div').html(`<img src=${res.sprites.back_default} alt='pokemon'>`);
        },
        error: function(err) {
            // server error
        },
        complete: function(next) {
            // regardless of success or error, this will run
            console.log('in done method');
        }
    })
    console.log('after the ajax method');

})