﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Web;
using System.Security.Cryptography.X509Certificates;

namespace lbaora2
{
    public partial class Form1 : Form
    {
        string name = "";
        string filename = "";
        DataSet dataSet = new DataSet();
        string Select1;
        OleDbConnection StrCon;
        OleDbCommand command1;
        OleDbDataAdapter adapt1;

        public Form1()
        {
            InitializeComponent();
            
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            dataGridView1.DataSource = Data.students;

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* OpenFileDialog f1=new OpenFileDialog();
            if(f1.ShowDialog() != DialogResult.Cancel)
            {
                try
                {
                    if (f1.FileName != null)
                    {
                        name = f1.FileName.Remove(f1.FileName.LastIndexOf("\\"));
                        filename = f1.FileName.Remove(0, f1.FileName.LastIndexOf("\\") + 1);
                        Select1 = "SELECT * FROM[" + filename + "]";
                        StrCon = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + name + ";Extended Propereties=text");
                        command1 = new OleDbCommand(Select1, StrCon);
                        adapt1 = new OleDbDataAdapter(command1);
                        StrCon.Open();
                        adapt1.Fill(dataSet);
                        dataGridView1.DataSource = dataSet.Tables[0];
                        StrCon.Close();
                    }
                }
                 catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                    
            }
        */}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
