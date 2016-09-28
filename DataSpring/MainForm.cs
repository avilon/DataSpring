using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSpring
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            string dllPath = System.IO.Directory.GetCurrentDirectory();
            dllPath += "\\DataLoader.dll";
            Assembly assembly = Assembly.LoadFile(dllPath);
            Type type = assembly.GetType("DataLoader.LoadForm");
            Form form = (Form)Activator.CreateInstance(type);
            form.ShowDialog(); // Or Application.Run(form)
        }

        /*
         * 
         */
 
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Top = Properties.Settings.Default.MainForm_Top;
            this.Left = Properties.Settings.Default.MainForm_Left;
            this.Width = Properties.Settings.Default.MainForm_Width;
            this.Height = Properties.Settings.Default.MainForm_Height;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.MainForm_Top = this.Top;
            Properties.Settings.Default.MainForm_Left = this.Left;
            Properties.Settings.Default.MainForm_Width = this.Width;
            Properties.Settings.Default.MainForm_Height = this.Height;
            Properties.Settings.Default.Save();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
