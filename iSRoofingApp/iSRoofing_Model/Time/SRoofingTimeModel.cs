using System;
using System.Collections.Generic;
using System.Text;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Model.Time
{
    public class SRoofingTimeModel
    {


        public string DateTimeTextWS { get; set; } = "0";

        public string DateTimeWS { get; set; } = "0";


        public string DateTextWS { get; set; } = "0";


        public string DateDayWS { get; set; } = "0";


        public string DateMonthWS { get; set; } = "0";


        public string DateYearWS { get; set; } = "0";


        public DateTime iDateTimeWS { get; set; } = DateTime.Now;


        public long iDateTimeMilliSecWS { get; set; } = 0;

        public SRoofingTimeModel ( ) { }





    }
}
