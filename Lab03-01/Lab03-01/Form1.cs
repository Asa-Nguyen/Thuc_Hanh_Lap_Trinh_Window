<<<<<<< HEAD
namespace Lab03_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = string.Format("Hôm nay là ngày {0} - Bây giờ là {1}", DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("hh:mm:ss tt"));
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "AVI file | *.avi | MPEG File | *.mpeg | Wav File | *.Wav | Midi File | *midi | MP3 | *.mp3 | MP4 File | *.mp4";
            if(dlg.ShowDialog () == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = dlg.FileName;
            }
        }
    }
}
>>>>>>> c29ed36222dd8190ff702d639482ca40ef934ad0
