﻿using Spire.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DeleteLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Load the document from disk
            PdfDocument doc = new PdfDocument();
            doc.LoadFromFile(@"..\..\..\..\..\..\Data\DeleteLayer.pdf");

            //Delete the "red line" layer
            doc.Layers.RemoveLayer("red line");

            //Save the document
            doc.SaveToFile("Output.pdf");

            //View the Pdf file
            PDFDocumentViewer("Output.pdf");
        }
        private void PDFDocumentViewer(string fileName)
        {
            try
            {
                System.Diagnostics.Process.Start(fileName);
            }
            catch { }
        }
    }
}
