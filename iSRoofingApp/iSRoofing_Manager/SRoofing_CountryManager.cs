﻿using S1RoofingMU.iSRoofingApp.iSRoofing_SyncManager;
using S1RoofingMU.iSRoofingApp.iSRoofing_Model.Country;
 
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
 
using System.Threading.Tasks;

namespace S1RoofingMU.iSRoofingApp.iSRoofing_Manager
    {
    class SRoofing_CountryManager
        {

        public static List<string> project = new List<string>();
        string[] projects = { "hey", "yo", "app", "xamarin", "c", "xaml" };


        public static List<String> _arrCountryName_List =
            new List<string>  {   "Afghanistan",
        "Aland Islands",
        "Albania",
        "Algeria",
        "American Samoa",
        "Andorra",
        "Angola",
        "Anguilla",
        "Antarctica",
        "Antigua and Barbuda",
        "Argentina",
        "Armenia",
        "Aruba",
        "Australia",
        "Austria",
        "Azerbaijan",
        "Bahamas",
        "Bahrain",
        "Bangladesh",
        "Barbados",
        "Belarus",
        "Belgium",
        "Belize",
        "Benin",
        "Bermuda",
        "Bhutan",
        "Bolivia",
        "Bosnia and Herzegovina",
        "Botswana",
        "Bouvet Island",
        "Brazil",
        "British Virgin Islands",
        "British Indian Ocean Territory",
        "Brunei",
        "Bulgaria",
        "Burkina Faso",
        "Burundi",
        "Cambodia",
        "Cameroon",
        "Canada",
        "Cape Verde",
        "Cayman Islands",
        "Central African Republic",
        "Chad",
        "Chile",
        "China",
        "Christmas Island",
        "Cocos (Keeling) Islands",
        "Colombia",
        "Comoros",
        "Congo (Brazzaville)",
        "Congo (Republic)",
        "Cook Islands",
        "Costa Rica",
        "Cote d\'Ivoire",
        "Croatia",
        "Cuba",
        "Cyprus",
        "Czech Republic",
        "Denmark",
        "Djibouti",
        "Dominica",
        "Dominican Republic",
        "Ecuador",
        "Egypt",
        "El Salvador",
        "Equatorial Guinea",
        "Eritrea",
        "Estonia",
        "Ethiopia",
        "Falkland Islands",
        "Faeroe Islands",
        "Fiji",
        "Finland",
        "France",
        "French Guiana",
        "French Polynesia",
        "French Southern Territories",
        "Gabon",
        "Gambia",
        "Georgia",
        "Germany",
        "Ghana",
        "Gibraltar",
        "Greece",
        "Greenland",
        "Grenada",
        "Guadeloupe",
        "Guam",
        "Guatemala",
        "Guernsey",
        "Guinea",
        "Guinea-Bissau",
        "Guyana",
        "Haiti",
        "Heard and Mcdonald Islands",
        "Holy See",
        "Honduras",
        "Hungary",
        "Iceland",
        "India",
        "Indonesia",
        "Iran",
        "Iraq",
        "Ireland",
        "Isle of Man",
        "Israel",
        "Italy",
        "Jamaica",
        "Japan",
        "Jersey",
        "Jordan",
        "Kazakhstan",
        "Kenya",
        "Kiribati",
        "Korea Democratic",
        "Korea Republic",
        "Kuwait",
        "Kyrgyzstan",
        "Laos",
        "Latvia",
        "Lebanon",
        "Lesotho",
        "Liberia",
        "Libya",
        "Liechtenstein",
        "Lithuania",
        "Luxembourg",
        "Macedonia Republic",
        "Madagascar",
        "Malawi",
        "Malaysia",
        "Maldives",
        "Mali",
        "Malta",
        "Marshall Islands",
        "Martinique",
        "Mauritania",
        "Mauritius",
        "Mayotte",
        "Mexico",
        "Micronesia Federal",
        "Moldova",
        "Monaco",
        "Mongolia",
        "Montenegro",
        "Montserrat",
        "Morocco",
        "Mozambique",
        "Myanmar",
        "Namibia",
        "Nauru",
        "Nepal",
        "Netherlands",
        "Netherlands Antilles",
        "New Caledonia",
        "New Zealand",
        "Nicaragua",
        "Niger",
        "Nigeria",
        "Niue",
        "Norfolk Island",
        "Northern Mariana Islands",
        "Norway",
        "Oman",
        "Pakistan",
        "Palau",
        "Palestinian Territory",
        "Panama",
        "Papua New Guinea",
        "Paraguay",
        "Peru",
        "Philippines",
        "Pitcairn Islands",
        "Poland",
        "Portugal",
        "Puerto Rico",
        "Qatar",
        "Reunion Island",
        "Romania",
        "Russia",
        "Rwanda",
        "Saint-Barthélemy",
        "Saint Helena",
        "Saint Kitts and Nevis",
        "Saint Lucia",
        "Saint-Martin",
        "Saint Pierre and Miquelon",
        "Saint Vincent and Grenadines",
        "Samoa",
        "San Marino",
        "Sao Tome and Principe",
        "Saudi Arabia",
        "Senegal",
        "Serbia",
        "Seychelles",
        "Sierra Leone",
        "Singapore",
        "Slovakia",
        "Slovenia",
        "Solomon Islands",
        "Somalia",
        "South Africa",
        "South Georgia and the South Sandwich Islands",
        "South Sudan",
        "Spain",
        "Sri Lanka",
        "Sudan",
        "Suriname",
        "Svalbard and Jan Mayen",
        "Swaziland",
        "Sweden",
        "Switzerland",
        "Syria",
        "Taiwan",
        "Tajikistan",
        "Tanzania",
        "Thailand",
        "Timor-Leste",
        "Togo",
        "Tokelau",
        "Tonga",
        "Trinidad and Tobago",
        "Tunisia",
        "Turkey",
        "Turkmenistan",
        "Turks and Caicos Islands",
        "Tuvalu",
        "Uganda",
        "Ukraine",
        "United Arab Emirates",
        "United Kingdom",
        "United States",
        "United States Minor Outlying Islands",
        "Uruguay",
        "Uzbekistan",
        "Vanuatu",
        "Venezuela",
        "Vietnam",
        "Virgin Islands",
        "Wallis and Futuna Islands",
        "Western Sahara",
        "Yemen",
        "Yugoslavia",
        "Zambia",
        "Zimbabwe"
};


        public static List<String> _arrCountryCode_List =
            new List<string>  {   "AF",
        "AX",
        "AL",
        "DZ",
        "AS",
        "AD",
        "AO",
        "AI",
        "AQ",
        "AG",
        "AR",
        "AM",
        "AW",
        "AU",
        "AT",
        "AZ",
        "BS",
        "BH",
        "BD",
        "BB",
        "BY",
        "BE",
        "BZ",
        "BJ",
        "BM",
        "BT",
        "BO",
        "BA",
        "BW",
        "BV",
        "BR",
        "VG",
        "IO",
        "BN",
        "BG",
        "BF",
        "BI",
        "KH",
        "CM",
        "CA",
        "CV",
        "KY",
        "CF",
        "TD",
        "CL",
        "CN",
        "CX",
        "CC",
        "CO",
        "KM",
        "CG",
        "CD",
        "CK",
        "CR",
        "CI",
        "HR",
        "CU",
        "CY",
        "CZ",
        "DK",
        "DJ",
        "DM",
        "DO",
        "EC",
        "EG",
        "SV",
        "GQ",
        "ER",
        "EE",
        "ET",
        "FK",
        "FO",
        "FJ",
        "FI",
        "FR",
        "GF",
        "PF",
        "TF",
        "GA",
        "GM",
        "GE",
        "DE",
        "GH",
        "GI",
        "GR",
        "GL",
        "GD",
        "GP",
        "GU",
        "GT",
        "GG",
        "GN",
        "GW",
        "GY",
        "HT",
        "HM",
        "VA",
        "HN",
        "HU",
        "IS",
        "IN",
        "ID",
        "IR",
        "IQ",
        "IE",
        "IM",
        "IL",
        "IT",
        "JM",
        "JP",
        "JE",
        "JO",
        "KZ",
        "KE",
        "KI",
        "KP",
        "KR",
        "KW",
        "KG",
        "LA",
        "LV",
        "LB",
        "LS",
        "LR",
        "LY",
        "LI",
        "LT",
        "LU",
        "MK",
        "MG",
        "MW",
        "MY",
        "MV",
        "ML",
        "MT",
        "MH",
        "MQ",
        "MR",
        "MU",
        "YT",
        "MX",
        "FM",
        "MD",
        "MC",
        "MN",
        "ME",
        "MS",
        "MA",
        "MZ",
        "MM",
        "NA",
        "NR",
        "NP",
        "NL",
        "AN",
        "NC",
        "NZ",
        "NI",
        "NE",
        "NG",
        "NU",
        "NF",
        "MP",
        "NO",
        "OM",
        "PK",
        "PW",
        "PS",
        "PA",
        "PG",
        "PY",
        "PE",
        "PH",
        "PN",
        "PL",
        "PT",
        "PR",
        "QA",
        "RE",
        "RO",
        "RU",
        "RW",
        "BL",
        "SH",
        "KN",
        "LC",
        "MF",
        "PM",
        "VC",
        "WS",
        "SM",
        "ST",
        "SA",
        "RS",
        "SN",
        "SC",
        "SL",
        "SG",
        "SK",
        "SI",
        "SB",
        "SO",
        "ZA",
        "GS",
        "SS",
        "ES",
        "LK",
        "SD",
        "SR",
        "SJ",
        "SZ",
        "SE",
        "CH",
        "SY",
        "TW",
        "TJ",
        "TZ",
        "TH",
        "TL",
        "TG",
        "TK",
        "TO",
        "TT",
        "TN",
        "TR",
        "TM",
        "TC",
        "TV",
        "UG",
        "UA",
        "AE",
        "GB",
        "US",
        "UM",
        "UY",
        "UZ",
        "VU",
        "VE",
        "VN",
        "VI",
        "WF",
        "EH",
        "YE",
        "YU",
        "ZM",
        "ZW"};

 

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



        public static List<string> _arrCountryFlag_List = new List<string>() {   "af.png",
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
        "dox.png",
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


        public static async Task<ObservableCollection<SRoofingCountryModel>>  Initilalize_CountryList()
        {

            try
            {
                ObservableCollection<SRoofingCountryModel> _arrCountryModelList;
                _arrCountryModelList = new ObservableCollection<SRoofingCountryModel>();

                SRoofingCountryModel iCountryModel;

                for (int i = 0; i < _arrCountryName_List.Count; i++)
                {

                    iCountryModel = new SRoofingCountryModel(
                            i,
                            _arrCountryName_List[i].ToString(),
                            _arrCountryCode_List[i].ToString(),
                            _arrCountryMobileCode_List[i].ToString(),
                            _arrCountryFlag_List[i].ToString(),
                            _arrCountryFlag_List[i].ToString());

                    _arrCountryModelList.Add(iCountryModel);

                }

                //TlknSync_Country_Manager.Sync_Country_Set_CountryList_All(
                //        _context, CountryList);

                SRoofingSync_Country_Manager.Sync_Country_Set_CountryList_All(App.Current,_arrCountryModelList);



                return await Task.FromResult(_arrCountryModelList) ;
            }
            catch (Exception)
            {

                throw;
            }

        }



        #endregion







    }
}