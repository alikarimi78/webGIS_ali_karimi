using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class GetTileController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetTile(int zoom , int row , int col)
        {
            string url_name = "http://localhost:8080/geoserver/topp/gwc/service/wmts?layer=topp%3Astates&style=&tilematrixset=EPSG%3A900913&Service=WMTS&Request=GetTile&Version=1.0.0&Format=image%2Fpng&TileMatrix=EPSG%3A900913%3A6&TileCol=" + col + "&TileRow=" + row;
            WebRequest request = WebRequest.Create(url_name);
            var response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            Bitmap bmp = new Bitmap(stream);
            string tile_path = "D:\\karshenasi_arshad\\webGIS\\webGIS_ali_karimi\\project 11\\tile_download\\tile_pic1.png";
            bmp.Save(tile_path);
            HttpResponseMessage response_msg = new HttpResponseMessage();
            var fs = new FileStream(tile_path, FileMode.Open);
            response_msg.Content = new StreamContent(fs);
            response_msg.Content.Headers.ContentType = new MediaTypeHeaderValue("Image/png");

            return response_msg;
        }
    }
}
