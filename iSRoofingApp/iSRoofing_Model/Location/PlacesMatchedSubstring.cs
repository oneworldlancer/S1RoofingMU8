using System;
using System.Collections.Generic;
using System.Text;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Model.Location
{
    public class PlacesMatchedSubstring
    {

        [Newtonsoft.Json.JsonProperty ( "length" )]
        public int Length { get; set; }

        [Newtonsoft.Json.JsonProperty ( "offset" )]
        public int Offset { get; set; }
    }
}
