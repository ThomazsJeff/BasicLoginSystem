using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BasicLoginSystem
{
    public partial class Form2 : Form
    {
        Thread principal;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            principal = new Thread(OpenPrin);
            principal.SetApartmentState(ApartmentState.STA);
            principal.Start();
        }

        private void OpenPrin(object obj)
        {
            Application.Run(new Form1());
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Show the user data
            lbluser.Text = Global.USERNAME_;
            lblpass.Text = Global.PASSWORD_;
        }
    }
}
