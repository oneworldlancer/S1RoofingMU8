using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using S1RoofingMU.iSRoofingApp.iSRoofing_Manager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Time;
using System.Web;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_HandlerManager
{
    public class SRoofing_HandlerManager
    {


        public static async Task<string> Handler_GetResponse(String HttpWebHandlerURL)
        {

            String Response = "0";

            try
            {


                #region iTimeModel

                SRoofingTimeModel _iTimeModel = new SRoofingTimeModel();
                _iTimeModel = SRoofing_TimeManager.Time_Get_TimeModel(DateTime.Now);

                #endregion

                string TimeHandlerMessage =
                     "&dtimetxt=" + HttpUtility.HtmlEncode(_iTimeModel.DateTimeTextWS)
                     + "&dtime=" +  HttpUtility.HtmlEncode(_iTimeModel.DateTimeWS)
                     + "&dtxt=" + HttpUtility.HtmlEncode(_iTimeModel.DateTextWS)
                     + "&dday=" +  HttpUtility.HtmlEncode(_iTimeModel.DateDayWS)
                     + "&dmonth=" + HttpUtility.HtmlEncode(_iTimeModel.DateMonthWS)
                     + "&dyear=" +  HttpUtility.HtmlEncode(_iTimeModel.DateYearWS)
                     + "&dmillisec=" + HttpUtility.HtmlEncode(_iTimeModel.iDateTimeMilliSecWS);


                HttpWebHandlerURL += TimeHandlerMessage;


                //////////            HttpWebHandlerURL += TimeHandlerMessage;

                //////////            WebClient client = new WebClient();

                //////////            ServicePointManager.ServerCertificateValidationCallback = new
                //////////RemoteCertificateValidationCallback
                //////////(
                //////////   delegate { return true; }
                //////////);




                var handler = new HttpClientHandler();
                handler.ClientCertificateOptions = ClientCertificateOption.Manual;
                handler.ServerCertificateCustomValidationCallback =
                    (httpRequestMessage, cert, cetChain, policyErrors) => true;

                var client = new HttpClient(handler);





                Uri myUri = new Uri(HttpWebHandlerURL);

             //   Response = await client.DownloadStringTaskAsync(myUri);
                Response = await client.GetStringAsync(myUri);

                return Response;


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            }
            return Response;

        }










        public static async Task<string> Handler_GetResponse(String HttpWebHandlerURL, SRoofingTimeModel _iTimeModel)
        {

            String Response = "0";

            try
            {


                //////#region iTimeModel

                //////SRoofingTimeModel _iTimeModel = new SRoofingTimeModel ( );
                //////_iTimeModel = SRoofing_TimeManager.Time_Get_TimeModel ( DateTime.Now );

                //////#endregion

                string TimeHandlerMessage =
                     "&dtimetxt=" + HttpUtility.HtmlEncode(_iTimeModel.DateTimeTextWS)
                     + "&dtime=" +  HttpUtility.HtmlEncode(_iTimeModel.DateTimeWS)
                     + "&dtxt=" + HttpUtility.HtmlEncode(_iTimeModel.DateTextWS)
                     + "&dday=" +  HttpUtility.HtmlEncode(_iTimeModel.DateDayWS)
                     + "&dmonth=" + HttpUtility.HtmlEncode(_iTimeModel.DateMonthWS)
                     + "&dyear=" +  HttpUtility.HtmlEncode(_iTimeModel.DateYearWS)
                     + "&dmillisec=" + HttpUtility.HtmlEncode(_iTimeModel.iDateTimeMilliSecWS);


                HttpWebHandlerURL += TimeHandlerMessage;

                //            WebClient client = new WebClient();

                //            ServicePointManager.ServerCertificateValidationCallback = new
                //RemoteCertificateValidationCallback
                //(
                //   delegate { return true; }
                //);



                var handler = new HttpClientHandler();
                handler.ClientCertificateOptions = ClientCertificateOption.Manual;
                handler.ServerCertificateCustomValidationCallback =
                    (httpRequestMessage, cert, cetChain, policyErrors) => true;

                var client = new HttpClient(handler);





                Uri myUri = new Uri(HttpWebHandlerURL);

                //   Response = await client.DownloadStringTaskAsync(myUri);
                Response = await client.GetStringAsync(myUri);



                //Uri myUri = new Uri(HttpWebHandlerURL);

                //Response = await client.DownloadStringTaskAsync(myUri);

                return Response;


            }
            catch (Exception ex)
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage(ex.Message.ToString());
            }
            return Response;

        }






    }
}
