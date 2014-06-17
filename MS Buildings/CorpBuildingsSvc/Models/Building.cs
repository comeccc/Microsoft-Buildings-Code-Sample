using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CorpBuildingsSvc.Models
{
    public class Building
    {
        public const string MapImageUrlTemplate = "http://dev.virtualearth.net/REST/V1/Imagery/Map/Road/{0}?key=AizHh-2d4EsoQ-A3yyt3qmyZLVyU3Fl-1lRoCrl-KOc1RbyHrcB9gzsOKO8Vkpt7";
        public int Id { get; set; }
        public string Name { get; set; }
        public string Area { get; set; }
        public string Address { get; set; }
        public string DetailsUrl { get; set; }
        public string MapImageUrl { get; set; }
        public string DirectionsUrl { get; set; }
    }
}