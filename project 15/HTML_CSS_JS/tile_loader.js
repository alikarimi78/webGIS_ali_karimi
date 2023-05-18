function show_tile() {
    let img = new Image();
    let row = document.getElementById("row").value;
    let col = document.getElementById("col").value;
    let zoom = document.getElementById("zoom").value;
    let url = 'https://c.tile-cyclosm.openstreetmap.fr/cyclosm/' + zoom + '/' + col + '/' + row + '.png';
    img.src = url;
    let tile_container = document.getElementById("tile_div");

    // Clear the tile_container before appending the new image
    tile_container.innerHTML = '';

    img.onload = function() {
        tile_container.appendChild(img);
    };

    img.onerror = function() {
        let errorText = document.createElement("p");
        errorText.textContent = 'Failed to load image: ' + url;
        tile_container.appendChild(errorText);
    };
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
