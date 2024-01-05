using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Chat;

 

namespace S1RoofingMU.iSRoofingApp.iSRoofing_RowSelector.Group.List
    {
    class Gallery_ListDataTemplateSelector : DataTemplateSelector
        {


        public DataTemplate Template_None { get; set; }
        public DataTemplate Template_Header { get; set; }
        public DataTemplate Template_Item_Private { get; set; }
        public DataTemplate Template_Item_Group { get; set; }

        protected override DataTemplate OnSelectTemplate ( object item , BindableObject container )
            {
            try
            {

                if (((  SRoofingUserGroupModelManager ) item ).iViewCodeType == SRoofingEnum_Generic_RowView_AdapterType.RowView_Header  ) 
                {
                    return Template_Header;
                }
                else if ( ( ( SRoofingUserGroupModelManager ) item )
                                   .GroupType == SRoofingEnum_GroupType.GroupType_PRIVATE )
                {
                    return Template_Item_Private;
                }
                     else if ( ( ( SRoofingUserGroupModelManager ) item )
                                   .GroupType == SRoofingEnum_GroupType.GroupType_GROUP)
                {
                    return Template_Item_Group;
                }
                return Template_None;

                //////return ( ( SRoofingUserGroupModelManager ) item )
                //////                  .iViewCodeType == SRoofingEnum_Generic_RowView_AdapterType.RowView_Header
                //////                   ? Template_Header : Template_Item;
            }
            catch ( Exception ex )
                {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return Template_Header;
                }

            }

        }
    }
