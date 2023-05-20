
function show_tile() {

    let row = $("#row").val();
    let col = $("#col").val();
    let zoom = $("#zoom").val();


    let xhttp = new XMLHttpRequest();
    xhttp.responseType = "blob"; // Set the response type to "blob" for binary data

    xhttp.onreadystatechange = function () {
        if (this.readyState === 4 && this.status === 200) {
            const blobUrl = URL.createObjectURL(this.response);
            const img = document.createElement("img");
            img.src = blobUrl;
            $("#tile_div").empty(); // Clear the content before appending the image
            $("#tile_div").append(img);

        }
        else{
            $("#tile_div").html("image can't be loaded!");

        }
    };

    xhttp.open("GET", 'https://c.tile-cyclosm.openstreetmap.fr/cyclosm/' + zoom + '/' + col + '/' + row + '.png', true);
    xhttp.send();

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
