﻿using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Editor;
using ESRI.ArcGIS.Framework;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtransEditorAGRC
{
    class clsGlobals
    {

        public static IApplication arcApplication
        {
            get;
            set;
        }


        public static IEditor3 arcEditor
        {
            get;
            set;
        }

        public static IGeoFeatureLayer arcGeoFLayerUtransStreets
        {
            get;
            set;
        }

        public static IGeoFeatureLayer arcGeoFLayerCountyStreets
        {
            get;
            set;
        }

        public static IGeoFeatureLayer arcGeoFLayerDfcResult
        {
            get;
            set;
        }

        public static IFeatureLayer arcFLayerAddrSysQuads
        {
            get;
            set;
        }
        public static IFeatureLayer arcFLayerZipCodes
        {
            get;
            set;
        }

        public static IFeatureLayer arcFLayerCounties
        {
            get;
            set;
        }

        public static IFeatureLayer arcFLayerMunicipalities
        {
            get;
            set;
        }

        public static frmUtransEditor UtransEdior2
        {
            get;
            set;
        }

        public static frmUserInputNotes UserInputNotes
        {
            get;
            set;
        }

        public static string strUserInputForSpreadsheet
        {
            get;
            set;
        }

        public static string strUserInputGoogleAccessCode
        {
            get;
            set;
        }

        public static string strCountySegment
        {
            get;
            set;
        }

        public static string strCountySegmentTrimed
        {
            get;
            set;
        }

        public static string strCountyID
        {
            get;
            set;
        }

        public static bool boolGoogleHasAccessCode
        {
            get;
            set;

        }

        public static string strCountyL_F_Add
        {
            get;
            set;
        }

        public static string strCountyL_T_Add
        {
            get;
            set;
        }

        public static string strCountyR_F_Add
        {
            get;
            set;
        }

        public static string strCountyR_T_Add
        {
            get;
            set;
        }

        public static string strAgrcSegment
        {
            get;
            set;
        }


        public static Logger logger
        {
            get;
            set;
        }


        public static bool blnCanUseUtransTool
        {
            get;
            set;
        }


    }
}
