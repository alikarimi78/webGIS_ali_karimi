class line {
    constructor(x1 , y1 , x2 , y2)
    {
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
    }

    azimuth_cal()
    {
        let delta_x = this.x2 - this.x1;
        let delta_y = this.y2 - this.y1;
        let azimuth_r = Math.atan2(delta_x , delta_y);

        // convert to degree :
        let azimuth_d = azimuth_r * 180 / Math.PI;

        // convert to positive number :
        if (azimuth_d < 0)
        {
            azimuth_d = azimuth_d + 180 ;
        }

        // rounding number :
        azimuth_d = azimuth_d.toFixed(4);
        return(azimuth_d);
    }
}

function azimuth_function(){
    let x1 = document.getElementById("x1").value;
    let x2 = document.getElementById("x2").value;
    let y1 = document.getElementById("y1").value;
    let y2 = document.getElementById("y2").value;

    // convert to float :
    x1 = parseFloat(x1);
    x2 = parseFloat(x2);
    y1 = parseFloat(y1);
    y2 = parseFloat(y2);


    // create a new instance :
    let line1 = new line(x1, y1, x2, y2);
    document.getElementById("result").innerHTML = line1.azimuth_cal() ;
}