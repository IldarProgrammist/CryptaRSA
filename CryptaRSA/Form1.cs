using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptaRSA.Clasess;

namespace CryptaRSA
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private SettingsUser _settingsUser = null;
        public Form1()
        {
            InitializeComponent();
            _settingsUser  = SettingsUser.GetSettingsUser();
            _initControlls();
        }

        private void _initControlls()
        {
            LoginTB.Text = _settingsUser.Login;
            passWordTB.Text = _settingsUser.GetPassWord();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            _settingsUser.Login = LoginTB.Text;
            _settingsUser.SetPassWord(passWordTB.Text);

            _settingsUser.Save();
        }
    }
}
