using System;
using System.Collections.Generic;
using System.Text;

using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Model.Category
    {
    public class SRoofingCategoryModelManager
        {


        public SRoofingCategoryModelManager ( )
            {
            }
        public SRoofingCategoryModelManager ( int CategoryID )
            {
            _CategoryID = CategoryID;
            }




        private string _iViewCodeType = SRoofingEnum_Generic_RowView_AdapterType.RowView_Header;

        public string iViewCodeType
            {
            get
                {
                return _iViewCodeType;
                }
            set
                {
                _iViewCodeType = value;
                }
            }




        private string _AccountType = SRoofingEnum_UserAccountManager.UserAccount_PERSONAL;
        public string AccountType
            {
            get
                {
                return _AccountType;
                }
            set
                {
                _AccountType = value;
                }
            }


        private int _CategoryID;
        public int CategoryID
            {
            get
                {
                return _CategoryID;
                }
            set
                {
                _CategoryID = value;
                }
            }

        private bool _IsSystem;
        public bool IsSystem
            {
            get
                {
                return _IsSystem;
                }
            set
                {
                _IsSystem = value;
                }
            }

        private string _CategoryCode;
        public string CategoryCode
            {
            get
                {
                return _CategoryCode;
                }
            set
                {
                _CategoryCode = value;
                }
            }

        private string _CategoryTokenID;
        public string CategoryTokenID
            {
            get
                {
                return _CategoryTokenID;
                }
            set
                {
                _CategoryTokenID = value;
                }
            }

        private string _CategoryName;
        public string CategoryName
            {
            get
                {
                return _CategoryName;
                }
            set
                {
                _CategoryName = value;
                }
            }


        private string _CategoryTitle;
        public string CategoryTitle
            {
            get
                {
                return _CategoryTitle;
                }
            set
                {
                _CategoryTitle = value;
                }
            }


        private string _CategoryDescription;
        public string CategoryDescription
            {
            get
                {
                return _CategoryDescription;
                }
            set
                {
                _CategoryDescription = value;
                }
            }

        private string _CategoryColor;
        public string CategoryColor
            {
            get
                {
                return _CategoryColor;
                }
            set
                {
                _CategoryColor = value;
                }
            }

        private string _GroupCount;
        public string GroupCount
            {
            get
                {
                return _GroupCount;
                }
            set
                {
                _GroupCount = value;
                }
            }


        private string _CategoryImageID;
        public string CategoryImageID
            {
            get
                {
                return _CategoryImageID;
                }
            set
                {
                _CategoryImageID = value;
                }
            }




        private string _ListAvatarImageID;
        public string ListAvatarImageID
            {
            get
                {
                return _ListAvatarImageID;
                }
            set
                {
                _ListAvatarImageID = value;
                }
            }

        private string _CategoryOrder;
        public string CategoryOrder
            {
            get
                {
                return _CategoryOrder;
                }
            set
                {
                _CategoryOrder = value;
                }
            }

        private string _IsActive;
        public string IsActive
            {
            get
                {
                return _IsActive;
                }
            set
                {
                _IsActive = value;
                }
            }


        }
    }
