/*M///////////////////////////////////////////////////////////////////////////////////////
//
//  IMPORTANT: READ BEFORE DOWNLOADING, COPYING, INSTALLING OR USING.
//
//  By downloading, copying, installing or using the software you agree to this license.
//  If you do not agree to this license, do not download, install,
//  copy or use the software.
//
//
//                           BioSCADA® License Agreement
//                For Open Source Human SCADA Library  
//
// Copyright (C) 2011-2014, Diego Schmaedech for this and Many Others Developers around the worlds for all, all rights reserved. 
//
//							For Open Source Human SCADA aplications
//
// Copyright (C) 2011-2014, Prof. Dr. Emílio Takase, Laboratório de Educação Cerebral, all rights reserved.
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
namespace Moveability
{
    partial class Heatmap
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInative = new System.Windows.Forms.Button();
            this.btnClicks = new System.Windows.Forms.Button();
            this.btnMoves = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInative
            // 
            this.btnInative.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(84)))), ((int)(((byte)(39)))));
            this.btnInative.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInative.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInative.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInative.FlatAppearance.BorderSize = 0;
            this.btnInative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInative.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInative.ForeColor = System.Drawing.Color.Transparent;
            this.btnInative.Image = global::Moveability.Properties.Resources.Cancel;
            this.btnInative.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInative.Location = new System.Drawing.Point(3, 3);
            this.btnInative.Name = "btnInative";
            this.btnInative.Size = new System.Drawing.Size(120, 32);
            this.btnInative.TabIndex = 3;
            this.btnInative.Text = "inativo";
            this.btnInative.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInative.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInative.UseVisualStyleBackColor = false;
            this.btnInative.Click += new System.EventHandler(this.btnInative_Click);
            // 
            // btnClicks
            // 
            this.btnClicks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(84)))), ((int)(((byte)(39)))));
            this.btnClicks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClicks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClicks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClicks.FlatAppearance.BorderSize = 0;
            this.btnClicks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClicks.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClicks.ForeColor = System.Drawing.Color.Transparent;
            this.btnClicks.Image = global::Moveability.Properties.Resources.Cancel;
            this.btnClicks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClicks.Location = new System.Drawing.Point(3, 41);
            this.btnClicks.Name = "btnClicks";
            this.btnClicks.Size = new System.Drawing.Size(120, 32);
            this.btnClicks.TabIndex = 2;
            this.btnClicks.Text = "click";
            this.btnClicks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClicks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClicks.UseVisualStyleBackColor = false;
            this.btnClicks.Click += new System.EventHandler(this.btnClicks_Click);
            // 
            // btnMoves
            // 
            this.btnMoves.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(84)))), ((int)(((byte)(39)))));
            this.btnMoves.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMoves.FlatAppearance.BorderSize = 0;
            this.btnMoves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoves.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoves.ForeColor = System.Drawing.Color.Transparent;
            this.btnMoves.Image = global::Moveability.Properties.Resources.Ok;
            this.btnMoves.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoves.Location = new System.Drawing.Point(3, 79);
            this.btnMoves.Name = "btnMoves";
            this.btnMoves.Size = new System.Drawing.Size(120, 34);
            this.btnMoves.TabIndex = 1;
            this.btnMoves.Text = "move";
            this.btnMoves.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMoves.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMoves.UseVisualStyleBackColor = false;
            this.btnMoves.Click += new System.EventHandler(this.btnMoves_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Moveability.Properties.Resources.koanbg2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(908, 424);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnInative, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMoves, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnClicks, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(782, 166);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(126, 116);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // Heatmap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Heatmap";
            this.Size = new System.Drawing.Size(908, 424);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMoves;
        private System.Windows.Forms.Button btnClicks;
        private System.Windows.Forms.Button btnInative;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
