function show_tile() {
    let row = $("#row").val();
    let col = $("#col").val();
    let zoom = $("#zoom").val();
    let url = 'https://c.tile-cyclosm.openstreetmap.fr/cyclosm/' + zoom + '/' + col + '/' + row + '.png';

    let img = $("<img>").attr("src", url);
    let tile_container = $("#tile_div");

    // Clear the tile_container before appending the new image
    tile_container.empty();

    img.on("load", function() {
        tile_container.append(img);
    });

    img.on("error", function() {
        let errorText = $("<p>").text('Failed to load image: ' + url);
        tile_container.append(errorText);
    });
}


function left_tile() {
    let col_val = $("#col");
    let col_int = parseInt(col_val.val());
    col_val.val(col_int - 1);
    show_tile();
}

function right_tile() {
    let col_val = $("#col");
    let col_int = parseInt(col_val.val());
    col_val.val(col_int + 1);
    show_tile();
}

function top_tile() {
    let row_val = $("#row");
    let row_int = parseInt(row_val.val());
    row_val.val(row_int - 1);
    show_tile();
}


function bottom_tile() {
    let row_val = $("#row");
    let row_int = parseInt(row_val.val());
    row_val.val(row_int + 1);
    show_tile();
}

