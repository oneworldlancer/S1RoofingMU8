using System;
using System.Collections.Generic;
using System.Text;

using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.History.Chat;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.KeyValue;

 

namespace S1RoofingMU.iSRoofingApp.iSRoofing_RowSelector.Alphabet
{
    class Alphabet_ListDataTemplateSelector : DataTemplateSelector
    {


        public DataTemplate Template_Disable { get; set; }
        public DataTemplate Template_Active { get; set; }
        public DataTemplate Template_Select { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            try
            {

                if ( ( ( SRoofingKeyValueModelManager ) item ).ItemCode == "select" )
                    {
                    return Template_Select;
                    }

                else if ( ( ( SRoofingKeyValueModelManager ) item ).ItemCode == "active" )
                    {

                    return Template_Active;
                    }
                else
                    {

                    return Template_Disable;
                    }
       
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return Template_Disable;
            }

        }

    }
}
