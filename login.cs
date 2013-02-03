using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MedicalStore
{
    public partial class LogIn : Form
    {
        Database db = new Database();
        DataTable dt = new DataTable();
        public LogIn()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {

            DataTable dt;
            dt = db.Displaygrid("select * from LoginMaster where UserName='" + UsernameTextBox.Text + "' and Password='" + PasswordTextBox.Text + "'");
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                Master m = new Master();
                m.Show();

            }
            else
            {
                db.message("Wrong Username and Password");
            } 


        }

        private void Cancel_Click(object sender, EventArgs e)
        {
           
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
        

        

       
    }
}
