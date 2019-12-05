using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicBedTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] filePath = (string[])e.Data.GetData(DataFormats.FileDrop);

            string addrImage = filePath[0];
        }

        private void btn_saveImage_Click(object sender, EventArgs e)
        {
            Image img;
            if(System.Windows.Forms.Clipboard.ContainsImage())
            {
                img = System.Windows.Forms.Clipboard.GetImage();
                picBox.Image = img;
            }
            else
            {
                this.toolStripStatusLabel.Text = "";
                this.toolStripStatusLabel.Text = "there is not an image in clipboard!";
            }
        }
    }
}
