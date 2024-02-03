using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Country;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

using System.Threading.Tasks;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Language;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Manager
{
    class SRoofing_LanguageManager
    {

        // https://learn.microsoft.com/en-us/azure/cognitive-services/speech-service/language-support?tabs=stt

        #region CountryList


        public static async Task<SRoofingLanguageTranslateModel> Initilalize_LanguageList_ByLanguageCode ( string LanguageCode )
        {

            try
            {
                SRoofingLanguageTranslateModel _iLanguageModel = new SRoofingLanguageTranslateModel ( );

                if ( LanguageCode == "en" )
                {
                    _iLanguageModel = await Initilalize_LanguageList_ByLanguageCode_EN ( );
                }
                else if ( LanguageCode == "fr" )
                {
                    _iLanguageModel = await Initilalize_LanguageList_ByLanguageCode_FR ( );
                }
                else if ( LanguageCode == "ar" )
                {
                    _iLanguageModel = await Initilalize_LanguageList_ByLanguageCode_AR ( );
                }

                return await Task.FromResult ( _iLanguageModel );
            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
            }

        }




        public static async Task<SRoofingLanguageTranslateModel> Initilalize_LanguageList_ByLanguageCode_EN ( )
        {

            try
            {
                ObservableCollection<SRoofingLanguageTranslateModel> _arrLanguageModelList;

                _arrLanguageModelList = new ObservableCollection<SRoofingLanguageTranslateModel> ( );


                #region English


                /* English */
                _arrLanguageModelList.Add ( new SRoofingLanguageTranslateModel ( )
                {

                    LanguageCode = "en" ,

                    lblText_Title_Register = "Register" ,
                    lblText_Title_SignIn = "Sign In" ,
                    lblText_Title_Account = "Account" ,
                    lblText_Title_Settings = "Settings" ,








                    lblText_Tab_Chats = "Chats" ,
                    lblText_Tab_Calls = "Calls" ,



                    lblText_Splash_WelcomeTo = "Welcome to" ,

                    lblText_Splash_CreateAccount = "Create Account" ,
                    lblText_Splash_SignIn = "Sign In" ,
                    lblText_Splash_SignOut = "Sign Out" ,


                    lblText_ForgotPassword = "Forgot password" ,

                    lblText_YourCountry = "Your Country" ,
                    lblText_MobileNumber = "Mobile Number" ,
                    lblText_FirstName = "First Name" ,
                    lblText_LastName = "Last Name" ,
                    lblText_EmailAddress = "Email Address" ,
                    lblText_TakePhoto = "Take Photo" ,
                    lblText_Optional = "Optional" ,

                    lblText_Agreement = "By creating an account you agree to our" ,
                    lblText_AND = "and" ,
                    lblText_TermsCondition = "Terms & Conditions" ,
                    lblText_PrivacyPolicy = "Privacy Policy" ,



                    lblText_Command_Continue = "Continue" ,
                    lblText_Command_Submit = "Submit" ,
                    lblText_Command_Next = "Next" ,
                    lblText_Command_Send = "Send" ,
                    lblText_Command_Cancel = "Cancel" ,


                    lblText_Command_Save = "Save" ,
                    lblText_Command_Reset = "Reset" ,

                    lblText_Command_Yes = "Yes" ,
                    lblText_Command_No = "No" ,


                    lblText_Message_AreYouSure = "Are you sure ?" ,


                    lblText_Pick_FromTheList_Message = "Pick from the list" ,

                    lblText_File_NotFound_Message = "File not found" ,


                    lblText_PersonalInfo = "Personal Info" ,
                    lblText_Avatar = "Avatar" ,
                    //public string lblText_Account_Send   =   ,


                    lblText_Privacy = "Privacy" ,
                    lblText_TheWorld = "TheWorld" ,
                    lblText_Sounds = "Sounds" ,
                    lblText_Notifications = "Notifications" ,
                    lblText_RateUs = "Rate Us" ,
                    lblText_FAQ = "FAQ" ,
                    lblText_About = "About" ,

                    lblText_Password = "Password" ,

                    lblText_ContactUs = "Contact Us" ,



                    lblText_StartTypingHere = "Start typing here" ,


                    ///////////


                    lblText_BirthDate = "Birth Date" ,
                    lblText_FullName = "Full Name" ,
                    lblText_Gender = "Gender" ,
                    lblText_Location = "Location" ,


                    lblText_Password_Current = "Current Password" ,
                    lblText_Password_New = "New Password" ,

                    lblText_Speech_Incoming = "Incoming Message" ,
                    lblText_Speech_Outgoing = "Outgoing Message" ,

                    lblText_Sound_Chat = "Chat" ,
                    lblText_Sound_Call = "Call" ,

                    lblText_Chat_History = "History" ,
                    lblText_Chat_BackgruondImageURL = "Backgruond Image" ,
                    lblText_Chat_Media = "Media" ,

                    lblText_Call_AutoAnswer = "Auto Answer" ,

                    lblText_Rate_Like = "Like" ,
                    lblText_Rate_Dislike = "Dislike" ,


                    lblText_Rate_WhatYouLike = "What you like" ,
                    lblText_Rate_WhatYouDislike = "What you dislike" ,

                    lblText_ContactUs_Message = "Contact Us" ,

                    ////////////////////////////////////



                    lblText_TryAgainLater_Message = "Try again later" ,

                    lblText_Wait_RegisterAccount_Message = "Wait, register account" ,
                    lblText_Wait_SetupAccount_Message = "Wait, setup account" ,
                    lblText_Wait_LoadSetting_Message = "Wait, load settings" ,
                    lblText_Wait_LoadProfile_Message = "Wait, load profile" ,


                    lblText_Fill_FirstName_Message = "Fill first name" ,
                    lblText_Fill_LastName_Message = "Fill last name" ,
                    lblText_Fill_MobileNumber_Message = "Fill mobile number" ,
                    lblText_Fill_Password_Message = "Fill pass code" ,
                    lblText_Fill_BirthDate_Message = "Fill birth date" ,
                    lblText_Fill_EmailAddress_Message = "Fill E-mail address" ,
                    lblText_Fill_CountryName_Message = "Fill country name" ,

                    lblText_Fill_Data_Message = "Fill data" ,
                    lblText_Check_Data_Message = "Check data" ,

                    lblText_NotValid_MobileNumber_Message = "Mobile number is unvalid" ,
                    lblText_NotValid_EmailAddress_Message = "E-mail address is unvalid" ,

                    lblText_Command_OK_Message = "Ok" ,
                    lblText_Command_CANCEL_Message = "Cancel" ,
                    lblText_Command_OPEN_Message = "Open" ,
                    lblText_Command_CLOSE_Message = "Close" ,
                    lblText_Command_GO_Message = "Go" ,
                    lblText_Command_ADD_Message = "Add" ,
                    lblText_Command_SUBMIT_Message = "Submit" ,
                    lblText_Command_SEARCH_Message = "Search" ,
                    lblText_Command_SEND_Message = "Send" ,
                    lblText_Command_BACK_Message = "Back" ,
                    lblText_Command_REMOVE_Message = "Remove" ,
                    lblText_Command_DELETE_Message = "Delete" ,
                    lblText_Command_SHARE_Message = "Share" ,
                    lblText_Command_VIEW_Message = "View" ,
                    lblText_Command_PLAY_Message = "Play" ,
                    lblText_Command_DOWNLOAD_Message = "Download" ,
                    lblText_Command_PICKUP_Message = "Pickup" ,
                    lblText_Command_RECORD_Message = "Record" ,
                    lblText_Command_SHOW_Message = "Show" ,
                    lblText_Command_PREVIEW_Message = "Preview" ,
                    lblText_Command_CAPTURE_Message = "Capture" ,


                    lblText_LogOut_Message = "Log out" ,


                    lblText_Setting_Privacy_ShowOnlineSttus_Message = "Show my online status" ,

                    lblText_Setting_Speech_IsEnable_Message = "Enable speech" ,

                    lblText_Setting_Speech_Incoming_Message = "Speech for incoming chat message" ,
                    lblText_Setting_Speech_Outgoing_Message = "Speech for outgoing chat message" ,



                    lblText_Setting_Sound_IsEnable_Message = "Enable all sounds" ,

                    lblText_Setting_Sound_Chat_Incoming_Message = "Sound for incoming chat" ,
                    lblText_Setting_Sound_Chat_Outgoing_Message = "Sound for outgoing chat" ,

                    lblText_Setting_Sound_Call_Incoming_Message = "Sound for incoming call" ,
                    lblText_Setting_Sound_Call_Outgoing_Message = "Sound for outgoing call" ,

                    lblText_Setting_SortBy_Message = "Sort by" ,
                    lblText_Setting_ByRecent_Message = "By recent" ,
                    lblText_Setting_ByName_Message = "By name" ,

                    lblText_Setting_SaveHistory_Message = "Save chat message history" ,
                    lblText_Setting_Chat_BackgroundImageURL_Message = "Chat background image" ,
                    lblText_Setting_Chat_MediaDownload_Image_Message = "Auto download photos" ,
                    lblText_Setting_Chat_MediaDownload_Video_Message = "Auto download videos" ,
                    lblText_Setting_Chat_MediaDownload_Document_Message = "Auto download documents" ,

                    lblText_Setting_Call_VoiceCommand_Message = "Enable voice commands" ,
                    lblText_Setting_Call_AutoAnswer_Message = "Answer calls automatically" ,
                    lblText_Setting_Call_AutoRedial_Message = "Auto redial when busy" ,
                    lblText_Setting_Call_AutoDecline_Message = "Auto call message" ,

                    lblText_Setting_Notification_AutoUpdate_Message = "Notify me when new update are available" ,
                    lblText_Setting_Notification_AutoWIFIf_Message = "Enable auto update via only WIFI" ,

                    lblText_Group_Title_Message = "Group" ,
                    lblText_Group_New_Message = "New Group" ,
                    lblText_Group_Edit_Message = "Edit Group" ,
                    lblText_Group_AddUser_Message = "Add Contact" ,
                    lblText_Group_RemoveUser_Message = "Remove Contact" ,

                    lblText_Screen_Title_PickContact_Message = "Pick Contact" ,
                    lblText_Screen_Title_PickChat_Message = "Pick Chat" ,
                    lblText_Screen_Title_PickCall_Message = "Pick Call" ,
                    lblText_Screen_Title_PickGroup_Message = "Pick Group" ,


                    lblText_Popup_Title_GroupNew_Message = "New Group" ,


                    lblText_Gallery_Message = "Gallery" ,

                    lblText_Call_Outgoing_Offline_Message = "outgoing call offline" ,
                    lblText_Call_Outgoing_Dropped_Message = "outgoing call dropped" ,
                    lblText_Call_Incoming_Missed_Message = "Incoming missed call" ,
                    lblText_Call_Ended_Duration_Message = "Call ended" ,

                    lblText_Chat_StartNew_Message = "Start new chat" ,



                    lblText_ScreenChatShow_ShareLocation_Message = "Shared location" ,
                    lblText_ScreenChatShow_ShareImage_Message = "Shared photo" ,
                    lblText_ScreenChatShow_ShareVideo_Message = "Shared video" ,
                    lblText_ScreenChatShow_ShareDocument_Message = "Shared file" ,
                    lblText_ScreenChatShow_ShareAudio_Message = "Shared audio" ,
                    lblText_ScreenChatShow_ShareContact_Message = "Shared contact" ,

                    lblText_ScreenChatShow_StartNew_Message = "Start new chat" ,
                    lblText_ScreenCallShow_StartNew_Message = "Start new call" ,

                    lblText_Picker_Image_Message = "Pick a photo" ,
                    lblText_Picker_Video_Message = "Pick a video" ,
                    lblText_Picker_Camera_Message = "Camera" ,
                    lblText_Picker_Gallery_Message = "Gallery" ,
                    lblText_Picker_Document_Message = "Pick a document" ,

                    lblText_Connection_CheckOnline_Message = "Network error" ,


                    lblText_AcceptAgreement_Message = "Accept agreement" ,


                    ////////////////////////////////////////////



                    lblText_Call_AutoMessage_SorryImBusyCanYouCallLater = "Sorry I'm busy can you call later" ,
                    lblText_Call_AutoMessage_IWillCallYouBackWhenImFree = "I will call you back when I'm free" ,
                    lblText_Call_AutoMessage_SorryIcanontTalkAtTheMoment = "Sorry I can't talk at the moment" ,
                    lblText_Call_AutoMessage_CanYouMessageMe = "Can you message me" ,



                    lblText_Gallery_PickImage = "Pick Image" ,
                    lblText_Gallery_PickVideo = "Pick Video" ,
                    lblText_Gallery_CaptureImage = "Capture Image" ,
                    lblText_Gallery_CaptureVideo = "Capture Video" ,


                    lblText_Permission_Camera_Message = "Camera" ,
                    lblText_Permission_Contact_Message = "Contact" ,
                    lblText_Permission_Location_Message = "Location" ,
                    lblText_Permission_Microphone_Message = "Microphone" ,
                    lblText_Permission_Photo_Message = "Photo" ,
                    lblText_Permission_SMS_Message = "SMS" ,
                    lblText_Permission_Storage_Message = "Storage" ,

                    lblText_AppError_TryAgainLater = "App error, try again later" ,


                    lblText_Title_Password = "Password" ,



                    lblText_Call_Calling = "CALLING" ,
                    lblText_Call_Ringing = "RINGING" ,
                    lblText_Call_Drop = "DROP" ,
                    lblText_Call_Decline = "DECLINE" ,
                    lblText_Call_Answer = "ANSWER" ,
                    lblText_Call_Cancel = "CANCEL" ,
                    lblText_Call_EndClose = "END" ,
                    lblText_Call_Redial = "REDIAL" ,
                    lblText_Call_Mute = "MUTE" ,
                    lblText_Call_Camera = "CAMERA" ,


                } );



                #endregion


                await SRoofingSync_Language_Manager.Sync_Language_Set_LanguageList_All ( App.Current , _arrLanguageModelList );

                await SRoofing_AutoMessageManager.Initilalize_Call_AutoMessage_ByLanguageCode ( _arrLanguageModelList[ 0 ] );

                SRoofing_DebugManager.Debug_ShowSystemMessage ( "_arrLanguageModelList == " + _arrLanguageModelList.Count.ToString ( ) );


                return await Task.FromResult ( _arrLanguageModelList[ 0 ] );
            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
            }

        }




        public static async Task<SRoofingLanguageTranslateModel> Initilalize_LanguageList_ByLanguageCode_FR ( )
        {

            try
            {
                ObservableCollection<SRoofingLanguageTranslateModel> _arrLanguageModelList;

                _arrLanguageModelList = new ObservableCollection<SRoofingLanguageTranslateModel> ( );


                #region French


                /* French */
                _arrLanguageModelList.Add ( new SRoofingLanguageTranslateModel ( )
                {

                    LanguageCode = "fr" ,


                    lblText_Title_Register = "Enregistrer" ,
                    lblText_Title_SignIn = "S'identifier" ,

                    lblText_Title_Account = "Compte" ,
                    lblText_Title_Settings = "Paramètres" ,


                    lblText_Tab_Chats = "Chattes" ,
                    lblText_Tab_Calls = "Appels" ,





                    lblText_Splash_WelcomeTo = "Bienvenue à" ,

                    lblText_Splash_CreateAccount = "Créer un compte" ,
                    lblText_Splash_SignIn = "S'identifier" ,
                    lblText_Splash_SignOut = "Se déconnecter" ,

                    lblText_ForgotPassword = "Mot de passe oublié" ,

                    lblText_YourCountry = "Votre pays" ,
                    lblText_MobileNumber = "Numéro de portable" ,
                    lblText_FirstName = "Prénom" ,
                    lblText_LastName = "Nom de famille" ,
                    lblText_EmailAddress = "Adresse e-mail" ,
                    lblText_TakePhoto = "Prendre une photo" ,
                    lblText_Optional = "Facultative" ,

                    lblText_Agreement = "En créant un compte, vous acceptez nos" ,
                    lblText_AND = "et" ,
                    lblText_TermsCondition = "termes et conditions" ,
                    lblText_PrivacyPolicy = "politique de confidentialité" ,



                    lblText_Command_Continue = "Continuer" ,
                    lblText_Command_Submit = "Soumettre" ,
                    lblText_Command_Next = "Suivante" ,
                    lblText_Command_Send = "Envoyer" ,
                    lblText_Command_Cancel = "Annuler" ,



                    lblText_Command_Save = "Sauvegarder" ,
                    lblText_Command_Reset = "Réinitialiser" ,



                    lblText_Command_Yes = "Oui" ,
                    lblText_Command_No = "Non" ,


                    lblText_Message_AreYouSure = "Es-tu sûr ?" ,



                    lblText_Pick_FromTheList_Message = "Choisissez dans la liste" ,



                    lblText_File_NotFound_Message = "Fichier introuvable" ,






                    lblText_PersonalInfo = "Informations personnelles" ,
                    lblText_Avatar = "Avatar" ,
                    //public string lblText_Account_Send   =   ,


                    lblText_Privacy = "Confidentialité" ,
                    lblText_TheWorld = "Le monde" ,
                    lblText_Sounds = "Des sons" ,
                    lblText_Notifications = "Avis" ,
                    lblText_RateUs = "Évaluez nous" ,
                    lblText_FAQ = "FAQ" ,
                    lblText_About = "À propos" ,


                    lblText_Password = "Mot de passe" ,

                    lblText_ContactUs = "Contactez-nous" ,



                    lblText_StartTypingHere = "Commencez à taper ici" ,


                    ///////////////////////////



                    lblText_BirthDate = "Date de naissance" ,
                    lblText_FullName = "Nom et prénom" ,
                    lblText_Gender = "Genre" ,
                    lblText_Location = "Emplacement" ,


                    lblText_Password_Current = "Mot de passe actuel" ,
                    lblText_Password_New = "Nouveau mot de passe" ,

                    lblText_Speech_Incoming = "Message entrant" ,
                    lblText_Speech_Outgoing = "Message sortant" ,

                    lblText_Sound_Chat = "Chattes" ,
                    lblText_Sound_Call = "Appels" ,

                    lblText_Chat_History = "Histoire" ,
                    lblText_Chat_BackgruondImageURL = "Image de fond" ,
                    lblText_Chat_Media = "Médias" ,

                    lblText_Call_AutoAnswer = "Réponse automatique" ,

                    lblText_Rate_Like = "Aime" ,
                    lblText_Rate_Dislike = "N'aime pas" ,


                    lblText_Rate_WhatYouLike = "Ce que tu aimes" ,
                    lblText_Rate_WhatYouDislike = "Ce que tu n'aimes pas" ,

                    lblText_ContactUs_Message = "Contactez-nous" ,


                    ////////////////////////////////////////////////

                    ////////////////////////////////////



                    lblText_TryAgainLater_Message = "Réessayez plus tard" ,

                    lblText_Wait_RegisterAccount_Message = "Attendez, enregistrez un compte" ,
                    lblText_Wait_SetupAccount_Message = "Attendez, configurez le compte" ,
                    lblText_Wait_LoadSetting_Message = "Attendez, chargez les paramètres" ,
                    lblText_Wait_LoadProfile_Message = "Attendez, chargez le profil" ,


                    lblText_Fill_FirstName_Message = "Remplir le prénom" ,
                    lblText_Fill_LastName_Message = "Remplir le nom de famille" ,
                    lblText_Fill_MobileNumber_Message = "Remplir le numéro de portable" ,
                    lblText_Fill_Password_Message = "Remplir le code d'accès" ,
                    lblText_Fill_BirthDate_Message = "Remplir la date de naissance" ,
                    lblText_Fill_EmailAddress_Message = "Remplir l'adresse e-mail" ,
                    lblText_Fill_CountryName_Message = "Remplir le nom du pays" ,

                    lblText_Fill_Data_Message = "Remplir les données" ,
                    lblText_Check_Data_Message = "Vérifier les données" ,

                    lblText_NotValid_MobileNumber_Message = "Le numéro de portable est invalide" ,
                    lblText_NotValid_EmailAddress_Message = "Adresse email invalide" ,

                    lblText_Command_OK_Message = "d'accord" ,
                    lblText_Command_CANCEL_Message = "Annuler" ,
                    lblText_Command_OPEN_Message = "ouvrir" ,
                    lblText_Command_CLOSE_Message = "fermer" ,
                    lblText_Command_GO_Message = "Aller" ,
                    lblText_Command_ADD_Message = "Ajouter" ,
                    lblText_Command_SUBMIT_Message = "Soumettre" ,
                    lblText_Command_SEARCH_Message = "Recherche" ,
                    lblText_Command_SEND_Message = "Envoyer" ,
                    lblText_Command_BACK_Message = "Dos" ,
                    lblText_Command_REMOVE_Message = "Retirer" ,
                    lblText_Command_DELETE_Message = "Supprimer" ,
                    lblText_Command_SHARE_Message = "Partager" ,
                    lblText_Command_VIEW_Message = "Voir" ,
                    lblText_Command_PLAY_Message = "Jouer" ,
                    lblText_Command_DOWNLOAD_Message = "Télécharger" ,
                    lblText_Command_PICKUP_Message = "Ramasser" ,
                    lblText_Command_RECORD_Message = "Enregistrer" ,
                    lblText_Command_SHOW_Message = "Montrer" ,
                    lblText_Command_PREVIEW_Message = "Aperçu" ,
                    lblText_Command_CAPTURE_Message = "Capture" ,


                    lblText_LogOut_Message = "Se déconnecter" ,


                    lblText_Setting_Privacy_ShowOnlineSttus_Message = "Afficher mon statut en ligne" ,

                    lblText_Setting_Speech_IsEnable_Message = "Activer la parole" ,

                    lblText_Setting_Speech_Incoming_Message = "Discours pour le message de chat entrant" ,
                    lblText_Setting_Speech_Outgoing_Message = "Discours pour le message de chat sortant" ,



                    lblText_Setting_Sound_IsEnable_Message = "Activer tous les sons" ,

                    lblText_Setting_Sound_Chat_Incoming_Message = "Son pour le chat entrant" ,
                    lblText_Setting_Sound_Chat_Outgoing_Message = "Son pour le chat sortant" ,

                    lblText_Setting_Sound_Call_Incoming_Message = "Son pour appel entrant" ,
                    lblText_Setting_Sound_Call_Outgoing_Message = "Son pour appel sortant" ,

                    lblText_Setting_SortBy_Message = "Trier par" ,
                    lblText_Setting_ByRecent_Message = "Par récent" ,
                    lblText_Setting_ByName_Message = "De nom" ,

                    lblText_Setting_SaveHistory_Message = "Enregistrer l'historique des messages de chat" ,
                    lblText_Setting_Chat_BackgroundImageURL_Message = "Image d'arrière-plan du chat" ,
                    lblText_Setting_Chat_MediaDownload_Image_Message = "Téléchargement automatique des photos" ,
                    lblText_Setting_Chat_MediaDownload_Video_Message = "Téléchargement automatique de vidéos" ,
                    lblText_Setting_Chat_MediaDownload_Document_Message = "Téléchargement automatique de documents" ,

                    lblText_Setting_Call_VoiceCommand_Message = "Activer les commandes vocales" ,
                    lblText_Setting_Call_AutoAnswer_Message = "Répondre aux appels automatiquement" ,
                    lblText_Setting_Call_AutoRedial_Message = "Rappel automatique en cas d'occupation" ,
                    lblText_Setting_Call_AutoDecline_Message = "Message d'appel automatique" ,

                    lblText_Setting_Notification_AutoUpdate_Message = "Prévenez-moi lorsque de nouvelles mises à jour sont disponibles" ,
                    lblText_Setting_Notification_AutoWIFIf_Message = "Activer la mise à jour automatique via le Wi-Fi uniquement" ,

                    lblText_Group_Title_Message = "Groupe" ,
                    lblText_Group_New_Message = "Nouveau groupe" ,
                    lblText_Group_Edit_Message = "Modifier le groupe" ,
                    lblText_Group_AddUser_Message = "Ajouter le contact" ,
                    lblText_Group_RemoveUser_Message = "Supprimer contact" ,

                    lblText_Screen_Title_PickContact_Message = "Choisissez un contact" ,
                    lblText_Screen_Title_PickChat_Message = "Choisissez le chat" ,
                    lblText_Screen_Title_PickCall_Message = "Choisir un appel" ,
                    lblText_Screen_Title_PickGroup_Message = "Choisir un groupe" ,


                    lblText_Popup_Title_GroupNew_Message = "Nouveau groupe" ,


                    lblText_Gallery_Message = "Galerie" ,

                    lblText_Call_Outgoing_Offline_Message = "Appel sortant hors ligne" ,
                    lblText_Call_Outgoing_Dropped_Message = "Appel sortant abandonné" ,
                    lblText_Call_Incoming_Missed_Message = "Appel manqué entrant" ,
                    lblText_Call_Ended_Duration_Message = "Appel terminé" ,

                    lblText_Chat_StartNew_Message = "Démarrer une nouvelle conversation" ,



                    lblText_ScreenChatShow_ShareLocation_Message = "Emplacement partagé" ,
                    lblText_ScreenChatShow_ShareImage_Message = "Photo partagée" ,
                    lblText_ScreenChatShow_ShareVideo_Message = "Vidéo partagée" ,
                    lblText_ScreenChatShow_ShareDocument_Message = "Document partagé" ,
                    lblText_ScreenChatShow_ShareAudio_Message = "Audio partagé" ,
                    lblText_ScreenChatShow_ShareContact_Message = "Coordonnées partagées" ,

                    lblText_ScreenChatShow_StartNew_Message = "Démarrer une nouvelle conversation" ,
                    lblText_ScreenCallShow_StartNew_Message = "Lancer un nouvel appel" ,

                    lblText_Picker_Image_Message = "Choisissez une photo" ,
                    lblText_Picker_Video_Message = "Choisissez la vidéo" ,
                    lblText_Picker_Camera_Message = "Caméra" ,
                    lblText_Picker_Gallery_Message = "Galerie" ,
                    lblText_Picker_Document_Message = "Choisir un document" ,

                    lblText_Connection_CheckOnline_Message = "Erreur de connexion" ,



                    lblText_AcceptAgreement_Message = "Accepter l'accord" ,





                    ////////////////////////////////////////////



                    lblText_Call_AutoMessage_SorryImBusyCanYouCallLater = "Désolé, je suis occupé pouvez-vous appeler plus tard" ,
                    lblText_Call_AutoMessage_IWillCallYouBackWhenImFree = "Je te rappellerai quand je serai libre" ,
                    lblText_Call_AutoMessage_SorryIcanontTalkAtTheMoment = "Désolé je ne peux pas parler pour le moment" ,
                    lblText_Call_AutoMessage_CanYouMessageMe = "Pouvez-vous m'envoyer un message" ,



                    lblText_Gallery_PickImage = "Choisir une image" ,
                    lblText_Gallery_PickVideo = "Choisissez la vidéo" ,
                    lblText_Gallery_CaptureImage = "Capturer une image" ,
                    lblText_Gallery_CaptureVideo = "Capturer une vidéo" ,



                    lblText_Permission_Camera_Message = "Caméra" ,
                    lblText_Permission_Contact_Message = "Contact" ,
                    lblText_Permission_Location_Message = "Emplacement" ,
                    lblText_Permission_Microphone_Message = "Microphone" ,
                    lblText_Permission_Photo_Message = "Photo" ,
                    lblText_Permission_SMS_Message = "SMS" ,
                    lblText_Permission_Storage_Message = "Stockage" ,


                    lblText_AppError_TryAgainLater = "Erreur d'application, réessayez plus tard" ,



                    lblText_Title_Password = "Mot de passe" ,



                 
                    lblText_Call_Calling = "APPEL" ,
                    lblText_Call_Ringing = "SONNERIE" ,
                    lblText_Call_Drop = "BAISSE" ,
                    lblText_Call_Decline = "D'ECLIN" ,
                    lblText_Call_Answer = "R'EPINDRE" ,
                    lblText_Call_Cancel = "ANNULER" ,
                    lblText_Call_EndClose = "FIN" ,
                    lblText_Call_Redial = "RECOMPOSER" ,
                    lblText_Call_Mute = "MUTTE" ,
                    lblText_Call_Camera = "CAM'ERA" ,



                } );


                #endregion



                await SRoofingSync_Language_Manager.Sync_Language_Set_LanguageList_All ( App.Current , _arrLanguageModelList );


                await SRoofing_AutoMessageManager.Initilalize_Call_AutoMessage_ByLanguageCode ( _arrLanguageModelList[ 0 ] );

                SRoofing_DebugManager.Debug_ShowSystemMessage ( "_arrLanguageModelList == " + _arrLanguageModelList.Count.ToString ( ) );


                return await Task.FromResult ( _arrLanguageModelList[ 0 ] );
            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
            }

        }




        public static async Task<SRoofingLanguageTranslateModel> Initilalize_LanguageList_ByLanguageCode_AR ( )
        {

            try
            {
                ObservableCollection<SRoofingLanguageTranslateModel> _arrLanguageModelList;

                _arrLanguageModelList = new ObservableCollection<SRoofingLanguageTranslateModel> ( );



                #region Arabic



                /* Arabic */
                _arrLanguageModelList.Add ( new SRoofingLanguageTranslateModel ( )
                {


                    LanguageCode = "ar" ,



                    lblText_Title_Register = "تسجيل" ,
                    lblText_Title_SignIn = "تسجيل الدخول" ,
                    lblText_Title_Account = "حسابي" ,
                    lblText_Title_Settings = "الإعدادات" ,



                    lblText_Tab_Chats = "الدردشات" ,
                    lblText_Tab_Calls = "المكالمات" ,



                    lblText_Splash_WelcomeTo = "مرحبا بك في" ,

                    lblText_Splash_CreateAccount = "إنشاء حساب" ,
                    lblText_Splash_SignIn = "تسجيل الدخول" ,
                    lblText_Splash_SignOut = "تسجيل الخروج" ,


                    lblText_ForgotPassword = "هل نسيت كلمه السر" ,

                    lblText_YourCountry = "بلدك" ,
                    lblText_MobileNumber = "رقم الهاتف المحمول" ,
                    lblText_FirstName = "الإسم الأول" ,
                    lblText_LastName = "إسم العائله" ,
                    lblText_EmailAddress = "عنوان البريد الإلكتروني" ,
                    lblText_TakePhoto = "تصوير" ,
                    lblText_Optional = "إختياري" ,

                    lblText_Agreement = "من خلال إنشاء حساب فإنك توافق على" ,
                    lblText_AND = "و" ,
                    lblText_TermsCondition = "البنود و الظروف" ,
                    lblText_PrivacyPolicy = "سياسه الخصوصيه" ,



                    lblText_Command_Continue = "متابعه" ,
                    lblText_Command_Submit = "إرسال" ,
                    lblText_Command_Next = "التالي" ,
                    lblText_Command_Send = "إرسال" ,
                    lblText_Command_Cancel = "إلغاء" ,




                    lblText_Command_Save = "حفظ" ,
                    lblText_Command_Reset = "إعاده" ,



                    lblText_Command_Yes = "نعم" ,
                    lblText_Command_No = "لا" ,


                    lblText_Message_AreYouSure = "هل أنت متأكد ؟" ,


                    lblText_Pick_FromTheList_Message = "إختر من القائمه" ,


                    lblText_File_NotFound_Message = "الملف غير موجود" ,



                    lblText_PersonalInfo = "معلومات شخصيه" ,
                    lblText_Avatar = "الصوره الرمزيه" ,
                    //public string lblText_Account_Send   =   ,


                    lblText_Privacy = "خصوصيه" ,
                    lblText_TheWorld = "العالم" ,
                    lblText_Sounds = "اصوات" ,
                    lblText_Notifications = "إشعارات" ,
                    lblText_RateUs = "قيمنا" ,
                    lblText_FAQ = "الأسئله الشائعه" ,
                    lblText_About = "عن" ,


                    lblText_Password = "الرقم السري" ,

                    lblText_ContactUs = "إتصل بنا" ,



                    lblText_StartTypingHere = "إبدأ كتابه هنا" ,



                    ////////////////////////////////////////////////




                    lblText_BirthDate = "تاريخ الميلاد" ,
                    lblText_FullName = "الإسم بالكامل" ,
                    lblText_Gender = "النوع" ,
                    lblText_Location = "الموقع" ,


                    lblText_Password_Current = "الكود الحالي" ,
                    lblText_Password_New = "الكود الجديد" ,

                    lblText_Speech_Incoming = "الرسائل الوارده" ,
                    lblText_Speech_Outgoing = "الرسائل الصادره" ,

                    lblText_Sound_Chat = "الدردشات" ,
                    lblText_Sound_Call = "المكالمات" ,

                    lblText_Chat_History = "الأرشيف" ,
                    lblText_Chat_BackgruondImageURL = "الخلفيه" ,
                    lblText_Chat_Media = "الميديا" ,

                    lblText_Call_AutoAnswer = "رد تلقائي" ,

                    lblText_Rate_Like = "أعجب" ,
                    lblText_Rate_Dislike = "لا أعجب" ,


                    lblText_Rate_WhatYouLike = "ما تحبه" ,
                    lblText_Rate_WhatYouDislike = "ما لم تحبه" ,

                    lblText_ContactUs_Message = "إتصل بنا" ,


                    //////////////////////////////////////////////////////////




                    ////////////////////////////////////



                    lblText_TryAgainLater_Message = "حاول مره أخرى في وقت لاحق" ,

                    lblText_Wait_RegisterAccount_Message = "انتظر ، سجل حساب" ,
                    lblText_Wait_SetupAccount_Message = "انتظر ، حساب الإعداد" ,
                    lblText_Wait_LoadSetting_Message = "انتظر ، قم بتحميل الإعدادات" ,
                    lblText_Wait_LoadProfile_Message = "انتظر ، قم بتحميل الملف الشخصي" ,


                    lblText_Fill_FirstName_Message = "املأ الاسم الأول" ,
                    lblText_Fill_LastName_Message = "املأ الاسم الأخير" ,
                    lblText_Fill_MobileNumber_Message = "املأ رقم الجوال" ,
                    lblText_Fill_Password_Message = "إملأ رمز المرور" ,
                    lblText_Fill_BirthDate_Message = "أدخل تاريخ الميلاد" ,
                    lblText_Fill_EmailAddress_Message = "إملأ عنوان البريد الإلكتروني" ,
                    lblText_Fill_CountryName_Message = "املأ اسم الدوله" ,

                    lblText_Fill_Data_Message = "املأ البيانات" ,
                    lblText_Check_Data_Message = "تأكد من البيانات" ,

                    lblText_NotValid_MobileNumber_Message = "رقم الجوال غير صحيح" ,
                    lblText_NotValid_EmailAddress_Message = "عنوان البريد الإلكتروني غير صالح" ,

                    lblText_Command_OK_Message = "موافقه" ,
                    lblText_Command_CANCEL_Message = "إلغاء" ,
                    lblText_Command_OPEN_Message = "إفتح" ,
                    lblText_Command_CLOSE_Message = "إغلاق" ,
                    lblText_Command_GO_Message = "إذهب" ,
                    lblText_Command_ADD_Message = "أضف" ,
                    lblText_Command_SUBMIT_Message = "إرسال" ,
                    lblText_Command_SEARCH_Message = "إبحث" ,
                    lblText_Command_SEND_Message = "إرسل" ,
                    lblText_Command_BACK_Message = "رجوع" ,
                    lblText_Command_REMOVE_Message = "يزيل" ,
                    lblText_Command_DELETE_Message = "إحذف" ,
                    lblText_Command_SHARE_Message = "مشاركه" ,
                    lblText_Command_VIEW_Message = "إعرض" ,
                    lblText_Command_PLAY_Message = "تشغيل" ,
                    lblText_Command_DOWNLOAD_Message = "تحميل" ,
                    lblText_Command_PICKUP_Message = "إلتقاط" ,
                    lblText_Command_RECORD_Message = "تسجبل" ,
                    lblText_Command_SHOW_Message = "يعرض" ,
                    lblText_Command_PREVIEW_Message = "معاينه" ,
                    lblText_Command_CAPTURE_Message = "يلتقط" ,


                    lblText_LogOut_Message = "تسجيل الخروج" ,


                    lblText_Setting_Privacy_ShowOnlineSttus_Message = "إظهار حاله الاتصال الخاصه بي" ,

                    lblText_Setting_Speech_IsEnable_Message = "تمكين الكلام" ,

                    lblText_Setting_Speech_Incoming_Message = "الكلام لرساله الدردشه الوارده" ,
                    lblText_Setting_Speech_Outgoing_Message = "الكلام لرساله الدردشه الصادره" ,



                    lblText_Setting_Sound_IsEnable_Message = "قم بتمكين كل الأصوات" ,

                    lblText_Setting_Sound_Chat_Incoming_Message = "صوت للدردشه الوارده" ,
                    lblText_Setting_Sound_Chat_Outgoing_Message = "صوت للدردشه الصادره" ,

                    lblText_Setting_Sound_Call_Incoming_Message = "صوت للمكالمات الوارده" ,
                    lblText_Setting_Sound_Call_Outgoing_Message = "صوت للمكالمات الصادره" ,

                    lblText_Setting_SortBy_Message = "طريقه العرض" ,
                    lblText_Setting_ByRecent_Message = "بالأحدث" ,
                    lblText_Setting_ByName_Message = "بالاسم" ,

                    lblText_Setting_SaveHistory_Message = "حفظ محفوظات رسائل الدردشه" ,
                    lblText_Setting_Chat_BackgroundImageURL_Message = "صوره خلفيه الدردشه" ,
                    lblText_Setting_Chat_MediaDownload_Image_Message = "تنزيل الصور تلقائيًا" ,
                    lblText_Setting_Chat_MediaDownload_Video_Message = "تنزيل ملفات الفيديو تلقائيًا" ,
                    lblText_Setting_Chat_MediaDownload_Document_Message = "مستندات التحميل التلقائي" ,

                    lblText_Setting_Call_VoiceCommand_Message = "قم بتمكين الأوامر الصوتيه" ,
                    lblText_Setting_Call_AutoAnswer_Message = "الرد الالي على المكالمات" ,
                    lblText_Setting_Call_AutoRedial_Message = "إعاده الطلب تلقائيًا عند الانشغال" ,
                    lblText_Setting_Call_AutoDecline_Message = "رساله مكالمه تلقائيه" ,

                    lblText_Setting_Notification_AutoUpdate_Message = "أعلمني عند توفر تحديث جديد" ,
                    lblText_Setting_Notification_AutoWIFIf_Message = "قم بتمكين التحديث التلقائي عبر WIFI فقط" ,

                    lblText_Group_Title_Message = "مجموعه" ,
                    lblText_Group_New_Message = "مجموعه جديده" ,
                    lblText_Group_Edit_Message = "تحرير المجموعه" ,
                    lblText_Group_AddUser_Message = "إضافه جهه اتصال" ,
                    lblText_Group_RemoveUser_Message = "حذف بيانات الاتصال بالشخص" ,

                    lblText_Screen_Title_PickContact_Message = "اختر جهه اتصال" ,
                    lblText_Screen_Title_PickChat_Message = "اختر الدردشه" ,
                    lblText_Screen_Title_PickCall_Message = "اختر جهه اتصال" ,
                    lblText_Screen_Title_PickGroup_Message = "اختر مجموعه" ,


                    lblText_Popup_Title_GroupNew_Message = "مجموعه جديده" ,


                    lblText_Gallery_Message = "معرض الصور" ,

                    lblText_Call_Outgoing_Offline_Message = "مكالمه صادره حاليا" ,
                    lblText_Call_Outgoing_Dropped_Message = "تم إسقاط المكالمه الصادره" ,
                    lblText_Call_Incoming_Missed_Message = "مكالمه وارده فائته" ,
                    lblText_Call_Ended_Duration_Message = "المكالمه انتهت" ,

                    lblText_Chat_StartNew_Message = "إبدأ محادثه جديده" ,



                    lblText_ScreenChatShow_ShareLocation_Message = "مشاركه موقع" ,
                    lblText_ScreenChatShow_ShareImage_Message = "مشاركه صوره" ,
                    lblText_ScreenChatShow_ShareVideo_Message = "مشاركه فيديو" ,
                    lblText_ScreenChatShow_ShareDocument_Message = "مشاركه مستند" ,
                    lblText_ScreenChatShow_ShareAudio_Message = "مشاركه صوت" ,
                    lblText_ScreenChatShow_ShareContact_Message = "جهه اتصال مشتركه" ,

                    lblText_ScreenChatShow_StartNew_Message = "ابدأ محادثه جديده" ,
                    lblText_ScreenCallShow_StartNew_Message = "ابدأ مكالمه جديده" ,

                    lblText_Picker_Image_Message = "إختر صوره" ,
                    lblText_Picker_Video_Message = "إختر مقطع فيديو" ,
                    lblText_Picker_Camera_Message = "كميرا" ,
                    lblText_Picker_Gallery_Message = "معرض الصور" ,
                    lblText_Picker_Document_Message = "إختر مستندآ" ,

                    lblText_Connection_CheckOnline_Message = "خطأ في الشبكه" ,



                    lblText_AcceptAgreement_Message = "قبول الاتفاق" ,






                    ////////////////////////////////////////////



                    lblText_Call_AutoMessage_SorryImBusyCanYouCallLater = "آسف أنا مشغول ، هل يمكنك الاتصال لاحقًا" ,
                    lblText_Call_AutoMessage_IWillCallYouBackWhenImFree = "سأعاود الاتصال بك عندما أكون متفرغًا" ,
                    lblText_Call_AutoMessage_SorryIcanontTalkAtTheMoment = "آسف لا أستطيع التحدث في الوقت الحالي" ,
                    lblText_Call_AutoMessage_CanYouMessageMe = "هل يمكنك مراسلتي" ,



                    lblText_Gallery_PickImage = "اختر صوره" ,
                    lblText_Gallery_PickVideo = "اختر فيديو" ,
                    lblText_Gallery_CaptureImage = "التقاط الصوره" ,
                    lblText_Gallery_CaptureVideo = "التقاط الفيديو" ,



                    lblText_Permission_Camera_Message = "الكميرا" ,
                    lblText_Permission_Contact_Message = "جهات الإتصال" ,
                    lblText_Permission_Location_Message = "الموقع" ,
                    lblText_Permission_Microphone_Message = "الميكروفون" ,
                    lblText_Permission_Photo_Message = "الصور" ,
                    lblText_Permission_SMS_Message = "الرسائل الهاتفيه" ,
                    lblText_Permission_Storage_Message = "الملفات" ,



                    lblText_AppError_TryAgainLater = "حاول في وقت لاحق" ,

                    lblText_Title_Password = "الرقم السري" ,





                    lblText_Call_Calling = "مكالمه صادره" ,
                    lblText_Call_Ringing = "مكالمه وارده" ,
                    lblText_Call_Drop = "إلغاء" ,
                    lblText_Call_Decline = "رفض" ,
                    lblText_Call_Answer = "رد" ,
                    lblText_Call_Cancel = "إقفل" ,
                    lblText_Call_EndClose = "إنهاء" ,
                    lblText_Call_Redial = "عاود الإتصال" ,
                    lblText_Call_Mute = "كتم الصوت" ,
                    lblText_Call_Camera = "كميرا" ,









                } );



                #endregion


                await SRoofingSync_Language_Manager.Sync_Language_Set_LanguageList_All ( App.Current , _arrLanguageModelList );


                await SRoofing_AutoMessageManager.Initilalize_Call_AutoMessage_ByLanguageCode ( _arrLanguageModelList[ 0 ] );


                SRoofing_DebugManager.Debug_ShowSystemMessage ( "_arrLanguageModelList == " + _arrLanguageModelList.Count.ToString ( ) );


                return await Task.FromResult ( _arrLanguageModelList[ 0 ] );
            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
            }

        }



        //////public static async Task<SRoofingLanguageTranslateModel> Get_LanguageModel (
        //////    string iTokenID ,
        //////    string iLanguageCode ,
        //////      string iLanguageText ,
        //////     string iLanguageTextOriginal ,
        //////   string iLanguageTextTranslated )
        //////{

        //////    try
        //////    {

        //////        SRoofingLanguageTranslateModel iLanguageModel;


        //////        iLanguageModel = new SRoofingLanguageTranslateModel ( )
        //////        {
        //////            TokenID = iTokenID.ToString ( ) ,
        //////            LanguageCode = iLanguageCode.ToString ( ) ,
        //////            LanguageText = iLanguageText.ToString ( ) ,
        //////            LanguageTextOriginal = iLanguageTextOriginal.ToString ( ) ,
        //////            LanguageTextTranslated = iLanguageTextTranslated.ToString ( )
        //////        };

        //////        return await Task.FromResult ( iLanguageModel );

        //////    }
        //////    catch ( Exception ex )
        //////    {
        //////        SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
        //////        return null;
        //////    }

        //////}



        #endregion







    }
}
