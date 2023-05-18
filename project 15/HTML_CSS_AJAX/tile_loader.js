function show_tile() {

    let row = document.getElementById("row").value;
    let col = document.getElementById("col").value;
    let zoom = document.getElementById("zoom").value;
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

function left_tile(){
    let col_val = document.getElementById("col");
    let col_int  = parseInt(col_val.value);
    col_val.value = col_int - 1;
}

function right_tile(){
    let col_val = document.getElementById("col");
    let col_int  = parseInt(col_val.value);
    col_val.value = col_int + 1;
}

function top_tile(){
    let row_val = document.getElementById("row");
    let row_int  = parseInt(row_val.value);
    row_val.value = row_int - 1;
}

function bottom_tile(){
    let row_val = document.getElementById("row");
    let row_int  = parseInt(row_val.value);
    row_val.value = row_int + 1;
}
