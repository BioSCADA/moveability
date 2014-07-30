/*M///////////////////////////////////////////////////////////////////////////////////////
//
//  IMPORTANT: READ BEFORE DOWNLOADING, COPYING, INSTALLING OR USING.
//
//  By downloading, copying, installing or using the software you agree to this license.
//  If you do not agree to this license, do not download, install,
//  copy or use the software.
//
//
//                            BioSCADA® License Agreement
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
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Moveability
{
    class Protocol
    {
        private static Protocol instance; 
        
        internal static Samples samples = new Samples();

        internal static string FILENAME { get; set; }

        internal static void WriteTxT(DataTable dt, string filePath)
        {
            int i = 0;
            StreamWriter sw = null;

            try
            {

                sw = new StreamWriter(filePath, false);

                for (i = 0; i < dt.Columns.Count - 1; i++)
                {

                    sw.Write(dt.Columns[i].ColumnName + (char)9);

                }
                sw.Write(dt.Columns[i].ColumnName);
                sw.WriteLine();

                foreach (DataRow row in dt.Rows)
                {
                    object[] array = row.ItemArray;

                    for (i = 0; i < array.Length - 1; i++)
                    {
                        sw.Write(array[i].ToString() + (char)9);
                    }
                    sw.Write(array[i].ToString());
                    sw.WriteLine();

                }

                sw.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Operação invalida WriteTxT: \n" + ex.ToString());
            }
        }
         
        internal Protocol() 
       {
       
       }

        public static Protocol Instance
       {
          get 
          {
             if (instance == null)
             {
                 instance = new Protocol();
             }
             return instance;
          }
       }

        internal static void AddSample(string p1, string p2, string p3, int p4, int p5)
        { 
            
            Sample sampling = new Sample(p1, p2, p3, Math.Abs(p4), Math.Abs(p5));
            samples.Add(sampling);
        }
       
        private string GetTextFromXMLFile()
        {
            StreamReader reader = new StreamReader(Protocol.FILENAME);
            string ret = reader.ReadToEnd();
            reader.Close();
            return ret;
        }
        
        internal static string CreateXMLAndGetFilename()
        {

            Protocol.samples.CollectionName = "Samples";
            Type[] extraTypes = new Type[1];
            extraTypes[0] = typeof(int);
            XmlRootAttribute root = new XmlRootAttribute("Samples");
            XmlAttributeOverrides attrOverrides = new XmlAttributeOverrides();
            XmlAttributes attrs = new XmlAttributes();
            XmlSerializer xml = new XmlSerializer(typeof(Samples), attrOverrides, extraTypes, root, "http://www.educacaocerebral.org");

            try
            {
                TextWriter writer = new StreamWriter(Protocol.FILENAME);
                xml.Serialize(writer, Protocol.samples);
                writer.Close(); 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return Protocol.FILENAME;
        }
        
        internal static void SaveAll( )
        {
             if (samples.Count > 0)  {
                CreateXMLAndGetFilename(); 
             }
        }

      
    }
}
