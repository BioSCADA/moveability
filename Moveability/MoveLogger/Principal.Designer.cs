namespace Moveability
{
    partial class Principal
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
            m_MouseHookManager.Enabled = true;
            m_KeyboardHookManager.Enabled = true;

            if (disposing && (components != null))
            {
                components.Dispose();
               
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelMousePosition = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnHeatmap = new System.Windows.Forms.Button();
            this.btnNEW = new System.Windows.Forms.Button();
            this.btSAVE = new System.Windows.Forms.Button();
            this.btnTable = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRec = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pCenter = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mouseKeyEventProvider1 = new MouseKeyboardActivityMonitor.Controls.MouseKeyEventProvider();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMousePosition
            // 
            this.labelMousePosition.AutoSize = true;
            this.labelMousePosition.BackColor = System.Drawing.Color.Transparent;
            this.labelMousePosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMousePosition.Font = new System.Drawing.Font("Myriad Web Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMousePosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(150)))), ((int)(((byte)(95)))));
            this.labelMousePosition.Location = new System.Drawing.Point(3, 0);
            this.labelMousePosition.Name = "labelMousePosition";
            this.labelMousePosition.Size = new System.Drawing.Size(197, 56);
            this.labelMousePosition.TabIndex = 2;
            this.labelMousePosition.Text = "x={0:####}   y={1:####}";
            this.labelMousePosition.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.toolTip1.SetToolTip(this.labelMousePosition, "posição do ponteiro do mouse");
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.BackColor = System.Drawing.Color.Transparent;
            this.lblClock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblClock.Font = new System.Drawing.Font("Myriad Web Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(150)))), ((int)(((byte)(95)))));
            this.lblClock.Location = new System.Drawing.Point(206, 0);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(198, 56);
            this.lblClock.TabIndex = 6;
            this.lblClock.Text = "TIME";
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.toolTip1.SetToolTip(this.lblClock, "tempo");
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPlay.BackgroundImage = global::Moveability.Properties.Resources.PlayerPlay;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Myriad Web Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.Transparent;
            this.btnPlay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlay.Location = new System.Drawing.Point(205, 3);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(95, 58);
            this.btnPlay.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnPlay, "gravar no arquivo");
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Visible = false;
            // 
            // btnHeatmap
            // 
            this.btnHeatmap.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHeatmap.BackgroundImage = global::Moveability.Properties.Resources.Stats3;
            this.btnHeatmap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHeatmap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHeatmap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHeatmap.FlatAppearance.BorderSize = 0;
            this.btnHeatmap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeatmap.ForeColor = System.Drawing.Color.Transparent;
            this.btnHeatmap.Location = new System.Drawing.Point(185, 3);
            this.btnHeatmap.Name = "btnHeatmap";
            this.btnHeatmap.Size = new System.Drawing.Size(85, 71);
            this.btnHeatmap.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnHeatmap, "mostrar heatmap do arquivo salvo");
            this.btnHeatmap.UseVisualStyleBackColor = false;
            this.btnHeatmap.Click += new System.EventHandler(this.btnHeatmap_Click);
            // 
            // btnNEW
            // 
            this.btnNEW.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNEW.BackgroundImage = global::Moveability.Properties.Resources.DocumentNew;
            this.btnNEW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNEW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNEW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNEW.FlatAppearance.BorderSize = 0;
            this.btnNEW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNEW.Font = new System.Drawing.Font("Myriad Web Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNEW.ForeColor = System.Drawing.Color.Transparent;
            this.btnNEW.Location = new System.Drawing.Point(3, 3);
            this.btnNEW.Name = "btnNEW";
            this.btnNEW.Size = new System.Drawing.Size(85, 71);
            this.btnNEW.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnNEW, "criar novo arquivo de log");
            this.btnNEW.UseVisualStyleBackColor = false;
            this.btnNEW.Click += new System.EventHandler(this.btnNEW_Click);
            // 
            // btSAVE
            // 
            this.btSAVE.BackColor = System.Drawing.Color.SteelBlue;
            this.btSAVE.BackgroundImage = global::Moveability.Properties.Resources.Save;
            this.btSAVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btSAVE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSAVE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btSAVE.FlatAppearance.BorderSize = 0;
            this.btSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSAVE.Font = new System.Drawing.Font("Myriad Web Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSAVE.ForeColor = System.Drawing.Color.Transparent;
            this.btSAVE.Location = new System.Drawing.Point(94, 3);
            this.btSAVE.Name = "btSAVE";
            this.btSAVE.Size = new System.Drawing.Size(85, 71);
            this.btSAVE.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btSAVE, "salvar arquivo");
            this.btSAVE.UseVisualStyleBackColor = false;
            this.btSAVE.Click += new System.EventHandler(this.btSAVE_Click);
            // 
            // btnTable
            // 
            this.btnTable.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTable.BackgroundImage = global::Moveability.Properties.Resources.Table;
            this.btnTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTable.FlatAppearance.BorderSize = 0;
            this.btnTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTable.ForeColor = System.Drawing.Color.Transparent;
            this.btnTable.Location = new System.Drawing.Point(276, 3);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(86, 71);
            this.btnTable.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnTable, "mostrar tabela do arquivo salvo");
            this.btnTable.UseVisualStyleBackColor = false;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.BackgroundImage = global::Moveability.Properties.Resources.PlayerStop;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Myriad Web Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(104, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 58);
            this.button1.TabIndex = 1;
            this.toolTip1.SetToolTip(this.button1, "gravar no arquivo");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // btnRec
            // 
            this.btnRec.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRec.BackgroundImage = global::Moveability.Properties.Resources.PlayerRecord;
            this.btnRec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRec.FlatAppearance.BorderSize = 0;
            this.btnRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRec.Font = new System.Drawing.Font("Myriad Web Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRec.ForeColor = System.Drawing.Color.Transparent;
            this.btnRec.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRec.Location = new System.Drawing.Point(306, 3);
            this.btnRec.Name = "btnRec";
            this.btnRec.Size = new System.Drawing.Size(98, 58);
            this.btnRec.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnRec, "gravar no arquivo");
            this.btnRec.UseVisualStyleBackColor = false;
            this.btnRec.Click += new System.EventHandler(this.btnRec_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.BackgroundImage = global::Moveability.Properties.Resources.PlayerPause;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Myriad Web Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 58);
            this.button3.TabIndex = 3;
            this.toolTip1.SetToolTip(this.button3, "gravar no arquivo");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Mouse And Key Logger";
            this.notifyIcon1.BalloonTipTitle = "Mouse And Key Logger";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Mouse And Key Logger";
            this.notifyIcon1.Visible = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 413F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pCenter, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 562);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.button3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnRec, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnPlay, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(374, 495);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(407, 64);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.labelMousePosition, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblClock, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(374, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(407, 77);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel3.Controls.Add(this.btnHeatmap, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnNEW, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btSAVE, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnTable, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(365, 77);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // pCenter
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pCenter, 2);
            this.pCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCenter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pCenter.Location = new System.Drawing.Point(3, 86);
            this.pCenter.Name = "pCenter";
            this.pCenter.Size = new System.Drawing.Size(778, 403);
            this.pCenter.TabIndex = 15;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mouseKeyEventProvider1
            // 
            this.mouseKeyEventProvider1.Enabled = false;
            this.mouseKeyEventProvider1.HookType = MouseKeyboardActivityMonitor.Controls.HookType.Global;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.Text = "Mouseability";
            this.Resize += new System.EventHandler(this.Principal_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelMousePosition;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnHeatmap;
        private System.Windows.Forms.Button btnNEW;
        private System.Windows.Forms.Button btSAVE;
        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.Panel pCenter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private MouseKeyboardActivityMonitor.Controls.MouseKeyEventProvider mouseKeyEventProvider1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnRec;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}