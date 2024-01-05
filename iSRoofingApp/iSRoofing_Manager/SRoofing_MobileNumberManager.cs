using PhoneNumbers;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Maui.Controls;


namespace S1RoofingMU.iSRoofingApp.iSRoofing_Manager
{
  public  class SRoofing_MobileNumberManager
    {

        public static
string MobileNumber_ValidateMobileNumberE164FromMobileNumberRaw(

        Application context,
        String MobileNumberRaw)
        {
            // return "0";
            try
            {

                PhoneNumberUtil phoneUtil = PhoneNumberUtil.GetInstance();

                String MobileNumberFormat = "";


                PhoneNumber xNumber;

                xNumber = PhoneNumberUtil.GetInstance().Parse(
                        MobileNumberRaw,
                        "");

                bool blnMobileNumberIsValid = phoneUtil
                        .IsValidNumber(xNumber);

                String strResult = "";

                if (blnMobileNumberIsValid)
                {
                    strResult = phoneUtil.Format(
                            xNumber,
                            PhoneNumberFormat.E164);
                }
                else
                {
                    strResult = "false";
                }

                SRoofing_DebugManager.Debug_ShowSystemMessage(
                        "MobileNumber_GetMobileNumberE164FromMobileNumberRaw|strResult: " + strResult);

                return strResult;

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }
        }



    }
}
