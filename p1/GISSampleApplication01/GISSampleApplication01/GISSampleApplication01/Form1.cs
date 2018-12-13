using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace GISSampleApplication01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Add first layer to your map
            int intHandler1; //integer index to handle the layer
            //create a new instance for MapWinGIS.Shapefile 
            //MapWinGIS.Shapefile  is a data provider for ESRI Shapefile
            MapWinGIS.Shapefile shapefile1 = new MapWinGIS.Shapefile();
            //Define the data source for MapWinGIS.Shapefile instance
            shapefile1.Open(@"G:\OneDrve\Documents\PROJECTS\gis\p1\GISSampleData\GISSampleData\base.shp", null);
            //display the layer on the map
            intHandler1 = axMap1.AddLayer(shapefile1, true);

            //Add second layer
            int intHandler2;
            MapWinGIS.Shapefile shapefile2 = new MapWinGIS.Shapefile();
            shapefile2.Open(@"G:\OneDrve\Documents\PROJECTS\gis\p1\GISSampleData\GISSampleData\nile.shp", null);
            intHandler2 = axMap1.AddLayer(shapefile2, true);


            //Set Filling color of the ploygon shapefile
            axMap1.set_ShapeLayerFillColor(intHandler1,
                (UInt32)(System.Drawing.ColorTranslator.ToOle (System.Drawing.Color.SaddleBrown)));
            //Set the line color
            axMap1 .set_ShapeLayerLineColor (intHandler2 ,
                (UInt32)(System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow)));
            //Set the line width
            axMap1.set_ShapeLayerLineWidth(intHandler2,5);
             


        }

        private void toolCursor_Click(object sender, EventArgs e)
        {
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmNone;
        }

        private void toolZoomExtent_Click(object sender, EventArgs e)
        {
            axMap1.ZoomToMaxExtents();
        }

        private void toolZoomIn_Click(object sender, EventArgs e)
        {
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmZoomIn;
        }

        private void toolZoomOut_Click(object sender, EventArgs e)
        {
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmZoomOut;
        }

        private void toolPan_Click(object sender, EventArgs e)
        {
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmPan;
        }
    }
}
