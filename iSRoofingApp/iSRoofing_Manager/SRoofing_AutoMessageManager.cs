using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Country;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
 
using System.Threading.Tasks;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Language;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.KeyValue;
using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Manager
{
    class SRoofing_AutoMessageManager
    {

        // https://learn.microsoft.com/en-us/azure/cognitive-services/speech-service/language-support?tabs=stt

        #region CountryList


        //////public static async Task<bool> Initilalize_AutoMessage_ByLanguageCode ( SRoofingLanguageTranslateModel iLanguageModel , string LanguageCode )
        //////{

        //////    try
        //////    {    
                
        //////        await Initilalize_Call_AutoMessage_ByLanguageCode ( iLanguageModel );
              

        //////        return await Task.FromResult ( true );
        //////    }
        //////    catch ( Exception ex )
        //////    {
        //////        SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
        //////        return false;
        //////    }

        //////}




        public static async Task<bool> Initilalize_Call_AutoMessage_ByLanguageCode ( SRoofingLanguageTranslateModel iLanguageModel )
        {

            try
            {
                ObservableCollection<SRoofingKeyValueModelManager> _arrLanguageModelList;

                #region English-Call-AutoMessage

                 
                _arrLanguageModelList = new ObservableCollection<SRoofingKeyValueModelManager> ( );


                /* English */
                _arrLanguageModelList.Add ( new SRoofingKeyValueModelManager ( )
                {
                    ItemText = iLanguageModel.lblText_Call_AutoMessage_SorryImBusyCanYouCallLater ,
                    ItemValue = iLanguageModel.lblText_Call_AutoMessage_SorryImBusyCanYouCallLater
                } );

                _arrLanguageModelList.Add ( new SRoofingKeyValueModelManager ( )
                {
                    ItemText = iLanguageModel.lblText_Call_AutoMessage_IWillCallYouBackWhenImFree ,
                    ItemValue = iLanguageModel.lblText_Call_AutoMessage_IWillCallYouBackWhenImFree
                } );

                _arrLanguageModelList.Add ( new SRoofingKeyValueModelManager ( )
                {
                    ItemText = iLanguageModel.lblText_Call_AutoMessage_SorryIcanontTalkAtTheMoment ,
                    ItemValue = iLanguageModel.lblText_Call_AutoMessage_SorryIcanontTalkAtTheMoment
                } );

                _arrLanguageModelList.Add ( new SRoofingKeyValueModelManager ( )
                {
                    ItemText = iLanguageModel.lblText_Call_AutoMessage_CanYouMessageMe ,
                    ItemValue = iLanguageModel.lblText_Call_AutoMessage_CanYouMessageMe
                } );


                await SRoofingSync_AutoMessage_Manager.Sync_AutoMessage_Call_Set_AutoReplyMessageList_ByAccountType ( App.Current , _arrLanguageModelList );

         
                #endregion




                #region English-Gallery_PickerList


                _arrLanguageModelList = new ObservableCollection<SRoofingKeyValueModelManager> ( );


                /* English */
                _arrLanguageModelList.Add ( new SRoofingKeyValueModelManager ( )
                {
                    ItemText = iLanguageModel.lblText_Gallery_PickImage ,
                    ItemValue = SRoofing_Enum_GalleryPicker.GalleryPicker_PICK_IMAGE
                } ) ;

                _arrLanguageModelList.Add ( new SRoofingKeyValueModelManager ( )
                {
                    ItemText = iLanguageModel.lblText_Gallery_CaptureImage ,
                    ItemValue = SRoofing_Enum_GalleryPicker.GalleryPicker_CAPTURE_IMAGE
                } );

                _arrLanguageModelList.Add ( new SRoofingKeyValueModelManager ( )
                {
                    ItemText = iLanguageModel.lblText_Gallery_PickVideo ,
                    ItemValue = SRoofing_Enum_GalleryPicker.GalleryPicker_CAPTURE_VIDEO
                } );

                _arrLanguageModelList.Add ( new SRoofingKeyValueModelManager ( )
                {
                    ItemText = iLanguageModel.lblText_Gallery_CaptureVideo ,
                    ItemValue = SRoofing_Enum_GalleryPicker.GalleryPicker_PICK_VIDEO
                } );


                await SRoofingSync_AutoMessage_Manager.Sync_AutoMessage_Gallery_Set_PickerMessageList_ByAccountType ( App.Current , _arrLanguageModelList );

                #endregion


                return await Task.FromResult ( true );

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return false;
            }

        }




        //////public static async Task<SRoofingKeyValueModelManager> Get_LanguageModel (
        //////    string iTokenID ,
        //////    string iLanguageCode ,
        //////      string iLanguageText ,
        //////     string iLanguageTextOriginal ,
        //////   string iLanguageTextTranslated )
        //////{

        //////    try
        //////    {

        //////        SRoofingKeyValueModelManager iLanguageModel;


        //////        iLanguageModel = new SRoofingKeyValueModelManager ( )
        //////        {
        //////            TokenID = iTokenID.ToString ( ) ,
        //////            LanguageCode = iLanguageCode.ToString ( ) ,
        //////            LanguageText = iLanguageText.ToString ( ) ,
        //////            LanguageTextOriginal = iLanguageTextOriginal.ToString ( ) ,
        //////            LanguageTextTranslated = iLanguageTextTranslated.ToString ( )
        //////        };

        //////        return await Task.FromResult ( iLanguageModel );

        //////    }
        //////    catch ( Exception ex )
        //////    {
        //////        SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
        //////        return null;
        //////    }

        //////}



        #endregion







    }
}
