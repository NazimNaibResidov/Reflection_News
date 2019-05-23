using ReflectionAppUI.Core;
using System;
using System.Windows.Forms;

namespace ReflectionAppUI
{
    public partial class Form1 : Form
    {
        ApplicationProvider ApplicationProvider;
       
        public Form1()
        {
            InitializeComponent();
            Tools.Copy();
            ApplicationProvider = new ApplicationProvider(groupBox1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path=  ApplicationPath.GetPath("libs");
            ApplicationProvider.Loader(path);
        }
    }
}
