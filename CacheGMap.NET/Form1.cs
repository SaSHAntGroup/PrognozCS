using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.CacheProviders;

namespace CacheGMap.NET
{
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
        }

        private void gMapControl2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                SQLitePureImageCache map = new SQLitePureImageCache();
                MemoryCache memory = new MemoryCache();

                map.CacheLocation = @"D:\Alexandr Olegovich\Projects\PrognozCS\PrognozCS\bin\x86\Debug\GMap.NET\TileDBv5\en\Data.gmdb";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double[] pointOnMap = { 51.3709559, 46.6363465 };

            gMapControl2.Bearing = 0;
            gMapControl2.CanDragMap = true;
            gMapControl2.DragButton = MouseButtons.Left;
            gMapControl2.MaxZoom = 14;
            gMapControl2.MinZoom = 7;
            gMapControl2.MouseWheelZoomType = MouseWheelZoomType.MousePositionAndCenter;
            gMapControl2.NegativeMode = false;
            gMapControl2.PolygonsEnabled = true;
            gMapControl2.ShowTileGridLines = false;
            gMapControl2.Zoom = 7;
            gMapControl2.Dock = DockStyle.Top;
            gMapControl2.MapProvider = GMap.NET.MapProviders.GMapProviders.GoogleMap;
            GMaps.Instance.Mode = AccessMode.CacheOnly;
            GMaps.Instance.CacheOnIdleRead = @"D:\Alexandr Olegovich\Projects\PrognozCS\PrognozCS\bin\x86\Debug\GMap.NET\TileDBv5\en\Data.gmdb";
            gMapControl2.Position = new PointLatLng(pointOnMap[0], pointOnMap[1]);
        }
    }
}
