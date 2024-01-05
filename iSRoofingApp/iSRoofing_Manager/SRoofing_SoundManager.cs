using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Country;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
 
using System.Threading.Tasks;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.KeyValue;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Manager
{
    class SRoofing_SoundManager
    {




        #region CountryList


        public static async Task<bool> Initilalize_Sound_List ( )
        {

            try
            {

                ObservableCollection<SRoofingKeyValueModelManager> arr_ItemList;

                arr_ItemList = new ObservableCollection<SRoofingKeyValueModelManager> ( );
                //arr_ItemList = await SRoofingSync_Speech_Manager
                //    .Sync_Speech_Get_SpeechList ( 
                //    App.Current);

                arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                {
                    ItemText = "Sound-1" ,
                    ItemValue = "snd_chat_in_1.mp3"
                } );


                arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                {
                    ItemText = "Sound-2" ,
                    ItemValue = "snd_chat_in_2.mp3"
                } );


                arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                {
                    ItemText = "Sound-3" ,
                    ItemValue = "snd_chat_in_3.mp3"
                } );



                await SRoofingSync_Sound_Manager.Sync_Sound_Set_Chat_Incoming_List ( App.Current , arr_ItemList );


                /////////////////////////////////////////







                arr_ItemList = new ObservableCollection<SRoofingKeyValueModelManager> ( );
                //arr_ItemList = await SRoofingSync_Speech_Manager
                //    .Sync_Speech_Get_SpeechList ( 
                //    App.Current);

                arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                {
                    ItemText = "Sound-1" ,
                    ItemValue = "snd_chat_out_1.mp3"
                } );


                arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                {
                    ItemText = "Sound-2" ,
                    ItemValue = "snd_chat_out_2.mp3"
                } );


                arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                {
                    ItemText = "Sound-3" ,
                    ItemValue = "snd_chat_out_3.mp3"
                } );




                await SRoofingSync_Sound_Manager.Sync_Sound_Set_Chat_Outgoing_List ( App.Current , arr_ItemList );

                ///////////////////////////////////////////////////////



                arr_ItemList = new ObservableCollection<SRoofingKeyValueModelManager> ( );
                //arr_ItemList = await SRoofingSync_Speech_Manager
                //    .Sync_Speech_Get_SpeechList ( 
                //    App.Current);

                arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                {
                    ItemText = "Sound-1" ,
                    ItemValue = "snd_call_in_1.mp3"
                } );


                arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                {
                    ItemText = "Sound-2" ,
                    ItemValue = "snd_call_in_2.mp3"
                } );


                arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                {
                    ItemText = "Sound-3" ,
                    ItemValue = "snd_call_in_3.mp3"
                } );



                await SRoofingSync_Sound_Manager.Sync_Sound_Set_Call_Incoming_List ( App.Current , arr_ItemList );






                ///////////////////////////////////////////



                arr_ItemList = new ObservableCollection<SRoofingKeyValueModelManager> ( );
                //arr_ItemList = await SRoofingSync_Speech_Manager
                //    .Sync_Speech_Get_SpeechList ( 
                //    App.Current);

                arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                {
                    ItemText = "Sound-1" ,
                    ItemValue = "snd_call_out_1.mp3"
                } );


                arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                {
                    ItemText = "Sound-2" ,
                    ItemValue = "snd_call_out_2.mp3"
                } );


                arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                {
                    ItemText = "Sound-3" ,
                    ItemValue = "snd_call_out_3.mp3"
                } );

                await SRoofingSync_Sound_Manager.Sync_Sound_Set_Call_Outgoing_List ( App.Current , arr_ItemList );

             
                return await Task.FromResult ( true );
            }
            catch ( Exception )
            {
                return false;
            }

        }


   
        public static async Task<bool> Initilalize_Sound_List_ByUserModel (SRoofingUserOwnerModelManager iOwnerModel )
        {

            try
            {

                ObservableCollection<SRoofingKeyValueModelManager> arr_ItemList;

                arr_ItemList = new ObservableCollection<SRoofingKeyValueModelManager> ( );
                //arr_ItemList = await SRoofingSync_Speech_Manager
                //    .Sync_Speech_Get_SpeechList ( 
                //    App.Current);

                arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                {
                    ItemText = "Sound-1" ,
                    ItemValue = "snd_chat_in_1.mp3"
                } );



                await SRoofingSync_Sound_Manager.Sync_Sound_Set_Chat_Incoming_ByUserID( App.Current , iOwnerModel , arr_ItemList[0] );


                /////////////////////////////////////////







                arr_ItemList = new ObservableCollection<SRoofingKeyValueModelManager> ( );
                //arr_ItemList = await SRoofingSync_Speech_Manager
                //    .Sync_Speech_Get_SpeechList ( 
                //    App.Current);

                arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                {
                    ItemText = "Sound-1" ,
                    ItemValue = "snd_chat_out_1.mp3"
                } );



                await SRoofingSync_Sound_Manager.Sync_Sound_Set_Chat_Outgoing_ByUserID ( App.Current , iOwnerModel , arr_ItemList[0] );

                ///////////////////////////////////////////////////////



                arr_ItemList = new ObservableCollection<SRoofingKeyValueModelManager> ( );
                //arr_ItemList = await SRoofingSync_Speech_Manager
                //    .Sync_Speech_Get_SpeechList ( 
                //    App.Current);

                arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                {
                    ItemText = "Sound-1" ,
                    ItemValue = "snd_call_in_1.mp3"
                } );



                await SRoofingSync_Sound_Manager.Sync_Sound_Set_Call_Incoming_ByUserID ( App.Current , iOwnerModel , arr_ItemList[0] );






                ///////////////////////////////////////////



                arr_ItemList = new ObservableCollection<SRoofingKeyValueModelManager> ( );
                //arr_ItemList = await SRoofingSync_Speech_Manager
                //    .Sync_Speech_Get_SpeechList ( 
                //    App.Current);

                arr_ItemList.Add ( new SRoofingKeyValueModelManager ( )
                {
                    ItemText = "Sound-1" ,
                    ItemValue = "snd_call_out_1.mp3"
                } );


                await SRoofingSync_Sound_Manager.Sync_Sound_Set_Call_Outgoing_ByUserID ( App.Current ,iOwnerModel, arr_ItemList[0] );

             
                return await Task.FromResult ( true );
            }
            catch ( Exception )
            {
                return false;
            }

        }



        #endregion







    }
}
