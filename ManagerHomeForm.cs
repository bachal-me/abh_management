using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABH
{
    public partial class ManagerHomeForm : Form
    {
        public ManagerHomeForm()
        {
            InitializeComponent();
            InitializeFullScreenMode();
            btnnewhosteler.BackColor = Color.Red;
            btnnewhosteler.ForeColor = Color.White;
        }
        private void InitializeFullScreenMode()
        {
            // Set form properties
           // this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            // Hide the taskbar
            this.TopMost = true;
        }
        private void allHostelersControl1_Load(object sender, EventArgs e)
        {

        }

        private void btnnewhosteler_Click(object sender, EventArgs e)
        {
            // Change the button's background color after it's clicked
            btnnewhosteler.BackColor = Color.Red;
            btnnewhosteler.ForeColor = Color.White;
            btnallhostelelers.BackColor = Color.White;
            btnallhostelelers.ForeColor = Color.Black;
            btnManageRooms.BackColor = Color.White;
            btnManageRooms.ForeColor = Color.Black;
            btnPayRent.BackColor = Color.White;
            btnPayRent.ForeColor = Color.Black;
            btnNewEmp.BackColor = Color.White;
            btnNewEmp.ForeColor = Color.Black;
            btnAllEmp.BackColor = Color.White;
            btnAllEmp.ForeColor = Color.Black;
            allHostelersControl1.Hide();
            manageRoomsControl1.Hide();
            payRent1.Hide();
            newEmployeeControl1.Hide();
            allEmployeesControl1.Hide();
            newHostelerControl1.Show();
            newHostelerControl1.BringToFront();
        }

        private void btnallhostelelers_Click(object sender, EventArgs e)
        {
            btnnewhosteler.BackColor = Color.White;
            btnnewhosteler.ForeColor = Color.Black;
            btnallhostelelers.BackColor = Color.Red;
            btnallhostelelers.ForeColor = Color.White;
            btnManageRooms.BackColor = Color.White;
            btnManageRooms.ForeColor = Color.Black;
            btnPayRent.BackColor = Color.White;
            btnPayRent.ForeColor = Color.Black;
            btnNewEmp.BackColor = Color.White;
            btnNewEmp.ForeColor = Color.Black;
            btnAllEmp.BackColor = Color.White;
            btnAllEmp.ForeColor = Color.Black;

            newHostelerControl1.Hide();
            manageRoomsControl1.Hide();
            payRent1.Hide();
            newEmployeeControl1.Hide();
            allEmployeesControl1.Hide();
            allHostelersControl1.Show();
            allHostelersControl1.BringToFront();
        }

        private void btnManageRooms_Click(object sender, EventArgs e)
        {
            btnnewhosteler.BackColor = Color.White;
            btnnewhosteler.ForeColor = Color.Black;
            btnallhostelelers.BackColor = Color.White;
            btnallhostelelers.ForeColor = Color.Black;
            btnManageRooms.BackColor = Color.Red;
            btnManageRooms.ForeColor = Color.White;
            btnPayRent.BackColor = Color.White;
            btnPayRent.ForeColor = Color.Black;
            btnNewEmp.BackColor = Color.White;
            btnNewEmp.ForeColor = Color.Black;
            btnAllEmp.BackColor = Color.White;
            btnAllEmp.ForeColor = Color.Black;

            newHostelerControl1.Hide();
            allHostelersControl1.Hide();
            newEmployeeControl1.Hide();
            payRent1.Hide();
            allEmployeesControl1.Hide();
            manageRoomsControl1.Show();
            manageRoomsControl1.BringToFront();
        }

        private void btnPayRent_Click(object sender, EventArgs e)
        {
            btnnewhosteler.BackColor = Color.White;
            btnnewhosteler.ForeColor = Color.Black;
            btnallhostelelers.BackColor = Color.White;
            btnallhostelelers.ForeColor = Color.Black;
            btnManageRooms.BackColor = Color.White;
            btnManageRooms.ForeColor = Color.Black;
            btnPayRent.BackColor = Color.Red;
            btnPayRent.ForeColor = Color.White;
            btnNewEmp.BackColor = Color.White;
            btnNewEmp.ForeColor = Color.Black;
            btnAllEmp.BackColor = Color.White;
            btnAllEmp.ForeColor = Color.Black;

            newHostelerControl1.Hide();
            allHostelersControl1.Hide();
            manageRoomsControl1.Hide();
            newEmployeeControl1.Hide();
            allEmployeesControl1.Hide();
            payRent1.Show();
            payRent1.BringToFront();
        }

        private void btnNewEmp_Click(object sender, EventArgs e)
        {
            btnnewhosteler.BackColor = Color.White;
            btnnewhosteler.ForeColor = Color.Black;
            btnallhostelelers.BackColor = Color.White;
            btnallhostelelers.ForeColor = Color.Black;
            btnManageRooms.BackColor = Color.White;
            btnManageRooms.ForeColor = Color.Black;
            btnPayRent.BackColor = Color.White;
            btnPayRent.ForeColor = Color.Black;
            btnNewEmp.BackColor = Color.Red;
            btnNewEmp.ForeColor = Color.White;
            btnAllEmp.BackColor = Color.White;
            btnAllEmp.ForeColor = Color.Black;

            newHostelerControl1.Hide();
            allHostelersControl1.Hide();
            manageRoomsControl1.Hide();
            payRent1.Hide();
            allEmployeesControl1.Hide();
            newEmployeeControl1.Show();
            newEmployeeControl1.BringToFront();
        }

        private void btnAllEmp_Click(object sender, EventArgs e)
        {
            btnnewhosteler.BackColor = Color.White;
            btnnewhosteler.ForeColor = Color.Black;
            btnallhostelelers.BackColor = Color.White;
            btnallhostelelers.ForeColor = Color.Black;
            btnManageRooms.BackColor = Color.White;
            btnManageRooms.ForeColor = Color.Black;
            btnPayRent.BackColor = Color.White;
            btnPayRent.ForeColor = Color.Black;
            btnNewEmp.BackColor = Color.White;
            btnNewEmp.ForeColor = Color.Black;
            btnAllEmp.BackColor = Color.Red;
            btnAllEmp.ForeColor = Color.White;

            newHostelerControl1.Hide();
            allHostelersControl1.Hide();
            manageRoomsControl1.Hide();
            payRent1.Hide();
            newEmployeeControl1.Hide();
            allEmployeesControl1.Show();
            allEmployeesControl1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void newHostelerControl1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }
    }
}
