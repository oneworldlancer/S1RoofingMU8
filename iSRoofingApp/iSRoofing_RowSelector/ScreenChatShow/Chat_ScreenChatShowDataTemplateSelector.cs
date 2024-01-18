using System;
using System.Collections.Generic;
using System.Text;

using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Call;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.ScreenChatShow;

 

namespace S1RoofingMU.iSRoofingApp.iSRoofing_RowSelector.History.Chat
{
    class Chat_ScreenChatShowDataTemplateSelector : DataTemplateSelector
    {


        public DataTemplate Template_None { get; set; }
        //  public DataTemplate Template_Item_IsNewMessage_FALSE { get; set; }
        //public DataTemplate Template_Item_IsNewMessage_TRUE { get; set; }
        public DataTemplate Template_Item_Owner_Text_Only_Message { get; set; }
        public DataTemplate Template_Item_Owner_Text_Translate_Message { get; set; }
        public DataTemplate Template_Item_Owner_Share_Emotion { get; set; }
        public DataTemplate Template_Item_Owner_Text_Map { get; set; }
        public DataTemplate Template_Item_Owner_Text_YouTube { get; set; }
        public DataTemplate Template_Item_Owner_Text_WebLink_Message { get; set; }
        public DataTemplate Template_Item_Owner_Share_Giphy { get; set; }
        public DataTemplate Template_Item_Owner_Share_Video { get; set; }
        public DataTemplate Template_Item_Owner_Share_Audio { get; set; }
        public DataTemplate Template_Item_Owner_Share_Document { get; set; }
        public DataTemplate Template_Item_Owner_Share_Sound { get; set; }
        public DataTemplate Template_Item_Owner_Share_Image { get; set; }
        public DataTemplate Template_Item_Owner_Share_Video_YouTube { get; set; }

     

        public DataTemplate Template_Item_Remote_Text_Only_Message { get; set; }
        public DataTemplate Template_Item_Remote_Text_Translate_Message { get; set; }
        public DataTemplate Template_Item_Remote_Share_Emotion { get; set; }
        public DataTemplate Template_Item_Remote_Text_Map { get; set; }
        public DataTemplate Template_Item_Remote_Text_YouTube { get; set; }
        public DataTemplate Template_Item_Remote_Text_WebLink_Message { get; set; }
        public DataTemplate Template_Item_Remote_Share_Giphy { get; set; }
        public DataTemplate Template_Item_Remote_Share_Video { get; set; }
        public DataTemplate Template_Item_Remote_Share_Audio { get; set; }
        public DataTemplate Template_Item_Remote_Share_Document { get; set; }
        public DataTemplate Template_Item_Remote_Share_Sound { get; set; }
        public DataTemplate Template_Item_Remote_Share_Image { get; set; }
        public DataTemplate Template_Item_Remote_Share_Video_YouTube { get; set; }













        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            try
            {

                SRoofingScreenChatShowMessageModelManager objModel = ((SRoofingScreenChatShowMessageModelManager)item);

                string MessageType = objModel.MessageType;
                if (MessageType == null)
                {
                    MessageType = "textmessage";
                }

                if (((SRoofingScreenChatShowMessageModelManager)item)
                                   .UserType == SRoofingEnum_UserType.UserType_Owner)
                {
                    //return Template_None;

                    if ((MessageType == ("textmessage")))
                    {
                        return Template_Item_Owner_Text_Only_Message;
                    }
                    else if (MessageType == ("textmessagetranslate"))
                    {
                        return Template_Item_Owner_Text_Translate_Message;
                    }
                    else if (MessageType == ("textemotion"))
                    {
                        return Template_Item_Owner_Share_Emotion;
                    }
                    else if (MessageType == ("textmap"))
                    {
                        return Template_Item_Owner_Text_Map;
                    }
                    else if (MessageType == ("textyoutube"))
                    {
                        return Template_Item_Owner_Text_YouTube;
                    }
                    else if (MessageType == ("textweblink"))
                    {
                        return Template_Item_Owner_Text_WebLink_Message;
                    }
                    else if (MessageType == ("textgiphy"))
                    {
                        return Template_Item_Owner_Share_Giphy;
                    }
                    else if (MessageType == ("textsharevideo"))
                    {

                        return Template_Item_Owner_Share_Video;


                    }  else if (MessageType == ("textsharevideoupload"))
                    {

                        return Template_Item_Owner_Share_Video;


                    }

                    else if (MessageType == ("textshareaudio"))
                    {

                        return Template_Item_Owner_Share_Audio;

                    }
                      else if (MessageType == ("textshareaudioupload"))
                    {

                        return Template_Item_Owner_Share_Audio;

                    }
                    else if (MessageType == ("textsharedocument"))
                    {
                        return Template_Item_Owner_Share_Document;

                    }
                      else if (MessageType == ("textsharedocumentupload"))
                    {
                        return Template_Item_Owner_Share_Document;

                    }
                    else if (MessageType == ("textsharesound"))
                    {
                        return Template_Item_Owner_Share_Sound;

                    }
                      else if (MessageType == ("textsharesoundupload"))
                    {
                        return Template_Item_Owner_Share_Sound;

                    }
                    else if (MessageType == ("textsharephoto"))
                    {
                        return Template_Item_Owner_Share_Image;
                    }
                    else if (MessageType == ("textsharephotoupload"))
                    {
                        return Template_Item_Owner_Share_Image;
                    }
                    else if (MessageType == ("textsharevideoyoutube"))
                    {
                        return Template_Item_Owner_Share_Video_YouTube;
                    }









                }
                else if (((SRoofingScreenChatShowMessageModelManager)item)
                                   .UserType == SRoofingEnum_UserType.UserType_Remote)
                {
                    // return Template_Item_IsNewMessage_TRUE;



                    if ((MessageType == ("textmessage")))
                    {
                        return Template_Item_Remote_Text_Only_Message;
                    }
                    else if (MessageType == ("textmessagetranslate"))
                    {
                        return Template_Item_Remote_Text_Translate_Message;
                    }
                    else if (MessageType == ("textemotion"))
                    {
                        return Template_Item_Remote_Share_Emotion;
                    }
                    else if (MessageType == ("textmap"))
                    {
                        return Template_Item_Remote_Text_Map;
                    }
                    else if (MessageType == ("textyoutube"))
                    {
                        return Template_Item_Remote_Text_YouTube;
                    }
                    else if (MessageType == ("textweblink"))
                    {
                        return Template_Item_Remote_Text_WebLink_Message;
                    }
                    else if (MessageType == ("textgiphy"))
                    {
                        return Template_Item_Remote_Share_Giphy;
                    }
                    else if (MessageType == ("textsharevideo"))
                    {

                        return Template_Item_Remote_Share_Video;
                    }
   else if (MessageType == ("textsharevideoupload"))
                    {

                        return Template_Item_Remote_Share_Video;
                    }

                    else if (MessageType == ("textshareaudio"))
                    {

                        return Template_Item_Remote_Share_Audio;

                    }
                    else if (MessageType == ("textshareaudioupload"))
                    {

                        return Template_Item_Remote_Share_Audio;

                    }
                    else if (MessageType == ("textsharedocument"))
                    {
                        return Template_Item_Remote_Share_Document;

                    }
                    else if (MessageType == ("textsharedocumentupload"))
                    {
                        return Template_Item_Remote_Share_Document;

                    }
                    else if (MessageType == ("textsharesound"))
                    {
                        return Template_Item_Remote_Share_Sound;

                    }
                    else if (MessageType == ("textsharesoundupload"))
                    {
                        return Template_Item_Remote_Share_Sound;

                    }
                    else if (MessageType == ("textsharephoto"))
                    {
                        return Template_Item_Remote_Share_Image;
                    }
                    else if (MessageType == ("textsharephotoupload"))
                    {
                        return Template_Item_Remote_Share_Image;
                    }
                    else if (MessageType == ("textsharevideoyoutube"))
                    {
                        return Template_Item_Remote_Share_Video_YouTube;
                    }




                }
                else
                {
                    return Template_None;


                }


                return Template_None;



                //return ( ( SRoofingScreenChatShowMessageModelManager ) item )
                //                   .iViewCodeType == SRoofingEnum_Generic_RowView_AdapterType.RowView_Header
                //                   ? Template_None : Template_Item_IsNewMessage_FALSE;
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return Template_None;
            }

        }

    }
}
