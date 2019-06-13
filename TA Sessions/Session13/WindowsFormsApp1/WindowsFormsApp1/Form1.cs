using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = textBox1.Text.Length.ToString();
            textBox2.Text = string.Format("Input : \r\n${0} \r\nNumber Of Char : \r\n#{1}", textBox1.Text , textBox3.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //FileController fileController = new FileController();
            FileSave fileController = new FileSave();
            bool res = fileController.Save(string.Format("Input : \r\n${0} \r\nNumber Of Char : \r\n#{1}", textBox1.Text, textBox3.Text));
            if (res)
            {
                MessageBox.Show("Save Successfully!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName;
                DialogResult result; // result of SaveFileDialog 
                using (SaveFileDialog fileChooser = new SaveFileDialog())
                {
                    fileChooser.CheckFileExists = false; // let user create file 

                    result = fileChooser.ShowDialog();
                    fileName = fileChooser.FileName;
                    // name of file to save data 
                } // end using
                //FileController fileController = new FileController();
                FileSaveAs fileController = new FileSaveAs();
                bool res = fileController.Save(string.Format("Input : \r\n${0} \r\nNumber Of Char : \r\n#{1}", textBox1.Text, textBox3.Text), fileName);
                if (res)
                {
                    MessageBox.Show("Save Successfully!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }          

        }
    }
}
