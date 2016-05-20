﻿using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Editor;
using ESRI.ArcGIS.Framework;
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

    }
}
