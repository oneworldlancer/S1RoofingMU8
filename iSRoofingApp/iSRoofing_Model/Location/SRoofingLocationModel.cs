using System;
using System.Collections.Generic;
using System.Text;

 

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Model.Location
{
    public class SRoofingLocationModel
    {


        bool IsSelect { get; set; } = false;

        private int CountryID { get; set; } = -1;

        public string _id { get; set; } = "0";// field





        public string CountryIsoCode { get; set; } = "0";
        public string CountryMobileCode { get; set; } = "0";
        public string CountryFlagSmall { get; set; } = "0";
        public string CountryFlagLarge { get; set; } = "0";





        public string LocationTitle  { get; set; } = "0";
        //{
        //    get
        //    {
        //        return SubThoroughfare + " " + Thoroughfare + ", " + SubAdminArea + " - " + AdminArea;
        //    }

        //    set
        //    {
        //        LocationTitle = SubThoroughfare + " " + Thoroughfare + ", " + SubAdminArea + " - " + AdminArea;
        //    }
        //}


        //{ get; set; } = "0";

        public string LocationLatitude { get; set; } = "0";

        public string LocationLongitude { get; set; } = "0";

        //Address
        public string Thoroughfare { get; set; } = "0";



        // AdminArea                                               
        public string StateName { get; set; } = "0";


        //CityName                                              
        //public string CityName
        //{

        //    get
        //    {
        //        return AdminArea;
        //    }

        //    set
        //    {
        //        CityName = AdminArea;
        //    }

        //}

        public string Locality { get; set; } = "0";


        /// <summary>
        /// ///////////////////////////////////////////////////
        /// </summary>

        public Microsoft.Maui.Devices.Sensors.Location Location { get; set; } = null;

        public string CountryCode { get; set; } = "0";

        public string CountryName { get; set; } = "0";

        public string FeatureName { get; set; } = "0";

        public string PostalCode { get; set; } = "0";


        //Address area name

        public string SubLocality { get; set; } = "0";


        public string SubThoroughfare { get; set; } = "0";


        public string AdminArea { get; set; } = "0";

        public string CityName { get; set; } = "0";

        public string SubAdminArea { get; set; } = "0";




        ////////////var geocodeAddress = "\n" +
        ////////////           $"{placemark.Thoroughfare}\n" + //Address
        ////////////           $"{placemark.SubLocality}\n" + //Address area name
        ////////////$"{placemark.Locality} {placemark.SubAdminArea}\n" + //CityName
        ////////////$"{placemark.PostalCode}\n" + //PostalCode
        ////////////$"{placemark.AdminArea}\n" + //StateName
        ////////////$"{placemark.CountryName}\n" + //CountryName
        ////////////$"CountryCode: {placemark.CountryCode}\n";








        public SRoofingLocationModel ( )
        {
        }


        ////////     public SRoofingLocationModel(

        ////////             int CountryID,
        ////////             string CountryName,
        ////////             string CountryCode,
        ////////             string CountryMobileCode,
        ////////             string CountryFlagSmall,
        ////////             string CountryFlagLarge)
        ////////     {

        ////////         // ToInt32
        ////////         IsSelect = false;

        ////////         this.id =  CountryID.Tostring();
        ////////this.CountryID = CountryID;

        ////////         this.CountryName = CountryName;

        ////////         this.CountryCode = CountryCode;
        ////////         this.CountryMobileCode = CountryMobileCode;

        ////////         this.CountryFlagSmall = CountryFlagSmall;
        ////////         this.CountryFlagLarge = CountryFlagLarge;

        ////////           this.CountryIsoCode= CountryCode;

        ////////     }



        ////////     public SRoofingLocationModel(

        ////////             string CountryCode,
        ////////             string CountryName)
        ////////     {

        ////////         IsSelect = false;

        ////////         //this._CountryID = CountryID;

        ////////         this.CountryName = CountryName;

        ////////         this.CountryCode = CountryCode;
        ////////         /* this._CountryMobileCode = CountryMobileCode;

        ////////          this._CountryFlagSmall = CountryFlagSmall;
        ////////          this._CountryFlagLarge = CountryFlagLarge;*/

        ////////     }



    }
}
