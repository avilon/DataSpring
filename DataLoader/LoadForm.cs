using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataLoader
{
    public partial class LoadForm : Form
    {
        public LoadForm()
        {
            InitializeComponent();
        }

        private void Execute()
        {
        }

        private void btnChoice_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void LoadForm_Load(object sender, EventArgs e)
        {
            this.Top = Properties.Settings.Default.LoadForm_Top;
            this.Left = Properties.Settings.Default.LoadForm_Left;
            this.Width = Properties.Settings.Default.LoadForm_Width;
            this.Height = Properties.Settings.Default.LoadForm_Height;
            this.tbPath.Text = Properties.Settings.Default.DB_Path;
        }

        private void LoadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.LoadForm_Top = this.Top;
            Properties.Settings.Default.LoadForm_Left = this.Left;
            Properties.Settings.Default.LoadForm_Width = this.Width;
            Properties.Settings.Default.LoadForm_Height = this.Height;
            Properties.Settings.Default.DB_Path = this.tbPath.Text;
            Properties.Settings.Default.Save();
        }
    }
}
