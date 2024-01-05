using System;
using System.Collections.Generic;
using System.Text;

using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;

 

namespace S1RoofingMU.iSRoofingApp.iSRoofing_RowSelector.Contact.List
    {
    class Contact_ListDataTemplateSelector : DataTemplateSelector
        {


        public DataTemplate Template_None { get; set; }
        public DataTemplate Template_Header { get; set; }
        public DataTemplate Template_InfoTutorial { get; set; }
        public DataTemplate Template_Item { get; set; }

        protected override DataTemplate OnSelectTemplate ( object item , BindableObject container )
            {
            try
                {



                if ( ( ( SRoofingUserRemoteModelManager ) item )
                    .iViewCodeType == SRoofingEnum_Generic_RowView_AdapterType.RowView_Header )
                {
                    return Template_Header;
                }
                else if ( ( ( SRoofingUserRemoteModelManager ) item )
    
                                   .iViewCodeType == SRoofingEnum_Generic_RowView_AdapterType.RowView_InfoTutorial )
                {
                    return Template_InfoTutorial;
                }
                //else if ( ( ( SRoofingUserRemoteModelManager ) item )
                //              .iViewCodeType == SRoofingEnum_Generic_RowView_AdapterType.RowView_Item )
                //{
                //    return Template_Item;
                //}
                
                else 
                {
                    return Template_Item;
                }
              
                return Template_None;

                //return ( ( SRoofingUserRemoteModelManager ) item )
                //                  .iViewCodeType == SRoofingEnum_Generic_RowView_AdapterType.RowView_Header
                //                   ? Template_Header : Template_Item;

                // return Template_Item;

            }
            catch ( Exception ex )
                {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return Template_Item;
                }

            }

        }
    }
