using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace Moveability
{
    public partial class Table : UserControl
    {
        private BackgroundWorker worker = new BackgroundWorker();
        DataSet ds = new DataSet();
        public Table()
        {
            InitializeComponent(); 
        }
        
        internal void UpdatePanel()
        {
            try
            {
                if (Protocol.samples.Count > 0)
                {
                    ds.Clear();
                    ds.ReadXml(Protocol.FILENAME, XmlReadMode.InferSchema);
                    this.xmlFileGridView.DataSource = ds.Tables[0].DefaultView;
                    this.xmlFileGridView.Update();
                    xmlFileGridView.Enabled = true;
                    this.Enabled = true;
                    this.Validate();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
