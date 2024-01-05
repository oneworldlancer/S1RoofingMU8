﻿using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Country;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
 
using System.Threading.Tasks;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.KeyValue;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Manager
{
    class SRoofing_SpeechManager
    {

        public static List<string> project = new List<string> ( );
        string[] projects = { "hey" , "yo" , "app" , "xamarin" , "c" , "xaml" };


        public static List<String> _arrCountryName_List =
            new List<string>  {
              "Afrikaans",
              "Albanian",
              "Amharic",
              "Arabic",
              "Armenian",
              "Assamese",
              "Azerbaijani",
              "Bangla",
              "Bosnian (Latin)",
              "Bulgarian",
              "Cantonese (Traditional)",
              "Catalan",
              "Chinese (Literary)",
              "Chinese Simplified",
              "Chinese Traditional",
              "Croatian",
              "Czech",
              "Danish",
              "Dari",
              "Dutch",
              "English",
              "Estonian",
              "Fijian",
              "Filipino",
              "Finnish",
              "French",
              "French (Canada)",
              "German",
              "Greek",
              "Gujarati",
              "Haitian Creole",
              "Hebrew",
              "Hindi",
              "Hmong Daw",
              "Hungarian",
              "Icelandic",
              "Indonesian",
              "Inuktitut",
              "Irish",
              "Italian",
              "Japanese",
              "Kannada",
              "Kazakh",
              "Khmer",
              "Klingon",
              "Klingon (plqaD)",
              "Korean",
              "Kurdish (Central)",
              "Kurdish (Northern)",
              "Lao",
              "Latvian",
              "Lithuanian",
              "Malagasy",
              "Malay",
              "Malayalam",
              "Maltese",
              "Maori",
              "Marathi",
              "Myanmar",
              "Nepali",
              "Norwegian",
              "Odia",
              "Pashto",
              "Persian",
              "Polish",
              "Portuguese (Brazil)",
              "Portuguese (Portugal)",
              "Punjabi",
              "Queretaro Otomi",
              "Romanian",
              "Russian",
              "Samoan",
              "Serbian (Cyrillic)",
              "Serbian (Latin)",
              "Slovak",
              "Slovenian",
              "Spanish",
              "Swahili",
              "Swedish",
              "Tahitian",
              "Tamil",
              "Telugu",
              "Thai",
              "Tigrinya",
              "Tongan",
              "Turkish",
              "Ukrainian",
              "Urdu",
              "Vietnamese",
              "Welsh",
              "Yucatec Maya"
};


        public static List<String> _arrCountryCode_List =
            new List<string>  {
              "af",
              "sq",
              "am",
              "ar",
              "hy",
              "as",
              "az",
              "bn",
              "bs",
              "bg",
              "yue",
              "ca",
              "lzh",
              "zh-Hans",
              "zh-Hant",
              "hr",
              "cs",
              "da",
              "prs",
              "nl",
              "en",
              "et",
              "fj",
              "fil",
              "fi",
              "fr",
              "fr-ca",
              "de",
              "el",
              "gu",
              "ht",
              "he",
              "hi",
              "mww",
              "hu",
              "is",
              "id",
              "iu",
              "ga",
              "it",
              "ja",
              "kn",
              "kk",
              "km",
              "tlh-Latn",
              "tlh-Piqd",
              "ko",
              "ku",
              "kmr",
              "lo",
              "lv",
              "lt",
              "mg",
              "ms",
              "ml",
              "mt",
              "mi",
              "mr",
              "my",
              "ne",
              "nb",
              "or",
              "ps",
              "fa",
              "pl",
              "pt",
              "pt-pt",
              "pa",
              "otq",
              "ro",
              "ru",
              "sm",
              "sr-Cyrl",
              "sr-Latn",
              "sk",
              "sl",
              "es",
              "sw",
              "sv",
              "ty",
              "ta",
              "te",
              "th",
              "ti",
              "to",
              "tr",
              "uk",
              "ur",
              "vi",
              "cy",
              "yua"
            };



        public static List<String> _arrCountryMobileCode_List =
            new List<string>  {
                "93",
        "358",
        "335",
        "213",
        "1 684",
        "376",
        "224",
        "1 264",
        "627",
        "1 268",
        "54",
        "374",
        "297",
        "61",
        "43",
        "994",
        "1 242",
        "973",
        "880",
        "1 246",
        "375",
        "32",
        "501",
        "229",
        "1 441",
        "975",
        "591",
        "387",
        "267",
        "BV",
        "55",
        "1 284",
        "IO",
        "673",
        "359",
        "226",
        "257",
        "855",
        "237",
        "1",
        "238",
        "1 345",
        "236",
        "235",
        "56",
        "86",
        "61",
        "61",
        "57",
        "269",
        "242",
        "243",
        "682",
        "506",
        "225",
        "385",
        "53",
        "357",
        "420",
        "45",
        "253",
        "1 767",
        "1 809",
        "593",
        "20",
        "503",
        "240",
        "291",
        "372",
        "251",
        "500",
        "298",
        "679",
        "258",
        "33",
        "594",
        "689",
        "262",
        "241",
        "220",
        "995",
        "49",
        "233",
        "350",
        "30",
        "299",
        "1 473",
        "590",
        "1 671",
        "502",
        "44",
        "224",
        "245",
        "592",
        "509",
        "61",
        "39",
        "504",
        "36",
        "354",
        "91",
        "62",
        "98",
        "964",
        "353",
        "44",
        "972",
        "39",
        "1 876",
        "81",
        "44",
        "962",
        "7",
        "254",
        "686",
        "243",
        "82",
        "965",
        "996",
        "856",
        "371",
        "961",
        "266",
        "231",
        "218",
        "423",
        "370",
        "352",
        "389",
        "261",
        "265",
        "60",
        "960",
        "223",
        "356",
        "692",
        "596",
        "222",
        "230",
        "262",
        "52",
        "691",
        "373",
        "377",
        "976",
        "382",
        "1 664",
        "212",
        "258",
        "95",
        "264",
        "674",
        "977",
        "31",
        "599",
        "687",
        "64",
        "505",
        "227",
        "234",
        "683",
        "672",
        "1 670",
        "47",
        "968",
        "92",
        "680",
        "PS",
        "507",
        "675",
        "595",
        "51",
        "63",
        "870",
        "48",
        "351",
        "1",
        "974",
        "262",
        "40",
        "7",
        "250",
        "590",
        "290",
        "1 869",
        "1 758",
        "1 599",
        "508",
        "1 784",
        "685",
        "378",
        "239",
        "966",
        "381",
        "221",
        "248",
        "232",
        "65",
        "421",
        "386",
        "677",
        "252",
        "27",
        "GS",
        "SS",
        "34",
        "94",
        "249",
        "597",
        "47",
        "268",
        "46",
        "41",
        "963",
        "886",
        "992",
        "255",
        "66",
        "670",
        "228",
        "690",
        "676",
        "1 868",
        "216",
        "90",
        "993",
        "1 649",
        "688",
        "256",
        "380",
        "971",
        "44",
        "1",
        "808",
        "598",
        "998",
        "678",
        "58",
        "84",
        "1 340",
        "681",
        "212",
        "967",
        "38",
        "260",
        "263"
 };



        public static List<string> _arrCountryFlag_List = new List<string> ( ) {   "af.png",
        "ax.png",
        "al.png",
        "dz.png",
        "as.png",
        "ad.png",
        "ao.png",
        "ai.png",
        "aq.png",
        "ag.png",
        "ar.png",
        "am.png",
        "aw.png",
        "au.png",
        "at.png",
        "az.png",
        "bs.png",
        "bh.png",
        "bd.png",
        "bb.png",
        "by.png",
        "be.png",
        "bz.png",
        "bj.png",
        "bm.png",
        "bt.png",
        "bo.png",
        "ba.png",
        "bw.png",
        "bv.png",
        "br.png",
        "vg.png",
        "io.png",
        "bn.png",
        "bg.png",
        "bf.png",
        "bi.png",
        "kh.png",
        "cm.png",
        "ca.png",
        "cv.png",
        "ky.png",
        "cf.png",
        "td.png",
        "cl.png",
        "cn.png",
        "cx.png",
        "cc.png",
        "co.png",
        "km.png",
        "cg.png",
        "cd.png",
        "ck.png",
        "cr.png",
        "ci.png",
        "hr.png",
        "cu.png",
        "cy.png",
        "cz.png",
        "dk.png",
        "dj.png",
        "dm.png",
        "do_.png",
        "ec.png",
        "eg.png",
        "sv.png",
        "gq.png",
        "er.png",
        "ee.png",
        "et.png",
        "fk.png",
        "fo.png",
        "fj.png",
        "fi.png",
        "fr.png",
        "gf.png",
        "pf.png",
        "tf.png",
        "ga.png",
        "gm.png",
        "ge.png",
        "de.png",
        "gh.png",
        "gi.png",
        "gr.png",
        "gl.png",
        "gd.png",
        "gp.png",
        "gu.png",
        "gt.png",
        "gg.png",
        "gn.png",
        "gw.png",
        "gy.png",
        "ht.png",
        "hm.png",
        "va.png",
        "hn.png",
        "hu.png",
        "is.png",
        "in.png",
        "id.png",
        "ir.png",
        "iq.png",
        "ie.png",
        "im.png",
        "il.png",
        "it.png",
        "jm.png",
        "jp.png",
        "je.png",
        "jo.png",
        "kz.png",
        "ke.png",
        "ki.png",
        "kp.png",
        "kr.png",
        "kw.png",
        "kg.png",
        "la.png",
        "lv.png",
        "lb.png",
        "ls.png",
        "lr.png",
        "ly.png",
        "li.png",
        "lt.png",
        "lu.png",
        "mk.png",
        "mg.png",
        "mw.png",
        "my.png",
        "mv.png",
        "ml.png",
        "mt.png",
        "mh.png",
        "mq.png",
        "mr.png",
        "mu.png",
        "yt.png",
        "mx.png",
        "fm.png",
        "md.png",
        "mc.png",
        "mn.png",
        "me.png",
        "ms.png",
        "ma.png",
        "mz.png",
        "mm.png",
        "na.png",
        "nr.png",
        "np.png",
        "nl.png",
        "an.png",
        "nc.png",
        "nz.png",
        "ni.png",
        "ne.png",
        "ng.png",
        "nu.png",
        "nf.png",
        "mp.png",
        "no.png",
        "om.png",
        "pk.png",
        "pw.png",
        "ps.png",
        "pa.png",
        "pg.png",
        "py.png",
        "pe.png",
        "ph.png",
        "pn.png",
        "pl.png",
        "pt.png",
        "pr.png",
        "qa.png",
        "re.png",
        "ro.png",
        "ru.png",
        "rw.png",
        "bl.png",
        "sh.png",
        "kn.png",
        "lc.png",
        "mf.png",
        "pm.png",
        "vc.png",
        "ws.png",
        "sm.png",
        "st.png",
        "sa.png",
        "sn.png",
        "rs.png",
        "sc.png",
        "sl.png",
        "sg.png",
        "sk.png",
        "si.png",
        "sb.png",
        "so.png",
        "za.png",
        "gs.png",
        "ss.png",
        "es.png",
        "lk.png",
        "sd.png",
        "sr.png",
        "sj.png",
        "sz.png",
        "se.png",
        "ch.png",
        "sy.png",
        "tw.png",
        "tj.png",
        "tz.png",
        "th.png",
        "tl.png",
        "tg.png",
        "tk.png",
        "to.png",
        "tt.png",
        "tn.png",
        "tr.png",
        "tm.png",
        "tc.png",
        "tv.png",
        "ug.png",
        "ua.png",
        "ae.png",
        "gb.png",
        "us.png",
        "um.png",
        "uy.png",
        "uz.png",
        "vu.png",
        "ve.png",
        "vn.png",
        "vi.png",
        "wf.png",
        "eh.png",
        "ye.png",
        "yu.png",
        "zm.png",
        "zw.png"
        };




        #region CountryList


        public static async Task<ObservableCollection<SRoofingKeyValueModelManager>> Initilalize_Speech_CountryList ( )
        {

            try
            {
                ObservableCollection<SRoofingKeyValueModelManager> _arrCountryModelList;
                _arrCountryModelList = new ObservableCollection<SRoofingKeyValueModelManager> ( );

                SRoofingKeyValueModelManager iCountryModel;

                for ( int i = 0 ; i < _arrCountryName_List.Count ; i++ )
                {

                    iCountryModel = new SRoofingKeyValueModelManager ( )
                    {
                        ItemText = _arrCountryName_List[ i ] + " (" + _arrCountryCode_List[ i ].ToUpper ( ) + ")" ,
                        ItemValue = _arrCountryCode_List[ i ].ToUpper ( ) ,
                        ItemName = _arrCountryName_List[ i ] ,
                        ItemTitle = _arrCountryName_List[ i ]
                    };

                    _arrCountryModelList.Add ( iCountryModel );

                }

                //TlknSync_Country_Manager.Sync_Country_Set_CountryList_All(
                //        _context, CountryList);

                await SRoofingSync_Speech_Manager.Sync_Speech_Set_SpeechList ( App.Current , _arrCountryModelList );

                return await Task.FromResult ( _arrCountryModelList );
            }
            catch ( Exception )
            {

                throw;
            }

        }



        #endregion







    }
}
