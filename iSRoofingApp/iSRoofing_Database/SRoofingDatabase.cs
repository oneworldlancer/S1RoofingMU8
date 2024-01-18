using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Call;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Language;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.ScreenChatShow;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Setting;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;

using SQLite;



namespace S1RoofingMU.iSRoofingApp.iSRoofing_Database
{

    public class SRoofingDatabase
    {




        public SQLiteAsyncConnection _database;
        public string _databasePath;

        public SRoofingDatabase(string path)
        {

            _databasePath = path;
            _database = new SQLiteAsyncConnection(path);



            Task.Run(async () =>
         {
             await _database.CreateTableAsync<SRoofingScreenChatShowMessageModelManager>();

             await _database.CreateTableAsync<SRoofingScreenChatShowHistoryMessageModelManager>();

             await _database.CreateTableAsync<SRoofingScreenCallShowHistoryMessageModelManager>();

         }).Wait();


        }

        //public async Task<List<SRoofingScreenChatShowMessageModelManager>> getAllAsync ( )
        //{

        //    try
        //    {

        //        return await _database.Table<SRoofingScreenChatShowMessageModelManager> ( ).ToListAsync ( );
        //    }
        //    catch ( Exception ex )
        //    {
        //        SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
        //        return null;
        //    }

        //}


        public async Task<ObservableCollection<SRoofingScreenChatShowMessageModelManager>> Get_List_Chat_Message_ByGroupTokenID(string GroupTokenID)
        {

            try
            {


                using (SQLiteConnection conn = new SQLiteConnection(App.iDatabasePath))
                {
                    var arrList = conn.Table<SRoofingScreenChatShowMessageModelManager>()
                           .Where(c =>
                           c.GroupID == GroupTokenID &&
                           c.IsVisible == 1)
                           .OrderByDescending(x => x._id).Take(20)
                           .ToList();

                    conn.Close();

                    // return arrList;
                    arrList.Reverse();

                    ObservableCollection<SRoofingScreenChatShowMessageModelManager> myObservableCollection = new ObservableCollection<SRoofingScreenChatShowMessageModelManager>(arrList);


                    return myObservableCollection;
                }
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return null;
            }

        }



        public async Task<ObservableCollection<SRoofingScreenChatShowMessageModelManager>> Get_List_Chat_Gallery_ByGroupTokenID(
            string GroupTokenID,
             SRoofingScreenChatShowMessageModelManager iMessageModel)
        {

            try
            {


                using (SQLiteConnection conn = new SQLiteConnection(App.iDatabasePath))
                {

                    var arrList = conn.Table<SRoofingScreenChatShowMessageModelManager>()
                           .Where(c =>
                           c.GroupID == GroupTokenID &&
                           c.MessageTokenID != iMessageModel.MessageTokenID &&
                           c.MessageLineCode == "media" &&
                           c.IsMediaGallerySlideShow == true &&
                           c.IsVisible == 1)
                           //.OrderByDescending ( x => x._id )
                           .Take(20)
                           .ToList();

                    // return arrList;
                    // arrList.Reverse ( );
                    conn.Close();


                    arrList.Insert(0, iMessageModel);

                    ObservableCollection<SRoofingScreenChatShowMessageModelManager> myObservableCollection = new ObservableCollection<SRoofingScreenChatShowMessageModelManager>(arrList);


                    return myObservableCollection;
                }

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return null;
            }

        }


        public async Task<ObservableCollection<SRoofingScreenChatShowMessageModelManager>> Get_New_Chat_MessageList_ByGroupTokenID(

       SRoofingUserOwnerModelManager iOwnerModel, string GroupTokenID)
        {

            try
            {


                using (SQLiteConnection conn = new SQLiteConnection(App.iDatabasePath))
                {

                    var arrList = conn.Table<SRoofingScreenChatShowMessageModelManager>()
                     .Where(c =>
                     c.GroupID == GroupTokenID &&
                     c.OwnerMobileNumberID == iOwnerModel.OwnerMobileNumberTokenID &&
                     c.IsNewMessage == 1 &&
                     c.IsVisible == 1)
                     .ToList();

                    for (int i = 0; i < arrList.Count; i++)
                    {
                        arrList[i].IsNewMessage = 0;

                    }

                    conn.UpdateAll(arrList);

                    conn.Close();

                    // return arrList;
                    //arrList.Reverse();

                    ObservableCollection<SRoofingScreenChatShowMessageModelManager> myObservableCollection = new ObservableCollection<SRoofingScreenChatShowMessageModelManager>(arrList);


                    return myObservableCollection;
                }

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return null;
            }

        }







        public async Task<bool> Check_History_IsNew_Message_True_ByOwnerUserTokenID(

           SRoofingUserOwnerModelManager iOwnerModel)
        {

            try
            {



                using (SQLiteConnection conn = new SQLiteConnection(App.iDatabasePath))
                {

                    var arrList = conn.Table<SRoofingScreenChatShowHistoryMessageModelManager>()
                     .Where(c =>
                     c.OwnerUserTokenID == iOwnerModel.OwnerUserTokenID &&
                     c.IsNewMessage == true &&
                     c.IsVisible == true)
                     .ToList();

                    conn.Close();

                    if (arrList.Count > 0)
                    {
                        return true;
                    }

                    return false;


                }

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return false;
            }

        }









        public async Task<bool> Get_Reset_Chat_Message_IsNew_FALSE_ByGroupTokenID(

            string GroupTokenID)
        {

            try
            {


                using (SQLiteConnection conn = new SQLiteConnection(App.iDatabasePath))
                {


                    var arrList = conn.Table<SRoofingScreenChatShowMessageModelManager>()
                     .Where(c =>
                     c.GroupID == GroupTokenID &&
                     c.IsNewMessage == 1)
                     .ToList();

                    for (int i = 0; i < arrList.Count; i++)
                    {
                        arrList[i].IsNewMessage = 0;

                    }

                    conn.UpdateAll(arrList);






                    conn.Close();




                    return true;
                }

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return false;
            }

        }














        public async Task<int> ScreenChatShow_Update_MediaPath_MessageModel(
            string iMessageTokenID,
            string iFileCode,
            string iFilePath)
        {

            try
            {

                using (SQLiteConnection conn = new SQLiteConnection(App.iDatabasePath))
                {

                    string _MessageTokenID = iMessageTokenID;

                    var arrList = conn.Table<SRoofingScreenChatShowMessageModelManager>()
                  .Where(c =>
                  c.MessageTokenID == _MessageTokenID)
                  .FirstOrDefault();


                    if (arrList != null)
                    {
                        if (iFileCode == SRoofingEnum_File_Code.FileCode_Video)
                        {
                            arrList.VideoDefaultPath = iFilePath;

                        }
                        else
                        {
                            arrList.ImageDefaultPath = iFilePath;

                        }

                        conn.Update(arrList);
                    }


                    conn.Close();

                    return 1;
                }
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return 0;
            }

        }





        //public async Task UpdateAsync(Aperture entity)
        //{
        //    String databasePath = await DB.GetDatabaseFilePath();
        //    SQLiteAsyncConnection db = new SQLiteAsyncConnection(databasePath);
        //    var x = App.db.DBInstance.Query<Aperture>($\"SELECT * FROM Aperture WHERE Id = '{entity.Id}'\");
        //    if (x != null)
        //    {
        //        x[0].Name = entity.Name;
        //        x[0].Active = entity.Active;
        //        x[0].Notes = entity.Notes;
        //        var y = await db.UpdateAllAsync(x[0]);
        //    }
        //}



        // public async Task<List<SRoofingScreenChatShowMessageModelManager>> Update_New_Chat_MessageList_ByGroupTokenID(

        //     string GroupTokenID)
        // {

        //     try
        //     {

        //var x=    await _database.Table<SRoofingScreenChatShowMessageModelManager>()
        //              .Where((o) => o.GroupID == GroupTokenID)
        //             .Where((o) => o.IsNewMessage == 1)
        //             .Where((o) => o.IsVisible == 1)

        //             .ToListAsync();

        //         for (int i = 0; i < x.Count; i++)
        //         {
        //             x[i].IsNewMessage = 0;

        //         }
        //         await _database.UpdateAllAsync(x);

        //         //return 

        //             }
        //     catch (Exception ex)
        //     {
        //         SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
        //         return null;
        //     }

        // }


        public async Task<int> saveDataAsync(SRoofingScreenChatShowMessageModelManager iData)
        {

            try
            {

                using (SQLiteConnection conn = new SQLiteConnection(App.iDatabasePath))
                {

                    conn.Insert(iData);

                    conn.Close();

                    return 1;
                }

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return 0;
            }

        }

        public async Task<int> saveDataAsync_X1(SRoofingScreenChatShowMessageModelManager iData)
        {

            try
            {

                return await _database.InsertAsync(iData);
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return 0;
            }

        }











        #region History_Chat



        public async Task<ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>> Get_List_History_Chat_Message_ByOwnerUserTokenID(
            SRoofingUserOwnerModelManager iOwnerModel,
            SRoofingUserSettingModelManager iSettingModel)
        {

            try
            {

                using (SQLiteConnection conn = new SQLiteConnection(App.iDatabasePath))
                {
                    //////conn.CreateTable<Location> ( );
                    //////foreach ( var location in locations )
                    //////{
                    //////    conn.Insert ( location );
                    //////}
                    ////////OR
                    ////////conn.InsertAll(locations);

                    List<SRoofingScreenChatShowHistoryMessageModelManager> arrList = new List<SRoofingScreenChatShowHistoryMessageModelManager>(); ;

                    if (iSettingModel.History_Chat_SortBy == SRoofing_Enum_SortBy.SortBy_NAME)
                    {
                        arrList = conn.Table<SRoofingScreenChatShowHistoryMessageModelManager>()
                                .Where(c =>
                                c.OwnerUserTokenID == iOwnerModel.OwnerUserTokenID &&
                                c.OwnerMobileNumberTokenID == iOwnerModel.OwnerMobileNumberTokenID &&
                                c.IsVisible == true)
                                .OrderBy(x => x.AvatarName)
                                .Take(20).ToList<SRoofingScreenChatShowHistoryMessageModelManager>()
                                .ToList();
                    }
                    else if (iSettingModel.History_Chat_SortBy == SRoofing_Enum_SortBy.SortBy_RECENT)
                    {

                        arrList = conn.Table<SRoofingScreenChatShowHistoryMessageModelManager>()
                                .Where(c =>
                                c.OwnerUserTokenID == iOwnerModel.OwnerUserTokenID &&
                                c.OwnerMobileNumberTokenID == iOwnerModel.OwnerMobileNumberTokenID &&
                                c.IsVisible == true)
                                .OrderByDescending(x => x._id)
                                .Take(20).ToList<SRoofingScreenChatShowHistoryMessageModelManager>()
                                .ToList();


                    }
                    // return arrList;
                    //arrList.Reverse ( );

                    conn.Close();



                    ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager> myObservableCollection = new ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager>(arrList);




                    return myObservableCollection;



                }


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return null;
            }

        }







        public async Task<bool> Get_Reset_History_Chat_Message_IsNew_False_ByGroupTokenID(

        SRoofingUserOwnerModelManager iOwnerModel,
        string GroupTokenID)
        {

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(App.iDatabasePath))
                {

                    var arrList = conn.Table<SRoofingScreenChatShowHistoryMessageModelManager>()
                     .Where(c =>
                     c.GroupTokenID == GroupTokenID &&
                     c.IsNewMessage == true)
                     .ToList();

                    for (int i = 0; i < arrList.Count; i++)
                    {
                        arrList[i].IsNewMessage = false;

                    }
                    await _database.UpdateAllAsync(arrList);


                    conn.Close();


                    return true;

                }

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return false;
            }

        }




        public async Task<int> updateDataAsync_HistoryChat_MessageModel(
            SRoofingUserOwnerModelManager iOwnerModel,
            SRoofingScreenChatShowHistoryMessageModelManager iData)
        {

            try
            {

                using (SQLiteConnection conn = new SQLiteConnection(App.iDatabasePath))
                {

                    string GroupTokenID = iData.GroupTokenID;

                    var arrList = conn.Table<SRoofingScreenChatShowHistoryMessageModelManager>()
                  .Where(c =>
                  c.GroupTokenID == GroupTokenID &&
                  c.OwnerMobileNumberTokenID == iOwnerModel.OwnerMobileNumberTokenID)
                  .FirstOrDefault();


                    if (arrList != null)
                    {
                        //  arrList = iData;
                        // conn.Update ( arrList );

                        arrList.MessageTokenID = iData.MessageTokenID;

                        arrList.MessageType = iData.MessageType;
                        arrList.DateTime = iData.DateTime;
                        arrList.DateTimeMilliSec = iData.DateTimeMilliSec;


                        arrList.MessageText = iData.MessageText;
                        arrList.DateTimeText = iData.DateTimeText;
                        arrList.UploadDateTimeMilliSec = iData.UploadDateTimeMilliSec;
                        arrList.ImagePath = iData.ImagePath;
                        arrList.IsNewMessage = iData.IsNewMessage;


                        conn.Update(arrList);
                    }
                    else
                    {
                        conn.Insert(iData);
                    }


                    conn.Close();

                    return 1;
                }
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return 0;
            }

        }


        public async Task<int> saveDataAsync_HistoryChat_MessageModel(SRoofingScreenChatShowHistoryMessageModelManager iData)
        {

            try
            {

                using (SQLiteConnection conn = new SQLiteConnection(App.iDatabasePath))
                {


                    conn.Insert(iData);

                    conn.Close();

                    return 1;
                }
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return 0;
            }

        }









        public async Task<int> Initialize_DataAsync_HistoryChat_MessageModel(
          SRoofingUserOwnerModelManager iOwnerModel,
           SRoofingLanguageTranslateModel iLanguageModel,
          ObservableCollection<SRoofingScreenChatShowHistoryMessageModelManager> iData)
        {

            try
            {

                using (SQLiteConnection conn = new SQLiteConnection(App.iDatabasePath))
                {

                    conn.DeleteAll<SRoofingScreenChatShowHistoryMessageModelManager>();

                    for (int i = 0; i < iData.Count; i++)
                    {

                        if (iData[i].MessageType == SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_SharePhotoMessage)
                        {
                            iData[i].MessageText = iLanguageModel.lblText_ScreenChatShow_ShareImage_Message;
                        }

                        else if (iData[i].MessageType == SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_ShareVideoMessage)
                        {
                            iData[i].MessageText = iLanguageModel.lblText_ScreenChatShow_ShareVideo_Message;
                        }


                        else if (iData[i].MessageType == SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_ShareDocument)
                        {
                            iData[i].MessageText = iLanguageModel.lblText_ScreenChatShow_ShareDocument_Message;
                        }


                        else if (iData[i].MessageType == SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_ShareLocationMessage)
                        {
                            iData[i].MessageText = iLanguageModel.lblText_ScreenChatShow_ShareLocation_Message;
                        }


                        else if (iData[i].MessageType == SRoofingEnum_ScreenChatShowMessageTypeManager.ScreenChatShowTextTypeMessage_GlobalMessage)
                        {
                            iData[i].MessageText = iLanguageModel.lblText_ScreenChatShow_StartNew_Message;
                        }


                        conn.Insert(iData[i]);

                        ////////string GroupTokenID = iData[ i ].GroupTokenID;

                        ////////var existingItem =
                        ////////     conn.Table<SRoofingScreenChatShowHistoryMessageModelManager> ( )
                        ////////    .Where ( x =>
                        ////////    x.OwnerMobileNumberTokenID == iOwnerModel.OwnerMobileNumberTokenID &&
                        ////////    x.GroupTokenID ==  GroupTokenID ) 
                        ////////    .FirstOrDefault ( );

                        ////////if ( existingItem == null )
                        ////////{
                        ////////    // Data does not exist, insert new data
                        ////////    //var newItem = new YourModel { YourField = valueToCheck };
                        ////////    //await _connection.InsertAsync ( newItem );
                        ////////    conn.Insert ( iData[ i ] );
                        ////////}


                    }


                    conn.Close();

                    return 1;

                    //  return await _database.InsertAsync ( iData );
                }

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return 0;
            }

        }
















        public async Task<bool> deleteDataAsync_HistoryChat_MessageModel(string GroupTokenID)
        {

            try
            {

                using (SQLiteConnection conn = new SQLiteConnection(App.iDatabasePath))
                {

                    var arrList = conn.Table<SRoofingScreenChatShowHistoryMessageModelManager>()
                   .Where(c =>
                   c.GroupTokenID == GroupTokenID)
                   .ToList();

                    for (int i = 0; i < arrList.Count; i++)
                    {
                        conn.Delete(arrList[i]);

                    }

                    conn.Close();

                    return true;
                }

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return false;
            }

        }










        #endregion






        #region History_Call



        public async Task<ObservableCollection<SRoofingScreenCallShowHistoryMessageModelManager>> Get_List_History_Call_Message_ByOwnerUserTokenID(
            SRoofingUserOwnerModelManager iOwnerModel,
            SRoofingUserSettingModelManager iSettingModel)
        {

            try
            {

                using (SQLiteConnection conn = new SQLiteConnection(App.iDatabasePath))
                {

                    List<SRoofingScreenCallShowHistoryMessageModelManager> arrList = new List<SRoofingScreenCallShowHistoryMessageModelManager>();

                    if (iSettingModel.History_Chat_SortBy == SRoofing_Enum_SortBy.SortBy_NAME)
                    {
                        arrList = conn.Table<SRoofingScreenCallShowHistoryMessageModelManager>()
                       .Where(c =>
                       c.OwnerUserTokenID == iOwnerModel.OwnerUserTokenID &&
                       c.OwnerMobileNumberTokenID == iOwnerModel.OwnerMobileNumberTokenID &&
                       c.IsVisible == true)
                       .OrderBy(x => x.AvatarName)
                       .Take(20).ToList<SRoofingScreenCallShowHistoryMessageModelManager>()
                       .ToList();


                    }
                    else if (iSettingModel.History_Chat_SortBy == SRoofing_Enum_SortBy.SortBy_RECENT)
                    {

                        arrList = conn.Table<SRoofingScreenCallShowHistoryMessageModelManager>()
                             .Where(c =>
                            c.OwnerUserTokenID == iOwnerModel.OwnerUserTokenID &&
                            c.OwnerMobileNumberTokenID == iOwnerModel.OwnerMobileNumberTokenID &&
                            c.IsVisible == true)
                            .OrderByDescending(x => x._id)
                            .Take(20).ToList<SRoofingScreenCallShowHistoryMessageModelManager>()
                            .ToList();



                    }

                    // return arrList;
                    //arrList.Reverse ( );

                    conn.Close();



                    ObservableCollection<SRoofingScreenCallShowHistoryMessageModelManager> myObservableCollection = new ObservableCollection<SRoofingScreenCallShowHistoryMessageModelManager>(arrList);




                    return myObservableCollection;



                }


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return null;
            }

        }




        public async Task<ObservableCollection<SRoofingScreenCallShowHistoryMessageModelManager>> Get_List_History_Call_Message_ByOwnerUserTokenID_X1(SRoofingUserOwnerModelManager iOwnerModel)
        {

            try
            {

                var arrList = await _database.Table<SRoofingScreenCallShowHistoryMessageModelManager>()
                           .Where(c =>
                           c.OwnerUserTokenID == iOwnerModel.OwnerUserTokenID &&
                           c.OwnerMobileNumberTokenID == iOwnerModel.OwnerMobileNumberTokenID &&
                           c.IsVisible == true)
                           .OrderByDescending(x => x._id)
                           .Take(20)
                           .ToListAsync();

                // return arrList;
                //arrList.Reverse ( );

                ObservableCollection<SRoofingScreenCallShowHistoryMessageModelManager> myObservableCollection = new ObservableCollection<SRoofingScreenCallShowHistoryMessageModelManager>(arrList);


                return myObservableCollection;
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return null;
            }

        }



        public async Task<bool> Get_Reset_History_Call_Message_IsNew_False_ByGroupTokenID(

        SRoofingUserOwnerModelManager iOwnerModel,
        string GroupTokenID)
        {

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(App.iDatabasePath))
                {

                    var arrList = conn.Table<SRoofingScreenCallShowHistoryMessageModelManager>()
                     .Where(c =>
                     c.GroupTokenID == GroupTokenID &&
                     c.IsNewMessage == true)
                     .ToList();

                    for (int i = 0; i < arrList.Count; i++)
                    {
                        arrList[i].IsNewMessage = false;

                    }
                    await _database.UpdateAllAsync(arrList);


                    conn.Close();


                    return true;

                }

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return false;
            }

        }




        public async Task<bool> Get_Reset_History_Call_Message_IsNew_False_ByGroupTokenID_X1(

        SRoofingUserOwnerModelManager iOwnerModel,
        string GroupTokenID)
        {

            try
            {

                var arrList = await _database.Table<SRoofingScreenCallShowHistoryMessageModelManager>()
                     .Where(c =>
                     c.GroupTokenID == GroupTokenID &&
                     c.IsNewMessage == true)
                     .ToListAsync();

                for (int i = 0; i < arrList.Count; i++)
                {
                    arrList[i].IsNewMessage = false;

                }
                await _database.UpdateAllAsync(arrList);


                return true;
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return false;
            }

        }



        public async Task<int> saveDataAsync_HistoryCall_MessageModel(SRoofingScreenCallShowHistoryMessageModelManager iData)
        {

            try
            {

                using (SQLiteConnection conn = new SQLiteConnection(App.iDatabasePath))
                {


                    conn.Insert(iData);

                    conn.Close();

                    return 1;
                }
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return 0;
            }

        }






        public async Task<int> updateDataAsync_HistoryCall_MessageModel(
            SRoofingUserOwnerModelManager iOwnerModel,
            SRoofingScreenCallShowHistoryMessageModelManager iData)
        {

            try
            {

                using (SQLiteConnection conn = new SQLiteConnection(App.iDatabasePath))
                {

                    string GroupTokenID = iData.GroupTokenID;

                    var arrList = conn.Table<SRoofingScreenCallShowHistoryMessageModelManager>()
                  .Where(c =>
                  c.GroupTokenID == GroupTokenID &&
                  c.OwnerMobileNumberTokenID == iOwnerModel.OwnerMobileNumberTokenID)
                  .FirstOrDefault();


                    if (arrList != null)
                    {
                        //  arrList = iData;
                        // conn.Update ( arrList );

                        arrList.GroupTokenID = iData.GroupTokenID;

                        //arrList.MessageType = iData.MessageType;
                        arrList.DateTime = iData.DateTime;
                        arrList.DateTimeMilliSec = iData.DateTimeMilliSec;


                        arrList.MessageText = iData.MessageText;
                        arrList.DateTimeText = iData.DateTimeText;
                        arrList.UploadDateTimeMilliSec = iData.UploadDateTimeMilliSec;
                        arrList.ImagePath = iData.ImagePath;
                        arrList.IsNewMessage = iData.IsNewMessage;


                        conn.Update(arrList);
                    }
                    else
                    {
                        conn.Insert(iData);
                    }


                    conn.Close();

                    return 1;
                }
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return 0;
            }

        }







        public async Task<int> Initialize_DataAsync_HistoryCall_MessageModel(
              SRoofingUserOwnerModelManager iOwnerModel,
              SRoofingLanguageTranslateModel iLanguageModel,
         ObservableCollection<SRoofingScreenCallShowHistoryMessageModelManager> iData)
        {

            try
            {

                using (SQLiteConnection conn = new SQLiteConnection(App.iDatabasePath))
                {

                    conn.DeleteAll<SRoofingScreenCallShowHistoryMessageModelManager>();

                    for (int i = 0; i < iData.Count; i++)
                    {

                        conn.Insert(iData[i]);

                    }

                    conn.Close();

                    return 1;

                    //  return await _database.InsertAsync ( iData );
                }



                //////using ( SQLiteConnection conn = new SQLiteConnection ( App.iDatabasePath ) )
                //////{

                //////    conn.DeleteAll<SRoofingScreenCallShowHistoryMessageModelManager> ( );

                //////    for ( int i = 0 ; i < iData.Count ; i++ )
                //////    {


                //////        var existingItem =
                //////           await _database.Table<SRoofingScreenCallShowHistoryMessageModelManager> ( )
                //////           .Where ( x =>
                //////           x.OwnerMobileNumberTokenID == iOwnerModel.OwnerMobileNumberTokenID &&
                //////           x.GroupTokenID == iData[ i ].GroupTokenID )
                //////           .FirstOrDefaultAsync ( );

                //////        if ( existingItem == null )
                //////        {
                //////            // Data does not exist, insert new data
                //////            //var newItem = new YourModel { YourField = valueToCheck };
                //////            //await _connection.InsertAsync ( newItem );
                //////            conn.Insert ( iData[ i ] );
                //////        }
                //////    }


                //////    conn.Close ( );

                //////    return 1;

                //////    //  return await _database.InsertAsync ( iData );
                //////}

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return 0;
            }

        }















        public async Task<bool> deleteDataAsync_HistoryCall_MessageModel(string GroupTokenID)
        {

            try
            {

                using (SQLiteConnection conn = new SQLiteConnection(App.iDatabasePath))
                {

                    var arrList = conn.Table<SRoofingScreenCallShowHistoryMessageModelManager>()
                   .Where(c =>
                   c.GroupTokenID == GroupTokenID)
                   .ToList();

                    for (int i = 0; i < arrList.Count; i++)
                    {
                        conn.Delete(arrList[i]);

                    }

                    conn.Close();

                    return true;
                }

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return false;
            }

        }








        #endregion



        ////////#region History_Call



        ////////public async Task<ObservableCollection<SRoofingScreenCallShowHistoryMessageModelManager>> Get_List_History_Call_Message_ByOwnerUserTokenID ( SRoofingUserOwnerModelManager iOwnerModel )
        ////////{

        ////////    try
        ////////    {

        ////////        var arrList = await _database.Table<SRoofingScreenCallShowHistoryMessageModelManager> ( )
        ////////                   .Where ( c =>
        ////////                   c.OwnerUserTokenID == iOwnerModel.OwnerUserTokenID &&
        ////////                   c.OwnerMobileNumberTokenID == iOwnerModel.OwnerMobileNumberTokenID &&
        ////////                   c.IsVisible == true )
        ////////                   .OrderByDescending ( x => x._id )
        ////////                   .Take ( 20 )
        ////////                   .ToListAsync ( );

        ////////        // return arrList;
        ////////        //arrList.Reverse ( );

        ////////        ObservableCollection<SRoofingScreenCallShowHistoryMessageModelManager> myObservableCollection = new ObservableCollection<SRoofingScreenCallShowHistoryMessageModelManager> ( arrList );


        ////////        return myObservableCollection;
        ////////    }
        ////////    catch ( Exception ex )
        ////////    {
        ////////        SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
        ////////        return null;
        ////////    }

        ////////}





        ////////public async Task<bool> Get_Reset_History_Call_Message_IsNew_False_ByOwnerUserTokenID (

        ////////SRoofingUserOwnerModelManager iOwnerModel ,
        ////////string GroupTokenID )
        ////////{

        ////////    try
        ////////    {

        ////////        var arrList = await _database.Table<SRoofingScreenCallShowHistoryMessageModelManager> ( )
        ////////             .Where ( c =>
        ////////             c.GroupTokenID == GroupTokenID &&
        ////////             c.IsNewMessage == true )
        ////////             .ToListAsync ( );

        ////////        for ( int i = 0 ; i < arrList.Count ; i++ )
        ////////        {
        ////////            arrList[ i ].IsNewMessage = false;

        ////////        }
        ////////        await _database.UpdateAllAsync ( arrList );











        ////////        return true;
        ////////    }
        ////////    catch ( Exception ex )
        ////////    {
        ////////        SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
        ////////        return false;
        ////////    }

        ////////}


        ////////public async Task<int> saveDataAsync_HistoryCall_MessageModel ( SRoofingScreenCallShowHistoryMessageModelManager iData )
        ////////{

        ////////    try
        ////////    {

        ////////        return await _database.InsertAsync ( iData );
        ////////    }
        ////////    catch ( Exception ex )
        ////////    {
        ////////        SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
        ////////        return 0;
        ////////    }

        ////////}




        ////////public async Task<int> Initialize_DataAsync_HistoryCall_MessageModel ( ObservableCollection<SRoofingScreenCallShowHistoryMessageModelManager> iData )
        ////////{

        ////////    try
        ////////    {


        ////////        //Task.Run ( async ( ) =>
        ////////        //{

        ////////        //    var db = new SQLiteConnection ( _databasePath );
        ////////        //    db.DeleteAll<SRoofingScreenCallShowHistoryMessageModelManager> ( );


        ////////        //    //db.Close ( );

        ////////        //} ).Wait ( );

        ////////        await _database.DeleteAllAsync<SRoofingScreenCallShowHistoryMessageModelManager> ( );

        ////////        for ( int i = 0 ; i < iData.Count ; i++ )
        ////////        {
        ////////            await _database.InsertAsync ( iData[ i ] );
        ////////        }

        ////////        return 1;

        ////////        //  return await _database.InsertAsync ( iData );
        ////////    }
        ////////    catch ( Exception ex )
        ////////    {
        ////////        SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
        ////////        return 0;
        ////////    }

        ////////}





        ////////public async Task<bool> deleteDataAsync_HistoryCall_MessageModel ( string GroupTokenID )
        ////////{

        ////////    try
        ////////    {

        ////////        //SRoofingScreenCallShowHistoryMessageModelManager iRow = await _database.Table<SRoofingScreenCallShowHistoryMessageModelManager> ( ).Where ( i => i.GroupTokenID == GroupTokenID ).FirstOrDefaultAsync ( );


        ////////        //return await _database.DeleteAsync ( iRow );


        ////////        var arrList = await _database.Table<SRoofingScreenCallShowHistoryMessageModelManager> ( )
        ////////           .Where ( c =>
        ////////           c.GroupTokenID == GroupTokenID )
        ////////           .ToListAsync ( );

        ////////        for ( int i = 0 ; i < arrList.Count ; i++ )
        ////////        {
        ////////            await _database.DeleteAsync ( arrList[ i ] );
        ////////        }

        ////////        return true;

        ////////    }
        ////////    catch ( Exception ex )
        ////////    {
        ////////        SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
        ////////        return false;
        ////////    }

        ////////}










        ////////#endregion



    }
}
