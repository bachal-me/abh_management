namespace ABH
{
    partial class ManagerHomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeshboard = new System.Windows.Forms.Button();
            this.btnAllEmp = new System.Windows.Forms.Button();
            this.btnNewEmp = new System.Windows.Forms.Button();
            this.btnManageRooms = new System.Windows.Forms.Button();
            this.btnPayRent = new System.Windows.Forms.Button();
            this.btnallhostelelers = new System.Windows.Forms.Button();
            this.btnnewhosteler = new System.Windows.Forms.Button();
            this.allEmployeesControl1 = new ABH.AllEmployeesControl();
            this.newHostelerControl1 = new ABH.NewHostelerControl();
            this.allHostelersControl1 = new ABH.AllHostelersControl();
            this.manageRoomsControl1 = new ABH.ManageRoomsControl();
            this.newEmployeeControl1 = new ABH.NewEmployeeControl();
            this.payRent1 = new ABH.PayRent();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Salmon;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDeshboard);
            this.panel1.Controls.Add(this.btnAllEmp);
            this.panel1.Controls.Add(this.btnNewEmp);
            this.panel1.Controls.Add(this.btnManageRooms);
            this.panel1.Controls.Add(this.btnPayRent);
            this.panel1.Controls.Add(this.btnallhostelelers);
            this.panel1.Controls.Add(this.btnnewhosteler);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 549);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Welcome,";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(9, 458);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button1.Size = new System.Drawing.Size(130, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Manager-Name";
            // 
            // btnDeshboard
            // 
            this.btnDeshboard.BackColor = System.Drawing.Color.White;
            this.btnDeshboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDeshboard.Location = new System.Drawing.Point(9, 404);
            this.btnDeshboard.Name = "btnDeshboard";
            this.btnDeshboard.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnDeshboard.Size = new System.Drawing.Size(130, 36);
            this.btnDeshboard.TabIndex = 6;
            this.btnDeshboard.Text = "Deshboard";
            this.btnDeshboard.UseVisualStyleBackColor = false;
            // 
            // btnAllEmp
            // 
            this.btnAllEmp.BackColor = System.Drawing.Color.White;
            this.btnAllEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAllEmp.Location = new System.Drawing.Point(9, 353);
            this.btnAllEmp.Name = "btnAllEmp";
            this.btnAllEmp.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnAllEmp.Size = new System.Drawing.Size(130, 36);
            this.btnAllEmp.TabIndex = 5;
            this.btnAllEmp.Text = "All Employees";
            this.btnAllEmp.UseVisualStyleBackColor = false;
            this.btnAllEmp.Click += new System.EventHandler(this.btnAllEmp_Click);
            // 
            // btnNewEmp
            // 
            this.btnNewEmp.BackColor = System.Drawing.Color.White;
            this.btnNewEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnNewEmp.Location = new System.Drawing.Point(9, 302);
            this.btnNewEmp.Name = "btnNewEmp";
            this.btnNewEmp.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnNewEmp.Size = new System.Drawing.Size(130, 36);
            this.btnNewEmp.TabIndex = 4;
            this.btnNewEmp.Text = "New Employee";
            this.btnNewEmp.UseVisualStyleBackColor = false;
            this.btnNewEmp.Click += new System.EventHandler(this.btnNewEmp_Click);
            // 
            // btnManageRooms
            // 
            this.btnManageRooms.BackColor = System.Drawing.Color.White;
            this.btnManageRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnManageRooms.Location = new System.Drawing.Point(9, 249);
            this.btnManageRooms.Name = "btnManageRooms";
            this.btnManageRooms.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnManageRooms.Size = new System.Drawing.Size(130, 36);
            this.btnManageRooms.TabIndex = 3;
            this.btnManageRooms.Text = "Manage Rooms";
            this.btnManageRooms.UseVisualStyleBackColor = false;
            this.btnManageRooms.Click += new System.EventHandler(this.btnManageRooms_Click);
            // 
            // btnPayRent
            // 
            this.btnPayRent.BackColor = System.Drawing.Color.White;
            this.btnPayRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPayRent.Location = new System.Drawing.Point(9, 195);
            this.btnPayRent.Name = "btnPayRent";
            this.btnPayRent.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnPayRent.Size = new System.Drawing.Size(130, 36);
            this.btnPayRent.TabIndex = 2;
            this.btnPayRent.Text = "Pay Rent";
            this.btnPayRent.UseVisualStyleBackColor = false;
            this.btnPayRent.Click += new System.EventHandler(this.btnPayRent_Click);
            // 
            // btnallhostelelers
            // 
            this.btnallhostelelers.BackColor = System.Drawing.Color.White;
            this.btnallhostelelers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnallhostelelers.Location = new System.Drawing.Point(9, 142);
            this.btnallhostelelers.Name = "btnallhostelelers";
            this.btnallhostelelers.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnallhostelelers.Size = new System.Drawing.Size(130, 36);
            this.btnallhostelelers.TabIndex = 1;
            this.btnallhostelelers.Text = "All Hostelers";
            this.btnallhostelelers.UseVisualStyleBackColor = false;
            this.btnallhostelelers.Click += new System.EventHandler(this.btnallhostelelers_Click);
            // 
            // btnnewhosteler
            // 
            this.btnnewhosteler.BackColor = System.Drawing.Color.White;
            this.btnnewhosteler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnewhosteler.Location = new System.Drawing.Point(9, 88);
            this.btnnewhosteler.Name = "btnnewhosteler";
            this.btnnewhosteler.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnnewhosteler.Size = new System.Drawing.Size(130, 35);
            this.btnnewhosteler.TabIndex = 0;
            this.btnnewhosteler.Text = "New Hosteler";
            this.btnnewhosteler.UseVisualStyleBackColor = false;
            this.btnnewhosteler.Click += new System.EventHandler(this.btnnewhosteler_Click);
            // 
            // allEmployeesControl1
            // 
            this.allEmployeesControl1.BackColor = System.Drawing.Color.LightSalmon;
            this.allEmployeesControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allEmployeesControl1.Location = new System.Drawing.Point(0, 0);
            this.allEmployeesControl1.Name = "allEmployeesControl1";
            this.allEmployeesControl1.Size = new System.Drawing.Size(997, 549);
            this.allEmployeesControl1.TabIndex = 7;
            // 
            // newHostelerControl1
            // 
            this.newHostelerControl1.BackColor = System.Drawing.Color.LightSalmon;
            this.newHostelerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newHostelerControl1.Location = new System.Drawing.Point(154, 0);
            this.newHostelerControl1.Name = "newHostelerControl1";
            this.newHostelerControl1.Size = new System.Drawing.Size(843, 549);
            this.newHostelerControl1.TabIndex = 3;
            this.newHostelerControl1.Load += new System.EventHandler(this.newHostelerControl1_Load);
            // 
            // allHostelersControl1
            // 
            this.allHostelersControl1.BackColor = System.Drawing.Color.LightSalmon;
            this.allHostelersControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allHostelersControl1.Location = new System.Drawing.Point(0, 0);
            this.allHostelersControl1.Name = "allHostelersControl1";
            this.allHostelersControl1.Size = new System.Drawing.Size(997, 549);
            this.allHostelersControl1.TabIndex = 2;
            this.allHostelersControl1.Load += new System.EventHandler(this.allHostelersControl1_Load);
            // 
            // manageRoomsControl1
            // 
            this.manageRoomsControl1.BackColor = System.Drawing.Color.LightSalmon;
            this.manageRoomsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manageRoomsControl1.Location = new System.Drawing.Point(0, 0);
            this.manageRoomsControl1.Name = "manageRoomsControl1";
            this.manageRoomsControl1.Size = new System.Drawing.Size(997, 549);
            this.manageRoomsControl1.TabIndex = 4;
            // 
            // newEmployeeControl1
            // 
            this.newEmployeeControl1.BackColor = System.Drawing.Color.LightSalmon;
            this.newEmployeeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newEmployeeControl1.Location = new System.Drawing.Point(0, 0);
            this.newEmployeeControl1.Name = "newEmployeeControl1";
            this.newEmployeeControl1.Size = new System.Drawing.Size(997, 549);
            this.newEmployeeControl1.TabIndex = 6;
            // 
            // payRent1
            // 
            this.payRent1.BackColor = System.Drawing.Color.LightSalmon;
            this.payRent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.payRent1.Location = new System.Drawing.Point(0, 0);
            this.payRent1.Name = "payRent1";
            this.payRent1.Size = new System.Drawing.Size(997, 549);
            this.payRent1.TabIndex = 5;
            // 
            // ManagerHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 549);
            this.Controls.Add(this.newHostelerControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.allHostelersControl1);
            this.Controls.Add(this.manageRoomsControl1);
            this.Controls.Add(this.newEmployeeControl1);
            this.Controls.Add(this.payRent1);
            this.Controls.Add(this.allEmployeesControl1);
            this.Name = "ManagerHomeForm";
            this.Text = "Welcome Manager ABH";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnallhostelelers;
        private System.Windows.Forms.Button btnnewhosteler;
        private AllHostelersControl allHostelersControl1;
        private System.Windows.Forms.Button btnDeshboard;
        private System.Windows.Forms.Button btnAllEmp;
        private System.Windows.Forms.Button btnNewEmp;
        private System.Windows.Forms.Button btnManageRooms;
        private System.Windows.Forms.Button btnPayRent;
        private NewHostelerControl newHostelerControl1;
        private ManageRoomsControl manageRoomsControl1;
        private PayRent payRent1;
        private NewEmployeeControl newEmployeeControl1;
        private AllEmployeesControl allEmployeesControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}