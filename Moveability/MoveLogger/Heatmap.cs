/*M///////////////////////////////////////////////////////////////////////////////////////
//
//  IMPORTANT: READ BEFORE DOWNLOADING, COPYING, INSTALLING OR USING.
//
//  By downloading, copying, installing or using the software you agree to this license.
//  If you do not agree to this license, do not download, install,
//  copy or use the software.
//
//
//                           License Agreement
//                For Open Source Human SCADA Library  
//
// Copyright (C) 2011-2014, Diego Schmaedech for this and Many Others Developers around the worlds for all, 
//all rights reserved. 
//
//							For Open Source Human SCADA
//
// Copyright (C) 2012, Laboratório de Educação Cerebral, all rights reserved.
//
// Third party copyrights are property of their respective owners.
// Third party copyrights are property of their respective owners.
//
// Redistribution and use in source and binary forms, with or without modification,
// are permitted provided that the following conditions are met:
//
//   * Redistribution's of source code must retain the above copyright notice,
//     this list of conditions and the following disclaimer.
//
//   * Redistribution's in binary form must reproduce the above copyright notice,
//     this list of conditions and the following disclaimer in the documentation
//     and/or other materials provided with the distribution.
//
//   * The name of the copyright holders may not be used to endorse or promote products
//     derived from this software without specific prior written permission.
//
// This software is provided by the copyright holders and contributors "as is" and
// any express or implied warranties, including, but not limited to, the implied
// warranties of merchantability and fitness for a particular purpose are disclaimed.
// In no event shall the Intel Corporation or contributors be liable for any direct,
// indirect, incidental, special, exemplary, or consequential damages
// (including, but not limited to, procurement of substitute goods or services;
// loss of use, data, or profits; or business interruption) however caused
// and on any theory of liability, whether in contract, strict liability,
// or tort (including negligence or otherwise) arising in any way out of
// the use of this software, even if advised of the possibility of such damage.
//
//M*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Xml.Serialization;

namespace Moveability
{
    public struct HeatPoint
    {
        public int X;
        public int Y;
        public int Intensity;
        public HeatPoint(int iX, int iY, int bIntensity)
        {
            X = iX;
            Y = iY;
            Intensity = bIntensity;
        }
    }

    public partial class Heatmap : UserControl
    {

        private List<HeatPoint> heatPoints = new List<HeatPoint>();
        Bitmap bMap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        Bitmap bImg = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        private BackgroundWorker worker = new BackgroundWorker();
        bool IsClicks = false;
        bool IsMoves = true;
        bool IsInatives = false;

        public Heatmap()
        {
            InitializeComponent();
        }
         
        public static float max(int[,] a)
        {
            float max = float.NegativeInfinity;


            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > max)
                        max = a[i, j];
                }
            }

            return max;
        }

        private Bitmap CreateIntensityMask(Bitmap bSurface, List<HeatPoint> aHeatPoints)
        {
            // Create new graphics surface from memory bitmap
            Graphics DrawSurface = Graphics.FromImage(bSurface);

            // Set background color to white so that pixels can be correctly colorized
            DrawSurface.Clear(Color.White);

            // Traverse heat point data and draw masks for each heat point
            foreach (HeatPoint DataPoint in aHeatPoints)
            {
                // Render current heat point on draw surface
                DrawHeatPoint(DrawSurface, DataPoint, 10);
            }

            return bSurface;
        }

        private void DrawHeatPoint(Graphics Canvas, HeatPoint HeatPoint, int Radius)
        {
            // Create points generic list of points to hold circumference points
            List<Point> CircumferencePointsList = new List<Point>();

            // Create an empty point to predefine the point struct used in the circumference loop
            Point CircumferencePoint;

            // Create an empty array that will be populated with points from the generic list
            Point[] CircumferencePointsArray;

            // Calculate ratio to scale byte intensity range from 0-255 to 0-1
            float fRatio = 1F / Byte.MaxValue;
            // Precalulate half of byte max value
            byte bHalf = Byte.MaxValue / 2;
            // Flip intensity on it's center value from low-high to high-low
            int iIntensity = (byte)(HeatPoint.Intensity - ((HeatPoint.Intensity - bHalf) * 2));
            // Store scaled and flipped intensity value for use with gradient center location
            float fIntensity = iIntensity * fRatio;

            // Loop through all angles of a circle
            // Define loop variable as a double to prevent casting in each iteration
            // Iterate through loop on 10 degree deltas, this can change to improve performance
            for (double i = 0; i <= 360; i += 10)
            {
                // Replace last iteration point with new empty point struct
                CircumferencePoint = new Point();

                // Plot new point on the circumference of a circle of the defined radius
                // Using the point coordinates, radius, and angle
                // Calculate the position of this iterations point on the circle
                CircumferencePoint.X = Convert.ToInt32(HeatPoint.X + Radius * Math.Cos(ConvertDegreesToRadians(i)));
                CircumferencePoint.Y = Convert.ToInt32(HeatPoint.Y + Radius * Math.Sin(ConvertDegreesToRadians(i)));

                // Add newly plotted circumference point to generic point list
                CircumferencePointsList.Add(CircumferencePoint);
            }

            // Populate empty points system array from generic points array list
            // Do this to satisfy the datatype of the PathGradientBrush and FillPolygon methods
            CircumferencePointsArray = CircumferencePointsList.ToArray();

            // Create new PathGradientBrush to create a radial gradient using the circumference points
            PathGradientBrush GradientShaper = new PathGradientBrush(CircumferencePointsArray);

            // Create new color blend to tell the PathGradientBrush what colors to use and where to put them
            ColorBlend GradientSpecifications = new ColorBlend(3);

            // Define positions of gradient colors, use intesity to adjust the middle color to
            // show more mask or less mask
            GradientSpecifications.Positions = new float[3] { 0, fIntensity, 1 };
            // Define gradient colors and their alpha values, adjust alpha of gradient colors to match intensity
            GradientSpecifications.Colors = new Color[3] { Color.FromArgb(0, Color.White), Color.FromArgb(HeatPoint.Intensity, Color.Black), Color.FromArgb(HeatPoint.Intensity, Color.Black) };

            // Pass off color blend to PathGradientBrush to instruct it how to generate the gradient
            GradientShaper.InterpolationColors = GradientSpecifications;

            // Draw polygon (circle) using our point array and gradient brush
            Canvas.FillPolygon(GradientShaper, CircumferencePointsArray);
        }

        private double ConvertDegreesToRadians(double degrees)
        {
            double radians = (Math.PI / 180) * degrees;
            return (radians);
        }

        public static Bitmap Colorize(Bitmap Mask, byte Alpha)
        {
            // Create new bitmap to act as a work surface for the colorization process
            Bitmap Output = new Bitmap(Mask.Width, Mask.Height, PixelFormat.Format32bppArgb);

            // Create a graphics object from our memory bitmap so we can draw on it and clear it's drawing surface
            Graphics Surface = Graphics.FromImage(Output);
            Surface.Clear(Color.Transparent);

            // Build an array of color mappings to remap our greyscale mask to full color
            // Accept an alpha byte to specify the transparancy of the output image
            ColorMap[] Colors = CreatePaletteIndex(Alpha);

            // Create new image attributes class to handle the color remappings
            // Inject our color map array to instruct the image attributes class how to do the colorization
            ImageAttributes Remapper = new ImageAttributes();
            Remapper.SetRemapTable(Colors);

            // Draw our mask onto our memory bitmap work surface using the new color mapping scheme
            Surface.DrawImage(Mask, new Rectangle(0, 0, Mask.Width, Mask.Height), 0, 0, Mask.Width, Mask.Height, GraphicsUnit.Pixel, Remapper);

            // Send back newly colorized memory bitmap
            return Output;
        }

        private static ColorMap[] CreatePaletteIndex(byte Alpha)
        {
            ColorMap[] OutputMap = new ColorMap[256];

            // Change this path to wherever you saved the palette image.
            Bitmap Palette = (Bitmap)Moveability.Properties.Resources.palette;

            // Loop through each pixel and create a new color mapping
            for (int X = 0; X <= 255; X++)
            {
                OutputMap[X] = new ColorMap();
                OutputMap[X].OldColor = Color.FromArgb(X, X, X);
                OutputMap[X].NewColor = Color.FromArgb(Alpha, Palette.GetPixel(X, 0));
            }

            return OutputMap;
        }

        private void CreateHeatmap()
        {

            Protocol.samples.CollectionName = "Samples";
            Type[] extraTypes = new Type[1];
            extraTypes[0] = typeof(int);
            XmlRootAttribute root = new XmlRootAttribute("Samples");
            XmlAttributeOverrides attrOverrides = new XmlAttributeOverrides();
            XmlAttributes attrs = new XmlAttributes();
            XmlSerializer xml = new XmlSerializer(typeof(Samples), attrOverrides, extraTypes, root, "http://www.educacaocerebral.org");
            FileStream ReadFileStream = new FileStream(Protocol.FILENAME, FileMode.Open, FileAccess.Read, FileShare.Read);
            if (ReadFileStream != null)
            {
                Samples samplesFromXML = (Samples)xml.Deserialize(ReadFileStream);
                ReadFileStream.Close();
                heatPoints.Clear();

                int deskHeight = Screen.PrimaryScreen.Bounds.Height + 64;
                int deskWidth = Screen.PrimaryScreen.Bounds.Width + 64;
                // Create new memory bitmap the same size as the picture box
                bMap = new Bitmap(deskWidth, deskHeight);
                bImg = new Bitmap(deskWidth, deskHeight);

                int[,] equipas = new int[deskWidth, deskHeight];
                Array.Clear(equipas, 0, equipas.Length);

                for (int i = 0; i < samplesFromXML.Count; i++)
                {
                    Sample nSample = samplesFromXML[i];
                    if (IsMoves)
                    {
                        if (nSample.Type.Trim() == "MouseMove")
                        {
                            heatPoints.Add(new HeatPoint(nSample.X, nSample.Y, 32));
                        }
                    }
                    if (IsClicks)
                    {
                        if (nSample.Type.Trim() == "MouseUp" || nSample.Type.Trim() == "MouseDown")
                        {
                            heatPoints.Add(new HeatPoint(nSample.X, nSample.Y, 64));
                        }
                    }
                    if (IsInatives )
                    {
                        if (nSample.Type.Trim() == "Inativo" )
                        {
                            heatPoints.Add(new HeatPoint(nSample.X, nSample.Y, 64));
                        }
                    }
                    // Console.WriteLine(equipas[iX, iY]);
                    //  worker.ReportProgress(i);
                }
                bMap = CreateIntensityMask(bMap, heatPoints);
                bImg = Colorize(bMap, 255);
                this.pictureBox1.BackgroundImage = bImg;
                bImg.Save(Protocol.FILENAME + ".png");
            }
        }

        public void UpdatePanel()
        {
            if (Protocol.samples.Count > 0)
            {
                CreateHeatmap();
            }
        }

        private void btnClicks_Click(object sender, EventArgs e)
        {
            if (IsClicks)
            {
                this.btnClicks.Image = global::Moveability.Properties.Resources.Cancel;
                IsClicks = false;
            }
            else
            {
                this.btnClicks.Image = global::Moveability.Properties.Resources.Ok;
                IsClicks = true;
            }
            UpdatePanel();
        }

        private void btnMoves_Click(object sender, EventArgs e)
        {
            if (IsMoves)
            {
                this.btnMoves.Image = global::Moveability.Properties.Resources.Cancel;
                IsMoves = false;
            }
            else
            {
                this.btnMoves.Image = global::Moveability.Properties.Resources.Ok;
                IsMoves = true;
            }
            UpdatePanel();
        }

        private void btnInative_Click(object sender, EventArgs e)
        {
            if (IsInatives)
            {
                this.btnInative.Image = global::Moveability.Properties.Resources.Cancel;
                IsInatives = false;
            }
            else
            {
                this.btnInative.Image = global::Moveability.Properties.Resources.Ok;
                IsInatives = true;
            }
            UpdatePanel();
        }

    }
}
