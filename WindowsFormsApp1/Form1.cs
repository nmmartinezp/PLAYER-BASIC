using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private OpenFileDialog opf;
        private FolderBrowserDialog fbd;
        private string rutaCarpeta = string.Empty;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            opf = null;
            opf = new OpenFileDialog();
            
            if (opf.ShowDialog() == DialogResult.OK)
            {
                NameMusic.Items.Clear();
                
                Player.currentMedia = Player.newMedia(opf.FileName);

                NameMusic.Items.Add(opf.SafeFileName);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.play();
        }

        private void btnpause_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.pause();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Player.uiMode = "none";
            Player.settings.autoStart = false;
        }

        private void btnAddDic_Click(object sender, EventArgs e)
        {
            fbd = null;
            fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                ListMusic.Items.Clear();

                rutaCarpeta = fbd.SelectedPath;

                DirectoryInfo info = new DirectoryInfo(fbd.SelectedPath);

                foreach(var Dato in info.GetFiles())
                {
                    ListMusic.Items.Add(Dato.Name);
                }
            }
        }
    }
}
