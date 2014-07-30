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
//                For Open Source Heart Rate SCADA Library  
//
// Copyright (C) 2011-2012, Diego Schmaedech, all rights reserved. 
//
							For Open Source Biosignal SCADA
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
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MouseKeyboardActivityMonitor.WinApi;
using MouseKeyboardActivityMonitor;
using System.Xml.Serialization;
using System.IO;
using System.Diagnostics;
namespace Moveability
{
    public partial class Principal : Form
    {

        private readonly KeyboardHookListener m_KeyboardHookManager;
        private readonly MouseHookListener m_MouseHookManager;
         
        
        private bool IsON = false;
        private ContextMenu mTray;
        Heatmap pHeatmap;
        Table pTable;

        protected void Exit_Click(Object sender, System.EventArgs e)
        {
            Close();
        }

        protected void Show_Click(Object sender, System.EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        protected void SaveEClose_Click(Object sender, System.EventArgs e)
        {
            btSAVE_Click(sender, e);
            this.Dispose();
        }

        private void m_notifyicon_DoubleClick(object Sender, EventArgs e)
        {
            // Show the form when the user double clicks on the notify icon. 

            // Set the WindowState to normal if the form is minimized. 
            if (this.WindowState == FormWindowState.Minimized)
            {
                Show();
                WindowState = FormWindowState.Normal;
            }
        }
    
        public Principal()
        {
            InitializeComponent();
            pHeatmap = new Heatmap();
            pTable = new Table();  
            pCenter.Controls.Add(pHeatmap);
            pCenter.Controls.Add(pTable);
            pHeatmap.Dock = System.Windows.Forms.DockStyle.Fill;
            pTable.Dock = System.Windows.Forms.DockStyle.Fill;

            mTray = new ContextMenu();
            mTray.MenuItems.Add(0, new MenuItem("Show", new System.EventHandler(Show_Click)));
            mTray.MenuItems.Add(1, new MenuItem("Exit", new System.EventHandler(Exit_Click)));
            mTray.MenuItems.Add(1, new MenuItem("Save and Close", new System.EventHandler(SaveEClose_Click)));


            notifyIcon1.DoubleClick += new System.EventHandler(this.m_notifyicon_DoubleClick);
            notifyIcon1.ContextMenu = mTray;
            CreateFile();

         
            m_KeyboardHookManager = new KeyboardHookListener(new GlobalHooker());
            //m_KeyboardHookManager.Enabled = true;

            m_MouseHookManager = new MouseHookListener(new GlobalHooker());
            // m_MouseHookManager.Enabled = true;

            m_MouseHookManager.MouseMove += HookManager_MouseMove;
            m_MouseHookManager.MouseClickExt += HookManager_MouseClick;
            m_MouseHookManager.MouseUp += HookManager_MouseUp;
            m_MouseHookManager.MouseDown += HookManager_MouseDown;
            m_MouseHookManager.MouseDoubleClick += HookManager_MouseDoubleClick;
            m_MouseHookManager.MouseWheel += HookManager_MouseWheel;

            m_KeyboardHookManager.KeyDown += HookManager_KeyDown;
            m_KeyboardHookManager.KeyUp += HookManager_KeyUp;
            m_KeyboardHookManager.KeyPress += HookManager_KeyPress;

            timer1.Start();
        }

        private void CreateFile() { 
           
            Protocol.samples = new Samples();
            DateTime dDate = DateTime.Now;
            //string timestamp, string type, string subType, string x, string y 
            Sample sampling = new Sample(dDate.ToString("yyyy-MM-dd HH:mm:ss.fff"), "NEW_Click", "NEW_Click", Cursor.Position.X, Cursor.Position.Y);
            Protocol.samples.Add(sampling);

            String xmlFileName = dDate.ToString("yyyy-MM-dd_HH-mm-ss");
            Protocol.FILENAME = "[move]" + xmlFileName + ".txt";
            Protocol.SaveAll();
            this.pHeatmap.UpdatePanel();
            this.pHeatmap.BringToFront(); 
        
        }

        private void btnNEW_Click(object sender, EventArgs e)
        { 
            CreateFile();
        }

        private void btSAVE_Click(object sender, EventArgs e)
        {
            this.btSAVE.BackgroundImage = global::Moveability.Properties.Resources.loadingTransparent;
            backgroundWorker1.RunWorkerAsync();
           // saveFileDialog1.FileName = Protocol.FILENAME;

           

            //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //{

            //    if (saveFileDialog1.FileName != "")
            //    {
            //        try
            //        {
            //            if (dsSamples.Tables[0].Rows.Count > 0)
            //            {
            //                Protocol.WriteTxT(dsSamples.Tables[0], saveFileDialog1.FileName);
            //                Process.Start(saveFileDialog1.FileName);
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            Console.WriteLine(ex.Message);
            //        }
            //    }
            //}
        }

        private void btnHeatmap_Click(object sender, EventArgs e)
        {
            this.pHeatmap.UpdatePanel();
            this.pHeatmap.BringToFront(); 
        }
        
        private void btnTable_Click(object sender, EventArgs e)
        {
            this.pTable.UpdatePanel();
            this.pTable.BringToFront(); 
        }


        //##################################################################
        #region Event handlers of particular events. They will be activated when an appropriate checkbox is checked.

        private void HookManager_KeyDown(object sender, KeyEventArgs e)
        { 
            DateTime dDate = DateTime.Now;
            Protocol.AddSample(dDate.ToString("yyyy-MM-dd HH:mm:ss.fff"), "KeyDown", "KeyDown", Cursor.Position.X, Cursor.Position.Y);
        }

        private void HookManager_KeyUp(object sender, KeyEventArgs e)
        { 
            DateTime dDate = DateTime.Now;
            Protocol.AddSample(dDate.ToString("yyyy-MM-dd HH:mm:ss.fff"), "KeyUp", "KeyUp", Cursor.Position.X, Cursor.Position.Y); 
        }


        private void HookManager_KeyPress(object sender, KeyPressEventArgs e)
        { 
            DateTime dDate = DateTime.Now;
            Protocol.AddSample(dDate.ToString("yyyy-MM-dd HH:mm:ss.fff"), "KeyPress", "KeyPress", Cursor.Position.X, Cursor.Position.Y); 
        }


        private void HookManager_MouseMove(object sender, MouseEventArgs e)
        {
            labelMousePosition.Text = string.Format("x={0:0000}; y={1:0000}", e.X, e.Y);
            DateTime dDate = DateTime.Now; 
            Protocol.AddSample(dDate.ToString("yyyy-MM-dd HH:mm:ss.fff"), "MouseMove", "MouseMove", e.X, e.Y); 
        }

        private void HookManager_MouseClick(object sender, MouseEventArgs e)
        { 
            DateTime dDate = DateTime.Now; 
            Protocol.AddSample(dDate.ToString("yyyy-MM-dd HH:mm:ss.fff"), "MouseMove", "MouseMove", e.X, e.Y); 
        }

        private void HookManager_MouseUp(object sender, MouseEventArgs e)
        { 
            DateTime dDate = DateTime.Now; 
            Protocol.AddSample(dDate.ToString("yyyy-MM-dd HH:mm:ss.fff"), "MouseUp", "MouseUp", e.X, e.Y); 
        }


        private void HookManager_MouseDown(object sender, MouseEventArgs e)
        { 
            DateTime dDate = DateTime.Now; 
            Protocol.AddSample(dDate.ToString("yyyy-MM-dd HH:mm:ss.fff"), "MouseDown", "MouseDown", e.X, e.Y); 
        }


        private void HookManager_MouseDoubleClick(object sender, MouseEventArgs e)
        { 
            DateTime dDate = DateTime.Now;
            Protocol.AddSample(dDate.ToString("yyyy-MM-dd HH:mm:ss.fff"), "MouseDoubleClick", "MouseDoubleClick", e.X, e.Y); 
        }


        private void HookManager_MouseWheel(object sender, MouseEventArgs e)
        {
            //lblClock.Text = string.Format("Wheel={0:000}", e.Delta);
            DateTime dDate = DateTime.Now; 
            Protocol.AddSample(dDate.ToString("yyyy-MM-dd HH:mm:ss.fff"), "Wheel", "Wheel", e.X, e.Y); 
        }

        private void HookManager_Supress(object sender, MouseEventExtArgs e)
        {
            if (e.Button != MouseButtons.Right)
            {
                return;
            }
            Log("Suppressed.\n");
            e.Handled = true;
            DateTime dDate = DateTime.Now; 
            Protocol.AddSample(dDate.ToString("yyyy-MM-dd HH:mm:ss.fff"), "RightClick", "Suppressed", Cursor.Position.X, Cursor.Position.Y); 
        }


        #endregion

        
        private void Log(string text)
        {
            //Console.WriteLine(text); 
        }
        
        private void Principal_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        { 
            Protocol.SaveAll(); 
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnHeatmap.Enabled = true;
            btnTable.Enabled = true;
            btnNEW.Enabled = true;
            btSAVE.Enabled = true;
            this.btSAVE.BackgroundImage = global::Moveability.Properties.Resources.Save;
            this.pHeatmap.UpdatePanel();
            this.pHeatmap.BringToFront(); 
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            btnHeatmap.Enabled = false;
            btnTable.Enabled = false;
            btnNEW.Enabled = false;
            btSAVE.Enabled = false; 
        }
        int LastCursorPositionX = Cursor.Position.X;
        int LastCursorPositionY = Cursor.Position.Y; 

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToLongTimeString();
            int CurrCursorPositionX = Cursor.Position.X;
            int CurrCursorPositionY = Cursor.Position.Y;

            if (CurrCursorPositionX == LastCursorPositionX && CurrCursorPositionY == LastCursorPositionY)
            {
                DateTime dDate = DateTime.Now;
                Protocol.AddSample(dDate.ToString("yyyy-MM-dd HH:mm:ss.fff"), "Inativo", "Inativo", CurrCursorPositionX, CurrCursorPositionY); 
     
            }
            LastCursorPositionX = CurrCursorPositionX;
            LastCursorPositionY = CurrCursorPositionY;


        }

        private void btnRec_Click(object sender, EventArgs e)
        {
            if (IsON)
            {
                this.btnRec.BackgroundImage = global::Moveability.Properties.Resources.PlayerRecord;
                this.btnRec.BackColor = System.Drawing.Color.LightGreen;
                m_MouseHookManager.Enabled = false;
                m_KeyboardHookManager.Enabled = false;
                IsON = false;
                this.toolTip1.SetToolTip(this.btnRec, "gravar no arquivo");
            }
            else
            {
                if (Protocol.FILENAME == null) { btnNEW_Click(sender, e); }
                this.btnRec.BackgroundImage = global::Moveability.Properties.Resources.PlayerPause;
                this.btnRec.BackColor = System.Drawing.Color.White;
                m_MouseHookManager.Enabled = true;
                m_KeyboardHookManager.Enabled = true;
                IsON = true;

                this.toolTip1.SetToolTip(this.btnRec, "parar gravação no arquivo");
            }
        }

        

    }
}
