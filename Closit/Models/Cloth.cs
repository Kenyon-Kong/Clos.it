using System;

namespace Closit.Models
{
    public class Cloth {
        public String UUID;
        public int realID {get;}
        public String listingName {get; set; }
        public String givenName {get; set; }
        public allEnums.Color[] colorList {get; set; }
        public allEnums.Season season {get; set; }
        public DateTime purchaseDate {get; set; }
        public allEnums.Gender gender {get; set; }
        public String brand {get; set; }
        public String tags {get; set; }
        public allEnums.Size size { get; set; }
        public int wears { get; set;}
    }
}