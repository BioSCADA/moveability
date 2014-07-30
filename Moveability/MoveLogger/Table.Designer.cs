
namespace Moveability
{
    partial class Table
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
            this.xmlFileGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.xmlFileGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // xmlFileGridView
            // 
            this.xmlFileGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.xmlFileGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xmlFileGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.xmlFileGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.xmlFileGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xmlFileGridView.Location = new System.Drawing.Point(0, 0);
            this.xmlFileGridView.Name = "xmlFileGridView";
            this.xmlFileGridView.Size = new System.Drawing.Size(622, 268);
            this.xmlFileGridView.TabIndex = 1;
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.xmlFileGridView);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Table";
            this.Size = new System.Drawing.Size(622, 268);
            ((System.ComponentModel.ISupportInitialize)(this.xmlFileGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView xmlFileGridView;
    }
}
