using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using GMap.NET;
using GMap.NET.WindowsForms;
using System.Windows.Forms;
using System.Collections.Generic;
using GMap.NET.WindowsForms.Markers;

namespace PrognozCS
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            //Model();
            Map();
        }

        private void Map()
        {
            double[] pointOnMap = { Form2.xMap, Form2.yMap};

            gMapControl1.Bearing = 0;
            gMapControl1.CanDragMap = true;
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.MaxZoom = Form2.zoom + 4;
            gMapControl1.MinZoom = Form2.zoom - 3;
            gMapControl1.MouseWheelZoomType = MouseWheelZoomType.MousePositionAndCenter;
            gMapControl1.NegativeMode = false;
            gMapControl1.PolygonsEnabled = true;
            gMapControl1.ShowTileGridLines = false;
            gMapControl1.Zoom = Form2.zoom;
            gMapControl1.Dock = DockStyle.Top;
            gMapControl1.MapProvider = GMap.NET.MapProviders.GMapProviders.GoogleMap;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            gMapControl1.Position = new PointLatLng(pointOnMap[0], pointOnMap[1]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CreateCircle(Form1.G);
        }

        private void CreateCircle(double dist)
        {            
            GMapOverlay polyOverlay = new GMapOverlay("polygons");
            List<PointLatLng> points = new List<PointLatLng>();

            if (Form1.f == 360)
            {
                double seg = Math.PI * 2 / 1000;

                for (int i = 0; i < 1000; i++)
                {
                    double theta = seg * i;
                    double a = Form2.xMap + Math.Cos(theta) / 102 * dist;
                    double b = Form2.yMap + Math.Sin(theta) / 62 * dist;
                    PointLatLng gpoi = new PointLatLng(a, b);
                    points.Add(gpoi);
                }
            }
            else
            {
                switch (Form2.side)
                {
                    case "n":
                        if (Form1.f == 45)
                        {
                            PointLatLng gpoi = new PointLatLng(Form2.xMap, Form2.yMap);
                            points.Add(gpoi);

                            double seg = 15 * Math.PI / 7 / 1000;

                            for (int i = 875; i < 1000; i++)
                            {
                                double theta = seg * i;
                                double a = Form2.xMap + Math.Cos(theta) / 102 * dist;
                                double b = Form2.yMap + Math.Sin(theta) / 62 * dist;
                                gpoi = new PointLatLng(a, b);
                                points.Add(gpoi);
                            }
                        }
                        if (Form1.f == 90)
                        {
                            PointLatLng gpoi = new PointLatLng(Form2.xMap, Form2.yMap);
                            points.Add(gpoi);

                            double seg = 9 * Math.PI / 4 / 1000;

                            for (int i = 782; i < 1000; i++)
                            {
                                double theta = seg * i;
                                double a = Form2.xMap + Math.Cos(theta) / 102 * dist;
                                double b = Form2.yMap + Math.Sin(theta) / 62 * dist;
                                gpoi = new PointLatLng(a, b);
                                points.Add(gpoi);
                            }
                        }
                        if (Form1.f == 180)
                        {

                        }
                        break;
                    case "s":
                        if (Form1.f == 45)
                        {
                            PointLatLng gpoi = new PointLatLng(Form2.xMap, Form2.yMap);
                            points.Add(gpoi);

                            double seg = 8 * Math.PI / 7 / 1000;

                            for (int i = 750; i < 1000; i++)
                            {
                                double theta = seg * i;
                                double a = Form2.xMap + Math.Cos(theta) / 102 * dist;
                                double b = Form2.yMap + Math.Sin(theta) / 62 * dist;
                                gpoi = new PointLatLng(a, b);
                                points.Add(gpoi);
                            }
                        }
                        if (Form1.f == 90)
                        {
                            PointLatLng gpoi = new PointLatLng(Form2.xMap, Form2.yMap);
                            points.Add(gpoi);

                            double seg = 5 * Math.PI / 4 / 1000;

                            for (int i = 602; i < 1000; i++)
                            {
                                double theta = seg * i;
                                double a = Form2.xMap + Math.Cos(theta) / 102 * dist;
                                double b = Form2.yMap + Math.Sin(theta) / 62 * dist;
                                gpoi = new PointLatLng(a, b);
                                points.Add(gpoi);
                            }
                        }
                        if (Form1.f == 180)
                        {

                        }
                        break;
                    case "w":
                        if (Form1.f == 45)
                        {
                            PointLatLng gpoi = new PointLatLng(Form2.xMap, Form2.yMap);
                            points.Add(gpoi);

                            double seg = 21 * Math.PI / 13 / 1000;

                            for (int i = 862; i < 1000; i++)
                            {
                                double theta = seg * i;
                                double a = Form2.xMap + Math.Cos(theta) / 102 * dist;
                                double b = Form2.yMap + Math.Sin(theta) / 62 * dist;
                                gpoi = new PointLatLng(a, b);
                                points.Add(gpoi);
                            }
                        }
                        if (Form1.f == 90)
                        {
                            PointLatLng gpoi = new PointLatLng(Form2.xMap, Form2.yMap);
                            points.Add(gpoi);

                            double seg = 7 * Math.PI / 4 / 1000;

                            for (int i = 722; i < 1000; i++)
                            {
                                double theta = seg * i;
                                double a = Form2.xMap + Math.Cos(theta) / 102 * dist;
                                double b = Form2.yMap + Math.Sin(theta) / 62 * dist;
                                gpoi = new PointLatLng(a, b);
                                points.Add(gpoi);
                            }
                        }
                        if (Form1.f == 180)
                        {

                        }
                        break;
                    case "e":
                        if (Form1.f == 45)
                        {
                            PointLatLng gpoi = new PointLatLng(Form2.xMap, Form2.yMap);
                            points.Add(gpoi);

                            double seg = 8 * Math.PI / 13 / 1000;

                            for (int i = 622; i < 1000; i++)
                            {
                                double theta = seg * i;
                                double a = Form2.xMap + Math.Cos(theta) / 102 * dist;
                                double b = Form2.yMap + Math.Sin(theta) / 62 * dist;
                                gpoi = new PointLatLng(a, b);
                                points.Add(gpoi);
                            }
                        }
                        if (Form1.f == 90)
                        {
                            PointLatLng gpoi = new PointLatLng(Form2.xMap, Form2.yMap);
                            points.Add(gpoi);

                            double seg = 3 * Math.PI / 4 / 1000;

                            for (int i = 372; i < 1000; i++)
                            {
                                double theta = seg * i;
                                double a = Form2.xMap + Math.Cos(theta) / 102 * dist;
                                double b = Form2.yMap + Math.Sin(theta) / 62 * dist;
                                gpoi = new PointLatLng(a, b);
                                points.Add(gpoi);
                            }
                        }
                        if (Form1.f == 180)
                        {
                            double seg = Math.PI / 1000;

                            for (int i = 0; i < 1000; i++)
                            {
                                double theta = seg * i;
                                double a = Form2.xMap + Math.Cos(theta) / 102 * dist;
                                double b = Form2.yMap + Math.Sin(theta) / 62 * dist;
                                PointLatLng gpoi = new PointLatLng(a, b);
                                points.Add(gpoi);
                            }
                        }
                        break;
                    case "nw":
                        if (Form1.f == 45)
                        {
                            PointLatLng gpoi = new PointLatLng(Form2.xMap, Form2.yMap);
                            points.Add(gpoi);

                            double seg = 13 * Math.PI / 7 / 1000;

                            for (int i = 875; i < 1000; i++)
                            {
                                double theta = seg * i;
                                double a = Form2.xMap + Math.Cos(theta) / 102 * dist;
                                double b = Form2.yMap + Math.Sin(theta) / 62 * dist;
                                gpoi = new PointLatLng(a, b);
                                points.Add(gpoi);
                            }
                        }
                        if (Form1.f == 90)
                        {
                            
                        }
                        if (Form1.f == 180)
                        {

                        }
                        break;
                    case "ne":
                        if (Form1.f == 45)
                        {
                            PointLatLng gpoi = new PointLatLng(Form2.xMap, Form2.yMap);
                            points.Add(gpoi);

                            double seg = 5 * Math.PI / 13 / 1000;

                            for (int i = 375; i < 1000; i++)
                            {
                                double theta = seg * i;
                                double a = Form2.xMap + Math.Cos(theta) / 102 * dist;
                                double b = Form2.yMap + Math.Sin(theta) / 62 * dist;
                                gpoi = new PointLatLng(a, b);
                                points.Add(gpoi);
                            }
                        }
                        if (Form1.f == 90)
                        {
                            
                        }
                        if (Form1.f == 180)
                        {

                        }
                        break;
                    case "sw":
                        if (Form1.f == 45)
                        {
                            PointLatLng gpoi = new PointLatLng(Form2.xMap, Form2.yMap);
                            points.Add(gpoi);

                            double seg = 18 * Math.PI / 13 / 1000;

                            for (int i = 800; i < 1000; i++)
                            {
                                double theta = seg * i;
                                double a = Form2.xMap + Math.Cos(theta) / 102 * dist;
                                double b = Form2.yMap + Math.Sin(theta) / 62 * dist;
                                gpoi = new PointLatLng(a, b);
                                points.Add(gpoi);
                            }
                        }
                        if (Form1.f == 90)
                        {
                            
                        }
                        if (Form1.f == 180)
                        {

                        }
                        break;
                    case "se":
                        if (Form1.f == 45)
                        {
                            PointLatLng gpoi = new PointLatLng(Form2.xMap, Form2.yMap);
                            points.Add(gpoi);

                            double seg = 17 * Math.PI / 19 / 1000;

                            for (int i = 700; i < 1000; i++)
                            {
                                double theta = seg * i;
                                double a = Form2.xMap + Math.Cos(theta) / 102 * dist;
                                double b = Form2.yMap + Math.Sin(theta) / 62 * dist;
                                gpoi = new PointLatLng(a, b);
                                points.Add(gpoi);
                            }
                        }
                        if (Form1.f == 90)
                        {
                            
                        }
                        if (Form1.f == 180)
                        {

                        }
                        break;
                }
            }

            GMapPolygon polygon = new GMapPolygon(points, "mypolygon");
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.OrangeRed));
            polygon.Stroke = new Pen(Color.Red, 1);
            polyOverlay.Polygons.Add(polygon);
            gMapControl1.Overlays.Add(polyOverlay);

            GMapOverlay markersOverlay = new GMapOverlay("markers");
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(Form2.xMap, Form2.yMap),
              GMarkerGoogleType.yellow_dot);
            markersOverlay.Markers.Add(marker);
            gMapControl1.Overlays.Add(markersOverlay);

            gMapControl1.Zoom = Form2.zoom + 1;
            gMapControl1.Zoom = Form2.zoom;
        }
    }
}
