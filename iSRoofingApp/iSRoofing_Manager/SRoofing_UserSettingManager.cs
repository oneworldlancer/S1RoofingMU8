using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Web;

using S1RoofingMU.iSRoofingApp.iSRoofing_EnumHandlerManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_HandlerManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.KeyValue;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_UControl.SnackBar;


using Microsoft.Maui.Controls;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Manager
{
    public class SRoofing_UserSettingManager
    {




        async public static Task<string> UserSetting_Update_BirthDate_ByOwnerUserTokenID(

    Application _context,
    string iAccountType,
    SRoofingUserOwnerModelManager iOwnerModel,
     string BirthDay,
      string BirthMonth,
    string BirthYear)
        {

            try
            {


                var strResult = "0";

                strResult = await SRoofing_HandlerManager.Handler_GetResponse(

                        App.SiteDomainURL + "_iWebHandler"
                        + "/SRoofing_UserSettingHandler.ashx?"

                        + "devid=" + Preferences.Get("DeviceGlobalID", "0") //Preferences.Get ( "DeviceGlobalID" , "0" )
                        + "&syscod=" + Preferences.Get("PlatformOS", "0")//DeviceInfo.Current.Platform.ToString().ToString().ToLower()
                        + "&acctyp=" + App.iAccountType
                        + "&dbserver=" + SRoofingEnum_DatabaseServer.DatabaseServer_UK
                        + "&gcmid=" + Preferences.Get("GCMID", "0")

                        + "&uid=" + iOwnerModel.OwnerUserTokenID
                        + "&mobid=" + iOwnerModel.OwnerMobileNumberTokenID

                        + "&birthday=" + BirthDay
                        + "&birthmonth=" + BirthMonth
                        + "&birthyear=" + BirthYear


                        + "&req=" + SRoofingEnumHandler_UserSettingHandler.UserSetting_BirthDate);


                return strResult;



            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }
        }




        async public static Task<string> UserSetting_Update_FullName_ByOwnerUserTokenID(

    Application _context,
    string iAccountType,
    SRoofingUserOwnerModelManager iOwnerModel,
     string FirstName,
    string LastName)
        {

            try
            {


                var strResult = "0";

                strResult = await SRoofing_HandlerManager.Handler_GetResponse(

                        App.SiteDomainURL + "_iWebHandler"
                        + "/SRoofing_UserSettingHandler.ashx?"

                        + "devid=" + Preferences.Get("DeviceGlobalID", "0") //Preferences.Get ( "DeviceGlobalID" , "0" )
                        + "&syscod=" + Preferences.Get("PlatformOS", "0")//DeviceInfo.Current.Platform.ToString().ToString().ToLower()
                        + "&acctyp=" + App.iAccountType
                        + "&dbserver=" + SRoofingEnum_DatabaseServer.DatabaseServer_UK
                        + "&gcmid=" + Preferences.Get("GCMID", "0")

                        + "&uid=" + iOwnerModel.OwnerUserTokenID
                        + "&mobid=" + iOwnerModel.OwnerMobileNumberTokenID


                        + "&fname=" + FirstName
                        + "&lname=" + LastName


                        + "&req=" + SRoofingEnumHandler_UserSettingHandler.UserSetting_FullName);


                return strResult;



            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }
        }




        async public static Task<string> UserSetting_Update_Gender_ByOwnerUserTokenID(

    Application _context,
    string iAccountType,
    SRoofingUserOwnerModelManager iOwnerModel,
     string Gender)
        {

            try
            {


                var strResult = "0";

                strResult = await SRoofing_HandlerManager.Handler_GetResponse(

                        App.SiteDomainURL + "_iWebHandler"
                        + "/SRoofing_UserSettingHandler.ashx?"

                        + "devid=" + Preferences.Get("DeviceGlobalID", "0") //Preferences.Get ( "DeviceGlobalID" , "0" )
                        + "&syscod=" + Preferences.Get("PlatformOS", "0")//DeviceInfo.Current.Platform.ToString().ToString().ToLower()
                        + "&acctyp=" + App.iAccountType
                        + "&dbserver=" + SRoofingEnum_DatabaseServer.DatabaseServer_UK
                        + "&gcmid=" + Preferences.Get("GCMID", "0")

                        + "&uid=" + iOwnerModel.OwnerUserTokenID
                        + "&mobid=" + iOwnerModel.OwnerMobileNumberTokenID

                         + "&gender=" + Gender


                        + "&req=" + SRoofingEnumHandler_UserSettingHandler.UserSetting_Gender);


                return strResult;



            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }
        }




        async public static Task<string> UserSetting_Update_MobileNumber_ByOwnerUserTokenID(

    Application _context,
    string iAccountType,
    SRoofingUserOwnerModelManager iOwnerModel,
     string MobileNumberE164,
     string CountryISOCode,
    string CountryMobileCode)
        {

            try
            {


                var strResult = "0";

                strResult = await SRoofing_HandlerManager.Handler_GetResponse(

                        App.SiteDomainURL + "_iWebHandler"
                        + "/SRoofing_UserSettingHandler.ashx?"

                        + "devid=" + Preferences.Get("DeviceGlobalID", "0") //Preferences.Get ( "DeviceGlobalID" , "0" )
                        + "&syscod=" + Preferences.Get("PlatformOS", "0")//DeviceInfo.Current.Platform.ToString().ToString().ToLower()
                        + "&acctyp=" + App.iAccountType
                        + "&dbserver=" + SRoofingEnum_DatabaseServer.DatabaseServer_UK
                        + "&gcmid=" + Preferences.Get("GCMID", "0")

                        + "&uid=" + iOwnerModel.OwnerUserTokenID
                        + "&mobid=" + iOwnerModel.OwnerMobileNumberTokenID

                        + "&mobnum164=" + MobileNumberE164
                        + "&cntryisocod=" + CountryISOCode

                        + "&mobcod=" + CountryMobileCode


                        + "&req=" + SRoofingEnumHandler_UserSettingHandler.UserSetting_MobileNumber);


                return strResult;



            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }
        }




        async public static Task<string> UserSetting_Update_Password_ByOwnerUserTokenID(

    Application _context,
    string iAccountType,
    SRoofingUserOwnerModelManager iOwnerModel,
     string Password)
        {

            try
            {


                var strResult = "0";

                strResult = await SRoofing_HandlerManager.Handler_GetResponse(

                        App.SiteDomainURL + "_iWebHandler"
                        + "/SRoofing_UserSettingHandler.ashx?"

                        + "devid=" + Preferences.Get("DeviceGlobalID", "0") //Preferences.Get ( "DeviceGlobalID" , "0" )
                        + "&syscod=" + Preferences.Get("PlatformOS", "0")//DeviceInfo.Current.Platform.ToString().ToString().ToLower()
                        + "&acctyp=" + App.iAccountType
                        + "&dbserver=" + SRoofingEnum_DatabaseServer.DatabaseServer_UK
                        + "&gcmid=" + Preferences.Get("GCMID", "0")

                        + "&uid=" + iOwnerModel.OwnerUserTokenID
                        + "&mobid=" + iOwnerModel.OwnerMobileNumberTokenID

                         + "&pswd=" + Password


                        + "&req=" + SRoofingEnumHandler_UserSettingHandler.UserSetting_Password);


                return strResult;



            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }
        }




        async public static Task<string> UserSetting_Update_EmailAddress_ByOwnerUserTokenID(

    Application _context,
    string iAccountType,
    SRoofingUserOwnerModelManager iOwnerModel,
     string EmailAddress)
        {

            try
            {


                var strResult = "0";

                strResult = await SRoofing_HandlerManager.Handler_GetResponse(

                        App.SiteDomainURL + "_iWebHandler"
                        + "/SRoofing_UserSettingHandler.ashx?"

                        + "devid=" + Preferences.Get("DeviceGlobalID", "0") //Preferences.Get ( "DeviceGlobalID" , "0" )
                        + "&syscod=" + Preferences.Get("PlatformOS", "0")//DeviceInfo.Current.Platform.ToString().ToString().ToLower()
                        + "&acctyp=" + App.iAccountType
                        + "&dbserver=" + SRoofingEnum_DatabaseServer.DatabaseServer_UK
                        + "&gcmid=" + Preferences.Get("GCMID", "0")

                        + "&uid=" + iOwnerModel.OwnerUserTokenID
                        + "&mobid=" + iOwnerModel.OwnerMobileNumberTokenID

                         + "&email=" + EmailAddress


                        + "&req=" + SRoofingEnumHandler_UserSettingHandler.UserSetting_EmailAddress);


                return strResult;



            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }
        }




        async public static Task<string> UserSetting_Update_VisibleStatus_IsEnable_ByOwnerUserTokenID(

    Application _context,
    string iAccountType,
    SRoofingUserOwnerModelManager iOwnerModel,
     bool VisibleStatus_IsEnable)
        {

            try
            {


                var strResult = "0";

                strResult = await SRoofing_HandlerManager.Handler_GetResponse(

                        App.SiteDomainURL + "_iWebHandler"
                        + "/SRoofing_UserSettingHandler.ashx?"

                        + "devid=" + Preferences.Get("DeviceGlobalID", "0") //Preferences.Get ( "DeviceGlobalID" , "0" )
                        + "&syscod=" + Preferences.Get("PlatformOS", "0")//DeviceInfo.Current.Platform.ToString().ToString().ToLower()
                        + "&acctyp=" + App.iAccountType
                        + "&dbserver=" + SRoofingEnum_DatabaseServer.DatabaseServer_UK
                        + "&gcmid=" + Preferences.Get("GCMID", "0")

                        + "&uid=" + iOwnerModel.OwnerUserTokenID
                        + "&mobid=" + iOwnerModel.OwnerMobileNumberTokenID

                        + "&vstatusok=" + VisibleStatus_IsEnable


                        + "&req=" + SRoofingEnumHandler_UserSettingHandler.UserSetting_VisibleStatus_IsEnable);


                return strResult;



            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }
        }




        async public static Task<string> UserSetting_Update_Speech_IsEnable_ByOwnerUserTokenID(

    Application _context,
    string iAccountType,
    SRoofingUserOwnerModelManager iOwnerModel,
     bool Speech_IsEnable)
        {

            try
            {


                var strResult = "0";

                strResult = await SRoofing_HandlerManager.Handler_GetResponse(

                        App.SiteDomainURL + "_iWebHandler"
                        + "/SRoofing_UserSettingHandler.ashx?"

                        + "devid=" + Preferences.Get("DeviceGlobalID", "0") //Preferences.Get ( "DeviceGlobalID" , "0" )
                        + "&syscod=" + Preferences.Get("PlatformOS", "0")//DeviceInfo.Current.Platform.ToString().ToString().ToLower()
                        + "&acctyp=" + App.iAccountType
                        + "&dbserver=" + SRoofingEnum_DatabaseServer.DatabaseServer_UK
                        + "&gcmid=" + Preferences.Get("GCMID", "0")

                        + "&uid=" + iOwnerModel.OwnerUserTokenID
                        + "&mobid=" + iOwnerModel.OwnerMobileNumberTokenID

                        + "&speechok=" + Speech_IsEnable


                        + "&req=" + SRoofingEnumHandler_UserSettingHandler.UserSetting_Speech_IsEnable);


                return strResult;



            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }
        }




        async public static Task<string> UserSetting_Update_Speech_Incoming_ByOwnerUserTokenID(

    Application _context,
    string iAccountType,
    SRoofingUserOwnerModelManager iOwnerModel,
     string Speech_Incoming)
        {

            try
            {


                var strResult = "0";

                strResult = await SRoofing_HandlerManager.Handler_GetResponse(

                        App.SiteDomainURL + "_iWebHandler"
                        + "/SRoofing_UserSettingHandler.ashx?"

                        + "devid=" + Preferences.Get("DeviceGlobalID", "0") //Preferences.Get ( "DeviceGlobalID" , "0" )
                        + "&syscod=" + Preferences.Get("PlatformOS", "0")//DeviceInfo.Current.Platform.ToString().ToString().ToLower()
                        + "&acctyp=" + App.iAccountType
                        + "&dbserver=" + SRoofingEnum_DatabaseServer.DatabaseServer_UK
                        + "&gcmid=" + Preferences.Get("GCMID", "0")

                        + "&uid=" + iOwnerModel.OwnerUserTokenID
                        + "&mobid=" + iOwnerModel.OwnerMobileNumberTokenID

                        + "&speechin=" + Speech_Incoming


                        + "&req=" + SRoofingEnumHandler_UserSettingHandler.UserSetting_Speech_Incoming);


                return strResult;



            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }
        }




        async public static Task<string> UserSetting_Update_Speech_Outgoing_ByOwnerUserTokenID(

    Application _context,
    string iAccountType,
    SRoofingUserOwnerModelManager iOwnerModel,
     string Speech_Outgoing)
        {

            try
            {


                var strResult = "0";

                strResult = await SRoofing_HandlerManager.Handler_GetResponse(

                        App.SiteDomainURL + "_iWebHandler"
                        + "/SRoofing_UserSettingHandler.ashx?"

                        + "devid=" + Preferences.Get("DeviceGlobalID", "0") //Preferences.Get ( "DeviceGlobalID" , "0" )
                        + "&syscod=" + Preferences.Get("PlatformOS", "0")//DeviceInfo.Current.Platform.ToString().ToString().ToLower()
                        + "&acctyp=" + App.iAccountType
                        + "&dbserver=" + SRoofingEnum_DatabaseServer.DatabaseServer_UK
                        + "&gcmid=" + Preferences.Get("GCMID", "0")

                        + "&uid=" + iOwnerModel.OwnerUserTokenID
                        + "&mobid=" + iOwnerModel.OwnerMobileNumberTokenID

                        + "&speechout=" + Speech_Outgoing


                        + "&req=" + SRoofingEnumHandler_UserSettingHandler.UserSetting_Speech_Outgoing);


                return strResult;



            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }
        }




        async public static Task<string> UserSetting_Update_Sound_IsEnable_ByOwnerUserTokenID(

    Application _context,
    string iAccountType,
    SRoofingUserOwnerModelManager iOwnerModel,
     bool Sound_IsEnable)
        {

            try
            {


                var strResult = "0";

                strResult = await SRoofing_HandlerManager.Handler_GetResponse(

                        App.SiteDomainURL + "_iWebHandler"
                        + "/SRoofing_UserSettingHandler.ashx?"

                        + "devid=" + Preferences.Get("DeviceGlobalID", "0") //Preferences.Get ( "DeviceGlobalID" , "0" )
                        + "&syscod=" + Preferences.Get("PlatformOS", "0")//DeviceInfo.Current.Platform.ToString().ToString().ToLower()
                        + "&acctyp=" + App.iAccountType
                        + "&dbserver=" + SRoofingEnum_DatabaseServer.DatabaseServer_UK
                        + "&gcmid=" + Preferences.Get("GCMID", "0")

                        + "&uid=" + iOwnerModel.OwnerUserTokenID
                        + "&mobid=" + iOwnerModel.OwnerMobileNumberTokenID

                       + "&sndok=" + Sound_IsEnable


                        + "&req=" + SRoofingEnumHandler_UserSettingHandler.UserSetting_Sound_IsEnable);


                return strResult;



            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }
        }




        async public static Task<string> UserSetting_Update_Sound_Chat_Incoming_ByOwnerUserTokenID(

    Application _context,
    string iAccountType,
    SRoofingUserOwnerModelManager iOwnerModel,
     string Sound_Chat_Incoming_Title,
     string Sound_Chat_Incoming)
        {

            try
            {


                var strResult = "0";

                strResult = await SRoofing_HandlerManager.Handler_GetResponse(

                        App.SiteDomainURL + "_iWebHandler"
                        + "/SRoofing_UserSettingHandler.ashx?"

                        + "devid=" + Preferences.Get("DeviceGlobalID", "0") //Preferences.Get ( "DeviceGlobalID" , "0" )
                        + "&syscod=" + Preferences.Get("PlatformOS", "0")//DeviceInfo.Current.Platform.ToString().ToString().ToLower()
                        + "&acctyp=" + App.iAccountType
                        + "&dbserver=" + SRoofingEnum_DatabaseServer.DatabaseServer_UK
                        + "&gcmid=" + Preferences.Get("GCMID", "0")

                        + "&uid=" + iOwnerModel.OwnerUserTokenID
                        + "&mobid=" + iOwnerModel.OwnerMobileNumberTokenID

                         + "&sndinchattitle=" + Sound_Chat_Incoming_Title
                         + "&sndinchat=" + Sound_Chat_Incoming


                        + "&req=" + SRoofingEnumHandler_UserSettingHandler.UserSetting_Sound_Chat_Incoming);


                return strResult;



            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }
        }




        async public static Task<string> UserSetting_Update_Sound_Chat_Outgoing_ByOwnerUserTokenID(

    Application _context,
    string iAccountType,
    SRoofingUserOwnerModelManager iOwnerModel,
     string Sound_Chat_Outgoing_Title,
     string Sound_Chat_Outgoing)
        {

            try
            {


                var strResult = "0";

                strResult = await SRoofing_HandlerManager.Handler_GetResponse(

                        App.SiteDomainURL + "_iWebHandler"
                        + "/SRoofing_UserSettingHandler.ashx?"

                        + "devid=" + Preferences.Get("DeviceGlobalID", "0") //Preferences.Get ( "DeviceGlobalID" , "0" )
                        + "&syscod=" + Preferences.Get("PlatformOS", "0")//DeviceInfo.Current.Platform.ToString().ToString().ToLower()
                        + "&acctyp=" + App.iAccountType
                        + "&dbserver=" + SRoofingEnum_DatabaseServer.DatabaseServer_UK
                        + "&gcmid=" + Preferences.Get("GCMID", "0")

                        + "&uid=" + iOwnerModel.OwnerUserTokenID
                        + "&mobid=" + iOwnerModel.OwnerMobileNumberTokenID

                        + "&sndoutchattitle=" + Sound_Chat_Outgoing_Title
                        + "&sndoutchat=" + Sound_Chat_Outgoing


                        + "&req=" + SRoofingEnumHandler_UserSettingHandler.UserSetting_Sound_Chat_Outgoing);


                return strResult;



            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }
        }




        async public static Task<string> UserSetting_Update_Sound_Call_Incoming_ByOwnerUserTokenID(

    Application _context,
    string iAccountType,
    SRoofingUserOwnerModelManager iOwnerModel,
     string Sound_Call_Incoming_Title,
     string Sound_Call_Incoming)
        {

            try
            {


                var strResult = "0";

                strResult = await SRoofing_HandlerManager.Handler_GetResponse(

                        App.SiteDomainURL + "_iWebHandler"
                        + "/SRoofing_UserSettingHandler.ashx?"

                        + "devid=" + Preferences.Get("DeviceGlobalID", "0") //Preferences.Get ( "DeviceGlobalID" , "0" )
                        + "&syscod=" + Preferences.Get("PlatformOS", "0")//DeviceInfo.Current.Platform.ToString().ToString().ToLower()
                        + "&acctyp=" + App.iAccountType
                        + "&dbserver=" + SRoofingEnum_DatabaseServer.DatabaseServer_UK
                        + "&gcmid=" + Preferences.Get("GCMID", "0")

                        + "&uid=" + iOwnerModel.OwnerUserTokenID
                        + "&mobid=" + iOwnerModel.OwnerMobileNumberTokenID

                        + "&sndincalltitle=" + Sound_Call_Incoming_Title
                        + "&sndincall=" + Sound_Call_Incoming


                        + "&req=" + SRoofingEnumHandler_UserSettingHandler.UserSetting_Sound_Call_Incoming);


                return strResult;



            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }
        }




        async public static Task<string> UserSetting_Update_Sound_Call_Outgoing_ByOwnerUserTokenID(

    Application _context,
    string iAccountType,
    SRoofingUserOwnerModelManager iOwnerModel,
     string Sound_Call_Outgoing_Title,
     string Sound_Call_Outgoing)
        {

            try
            {


                var strResult = "0";

                strResult = await SRoofing_HandlerManager.Handler_GetResponse(

                        App.SiteDomainURL + "_iWebHandler"
                        + "/SRoofing_UserSettingHandler.ashx?"

                        + "devid=" + Preferences.Get("DeviceGlobalID", "0") //Preferences.Get ( "DeviceGlobalID" , "0" )
                        + "&syscod=" + Preferences.Get("PlatformOS", "0")//DeviceInfo.Current.Platform.ToString().ToString().ToLower()
                        + "&acctyp=" + App.iAccountType
                        + "&dbserver=" + SRoofingEnum_DatabaseServer.DatabaseServer_UK
                        + "&gcmid=" + Preferences.Get("GCMID", "0")

                        + "&uid=" + iOwnerModel.OwnerUserTokenID
                        + "&mobid=" + iOwnerModel.OwnerMobileNumberTokenID

                        + "&sndoutcalltitle=" + Sound_Call_Outgoing_Title
                        + "&sndoutcall=" + Sound_Call_Outgoing


                        + "&req=" + SRoofingEnumHandler_UserSettingHandler.UserSetting_Sound_Call_Outgoing);


                return strResult;



            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }
        }




        async public static Task<string> UserSetting_Update_Chat_SaveHistory_IsEnable_ByOwnerUserTokenID(

    Application _context,
    string iAccountType,
    SRoofingUserOwnerModelManager iOwnerModel,
     bool Chat_SaveHistory_IsEnable)
        {

            try
            {


                var strResult = "0";

                strResult = await SRoofing_HandlerManager.Handler_GetResponse(

                        App.SiteDomainURL + "_iWebHandler"
                        + "/SRoofing_UserSettingHandler.ashx?"

                        + "devid=" + Preferences.Get("DeviceGlobalID", "0") //Preferences.Get ( "DeviceGlobalID" , "0" )
                        + "&syscod=" + Preferences.Get("PlatformOS", "0")//DeviceInfo.Current.Platform.ToString().ToString().ToLower()
                        + "&acctyp=" + App.iAccountType
                        + "&dbserver=" + SRoofingEnum_DatabaseServer.DatabaseServer_UK
                        + "&gcmid=" + Preferences.Get("GCMID", "0")

                        + "&uid=" + iOwnerModel.OwnerUserTokenID
                        + "&mobid=" + iOwnerModel.OwnerMobileNumberTokenID

                        + "&chatsaveok=" + Chat_SaveHistory_IsEnable


                        + "&req=" + SRoofingEnumHandler_UserSettingHandler.UserSetting_Chat_SaveHistory_IsEnable);


                return strResult;



            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }
        }




        async public static Task<string> UserSetting_Update_Chat_BackgroundImageURL_ByOwnerUserTokenID(

    Application _context,
    string iAccountType,
    SRoofingUserOwnerModelManager iOwnerModel,
     string Chat_BackgroundImageURL)
        {

            try
            {


                var strResult = "0";

                strResult = await SRoofing_HandlerManager.Handler_GetResponse(

                        App.SiteDomainURL + "_iWebHandler"
                        + "/SRoofing_UserSettingHandler.ashx?"

                        + "devid=" + Preferences.Get("DeviceGlobalID", "0") //Preferences.Get ( "DeviceGlobalID" , "0" )
                        + "&syscod=" + Preferences.Get("PlatformOS", "0")//DeviceInfo.Current.Platform.ToString().ToString().ToLower()
                        + "&acctyp=" + App.iAccountType
                        + "&dbserver=" + SRoofingEnum_DatabaseServer.DatabaseServer_UK
                        + "&gcmid=" + Preferences.Get("GCMID", "0")

                        + "&uid=" + iOwnerModel.OwnerUserTokenID
                        + "&mobid=" + iOwnerModel.OwnerMobileNumberTokenID

                        + "&chatimgurl=" + Chat_BackgroundImageURL


                        + "&req=" + SRoofingEnumHandler_UserSettingHandler.UserSetting_Chat_BackgroundImageURL);


                return strResult;



            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }
        }




        async public static Task<string> UserSetting_Update_Chat_Media_Image_IsDownload_ByOwnerUserTokenID(

    Application _context,
    string iAccountType,
    SRoofingUserOwnerModelManager iOwnerModel,
     bool Chat_Media_Image_IsDownload)
        {

            try
            {


                var strResult = "0";

                strResult = await SRoofing_HandlerManager.Handler_GetResponse(

                        App.SiteDomainURL + "_iWebHandler"
                        + "/SRoofing_UserSettingHandler.ashx?"

                        + "devid=" + Preferences.Get("DeviceGlobalID", "0") //Preferences.Get ( "DeviceGlobalID" , "0" )
                        + "&syscod=" + Preferences.Get("PlatformOS", "0")//DeviceInfo.Current.Platform.ToString().ToString().ToLower()
                        + "&acctyp=" + App.iAccountType
                        + "&dbserver=" + SRoofingEnum_DatabaseServer.DatabaseServer_UK
                        + "&gcmid=" + Preferences.Get("GCMID", "0")

                        + "&uid=" + iOwnerModel.OwnerUserTokenID
                        + "&mobid=" + iOwnerModel.OwnerMobileNumberTokenID

                        + "&chatimgok=" + Chat_Media_Image_IsDownload


                        + "&req=" + SRoofingEnumHandler_UserSettingHandler.UserSetting_Chat_Media_Image_IsDownload);


                return strResult;



            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }
        }





        async public static Task<string> UserSetting_Update_Chat_Media_Video_IsDownload_ByOwnerUserTokenID(

    Application _context,
    string iAccountType,
    SRoofingUserOwnerModelManager iOwnerModel,
     bool Chat_Media_Video_IsDownload)
        {

            try
            {


                var strResult = "0";

                strResult = await SRoofing_HandlerManager.Handler_GetResponse(

                        App.SiteDomainURL + "_iWebHandler"
                        + "/SRoofing_UserSettingHandler.ashx?"

                        + "devid=" + Preferences.Get("DeviceGlobalID", "0") //Preferences.Get ( "DeviceGlobalID" , "0" )
                        + "&syscod=" + Preferences.Get("PlatformOS", "0")//DeviceInfo.Current.Platform.ToString().ToString().ToLower()
                        + "&acctyp=" + App.iAccountType
                        + "&dbserver=" + SRoofingEnum_DatabaseServer.DatabaseServer_UK
                        + "&gcmid=" + Preferences.Get("GCMID", "0")

                        + "&uid=" + iOwnerModel.OwnerUserTokenID
                        + "&mobid=" + iOwnerModel.OwnerMobileNumberTokenID

                        + "&chatvidok=" + Chat_Media_Video_IsDownload


                        + "&req=" + SRoofingEnumHandler_UserSettingHandler.UserSetting_Chat_Media_Video_IsDownload);


                return strResult;



            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }
        }





        async public static Task<string> UserSetting_Update_Chat_Media_Document_IsDownload_ByOwnerUserTokenID(

    Application _context,
    string iAccountType,
    SRoofingUserOwnerModelManager iOwnerModel,
     bool Chat_Media_Document_IsDownload)
        {

            try
            {


                var strResult = "0";

                strResult = await SRoofing_HandlerManager.Handler_GetResponse(

                        App.SiteDomainURL + "_iWebHandler"
                        + "/SRoofing_UserSettingHandler.ashx?"

                        + "devid=" + Preferences.Get("DeviceGlobalID", "0") //Preferences.Get ( "DeviceGlobalID" , "0" )
                        + "&syscod=" + Preferences.Get("PlatformOS", "0")//DeviceInfo.Current.Platform.ToString().ToString().ToLower()
                        + "&acctyp=" + App.iAccountType
                        + "&dbserver=" + SRoofingEnum_DatabaseServer.DatabaseServer_UK
                        + "&gcmid=" + Preferences.Get("GCMID", "0")

                        + "&uid=" + iOwnerModel.OwnerUserTokenID
                        + "&mobid=" + iOwnerModel.OwnerMobileNumberTokenID

                        + "&chatdocok=" + Chat_Media_Document_IsDownload


                        + "&req=" + SRoofingEnumHandler_UserSettingHandler.UserSetting_Chat_Media_Document_IsDownload);


                return strResult;



            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }
        }




        async public static Task<string> UserSetting_Update_Call_VoiceCommand_IsEnable_ByOwnerUserTokenID(

    Application _context,
    string iAccountType,
    SRoofingUserOwnerModelManager iOwnerModel,
     bool Call_VoiceCommand_IsEnable)
        {

            try
            {


                var strResult = "0";

                strResult = await SRoofing_HandlerManager.Handler_GetResponse(

                        App.SiteDomainURL + "_iWebHandler"
                        + "/SRoofing_UserSettingHandler.ashx?"

                        + "devid=" + Preferences.Get("DeviceGlobalID", "0") //Preferences.Get ( "DeviceGlobalID" , "0" )
                        + "&syscod=" + Preferences.Get("PlatformOS", "0")//DeviceInfo.Current.Platform.ToString().ToString().ToLower()
                        + "&acctyp=" + App.iAccountType
                        + "&dbserver=" + SRoofingEnum_DatabaseServer.DatabaseServer_UK
                        + "&gcmid=" + Preferences.Get("GCMID", "0")

                        + "&uid=" + iOwnerModel.OwnerUserTokenID
                        + "&mobid=" + iOwnerModel.OwnerMobileNumberTokenID

                        + "&callvoiceok=" + Call_VoiceCommand_IsEnable


                        + "&req=" + SRoofingEnumHandler_UserSettingHandler.UserSetting_Call_VoiceCommand_IsEnable);


                return strResult;



            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }
        }




        async public static Task<string> UserSetting_Update_Call_Auto_Answer_ByOwnerUserTokenID(

    Application _context,
    string iAccountType,
    SRoofingUserOwnerModelManager iOwnerModel,
    bool Call_Auto_Answer)
        {

            try
            {


                var strResult = "0";

                strResult = await SRoofing_HandlerManager.Handler_GetResponse(

                        App.SiteDomainURL + "_iWebHandler"
                        + "/SRoofing_UserSettingHandler.ashx?"

                        + "devid=" + Preferences.Get("DeviceGlobalID", "0") //Preferences.Get ( "DeviceGlobalID" , "0" )
                        + "&syscod=" + Preferences.Get("PlatformOS", "0")//DeviceInfo.Current.Platform.ToString().ToString().ToLower()
                        + "&acctyp=" + App.iAccountType
                        + "&dbserver=" + SRoofingEnum_DatabaseServer.DatabaseServer_UK
                        + "&gcmid=" + Preferences.Get("GCMID", "0")

                        + "&uid=" + iOwnerModel.OwnerUserTokenID
                        + "&mobid=" + iOwnerModel.OwnerMobileNumberTokenID

                        + "&callanswerok=" + Call_Auto_Answer


                        + "&req=" + SRoofingEnumHandler_UserSettingHandler.UserSetting_Call_Auto_Answer);


                return strResult;



            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }
        }




        async public static Task<string> UserSetting_Update_Call_Auto_Redial_ByOwnerUserTokenID(

    Application _context,
    string iAccountType,
    SRoofingUserOwnerModelManager iOwnerModel,
    bool Call_Auto_Redial)
        {

            try
            {


                var strResult = "0";

                strResult = await SRoofing_HandlerManager.Handler_GetResponse(

                        App.SiteDomainURL + "_iWebHandler"
                        + "/SRoofing_UserSettingHandler.ashx?"

                        + "devid=" + Preferences.Get("DeviceGlobalID", "0") //Preferences.Get ( "DeviceGlobalID" , "0" )
                        + "&syscod=" + Preferences.Get("PlatformOS", "0")//DeviceInfo.Current.Platform.ToString().ToString().ToLower()
                        + "&acctyp=" + App.iAccountType
                        + "&dbserver=" + SRoofingEnum_DatabaseServer.DatabaseServer_UK
                        + "&gcmid=" + Preferences.Get("GCMID", "0")

                        + "&uid=" + iOwnerModel.OwnerUserTokenID
                        + "&mobid=" + iOwnerModel.OwnerMobileNumberTokenID

                        + "&callredialok=" + Call_Auto_Redial


                        + "&req=" + SRoofingEnumHandler_UserSettingHandler.UserSetting_Call_Auto_Redial);


                return strResult;



            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }
        }




        async public static Task<string> UserSetting_Update_Call_Auto_Message_ByOwnerUserTokenID(

    Application _context,
    string iAccountType,
    SRoofingUserOwnerModelManager iOwnerModel,
     string Call_Auto_Message)
        {

            try
            {


                var strResult = "0";

                strResult = await SRoofing_HandlerManager.Handler_GetResponse(

                        App.SiteDomainURL + "_iWebHandler"
                        + "/SRoofing_UserSettingHandler.ashx?"

                        + "devid=" + Preferences.Get("DeviceGlobalID", "0") //Preferences.Get ( "DeviceGlobalID" , "0" )
                        + "&syscod=" + Preferences.Get("PlatformOS", "0")//DeviceInfo.Current.Platform.ToString().ToString().ToLower()
                        + "&acctyp=" + App.iAccountType
                        + "&dbserver=" + SRoofingEnum_DatabaseServer.DatabaseServer_UK
                        + "&gcmid=" + Preferences.Get("GCMID", "0")

                        + "&uid=" + iOwnerModel.OwnerUserTokenID
                        + "&mobid=" + iOwnerModel.OwnerMobileNumberTokenID

                        + "&callmsg=" + Call_Auto_Message


                        + "&req=" + SRoofingEnumHandler_UserSettingHandler.UserSetting_Call_Auto_Message);


                return strResult;



            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }
        }




        async public static Task<string> UserSetting_Update_Notification_Update_IsEnable_ByOwnerUserTokenID(

    Application _context,
    string iAccountType,
    SRoofingUserOwnerModelManager iOwnerModel,
    bool Notification_Update_IsEnable)
        {

            try
            {


                var strResult = "0";

                strResult = await SRoofing_HandlerManager.Handler_GetResponse(

                        App.SiteDomainURL + "_iWebHandler"
                        + "/SRoofing_UserSettingHandler.ashx?"

                        + "devid=" + Preferences.Get("DeviceGlobalID", "0") //Preferences.Get ( "DeviceGlobalID" , "0" )
                        + "&syscod=" + Preferences.Get("PlatformOS", "0")//DeviceInfo.Current.Platform.ToString().ToString().ToLower()
                        + "&acctyp=" + App.iAccountType
                        + "&dbserver=" + SRoofingEnum_DatabaseServer.DatabaseServer_UK
                        + "&gcmid=" + Preferences.Get("GCMID", "0")

                        + "&uid=" + iOwnerModel.OwnerUserTokenID
                        + "&mobid=" + iOwnerModel.OwnerMobileNumberTokenID

                        + "&notfupdateok=" + Notification_Update_IsEnable


                        + "&req=" + SRoofingEnumHandler_UserSettingHandler.UserSetting_Notification_Update_IsEnable);


                return strResult;



            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }
        }




        async public static Task<string> UserSetting_Update_Notification_Update_WIFI_ByOwnerUserTokenID(

    Application _context,
    string iAccountType,
    SRoofingUserOwnerModelManager iOwnerModel,
     bool Notification_Update_WIFI)
        {

            try
            {


                var strResult = "0";

                strResult = await SRoofing_HandlerManager.Handler_GetResponse(

                        App.SiteDomainURL + "_iWebHandler"
                        + "/SRoofing_UserSettingHandler.ashx?"

                        + "devid=" + Preferences.Get("DeviceGlobalID", "0") //Preferences.Get ( "DeviceGlobalID" , "0" )
                        + "&syscod=" + Preferences.Get("PlatformOS", "0")//DeviceInfo.Current.Platform.ToString().ToString().ToLower()
                        + "&acctyp=" + App.iAccountType
                        + "&dbserver=" + SRoofingEnum_DatabaseServer.DatabaseServer_UK
                        + "&gcmid=" + Preferences.Get("GCMID", "0")

                        + "&uid=" + iOwnerModel.OwnerUserTokenID
                        + "&mobid=" + iOwnerModel.OwnerMobileNumberTokenID

                        + "&notfupdatewifiok=" + Notification_Update_WIFI


                        + "&req=" + SRoofingEnumHandler_UserSettingHandler.UserSetting_Notification_Update_WIFI);


                return strResult;



            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }
        }




        async public static Task<string> UserSetting_Update_RateUs_Value_ByOwnerUserTokenID(

    Application _context,
    string iAccountType,
    SRoofingUserOwnerModelManager iOwnerModel,
     string RateUs_Value)
        {

            try
            {


                var strResult = "0";

                strResult = await SRoofing_HandlerManager.Handler_GetResponse(

                        App.SiteDomainURL + "_iWebHandler"
                        + "/SRoofing_UserSettingHandler.ashx?"

                        + "devid=" + Preferences.Get("DeviceGlobalID", "0") //Preferences.Get ( "DeviceGlobalID" , "0" )
                        + "&syscod=" + Preferences.Get("PlatformOS", "0")//DeviceInfo.Current.Platform.ToString().ToString().ToLower()
                        + "&acctyp=" + App.iAccountType
                        + "&dbserver=" + SRoofingEnum_DatabaseServer.DatabaseServer_UK
                        + "&gcmid=" + Preferences.Get("GCMID", "0")

                        + "&uid=" + iOwnerModel.OwnerUserTokenID
                        + "&mobid=" + iOwnerModel.OwnerMobileNumberTokenID

                        + "&rateus=" + RateUs_Value


                        + "&req=" + SRoofingEnumHandler_UserSettingHandler.UserSetting_RateUs_Value);


                return strResult;



            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }
        }




        async public static Task<string> UserSetting_Update_RateUs_Like_ByOwnerUserTokenID(

    Application _context,
    string iAccountType,
    SRoofingUserOwnerModelManager iOwnerModel,
     string RateUs_Like)
        {

            try
            {


                var strResult = "0";

                strResult = await SRoofing_HandlerManager.Handler_GetResponse(

                        App.SiteDomainURL + "_iWebHandler"
                        + "/SRoofing_UserSettingHandler.ashx?"

                        + "devid=" + Preferences.Get("DeviceGlobalID", "0") //Preferences.Get ( "DeviceGlobalID" , "0" )
                        + "&syscod=" + Preferences.Get("PlatformOS", "0")//DeviceInfo.Current.Platform.ToString().ToString().ToLower()
                        + "&acctyp=" + App.iAccountType
                        + "&dbserver=" + SRoofingEnum_DatabaseServer.DatabaseServer_UK
                        + "&gcmid=" + Preferences.Get("GCMID", "0")

                        + "&uid=" + iOwnerModel.OwnerUserTokenID
                        + "&mobid=" + iOwnerModel.OwnerMobileNumberTokenID

                        + "&like=" + RateUs_Like


                        + "&req=" + SRoofingEnumHandler_UserSettingHandler.UserSetting_RateUs_Like);


                return strResult;



            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }
        }




        async public static Task<string> UserSetting_Update_RateUs_Dislike_ByOwnerUserTokenID(

    Application _context,
    string iAccountType,
    SRoofingUserOwnerModelManager iOwnerModel,
     string RateUs_Dislike)
        {

            try
            {


                var strResult = "0";

                strResult = await SRoofing_HandlerManager.Handler_GetResponse(

                        App.SiteDomainURL + "_iWebHandler"
                        + "/SRoofing_UserSettingHandler.ashx?"

                        + "devid=" + Preferences.Get("DeviceGlobalID", "0") //Preferences.Get ( "DeviceGlobalID" , "0" )
                        + "&syscod=" + Preferences.Get("PlatformOS", "0")//DeviceInfo.Current.Platform.ToString().ToString().ToLower()
                        + "&acctyp=" + App.iAccountType
                        + "&dbserver=" + SRoofingEnum_DatabaseServer.DatabaseServer_UK
                        + "&gcmid=" + Preferences.Get("GCMID", "0")

                        + "&uid=" + iOwnerModel.OwnerUserTokenID
                        + "&mobid=" + iOwnerModel.OwnerMobileNumberTokenID

                        + "&dislike=" + RateUs_Dislike


                        + "&req=" + SRoofingEnumHandler_UserSettingHandler.UserSetting_RateUs_Dislike);


                return strResult;



            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }
        }




        async public static Task<string> UserSetting_Update_ContactUs_Message_ByOwnerUserTokenID(

    Application _context,
    string iAccountType,
    SRoofingUserOwnerModelManager iOwnerModel,
    string ContactUs_Message)
        {

            try
            {


                var strResult = "0";

                strResult = await SRoofing_HandlerManager.Handler_GetResponse(

                        App.SiteDomainURL + "_iWebHandler"
                        + "/SRoofing_UserSettingHandler.ashx?"

                        + "devid=" + Preferences.Get("DeviceGlobalID", "0") //Preferences.Get ( "DeviceGlobalID" , "0" )
                        + "&syscod=" + Preferences.Get("PlatformOS", "0")//DeviceInfo.Current.Platform.ToString().ToString().ToLower()
                        + "&acctyp=" + App.iAccountType
                        + "&dbserver=" + SRoofingEnum_DatabaseServer.DatabaseServer_UK
                        + "&gcmid=" + Preferences.Get("GCMID", "0")

                        + "&uid=" + iOwnerModel.OwnerUserTokenID
                        + "&mobid=" + iOwnerModel.OwnerMobileNumberTokenID

                        + "&contactus=" + ContactUs_Message


                        + "&req=" + SRoofingEnumHandler_UserSettingHandler.UserSetting_ContactUs_Message);


                return strResult;



            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }
        }






        async public static Task<string> UserSetting_Update_Chat_SortBy_ByOwnerUserTokenID(

    Application _context,
    string iAccountType,
    SRoofingUserOwnerModelManager iOwnerModel,
    string SortByMessage)
        {

            try
            {


                var strResult = "0";

                strResult = await SRoofing_HandlerManager.Handler_GetResponse(

                        App.SiteDomainURL + "_iWebHandler"
                        + "/SRoofing_UserSettingHandler.ashx?"

                        + "devid=" + Preferences.Get("DeviceGlobalID", "0") //Preferences.Get ( "DeviceGlobalID" , "0" )
                        + "&syscod=" + Preferences.Get("PlatformOS", "0")//DeviceInfo.Current.Platform.ToString().ToString().ToLower()
                        + "&acctyp=" + App.iAccountType
                        + "&dbserver=" + SRoofingEnum_DatabaseServer.DatabaseServer_UK
                        + "&gcmid=" + Preferences.Get("GCMID", "0")

                        + "&uid=" + iOwnerModel.OwnerUserTokenID
                        + "&mobid=" + iOwnerModel.OwnerMobileNumberTokenID

                        + "&sortby=" + SortByMessage


                        + "&req=" + SRoofingEnumHandler_UserSettingHandler.UserSetting_Chat_SortBy_Message);


                return strResult;



            }
            catch (Exception ex)
            {

                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }
        }






        async public static Task<string> UserSetting_Update_Call_SortBy_ByOwnerUserTokenID(

    Application _context,
    string iAccountType,
    SRoofingUserOwnerModelManager iOwnerModel,
    string SortByMessage)
        {

            try
            {


                var strResult = "0";

                strResult = await SRoofing_HandlerManager.Handler_GetResponse(

                        App.SiteDomainURL + "_iWebHandler"
                        + "/SRoofing_UserSettingHandler.ashx?"

                        + "devid=" + Preferences.Get("DeviceGlobalID", "0") //Preferences.Get ( "DeviceGlobalID" , "0" )
                        + "&syscod=" + Preferences.Get("PlatformOS", "0")//DeviceInfo.Current.Platform.ToString().ToString().ToLower()
                        + "&acctyp=" + App.iAccountType
                        + "&dbserver=" + SRoofingEnum_DatabaseServer.DatabaseServer_UK
                        + "&gcmid=" + Preferences.Get("GCMID", "0")

                        + "&uid=" + iOwnerModel.OwnerUserTokenID
                        + "&mobid=" + iOwnerModel.OwnerMobileNumberTokenID

                        + "&sortby=" + SortByMessage


                        + "&req=" + SRoofingEnumHandler_UserSettingHandler.UserSetting_Call_SortBy_Message);


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
