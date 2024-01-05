using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Chat;

using System;
using System.Collections.Generic;
using System.Text;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Model.KeyValue
{
    public class SRoofingKeyValueModelManager
    {


        private string m_ItemCode = "0";
        private string m_ItemValue = "0";
        private string m_ItemText = "0";
        private int m_ItemWidth = 0;
        private int m_ItemHeight =0;
 
        public SRoofingKeyValueModelManager ( )
        {

            // m_ItemValue = ItemText

            // m_ItemText = ItemValue

        }

        public SRoofingKeyValueModelManager ( string ItemText , string ItemValue )
        {
            m_ItemValue = ItemValue;
            m_ItemText = ItemText;
        }

        public string ItemCode
        {
            get
            {
                return m_ItemCode;
            }

            set
            {
                m_ItemCode = value;
            }
        }

        public string ItemValue
        {
            get
            {
                return m_ItemValue;
            }

            set
            {
                m_ItemValue = value;
            }
        }

        public int ItemIndex
        {
            get; set;
        } = 0;

        public string ItemTitle
        {
            get; set;
        } = "0";


        public string ItemName
        {
            get; set;
        } = "0";

        public string ItemText
        {
            get
            {
                return m_ItemText;
            }

            set
            {
                m_ItemText = value;
            }
        }

      
        public int ItemHeight
        {
            get
            {
                return m_ItemHeight;
            }

            set
            {
                m_ItemHeight = value;
            }
        }

      
        public int ItemWidth
        {
            get
            {
                return m_ItemWidth;
            }

            set
            {
                m_ItemWidth = value;
            }
        }

        private string m_ItemCount;

        public string ItemCount
        {
            get
            {
                return m_ItemCount;
            }

            set
            {
                m_ItemCount = value;
            }
        }

        private string m_IsSystem;

        public string IsSystem
        {
            get
            {
                return m_IsSystem;
            }

            set
            {
                m_IsSystem = value;
            }
        }



        public SRoofingScreenChatShowHistoryMessageModelManager iHistoryChatMessageModel { get; set; } = null;
    }
}
