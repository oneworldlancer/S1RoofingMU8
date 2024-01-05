using System;
using System.Collections.Generic;
using System.Text;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Model.Location
{
    public class PlacesLocationPredictions
    {
        [Newtonsoft.Json.JsonProperty ( "predictions" )]
        public List<Prediction> Predictions { get; set; }

        [Newtonsoft.Json.JsonProperty ( "status" )]
        public string Status { get; set; }
    }
}
