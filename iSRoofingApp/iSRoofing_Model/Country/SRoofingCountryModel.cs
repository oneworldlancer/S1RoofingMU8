using System;
using System.Collections.Generic;
using System.Text;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Model.Country
    {
 public   class SRoofingCountryModel
    {


        Boolean IsSelect { get; set; } = false;

        private int CountryID { get; set; }=-1;

        public String id; // field

        //public string id   // property
        //{
        //    get { return _id; }   // get method
        //    set { _id = value; }  // set method
        //}

        public String CountryName{ get; set; } ="0";
        //public String CountryName{
        //    get {
        //        return _CountryName;
        //    }
        //    set {
        //        _CountryName = value;
           
        //            }
        //}

 
        public String CountryCode { get; set; }="0";
        public String CountryIsoCode { get; set; }="0";
        public String CountryMobileCode { get; set; }="0";
        public String CountryFlagSmall { get; set; }="0";
        public String CountryFlagLarge { get; set; }="0";

     
        public SRoofingCountryModel()
        {
        }


        public SRoofingCountryModel(

                int CountryID,
                String CountryName,
                String CountryCode,
                String CountryMobileCode,
                String CountryFlagSmall,
                String CountryFlagLarge)
        {

            // ToInt32
            IsSelect = false;

            this.id =  CountryID.ToString();
   this.CountryID = CountryID;

            this.CountryName = CountryName;

            this.CountryCode = CountryCode;
            this.CountryMobileCode = CountryMobileCode;

            this.CountryFlagSmall = CountryFlagSmall;
            this.CountryFlagLarge = CountryFlagLarge;

              this.CountryIsoCode= CountryCode;

        }



        public SRoofingCountryModel(

                String CountryCode,
                String CountryName)
        {

            IsSelect = false;

            //this._CountryID = CountryID;

            this.CountryName = CountryName;

            this.CountryCode = CountryCode;
            /* this._CountryMobileCode = CountryMobileCode;

             this._CountryFlagSmall = CountryFlagSmall;
             this._CountryFlagLarge = CountryFlagLarge;*/

        }



    }
}
