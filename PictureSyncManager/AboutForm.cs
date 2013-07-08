using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureSyncManager
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            linkLabel1.Links.Add(0,25,"mailto:kotlarz.mateusz@gmail.com");
            linkLabel2.Links.Add(0, 17, "https://github.com/rampler/PictureSyncManager"); //TODO
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            About.ActiveForm.Close();
        }
    }
}
