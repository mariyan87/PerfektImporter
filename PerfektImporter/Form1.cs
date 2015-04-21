using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PerfektImporter
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private string _sourceText = "";
        private string _formatedXML = "";

        public Form1()
        {
            InitializeComponent();

            InitControls();

        }

        private void InitControls()
        {
            openFileDialog1.Filter = "Text Files (.txt)|*.txt";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;
            openFileDialog1.FileName = "";

            recDescription.Text = Common.DESCRIPTION;

            rgrBuySell.Properties.Items.Add(new DevExpress.XtraEditors.Controls.RadioGroupItem(BuySell.Buy, "покупки"));
            rgrBuySell.Properties.Items.Add(new DevExpress.XtraEditors.Controls.RadioGroupItem(BuySell.Sell, "продажби"));
            rgrBuySell.EditValue = BuySell.Sell;

            List<XmlColumnFormat> xmlColumnFormats = new List<XmlColumnFormat>() { 
                new XmlColumnFormat(){XmlTag= XmlTags.ACCDATE, StartIndex= 15,Length= 6},
                new XmlColumnFormat(){XmlTag= XmlTags.DOCDATE,StartIndex= 62, Length=10},
                new XmlColumnFormat(){XmlTag= XmlTags.PERFORMER,StartIndex= 87,Length= 50},
                new XmlColumnFormat(){XmlTag= XmlTags.SUBJECT, StartIndex=137,Length= 41},
                new XmlColumnFormat(){XmlTag= XmlTags.BULSTAT,StartIndex= 2,Length= 9},
                new XmlColumnFormat(){XmlTag= XmlTags.BGBULSTAT,StartIndex= 0,Length= 11},
                new XmlColumnFormat(){XmlTag= XmlTags.BRUTO,StartIndex= 182,Length= 15},
                new XmlColumnFormat(){XmlTag= XmlTags.FEE,StartIndex= 197, Length=15}
            };
            gcXmlTags.DataSource = xmlColumnFormats;
            gvXmlTags.Columns[0].FieldName = "XmlTag";
            gvXmlTags.Columns[1].FieldName = "StartIndex";
            gvXmlTags.Columns[2].FieldName = "Length";

            InitEncodings();

            bwOpenTxt.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
            bwOpenTxt.DoWork += new DoWorkEventHandler(bwTxt_DoWork);

            bwXml.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bwXML_RunWorkerCompleted);
            bwXml.DoWork += new DoWorkEventHandler(bwXML_DoWork);
        }

        private void InitEncodings()
        {
            foreach (EncodingInfo ei in Encoding.GetEncodings())
            {
                Encoding e = ei.GetEncoding();

                if (e.IsBrowserDisplay && e.IsBrowserSave && e.IsMailNewsDisplay)
                {
                    cbEncodings.Properties.Items.Add(ei.Name);
                    cbEncodingTxt.Properties.Items.Add(ei.Name);
                }
            }

            cbEncodings.EditValue = "windows-1251";
            cbEncodingTxt.EditValue = "windows-1251";
        }

        private void bbiOpenTxt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ResetValues();

            // Process input if the user clicked OK.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName == "")
                {
                    MessageBox.Show("Моля, изберете входящ TXT файл!");
                    return;
                }

                bwOpenTxt.RunWorkerAsync(cbEncodingTxt.SelectedItem);
            }
        }

        private void ResetValues()
        {
            openFileDialog1.FileName = "";
            _sourceText = "";
            _formatedXML = "";
            recTxt.Text = "";
            recXML.Text = "";
        }

        void bwXML_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("Error on generating XML :" + Environment.NewLine + e.Error);
                return;
            }

            _formatedXML = e.Result.ToString();
            recXML.Text = _formatedXML;
        }

        void bwXML_DoWork(object sender, DoWorkEventArgs e)
        {
            BuySell buySell = (BuySell)rgrBuySell.EditValue;
            PerfektTXTImporter txtImporter = new PerfektTXTImporter((List < XmlColumnFormat >) gcXmlTags.DataSource, cbDateFormats.EditValue.ToString());
            e.Result = txtImporter.GenerateXML(buySell, _sourceText, nudStartNum.Value);
        }

        void bwTxt_DoWork(object sender, DoWorkEventArgs e)
        {
            string encoding = e.Argument.ToString();
            _sourceText = File.ReadAllText(openFileDialog1.FileName, Encoding.GetEncoding(encoding));
        }

        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                if (e.Error is IOException || e.Error is FileNotFoundException || e.Error is IOException)
                {
                    MessageBox.Show("Error on reading data from file");
                }
                else
                {
                    MessageBox.Show("Error :" + Environment.NewLine + e.Error);
                }

                return;
            }

            recTxt.Text = _sourceText;
            _formatedXML = "";
            recXML.Text = _formatedXML;
            tbLoadedTxtFilename.Text = openFileDialog1.FileName;
        }

        private void bbiGenerateXML_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (openFileDialog1.FileName == "")
            {
                MessageBox.Show("Моля, изберете входящ TXT файл!");
                return;
            }

            if (((List<XmlColumnFormat>)gcXmlTags.DataSource).Count == 0)
            {
                MessageBox.Show("Въведете описание на колоните!");
                return;
            }

            bwXml.RunWorkerAsync();
        }
    }
}
