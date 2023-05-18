
function show_tile() {

    let row = $("#row").val();
    let col = $("#col").val();
    let zoom = $("#zoom").val();
    let tile_container = document.getElementById("tile_div");
    let xhttp= new XMLHttpRequest();
    xhttp.onreadystatechange= function() {
        if (this.readyState === 4 && this.status === 200) {

            let img = new Image();
            img.src = 'https://c.tile-cyclosm.openstreetmap.fr/cyclosm/' + zoom + '/' + col + '/' + row + '.png';

            tile_container.innerHTML = '';

            img.onload = function () {
                tile_container.appendChild(img);
            }

            img.onerror = function () {
                let errorText = document.createElement("p");
                errorText.textContent = 'Failed to load image';
                tile_container.appendChild(errorText);
            };

        }else {
            tile_container.innerHTML = '';
            let errorText = document.createElement("p");
            errorText.textContent = 'Failed to load image';
            tile_container.appendChild(errorText);
        }
    };

    xhttp.open("GET",'https://c.tile-cyclosm.openstreetmap.fr/cyclosm/' + zoom + '/' + col + '/' + row + '.png',true);
    xhttp.send();

}

$(document).ready(function(){
    $("#left_tile").click(function(){
        let col_val = $("#col");
        let col_int = parseInt(col_val.val());
        col_val.val(col_int - 1);
    });
});

$(document).ready(function(){
    $("#right_tile").click(function(){
        let col_val = $("#col");
        let col_int = parseInt(col_val.val());
        col_val.val(col_int + 1);
    });
});

$(document).ready(function(){
    $("#top_tile").click(function(){
        let row_val = $("#row");
        let row_int = parseInt(row_val.val());
        row_val.val(row_int - 1);
    });
});

$(document).ready(function(){
    $("#bottom_tile").click(function(){
        let row_val = $("#row");
        let row_int = parseInt(row_val.val());
        row_val.val(row_int + 1);
    });
});
