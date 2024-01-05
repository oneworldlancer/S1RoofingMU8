﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Group;
using S1RoofingMU.iSRoofingApp.iSRoofing_RowModel.History.Chat;

 
 

namespace S1RoofingMU.iSRoofingApp.iSRoofing_RowModel.Header
    {
    [XamlCompilation ( XamlCompilationOptions.Compile )]
    public partial class Row_Header_Group_View : ContentView
        {
        public Row_Header_Group_View ( )
            {
            InitializeComponent ( );
            }



        #region Bindings

        public SRoofingUserGroupModelManager iGroupModel
        {
            get
            {
                return ( SRoofingUserGroupModelManager ) GetValue ( iGroupModelProperty );
            }
            set
            {
                SetValue ( iGroupModelProperty , value );
            }
        }

        public static BindableProperty iGroupModelProperty =
            BindableProperty.Create ( nameof ( iGroupModel ) , typeof ( SRoofingUserGroupModelManager ) , typeof ( Row_Chat_Private_IsNewMessage_FALSE_View ) , new SRoofingUserGroupModelManager ( ) ,
                BindingMode.TwoWay );


        public string NameLine
            {
            get
                {
                return ( string ) GetValue ( NameLineProperty );
                }
            set
                {
                SetValue ( NameLineProperty , value );
                }
            }

        public static BindableProperty NameLineProperty =
            BindableProperty.Create ( nameof ( NameLine ) , typeof ( string ) , typeof ( Row_Chat_Private_IsNewMessage_FALSE_View ) , null ,
                BindingMode.TwoWay );






        protected override void OnPropertyChanged ( string propertyName = null )
            {
            base.OnPropertyChanged ( propertyName );

            if ( propertyName == NameLineProperty.PropertyName )
                {
                if ( NameLine != null )
                    {
                    // Update ContentView properties and elements.
                    }
                }
            }

        #endregion




        }
    }