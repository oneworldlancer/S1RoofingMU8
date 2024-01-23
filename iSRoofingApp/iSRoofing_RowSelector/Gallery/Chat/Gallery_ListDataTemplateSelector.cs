using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.ScreenChatShow;



namespace S1RoofingMU.iSRoofingApp.iSRoofing_RowSelector.Gallery.Chat
{
    class Gallery_ListDataTemplateSelector : DataTemplateSelector
    {


        public DataTemplate Template_None { get; set; }
        public DataTemplate Template_Header { get; set; }
        public DataTemplate Template_Item_Image { get; set; }
        public DataTemplate Template_Item_Video { get; set; }
        public DataTemplate Template_Item_WebLink { get; set; }
        public DataTemplate Template_Item_Document { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            try
            {

                if (((SRoofingScreenChatShowMessageModelManager)item).MediaFile_Code == SRoofingEnum_File_Code.FileCode_Image)
                {
                    return Template_Item_Image;
                }
                else if (((SRoofingScreenChatShowMessageModelManager)item).MediaFile_Code == SRoofingEnum_File_Code.FileCode_Video)
                {
                    return Template_Item_Video;
                }
                else if (((SRoofingScreenChatShowMessageModelManager)item).MediaFile_Code == SRoofingEnum_File_Code.FileCode_Document)
                {
                    return Template_Item_Document;
                }
                else if (((SRoofingScreenChatShowMessageModelManager)item).MediaFile_Code == SRoofingEnum_File_Code.FileCode_WebLink)
                {
                    return Template_Item_WebLink;
                }

                return Template_None;

                //////return ( ( SRoofingScreenChatShowMessageModelManager ) item )
                //////                  .iViewCodeType == SRoofingEnum_Generic_RowView_AdapterType.RowView_Header
                //////                   ? Template_Header : Template_Item;
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return Template_Header;
            }

        }

    }
}
