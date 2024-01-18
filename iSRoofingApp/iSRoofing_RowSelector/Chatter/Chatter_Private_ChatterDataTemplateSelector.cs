using System;
using System.Collections.Generic;
using System.Text;

using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Call;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;

 

namespace S1RoofingMU.iSRoofingApp.iSRoofing_RowSelector.Chatter
    {
    class Chatter_Private_ChatterDataTemplateSelector : DataTemplateSelector
        {


        public DataTemplate Template_None { get; set; }
       // public DataTemplate Template_Header { get; set; }
       // public DataTemplate Template_InfoTutorial { get; set; }
       // public DataTemplate Template_Item_Private_IsNewMessage_FALSE { get; set; }
       // public DataTemplate Template_Item_Private_IsNewMessage_TRUE { get; set; }

      public DataTemplate Template_Item_Owner_View { get; set; }
        //public DataTemplate Template_Item_Remote_View { get; set; }

        protected override DataTemplate OnSelectTemplate ( object item , BindableObject container )
            {
            try
                {

                    return Template_Item_Owner_View;
             

                //////////if ((((SRoofingUserRemoteModelManager)item) .GroupTokenID == "0")
                //////////    &&  (((SRoofingUserRemoteModelManager)item).PrivateGroupTokenID == "0"))
                //////////{
                //////////    return Template_Item_Owner_View;
                //////////}
                //////////else  
                //////////{
                //////////    return Template_Item_Remote_View;
                //////////}
                //else if (( ( ( SRoofingUserRemoteModelManager ) item )
                //                    .GroupType== SRoofingEnum_GroupType.GroupType_PRIVATE)  && (((SRoofingUserRemoteModelManager)item)
                //                    .IsNewMessage == true))
                //{
                //    return Template_Item_Private_IsNewMessage_TRUE;
                //}
                //else if ( ( ( ( SRoofingUserRemoteModelManager ) item )
                //                    .GroupType == SRoofingEnum_GroupType.GroupType_PRIVATE )  && (( (SRoofingUserRemoteModelManager)item)
                //                   .IsNewMessage == false) )
                //{
                //    return Template_Item_Private_IsNewMessage_FALSE;
                //}
                //  else if ( ( ( ( SRoofingUserRemoteModelManager ) item )
                //                    .GroupType == SRoofingEnum_GroupType.GroupType_GROUP )  && (((SRoofingUserRemoteModelManager)item)
                //                    .IsNewMessage == true))
                //{
                //    return Template_Item_Group_IsNewMessage_TRUE;
                //}
                //else if ( ( ( ( SRoofingUserRemoteModelManager ) item )
                //                    .GroupType == SRoofingEnum_GroupType.GroupType_GROUP )   && (( (SRoofingUserRemoteModelManager)item)
                //                   .IsNewMessage == false) )
                //{
                //    return Template_Item_Group_IsNewMessage_FALSE;
                //}

               // return Template_None;



                //return ( ( SRoofingUserRemoteModelManager ) item )
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
