using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;
using System.Web.Mvc;
using CorpBuildingsSvc.Models;
using System.Web.Http.Cors;

namespace CorpBuildingsSvc.Controllers
{

    public class BuildingsController : ApiController
    {
        //
        // GET: /Buildings/
        Building[] buildings = new Building[] 
        { 
            new Building { Id = 0, Name = "Building 1", Address = "16011 NE 36th Way, Redmond, WA   98052", Area="Original Campus", DetailsUrl = "http://campusbuilding.com/b/microsoft-building-1/", MapImageUrl = String.Format(Building.MapImageUrlTemplate, "Microsoft Building 1"), DirectionsUrl="http://www.bing.com/maps/default.aspx?v=2&cp=47.6437737313465~-122.12793703819&lvl=16&dir=0&sty=r&rtp=~pos.47.6437737313465_-122.12793703819_near%203801+NE+39th+Street%2C+Redmond%2C+WA+98052___a_&mode=D&rtop=0~0~0~&encType=1&q=3801+NE+39th+Street%2C+Redmond%2C+WA+98052" }, 
            new Building { Id = 1, Name = "Building 2", Address = "16021 NE 36th Way, Redmond, WA   98052", Area="Original Campus",DetailsUrl = "http://campusbuilding.com/b/microsoft-building-2/", MapImageUrl = String.Format(Building.MapImageUrlTemplate, "Microsoft Building 2"), DirectionsUrl="" }, 
            new Building { Id = 2, Name = "Building 3", Address = "16031 NE 36th Way, Redmond, WA   98052", Area="Original Campus",DetailsUrl = "http://campusbuilding.com/b/microsoft-building-3/", MapImageUrl = String.Format(Building.MapImageUrlTemplate, "Microsoft Building 3"), DirectionsUrl=""  }, 
            new Building { Id = 3, Name = "Building 4", Address = "16041 NE 36th Way, Redmond, WA   98052", Area="Original Campus",DetailsUrl = "http://campusbuilding.com/b/microsoft-building-4/", MapImageUrl = String.Format(Building.MapImageUrlTemplate, "Microsoft Building 4"), DirectionsUrl=""  }, 
            new Building { Id = 4, Name = "Building 5", Address = "16051 NE 36th Way, Redmond, WA   98052", Area="Original Campus",DetailsUrl = "http://campusbuilding.com/b/microsoft-building-5/", MapImageUrl = String.Format(Building.MapImageUrlTemplate, "Microsoft Building 5"), DirectionsUrl=""  }, 
            new Building { Id = 5, Name = "Building 6", Address = "16061 NE 36th Way, Redmond, WA   98052", Area="Original Campus",DetailsUrl = "http://campusbuilding.com/b/microsoft-building-6/", MapImageUrl = String.Format(Building.MapImageUrlTemplate, "Microsoft Building 6"), DirectionsUrl=""  }, 
            new Building { Id = 6, Name = "Building 8", Address = "3460 157th AVE NE, Redmond, WA   98052", Area="Original Campus",DetailsUrl = "http://campusbuilding.com/b/microsoft-building-8/", MapImageUrl = String.Format(Building.MapImageUrlTemplate, "Microsoft Building 8"), DirectionsUrl=""  }, 
            new Building { Id = 7, Name = "Building 9", Address = "3350 157th Place NE, Redmond, WA   98052", Area="Original Campus",DetailsUrl = "http://campusbuilding.com/b/microsoft-building-9/", MapImageUrl = String.Format(Building.MapImageUrlTemplate, "Microsoft Building 9"), DirectionsUrl="" }, 
            new Building { Id = 8, Name = "Building 10", Address = "3240 157th AVE NE, Redmond, WA   98052", Area="Original Campus",DetailsUrl = "http://campusbuilding.com/b/microsoft-building-10/", MapImageUrl = String.Format(Building.MapImageUrlTemplate, "Microsoft Building 10"), DirectionsUrl=""  }, 
            new Building { Id = 9, Name = "Building 11", Address = "3635 156th Avenue NE, Redmond, WA   98052", Area="Main Campus",DetailsUrl = "http://campusbuilding.com/b/microsoft-building-11/", MapImageUrl = String.Format(Building.MapImageUrlTemplate, "Microsoft Building 11"), DirectionsUrl="http://www.bing.com/maps/default.aspx?v=2&cp=47.6396341143769~-122.131332460569&lvl=16&dir=0&sty=r&rtp=~pos.47.6396341143769_-122.131332460569_near%203635+156th+Avenue+NE%2C+Redmond%2C+WA+98052___a_&mode=D&rtop=0~0~0~&encType=1&q=3635+156th+Avenue+NE%2C+Redmond%2C+WA+98052"  }, 
            new Building { Id = 10, Name = "Building 16", Address = "3600 159th Avenue NE, Redmond, WA   98052", Area="Main Campus",DetailsUrl = "http://campusbuilding.com/b/microsoft-building-16/", MapImageUrl = String.Format(Building.MapImageUrlTemplate, "Microsoft Building 16"), DirectionsUrl="http://www.bing.com/maps/default.aspx?v=2&cp=47.6431077162454~-122.128870135642&lvl=16&dir=0&sty=r&rtp=~pos.47.6431077162454_-122.128870135642_near%203600+159th+Avenue+NE%2C+Redmond%2C+WA+98052___a_&mode=D&rtop=0~0~0~&encType=1&q=3600+159th+Avenue+NE%2C+Redmond%2C+WA+98052"  }, 
            new Building { Id = 11, Name = "Building 17", Address = "3801 NE 39th Street, Redmond, WA   98052", Area="Main Campus",DetailsUrl = "http://campusbuilding.com/b/microsoft-building-17/", MapImageUrl = String.Format(Building.MapImageUrlTemplate, "Microsoft Building 17"), DirectionsUrl="http://www.bing.com/maps/default.aspx?v=2&cp=47.6437737313465~-122.12793703819&lvl=16&dir=0&sty=r&rtp=~pos.47.6437737313465_-122.12793703819_near%203801+NE+39th+Street%2C+Redmond%2C+WA+98052___a_&mode=D&rtop=0~0~0~&encType=1&q=3801+NE+39th+Street%2C+Redmond%2C+WA+98052"  }, 
            new Building { Id = 12, Name = "Building 18", Address = "16011 NE 36th Way, Redmond, WA   98052", Area="Main Campus",DetailsUrl = "http://campusbuilding.com/b/microsoft-building-18/", MapImageUrl = String.Format(Building.MapImageUrlTemplate, "Microsoft Building 18"), DirectionsUrl=""  }, 
            new Building { Id = 13, Name = "Building 19", Address = "16011 NE 36th Way, Redmond, WA   98052", Area="Main Campus", DetailsUrl = "http://campusbuilding.com/b/microsoft-building-19/", MapImageUrl = String.Format(Building.MapImageUrlTemplate, "Microsoft Building 19"), DirectionsUrl=""  }, 
            new Building { Id = 14, Name = "Building 20", Address = "16011 NE 36th Way, Redmond, WA   98052", Area="Main Campus",DetailsUrl = "http://campusbuilding.com/b/microsoft-building-20/", MapImageUrl = String.Format(Building.MapImageUrlTemplate, "Microsoft Building 20"), DirectionsUrl=""  }, 
            new Building { Id = 15, Name = "Building 21", Address = "16011 NE 36th Way, Redmond, WA   98052", Area="Main Campus",DetailsUrl = "http://campusbuilding.com/b/microsoft-building-21/", MapImageUrl = String.Format(Building.MapImageUrlTemplate, "Microsoft Building 21"), DirectionsUrl=""  }, 
            new Building { Id = 16, Name = "Building 22", Address = "16011 NE 36th Way, Redmond, WA   98052",Area="Main Campus", DetailsUrl = "http://campusbuilding.com/b/microsoft-building-22/", MapImageUrl = String.Format(Building.MapImageUrlTemplate, "Microsoft Building 22"), DirectionsUrl=""  }, 
            new Building { Id = 17, Name = "Building 24", Address = "16011 NE 36th Way, Redmond, WA   98052", Area="Main Campus",DetailsUrl = "http://campusbuilding.com/b/microsoft-building-24/", MapImageUrl = String.Format(Building.MapImageUrlTemplate, "Microsoft Building 24"), DirectionsUrl=""  } 
        };


        public IEnumerable<Building> Get()
        {
            return buildings;
        }

        /*
        public IHttpActionResult GetProduct(int id)
        {
            var building = buildings.FirstOrDefault((p) => p.Id == id);
            if (building == null)
            {
                return NotFound();
            }
            return Ok(building);
        }
        */
    }
}
