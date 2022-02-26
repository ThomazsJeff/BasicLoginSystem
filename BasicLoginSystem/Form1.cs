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
    public partial class Form1 : Form
    {
        Thread secondwin;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Login system
            if (tbuser.Text == Global.USERNAME_ && tbpass.Text == Global.PASSWORD_)
            {
                this.Close();
                secondwin = new Thread(OpenWin);
                secondwin.SetApartmentState(ApartmentState.STA);
                secondwin.Start();
            }
            //Warning
            else if (tbuser.Text != Global.USERNAME_ || tbpass.Text != Global.PASSWORD_)
            {
                lblwarning.Text = "Some informations are empty, wrong or you don't have an account.\n Please fill them in and try again";
            }

        }

        private void OpenWin(object obj)
        {
            Application.Run(new Form2());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Hide the create account screen
            userControl11.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Show the create account screen
            userControl11.Show();
        }

    }
}
