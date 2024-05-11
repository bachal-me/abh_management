using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABH
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Validate username and password (you can replace this with your logic)
            if (username == "manager" && password == "manager123")
            {
                // Redirect to manager's home page
                // Example: open a new form or change the current form
                ManagerHomeForm managerForm = new ManagerHomeForm();
                this.Hide();
                managerForm.Show();
            }
            else if (username == "warden" && password == "warden123")
            {
                // Redirect to warden's home page
                // Example: open a new form or change the current form
                WardenHomeForm wardenForm = new WardenHomeForm();
                this.Hide();
                wardenForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }
    }
}
