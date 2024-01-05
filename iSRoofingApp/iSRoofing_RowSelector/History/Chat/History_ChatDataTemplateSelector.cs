using System;
using System.Collections.Generic;
using System.Text;

using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.History.Call;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;

 

namespace S1RoofingMU.iSRoofingApp.iSRoofing_RowSelector.History.Chat
    {
    class History_ChatDataTemplateSelector : DataTemplateSelector
        {


        public DataTemplate Template_None { get; set; }
        //public DataTemplate Template_Header { get; set; }
        //public DataTemplate Template_InfoTutorial { get; set; }
        public DataTemplate Template_Item_Private_IsNewMessage_FALSE { get; set; }
        public DataTemplate Template_Item_Private_IsNewMessage_TRUE { get; set; }

       public DataTemplate Template_Item_Group_IsNewMessage_FALSE { get; set; }
        public DataTemplate Template_Item_Group_IsNewMessage_TRUE { get; set; }

        protected override DataTemplate OnSelectTemplate ( object item , BindableObject container )
            {
            try
                {



                //if (((SRoofingScreenChatShowHistoryMessageModelManager)item)
                //                   .iViewCodeType == SRoofingEnum_Generic_RowView_AdapterType.RowView_Header)
                //{
                //    return Template_Header;
                //}
                //else if ( ( ( SRoofingScreenChatShowHistoryMessageModelManager ) item )

                //                   .iViewCodeType == SRoofingEnum_Generic_RowView_AdapterType.RowView_InfoTutorial )
                //{
                //    return Template_InfoTutorial;
                //}
                //else
                //
                
                if (( ( ( SRoofingScreenChatShowHistoryMessageModelManager ) item )
                                    .GroupType== SRoofingEnum_GroupType.GroupType_PRIVATE)  && (((SRoofingScreenChatShowHistoryMessageModelManager)item)
                                    .IsNewMessage == true))
                {
                    return Template_Item_Private_IsNewMessage_TRUE;
                }
                else if ( ( ( ( SRoofingScreenChatShowHistoryMessageModelManager ) item )
                                    .GroupType == SRoofingEnum_GroupType.GroupType_PRIVATE )  && (( (SRoofingScreenChatShowHistoryMessageModelManager)item)
                                   .IsNewMessage == false) )
                {
                    return Template_Item_Private_IsNewMessage_FALSE;
                }
                  else if ( ( ( ( SRoofingScreenChatShowHistoryMessageModelManager ) item )
                                    .GroupType == SRoofingEnum_GroupType.GroupType_GROUP )  && (((SRoofingScreenChatShowHistoryMessageModelManager)item)
                                    .IsNewMessage == true))
                {
                    return Template_Item_Group_IsNewMessage_TRUE;
                }
                else if ( ( ( ( SRoofingScreenChatShowHistoryMessageModelManager ) item )
                                    .GroupType == SRoofingEnum_GroupType.GroupType_GROUP )   && (( (SRoofingScreenChatShowHistoryMessageModelManager)item)
                                   .IsNewMessage == false) )
                {
                    return Template_Item_Group_IsNewMessage_FALSE;
                }

                return Template_None;



                //return ( ( SRoofingScreenChatShowHistoryMessageModelManager ) item )
                //                   .iViewCodeType == SRoofingEnum_Generic_RowView_AdapterType.RowView_Header
                //                   ? Template_None : Template_Item_IsNewMessage_FALSE;
                }
            catch ( Exception ex )
                {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return Template_None;
                }

            }

        }
    }
