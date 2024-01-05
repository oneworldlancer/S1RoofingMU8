using System;
using System.Collections.Generic;
using System.Text;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Model.Location
{
    public class PlacesTerm
    {
        [Newtonsoft.Json.JsonProperty ( "offset" )]
        public int Offset { get; set; }

        [Newtonsoft.Json.JsonProperty ( "value" )]
        public string Value { get; set; }
    }
}
