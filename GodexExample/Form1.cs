using System.Drawing.Printing;
using System.Windows.Forms;
using System.Diagnostics;
using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using System.Data;
using System.Collections.Generic;


using System.Drawing.Printing;
using System.Text;

namespace GodexExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PrinterList();
        }

        private void PrinterFindButton_Click(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Now;
            dayoftimetextbox.Text = bugun.ToShortDateString();
            
           PrintBarcode(qrcodetextbox.Text, dayoftimetextbox.Text, productnametextbox.Text, qrcodetextbox.TextLength.ToString());
        }
    
        private void PrinterList()
        {
            foreach (string sPrinters  in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                listBox1.Items.Add(sPrinters);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBox1.SelectedItem.ToString();
            printername.Text=curItem;
        }

        public void PrintBarcode(String L1, String L2, String L3, String L4)
        {
            String tempFile = "C:\\PrnTmp\\Temp.prn";
            String PrinterName = printername.Text;
            StreamReader SR = new StreamReader(tempFile, Encoding.Default);
            String all = SR.ReadToEnd();
            SR.Close();

            all = all.Replace("*Line1*", L1);
            all = all.Replace("*Line2*", L2);
            all = all.Replace("*Line3*", L3);
            all = all.Replace("*Line4*", L4);

           
            if (RawPrinterHelper.SendStringToPrinter(PrinterName, all))
            {
                System.Windows.Forms.MessageBox.Show("Succes");
            }
        }
    }   
}