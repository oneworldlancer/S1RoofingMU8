using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Azure;
using Azure.AI.TextAnalytics;



using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.ScreenChatShow;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Speech;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;
using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;

using Microsoft.Maui.Controls;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Manager
{
    public class SRoofing_ScreenChatShowTextMessageManager
    {





        #region Message_Status


        public static async Task ScreenChatShowMessage_Reset_History_Chat_Message_IsNew_False_ByGroupTokenID (
          Application _context ,
          string iAccountType ,
           SRoofingUserOwnerModelManager iOwnerModel ,
           string iUserType ,
          string GroupTokenID ,
          string MessageTokenID )
        {


            try
            {
               _=   Task.Run ( async ( ) =>
                {

                    await App.Database.Get_Reset_History_Chat_Message_IsNew_False_ByGroupTokenID (
                         iOwnerModel , GroupTokenID );


                    await App.Database.Get_Reset_Chat_Message_IsNew_FALSE_ByGroupTokenID ( GroupTokenID );

                } ).ConfigureAwait ( false );//.Wait ( );


            }

            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );

                return;
            }


        }


     
        
          
        public static async Task<bool> ScreenChatShowMessage_Check_IsNew_Message_True_ByOwnerUserTokenID (
          Application _context ,
          string iAccountType ,
           SRoofingUserOwnerModelManager iOwnerModel )
        {


            try
            {
                return     await App.Database.Check_History_IsNew_Message_True_ByOwnerUserTokenID (   iOwnerModel);


            }

            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );

                return false;
            }


        }


        
        
        
        
        
        
        
        #endregion













        #region Emotion


        #endregion
        public static async Task<string> ScreenChatShowMessage_Get_Translated (
                    Application _context ,
                    String iAccountType ,
                    //SRoofingUserSettingModelManager iSettingModel ,
                    SRoofingUserOwnerModelManager iOwnerModel ,
                    String MessageType ,
                    String MessageText )
        {

            ////TODO UNCOMMENT AFTER CREATE NEW CODE
            String _iLanguageCode;
            String _iOriginal_MessageText = MessageText;

            String _iTranslated_MessageText;
            String _iResult_MessageText;


            try
            {

                //DetectLanguageClient client = new DetectLanguageClient ( "6443b209c0ecfc15eb9ef9d9a7f49132" );
                // "48d383bb948f930cfdf51e17cfb5f01c";

                if ( MessageType == ( SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_EmotionMessage ) )
                {
                    /*
                                    _iResult_MessageText = "Emotion";
                    */
                    _iResult_MessageText = _iOriginal_MessageText;
                }
                else if ( MessageType == ( SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_StickerMessage ) )
                {
                    _iResult_MessageText = "Sticker";
                }
                else if ( MessageType == ( SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_GiphyMessage ) )
                {
                    _iResult_MessageText = "Giphy";
                }
                else if ( MessageType == ( SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_TextEventMessage ) )
                {
                    _iResult_MessageText = "Event invitation";
                }
                else if ( MessageType == ( SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_ShareDocument ) )
                {
                    _iResult_MessageText = "Shared file";
                }
                else if ( MessageType == ( SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_ShareAudioMessage ) )
                {
                    _iResult_MessageText = "Voice message";
                }
                else if ( MessageType == ( SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_ShareSound ) )
                {
                    _iResult_MessageText = "Shared sound";
                }
                else if ( MessageType == ( SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_ShareLocationCityMessage ) )
                {
                    _iResult_MessageText = "Shared location";
                }
                else if ( MessageType == ( SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_ShareLocationPinPointMessage ) )
                {
                    _iResult_MessageText = "Shared pinpoint";
                }
                else if ( MessageType == ( SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_ShareLocationAskRemoteMessage ) )
                {
                    _iResult_MessageText = "Request location";
                }
                //////////else if ( MessageType==  ( SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_ShareShopMessage ) )
                //////////    {
                //////////    String [ ] arrayOfString = MessageText.split ( "\\|" );
                //////////    bool bool4 =
                //////////            arrayOfString [ 0 ]==  ( TlknEnum_Shop.Shop_Wallpaper );
                //////////    _iResult_MessageText = null;
                //////////    if ( bool4 )
                //////////        {
                //////////        _iResult_MessageText = "Shared wallpaper package";
                //////////        }
                //////////    if ( arrayOfString [ 0 ]==  ( TlknEnum_Shop.Shop_Sticker ) )
                //////////        {
                //////////        _iResult_MessageText = "Shared sticker package";
                //////////        }
                //////////    }
                else if ( (
                        MessageType == ( SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_TextTranslateMessage )
                        || ( MessageType == ( SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_TextMessage_ParsePendingMessage ) ) ) )
                {

                    _iOriginal_MessageText =
                             WebUtility.UrlDecode ( MessageText ).Split ( '|' )[ 1 ];
                    bool get_Speech_IsEnable = true;
                    //if ( iSettingModel.Speech_IsEnable ( ).boolValue ( ) == true )  
                    if ( get_Speech_IsEnable == true )
                    {

                        _iLanguageCode = await SRoofing_TranslationManager.DetectMessageTextLanguage ( _iOriginal_MessageText ); //client.DetectCodeAsync ( _iOriginal_MessageText );

                        if ( _iLanguageCode != null )
                        {


                            SRoofingSpeechModel _iOwnerSpeechModel = await
                                    SRoofingSync_Speech_Manager.Sync_Speech_Get_Incoming_ByUserID ( _context ,
                                                                                                iOwnerModel );
                            //_iOwnerSpeechModel.LanguageCode
                            if ( _iLanguageCode == ( "en" ) )
                            {
                                _iResult_MessageText = _iOriginal_MessageText;
                            }
                            else
                            {

                                if ( get_Speech_IsEnable == true )
                                {
                                    //_iOwnerSpeechModel.LanguageCode
                                    _iTranslated_MessageText =
                                     await SRoofing_TranslationManager.TranslateText ( _iLanguageCode , "en" , _iOriginal_MessageText
                                                                                   );

                                    if ( _iTranslated_MessageText == null )
                                    {

                                        _iResult_MessageText = _iOriginal_MessageText;
                                    }
                                    else if ( _iTranslated_MessageText == ( "" ) )
                                    {
                                        _iResult_MessageText = _iOriginal_MessageText;

                                    }
                                    else
                                    {
                                        _iResult_MessageText = _iTranslated_MessageText;
                                    }
                                }
                                else
                                {


                                    _iResult_MessageText = _iOriginal_MessageText;
                                }

                            }

                        }
                        else
                        {

                            _iResult_MessageText = _iOriginal_MessageText;

                        }


                    }
                    else
                    {
                        _iResult_MessageText = _iOriginal_MessageText;
                    }
                }
                else
                {
                    _iResult_MessageText = _iOriginal_MessageText;
                }


                return _iResult_MessageText;

            }
            //catch ( IndexOutOfBoundsException localIndexOutOfBoundsException )
            //    {
            //    return _iOriginal_MessageText;
            //    }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );

                return _iOriginal_MessageText;
            }


        }


    }
}
