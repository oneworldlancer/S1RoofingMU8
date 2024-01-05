using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Time;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

 

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Manager
{
    public class SRoofing_TimeManager
    {




        public static string[] Weekdays = new string[] { "Sun" , "Mon" , "Tue" , "Wed" , "Thu" , "Fri" , "Sat" };
        public static string[] MonthsLong = { "January" , "February" , "March" , "April" , "May" , "June" , "July" , "August" , "September" , "October" , "November" , "December" };
        public static string[] MonthsShort = { "Jan" , "Feb" , "Mar" , "Apr" , "May" , "Jun" , "Jul" , "Aug" , "Sep" , "Oct" , "Nov" , "Dec" };
        public static int[] DaysOfMonth = { 31 , 28 , 31 , 30 , 31 , 30 , 31 , 31 , 30 , 31 , 30 , 31 };



        public static
        string Time_GenerateToken ( )
        {

            try
            {
                // return DateTime.Now.ToUniversalTime().Tostring();
                return DateTimeOffset.UtcNow.ToUnixTimeMilliseconds ( ).ToString ( );

                //            return string.valueOf (System.currentTimeMillis ());

                //Calendar cal = Calendar.getInstance(TimeZone.getTimeZone("UTC"));
                //long time = cal.getTimeInMillis();

                ////long time = System.currentTimeMillis ();

                //return string.valueOf(time);

            }
            catch (Exception ex )
            {
                return "0";
            }


        }


        public static
string Time_Get_UploadDay ( DateTime objNow )
        {

            try
            {



                if ( objNow == null ) objNow = DateTime.Now;

                return objNow.Day.ToString ( );


                //Calendar c = Calendar.getInstance();

                //return String.valueOf(c.get(Calendar.DATE));

            }
            catch (Exception ex )
            {
                return "00";
            }

        }

        public static
        string Time_Get_UploadMonth ( DateTime objNow )
        {

            try
            {


                if ( objNow == null ) objNow = DateTime.Now;

                return objNow.Month.ToString ( );

                //////Calendar c = Calendar.getInstance();

                //////return String.valueOf(c.get(Calendar.MONTH) + 1);

                //			return String.valueOf(Calendar.getInstance().get(
                //		Calendar.DAY_OF_MONTH));
            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );

                return "00";
            }

        }

        public static
        string Time_Get_UploadYear ( DateTime objNow )
        {

            try
            {

                if ( objNow == null ) objNow = DateTime.Now;


                return objNow.Year.ToString ( );


                //////Calendar c = Calendar.getInstance();

                //////return String.valueOf(c.get(Calendar.YEAR));

                //			return String.valueOf(Calendar.getInstance().get(
                //					Calendar.DAY_OF_YEAR));
            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );

                return "0000";
            }

        }



        public static
        string Time_Get_UploadTime ( DateTime objNow )
        {

            try
            {

                if ( objNow == null ) objNow = DateTime.Now;

                return objNow.ToString ( "hh:mm tt" );


            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );

                return "00:00";
            }

        }





        public static
        string Time_Get_DateTimeText ( DateTime objNow )
        {

            try
            {
                if ( objNow == null ) objNow = DateTime.Now;

                return objNow.Day.ToString ( ) + Time_GetMonthName (
          objNow.Month , true )
           + ", " + objNow.Year.ToString ( )
           + " "
           + Time_Get_UploadTime ( objNow ); //objNow.ToString ( "hh:mm tt" );
            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );

                return "00:00";
            }

        }




        public static
           string Time_Get_DateTime ( DateTime objNow )
        {

            try
            {

                if ( objNow == null ) objNow = DateTime.Now;

                return DateTime.Now.ToString ( "hh:mm tt" );


                ///////////*
                //////////            return Calendar.getInstance ().get (Calendar.HOUR) + ":"
                //////////                   + Calendar.getInstance ().get (Calendar.MINUTE);
                //////////*/

                //////////string strResult;
                //////////string _timeZone = "";

                //////////Calendar now = Calendar.getInstance();
                //////////int a = now.get(Calendar.AM_PM);

                //////////if (a == Calendar.AM)
                //////////{
                //////////    _timeZone = "am";
                //////////}
                //////////else if (a == Calendar.PM)
                //////////{
                //////////    _timeZone = "pm";
                //////////}


                ///////////*
                //////////            strResult = String.format (
                //////////                    "%02d:%02d",
                //////////                    Calendar.getInstance ().get (Calendar.HOUR)
                //////////                    ,
                //////////                    Calendar.getInstance ().get (Calendar.MINUTE)) + " " + _timeZone.toUpperCase ();
                //////////*/

                //////////strResult = Calendar.getInstance().get(Calendar.HOUR)
                //////////        + ":" + String.format(
                //////////        "%02d", Calendar.getInstance().get(Calendar.MINUTE))
                //////////        + " " + _timeZone.toUpperCase();


                ///////////*
                //////////                    String.format (
                //////////                    "%02d:%02d",
                //////////                    Calendar.getInstance ().get (Calendar.HOUR)
                //////////                   , Calendar.getInstance ().get (Calendar.MINUTE)) + " " + _timeZone.toUpperCase ();
                //////////*/

                ///////////*
                //////////            strResult = Calendar.getInstance ().get (Calendar.HOUR) + ":"
                //////////                        + Calendar.getInstance ().get (Calendar.MINUTE) + " " + _timeZone.toUpperCase ();
                //////////*/

                //////////return strResult;

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );

                return "00:00";
            }

        }





        public static
             string Time_Get_DateText ( DateTime objNow )
        {

            try
            {

                if ( objNow == null ) objNow = DateTime.Now;

                return objNow.Day.ToString ( ) + Time_GetMonthName (
            objNow.Month , true )
             + ", " + objNow.Year.ToString ( );

                ///////////*
                //////////            return Calendar.getInstance ().get (Calendar.HOUR) + ":"
                //////////                   + Calendar.getInstance ().get (Calendar.MINUTE);
                //////////*/

                //////////string strResult;
                //////////string _timeZone = "";

                //////////Calendar now = Calendar.getInstance();
                //////////int a = now.get(Calendar.AM_PM);

                //////////if (a == Calendar.AM)
                //////////{
                //////////    _timeZone = "am";
                //////////}
                //////////else if (a == Calendar.PM)
                //////////{
                //////////    _timeZone = "pm";
                //////////}


                ///////////*
                //////////            strResult = String.format (
                //////////                    "%02d:%02d",
                //////////                    Calendar.getInstance ().get (Calendar.HOUR)
                //////////                    ,
                //////////                    Calendar.getInstance ().get (Calendar.MINUTE)) + " " + _timeZone.toUpperCase ();
                //////////*/

                //////////strResult = Calendar.getInstance().get(Calendar.HOUR)
                //////////        + ":" + String.format(
                //////////        "%02d", Calendar.getInstance().get(Calendar.MINUTE))
                //////////        + " " + _timeZone.toUpperCase();


                ///////////*
                //////////                    String.format (
                //////////                    "%02d:%02d",
                //////////                    Calendar.getInstance ().get (Calendar.HOUR)
                //////////                   , Calendar.getInstance ().get (Calendar.MINUTE)) + " " + _timeZone.toUpperCase ();
                //////////*/

                ///////////*
                //////////            strResult = Calendar.getInstance ().get (Calendar.HOUR) + ":"
                //////////                        + Calendar.getInstance ().get (Calendar.MINUTE) + " " + _timeZone.toUpperCase ();
                //////////*/

                //////////return strResult;

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );

                return "00:00";
            }

        }






        public static
        string Time_GetMonthName ( int month , Boolean IsShort )
        {

            try
            {

                if ( IsShort == false )
                {
                    return MonthsLong[ month - 1 ];

                }
                else
                {
                    return MonthsShort[ month - 1 ].ToUpperInvariant ( );
                }

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
            }
        }






        public static
        SRoofingTimeModel Time_Get_TimeModel ( DateTime objNow )
        {

            try
            {

                if ( objNow == null ) objNow = DateTime.Now;

                string DateTimeTextWS, DateTimeWS, DateTextWS, UserDateDayWS, UserDateMonthWS, UserDateYearWS;

                SRoofingTimeModel iTimeModel = new SRoofingTimeModel ( )
                {
                    DateTimeTextWS = Time_Get_DateTimeText ( objNow ) ,
                    DateTimeWS = Time_Get_DateTime ( objNow ) ,
                    DateTextWS = Time_Get_DateText ( objNow ) ,
                    DateDayWS = Time_Get_UploadDay ( objNow ) ,
                    DateMonthWS = Time_Get_UploadMonth ( objNow ) ,
                    DateYearWS = Time_Get_UploadYear ( objNow ) ,
                    iDateTimeWS = objNow ,
                    iDateTimeMilliSecWS = new DateTimeOffset ( objNow ).ToUnixTimeMilliseconds ( )

                };

                return iTimeModel;


            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
            }


        }





        public static
        SRoofingTimeModel Time_Get_TimeModel ( string DateTimeMilliSec )
        {
            try
            {
                long milliseconds = long.Parse ( DateTimeMilliSec );// 1509359657633;
                TimeSpan time = TimeSpan.FromMilliseconds ( milliseconds );
                DateTime objNow = new DateTime ( 1970 , 1 , 1 ).AddTicks ( time.Ticks );


                if ( objNow == null ) objNow = DateTime.Now;

                string DateTimeTextWS, DateTimeWS, DateTextWS, UserDateDayWS, UserDateMonthWS, UserDateYearWS;

                SRoofingTimeModel iTimeModel = new SRoofingTimeModel ( )
                {
                    DateTimeTextWS = Time_Get_DateTimeText ( objNow ) ,
                    DateTimeWS = Time_Get_DateTime ( objNow ) ,
                    DateTextWS = Time_Get_DateText ( objNow ) ,
                    DateDayWS = Time_Get_UploadDay ( objNow ) ,
                    DateMonthWS = Time_Get_UploadMonth ( objNow ) ,
                    DateYearWS = Time_Get_UploadYear ( objNow ) ,
                    iDateTimeWS = objNow ,
                    iDateTimeMilliSecWS = new DateTimeOffset ( objNow ).ToUnixTimeMilliseconds ( )

                };

                return iTimeModel;

            }
            catch ( Exception ex )
            {
                SRoofing_DebugManager.Debug_ShowSystemMessage ( ex.Message.ToString ( ) );
                return null;
            }


        }





        ////////public static
        ////////string Time_GetUploadTime_24Hour()
        ////////{

        ////////    try
        ////////    {

        ////////        string now = new SimpleDateFormat("hh:mm aa").format(new java.util.Date().getTime());

        ////////        System.out.println("time in 12 hour format : " + now);
        ////////        SimpleDateFormat inFormat = new SimpleDateFormat("hh:mm aa");
        ////////        SimpleDateFormat outFormat = new SimpleDateFormat("HH:mm");

        ////////        string time24 = outFormat.format(inFormat.parse(now));
        ////////        //System.out.println("time in 24 hour format : " +time24 );

        ////////        return time24;


        ////////    }
        ////////    catch (Exception ex)
        ////////    {
        ////////        System.out.println("Exception : " + e.getMessage());

        ////////        return "00:00";
        ////////    }


        ////////}



        ////////public static string Time_GetUploadTime_24Hour(string paramString)
        ////////{
        ////////    try
        ////////    {
        ////////        string str1 = new SimpleDateFormat("hh:mm aa").format(Long.valueOf(Long.parseLong(paramString)));
        ////////        System.out.println("time in 12 hour format : " + str1);
        ////////        SimpleDateFormat localSimpleDateFormat = new SimpleDateFormat("hh:mm aa");
        ////////        string str2 = new SimpleDateFormat("HH:mm").format(localSimpleDateFormat.parse(str1));
        ////////        return str2;
        ////////    }
        ////////    catch (Exception localException)
        ////////    {
        ////////        System.out.println("Exception : " + localException.getMessage());
        ////////    }
        ////////    return "00:00";
        ////////}


        ////////public static
        ////////string Time_GetUploadDateTime()
        ////////{

        ////////    try
        ////////    {

        ////////        SimpleDateFormat sdfDateTime = new SimpleDateFormat(
        ////////                "yyyy-MM-dd HH:mm:ss", Locale.US);

        ////////        return sdfDateTime.format(new Date(System.currentTimeMillis()));
        ////////    }
        ////////    catch (Exception ex)
        ////////    {
        ////////        return "00:00";
        ////////    }
        ////////}



        ////////public static
        ////////string Time_GetUploadDayName(Boolean IsShort)
        ////////{

        ////////    try
        ////////    {

        ////////        String[] days = null;

        ////////        if (IsShort == true)
        ////////        {
        ////////            days = new String[] { "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT" };

        ////////        }
        ////////        else if (IsShort == false)
        ////////        {
        ////////            days = new String[] { "SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY" };

        ////////        }

        ////////        Calendar c = Calendar.getInstance();

        ////////        int _iDay = c.get(Calendar.DAY_OF_WEEK);

        ////////        return String.valueOf(days[_iDay - 1]);

        ////////    }
        ////////    catch (Exception ex)
        ////////    {
        ////////        return null;
        ////////    }
        ////////}



    }
}
