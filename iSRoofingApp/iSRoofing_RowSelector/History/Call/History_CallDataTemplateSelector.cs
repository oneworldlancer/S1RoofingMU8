using System;
using System.Collections.Generic;
using System.Text;

using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Call;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.User;

 

namespace S1RoofingMU.iSRoofingApp.iSRoofing_RowSelector.History.Call
{
    class History_CallDataTemplateSelector : DataTemplateSelector
    {


        public DataTemplate Template_None { get; set; }
        public DataTemplate Template_Header { get; set; }
        public DataTemplate Template_InfoTutorial { get; set; }
        public DataTemplate Template_Item_IsNewMessage_FALSE_IN { get; set; }
        public DataTemplate Template_Item_IsNewMessage_FALSE_OUT { get; set; }
        public DataTemplate Template_Item_IsNewMessage_TRUE { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            try
            {

                if (((SRoofingScreenCallShowHistoryMessageModelManager)item)
                                   .iViewCodeType == SRoofingEnum_Generic_RowView_AdapterType.RowView_Header)
                {
                    return Template_Header;
                }

                else if ( ( ( SRoofingScreenCallShowHistoryMessageModelManager ) item )

                                     .iViewCodeType == SRoofingEnum_Generic_RowView_AdapterType.RowView_InfoTutorial )
                {
                    return Template_InfoTutorial;
                }
                else  if (((SRoofingScreenCallShowHistoryMessageModelManager)item).CallStatus  == ("in"))
                {


                    //vHolder.tvMessageText.setTextColor(
                    //        ContextCompat.getColor(_context,
                    //                                 R.Colors.WHITE));

                    //vHolder.tvLocation.setTextColor(
                    //        ContextCompat.getColor(_context, R.Colors.WHITESMOKE));

                    //vHolder.imgChatType.setBackgroundResource(R.mipmap.img_call_in_white);

                    return Template_Item_IsNewMessage_FALSE_IN;



                }
                else if (((SRoofingScreenCallShowHistoryMessageModelManager)item).CallStatus  == ("out"))
                {


                    //vHolder.tvMessageText.setTextColor(
                    //        ContextCompat.getColor(_context, R.Colors.WHITE));

                    //vHolder.tvLocation.setTextColor(
                    //        ContextCompat.getColor(_context, R.Colors.WHITESMOKE));

                    //vHolder.imgChatType.setBackgroundResource(R.mipmap.img_call_out_white);


                    return Template_Item_IsNewMessage_FALSE_OUT;


                }
                else if (((SRoofingScreenCallShowHistoryMessageModelManager)item).CallStatus  == ("missed"))
                {

                    if (((SRoofingScreenCallShowHistoryMessageModelManager)item).IsNewMessage  == true)
                    {

                        //vHolder.tvMessageText.setTextColor(
                        //        ContextCompat.getColor(_context, R.Colors.RED));

                        //vHolder.tvLocation.setTextColor(
                        //          ContextCompat.getColor(_context, R.Colors.RED));

                        //vHolder.imgChatType.setBackgroundResource(R.mipmap.img_call_missed_red);

                        return Template_Item_IsNewMessage_TRUE;



                    }
                    else
                    {

                        //vHolder.tvMessageText.setTextColor(
                        //        ContextCompat.getColor(_context, R.Colors.WHITE));

                        //vHolder.tvLocation.setTextColor(
                        //          ContextCompat.getColor(_context, R.Colors.WHITESMOKE));

                        //vHolder.imgChatType.setBackgroundResource(R.mipmap.img_call_missed_white);


                        return Template_Item_IsNewMessage_FALSE_OUT;

                    }
                }



                
                
                //else if (((SRoofingScreenCallShowHistoryMessageModelManager)item)
                //                    .IsNewMessage == true)
                //{
                //    return Template_Item_IsNewMessage_TRUE;
                //}
                //else if (((SRoofingScreenCallShowHistoryMessageModelManager)item)
                //                   .IsNewMessage == true)
                //{
                //    return Template_Item_IsNewMessage_FALSE;
                //}

                return Template_None;
















                //return ( ( SRoofingScreenCallShowHistoryMessageModelManager ) item )
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
