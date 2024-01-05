using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

using Azure.AI.TextAnalytics;
using Azure;

 

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using S1RoofingMU.iSRoofingApp.iSRoofing_EnumManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Translation;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Manager
{
    public class SRoofing_TranslationManager
    {

        #region Translate

        private static readonly string key_TranslateText = "df547c6adba44e3dac47fefb6b3fc7a9";
        private static readonly string endpoint_TranslateText = "https://api.cognitive.microsofttranslator.com";

        // location, also known as region.
        // required if you're using a multi-service or regional (not global) resource. It can be found in the Azure portal on the Keys and Endpoint page.
        private static readonly string location = "westeurope";
        //string[] args
        public static async Task<string> TranslateText (string OriginalCode, String TranslationCode, String strToTranslate)
        {
           
            try
            {
                string text = "0";
            // Input and output languages are defined as parameters.
            // string route = "/translate?api-version=3.0&from=en&to=fr&to=zu";
           // string route = "/translate?api-version=3.0&from=en&to=fr&to=ar";
            string route = "/translate?api-version=3.0&from=" + OriginalCode + "&to="+ TranslationCode;
           // string textToTranslate = "I would really like to drive your car around the block a few times!";
            object[] body = new object[] { new { Text = strToTranslate } };
            var requestBody = JsonConvert.SerializeObject(body);

            using (var client = new HttpClient())
            using (var request = new HttpRequestMessage())
            {
                // Build the request.
                request.Method = HttpMethod.Post;
                request.RequestUri = new Uri( endpoint_TranslateText + route);
                request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");
                request.Headers.Add("Ocp-Apim-Subscription-Key", key_TranslateText );
                // location required if you're using a multi-service or regional (not global) resource.
                request.Headers.Add("Ocp-Apim-Subscription-Region", location);

                // Send the request and get response.
                HttpResponseMessage response = await client.SendAsync(request).ConfigureAwait(false);
                // Read response as a string.
                string result = await response.Content.ReadAsStringAsync();

                    var jsonData = JsonConvert.DeserializeObject<List<dynamic>>(result);


                   // var genre = jsonData[0];

                    // string xx = string.Format(" {0}", genre.translations[0].text);
                    text = string.Format(" {0}", jsonData[0].translations[0].text);

           }

                return await Task.FromResult(text)  ;
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }
            
          
                //  Console.WriteLine("TranslateText == " + result);
              //  Console.WriteLine("TranslateText == " + translationItems.ToString());
           
        }


          
        #endregion



        #region Detect-Language

        private static readonly AzureKeyCredential credentials_DetectLanguage = new AzureKeyCredential ( "d780f40d7deb4852b98ff4bc6206664b" );
        private static readonly Uri endpoint_DetectLanguage = new Uri ( "https://s1roofingxf-x1101-detectlanguage.cognitiveservices.azure.com/" );


        // Example method for detecting the language of text
        public static Task<string> DetectMessageTextLanguage ( string OriginalMessageText )
        {

            try
            {
                /* TextAnalyticsClient client */

                var client = new TextAnalyticsClient ( endpoint_DetectLanguage , credentials_DetectLanguage );
                //DetectedLanguage detectedLanguage = client.DetectLanguage ( "Ce document est rédigé en Français." );
                DetectedLanguage detectedLanguage = client.DetectLanguage ( OriginalMessageText );


                //Console.WriteLine ( "LanguageDetectionExample-Language:" );
                //Console.WriteLine ( $"\t{detectedLanguage.Name},\tISO-6391: {detectedLanguage.Iso6391Name}\n" );

                return Task.FromResult ( detectedLanguage.Iso6391Name.ToLower ( ).ToString ( ) );
            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return Task.FromResult ( "0" );
            }

        }



        #endregion





        public static string TranslateText_X1101 (String TranslationCode, String strToTranslate)
        {

            try
            {

                return "This translated text";

                //////////////// Set the language from/to in the url (or pass it into this function)
                //////////////string url = String.Format
                //////////////("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}",
                ////////////// "auto", TranslationCode, (WebUtility.UrlDecode(strToTranslate)));

                ////////////////string url = String.Format
                ////////////////( "https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}" ,
                //////////////// "auto" , TranslationCode , Uri.EscapeUriString ( WebUtility.UrlDecode( strToTranslate  ) ) );


                //////////////HttpClient httpClient = new HttpClient();
                //////////////string result = httpClient.GetStringAsync(url).Result;

                //////////////// Get all json data
                //////////////var jsonData = JsonConvert.DeserializeObject<List<dynamic>>(result);

                //////////////// Extract just the first array element (This is the only data we are interested in)
                //////////////var translationItems = jsonData[0];

                //////////////// Translation Data
                //////////////string translation = "";

                //////////////// Loop through the collection extracting the translated objects
                //////////////foreach (object item in translationItems)
                //////////////{
                //////////////    // Convert the item array to IEnumerable
                //////////////    IEnumerable translationLineObject = item as IEnumerable;

                //////////////    // Convert the IEnumerable translationLineObject to a IEnumerator
                //////////////    IEnumerator translationLineString = translationLineObject.GetEnumerator();

                //////////////    // Get first object in IEnumerator
                //////////////    translationLineString.MoveNext();

                //////////////    // Save its value (translated text)
                //////////////    translation += string.Format(" {0}", Convert.ToString(translationLineString.Current));
                //////////////}

                //////////////// Remove first blank character
                //////////////if (translation.Length > 1)
                //////////////{
                //////////////    translation = translation.Substring(1);
                //////////////};

                //////////////// Return translation
                //////////////return translation;

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }


        }





        public static string TranslateText_X1(String TranslationCode, String strToTranslate)
        {

            try
            {

                ////////// Set the language from/to in the url (or pass it into this function)
                ////////string url = String.Format
                ////////("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}",
                //////// "auto", TranslationCode, (WebUtility.UrlDecode(strToTranslate)));

                //////////string url = String.Format
                //////////( "https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}" ,
                ////////// "auto" , TranslationCode , Uri.EscapeUriString ( WebUtility.UrlDecode( strToTranslate  ) ) );


                ////////HttpClient httpClient = new HttpClient();
                ////////string result = httpClient.GetStringAsync(url).Result;

                ////////// Get all json data
                ////////var jsonData = JsonConvert.DeserializeObject<List<dynamic>>(result);

                ////////// Extract just the first array element (This is the only data we are interested in)
                ////////var translationItems = jsonData[0];

                ////////// Translation Data
                ////////string translation = "";

                ////////// Loop through the collection extracting the translated objects
                ////////foreach (object item in translationItems)
                ////////{
                ////////    // Convert the item array to IEnumerable
                ////////    IEnumerable translationLineObject = item as IEnumerable;

                ////////    // Convert the IEnumerable translationLineObject to a IEnumerator
                ////////    IEnumerator translationLineString = translationLineObject.GetEnumerator();

                ////////    // Get first object in IEnumerator
                ////////    translationLineString.MoveNext();

                ////////    // Save its value (translated text)
                ////////    translation += string.Format(" {0}", Convert.ToString(translationLineString.Current));
                ////////}

                ////////// Remove first blank character
                ////////if (translation.Length > 1)
                ////////{
                ////////    translation = translation.Substring(1);
                ////////};

                ////////// Return translation
                ////////return translation;

                return null;

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return "0";
            }


        }



        public static async Task<SRoofingTranslationModel> Get_TranslationModel(
            string TranslateDirection,
              string iOwner_LanguageCode_IN,
             string iOwner_LanguageCode_OUT,
             string strToTranslate)
        {
            try
            {



                ////TODO UNCOMMENT AFTER CREATE NEW CODE
                //////String _iLanguageCode;
                //////String _iOwner_LanguageCode;
                //////String _iOriginal_LanguageCode;
                //////String _iOriginal_MessageText = MessageText;

                //////String _iTranslated_MessageText;
                //////String _iTranslated_LanguageCode;
                //////String _iResult_MessageText;


                // Return translation
                SRoofingTranslationModel iTranslationModel = new SRoofingTranslationModel();


                string MessageType = "0";
                string MessageCode_Original = "0";
                string MessageText_Original = strToTranslate;
                string MessageCode_Translated = "0";
                string MessageText_Translated = "0";

                string url = "0";

                //DetectLanguageClient client = new DetectLanguageClient("6443b209c0ecfc15eb9ef9d9a7f49132");

                string _iLanguageCode = await DetectMessageTextLanguage ( MessageText_Original );//client.DetectCodeAsync(MessageText_Original);

                //////if (_iLanguageCode != null)   
                    
                    if (_iLanguageCode != "0")
                {

                    if (TranslateDirection == SRoofingEnum_Direction.Direction_In)
                    {

                        if (_iLanguageCode == iOwner_LanguageCode_IN)
                        {
                            iTranslationModel.MessageType = "textmessage";

                            iTranslationModel.MessageCode_Original = iOwner_LanguageCode_IN;
                            iTranslationModel.MessageText_Original = MessageText_Original;

                            iTranslationModel.MessageCode_Translated = iOwner_LanguageCode_IN;
                            iTranslationModel.MessageText_Translated = MessageText_Original;


                        }
                        else
                        {
                            iTranslationModel = Parse_TranslatedModel(
                                                    _iLanguageCode, iOwner_LanguageCode_IN, MessageText_Original).Result;
                        }




                        ////////// Set the language from/to in the url (or pass it into this function)
                        ////////url = String.Format
                        ////////      ("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}",
                        ////////       "auto", iOwner_LanguageCode_IN, (WebUtility.UrlDecode(strToTranslate)));
                    }
                  
                    else if (TranslateDirection == SRoofingEnum_Direction.Direction_Out)
                    {


                        if (_iLanguageCode == iOwner_LanguageCode_OUT)
                        {

                            iTranslationModel.MessageType = "textmessage";

                            iTranslationModel.MessageCode_Original = iOwner_LanguageCode_OUT;
                            iTranslationModel.MessageText_Original = MessageText_Original;

                            iTranslationModel.MessageCode_Translated = iOwner_LanguageCode_OUT;
                            iTranslationModel.MessageText_Translated = MessageText_Original;


                        }
                        else
                        {
                            iTranslationModel = Parse_TranslatedModel(
                                _iLanguageCode, iOwner_LanguageCode_OUT, MessageText_Original).Result;
                        }


                    }

                     


                }
                else
                {


                    iTranslationModel.MessageType = "textmessage";

                    iTranslationModel.MessageCode_Original = MessageCode_Original;
                    iTranslationModel.MessageText_Original = MessageText_Original;

                    iTranslationModel.MessageCode_Translated = MessageCode_Original;
                    iTranslationModel.MessageText_Translated = MessageText_Original;


                }


                //iTranslationModel.MessageType = "0";
                //iTranslationModel.MessageCode_Original = "0";
                //iTranslationModel.MessageText_Original = "0";
                //iTranslationModel.MessageCode_Translated = "0";
                //iTranslationModel.MessageText_Translated = "0";

                //  return translation;
                return iTranslationModel;
            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return null;
            }
        }



        public static async Task<SRoofingTranslationModel> Parse_TranslatedModel(
          string MessageCode_Original, string MessageCode_Translated, string strToTranslate)
        {

            try
            {

                SRoofingTranslationModel iTranslationModel = new SRoofingTranslationModel();

       
                    iTranslationModel.MessageType = "textmessagetranslate";

                    iTranslationModel.MessageCode_Original = MessageCode_Original;
                    iTranslationModel.MessageText_Original = strToTranslate;

                    iTranslationModel.MessageCode_Translated = MessageCode_Translated;
                 //   iTranslationModel.MessageText_Translated = "This's the translated message";
                    iTranslationModel.MessageText_Translated =await SRoofing_TranslationManager
                    .TranslateText(MessageCode_Original, MessageCode_Translated, strToTranslate);

                 

                return iTranslationModel;


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return null;
            }

        }


        public static async Task<SRoofingTranslationModel> Parse_TranslatedMoel_XXX111(
          string MessageCode_Original, string MessageCode_Translated, string strToTranslate)
        {

            try
            {

                //////SRoofingTranslationModel iTranslationModel = new SRoofingTranslationModel();



                //////// Set the language from/to in the url (or pass it into this function)
                //////string url = String.Format
                //////          ("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}",
                //////           "auto", MessageCode_Translated, (WebUtility.UrlDecode(strToTranslate)));


                //////HttpClient httpClient = new HttpClient();
                //////string result = httpClient.GetStringAsync(url).Result;

                //////// Get all json data
                //////var jsonData = JsonConvert.DeserializeObject<List<dynamic>>(result);

                //////// Extract just the first array element (This is the only data we are interested in)
                //////var translationItems = jsonData[0];

                //////// Translation Data
                //////string translation = "";

                //////// Loop through the collection extracting the translated objects
                //////foreach (object item in translationItems)
                //////{
                //////    // Convert the item array to IEnumerable
                //////    IEnumerable translationLineObject = item as IEnumerable;

                //////    // Convert the IEnumerable translationLineObject to a IEnumerator
                //////    IEnumerator translationLineString = translationLineObject.GetEnumerator();

                //////    // Get first object in IEnumerator
                //////    translationLineString.MoveNext();

                //////    // Save its value (translated text)
                //////    translation += string.Format(" {0}", Convert.ToString(translationLineString.Current));
                //////}

                //////// Remove first blank character
                //////if (translation.Length > 1)
                //////{
                //////    translation = translation.Substring(1);

                //////    iTranslationModel.MessageType = "textmessagetranslate";

                //////    iTranslationModel.MessageCode_Original = MessageCode_Original;
                //////    iTranslationModel.MessageText_Original = strToTranslate;

                //////    iTranslationModel.MessageCode_Translated = MessageCode_Translated;
                //////    iTranslationModel.MessageText_Translated = translation;


                //////}
                //////else
                //////{
                //////    translation = "0";

                //////    iTranslationModel.MessageType = "textmessage";

                //////    iTranslationModel.MessageCode_Original = MessageCode_Original;
                //////    iTranslationModel.MessageText_Original = strToTranslate;

                //////    iTranslationModel.MessageCode_Translated = "0";
                //////    iTranslationModel.MessageText_Translated = "0";

                //////}


                ////   return iTranslationModel;
                return null;

            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
                return null;
            }

        }




    }
}
