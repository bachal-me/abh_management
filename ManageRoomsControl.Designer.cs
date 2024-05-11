namespace ABH
{
    partial class ManageRoomsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnRoomSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RoomNumberCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BedsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableBedsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FloorCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResidentsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRoomUpdate = new System.Windows.Forms.Button();
            this.btnRoomSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Number";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(226, 130);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 27);
            this.textBox1.TabIndex = 1;
            // 
            // btnRoomSearch
            // 
            this.btnRoomSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRoomSearch.BackColor = System.Drawing.Color.White;
            this.btnRoomSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomSearch.Location = new System.Drawing.Point(546, 124);
            this.btnRoomSearch.Name = "btnRoomSearch";
            this.btnRoomSearch.Size = new System.Drawing.Size(75, 35);
            this.btnRoomSearch.TabIndex = 2;
            this.btnRoomSearch.Text = "Search";
            this.btnRoomSearch.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomNumberCol,
            this.BedsCol,
            this.AvailableBedsCol,
            this.FloorCol,
            this.ResidentsCol});
            this.dataGridView1.Location = new System.Drawing.Point(58, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(567, 344);
            this.dataGridView1.TabIndex = 3;
            // 
            // RoomNumberCol
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Format = "N0";
            this.RoomNumberCol.DefaultCellStyle = dataGridViewCellStyle4;
            this.RoomNumberCol.Frozen = true;
            this.RoomNumberCol.HeaderText = "Room";
            this.RoomNumberCol.Name = "RoomNumberCol";
            this.RoomNumberCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // BedsCol
            // 
            this.BedsCol.HeaderText = "Beds";
            this.BedsCol.Name = "BedsCol";
            // 
            // AvailableBedsCol
            // 
            this.AvailableBedsCol.HeaderText = "Available Beds";
            this.AvailableBedsCol.Name = "AvailableBedsCol";
            // 
            // FloorCol
            // 
            this.FloorCol.HeaderText = "Floor";
            this.FloorCol.Name = "FloorCol";
            // 
            // ResidentsCol
            // 
            this.ResidentsCol.HeaderText = "Residents";
            this.ResidentsCol.Name = "ResidentsCol";
            // 
            // btnRoomUpdate
            // 
            this.btnRoomUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRoomUpdate.BackColor = System.Drawing.Color.White;
            this.btnRoomUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomUpdate.Location = new System.Drawing.Point(427, 551);
            this.btnRoomUpdate.Name = "btnRoomUpdate";
            this.btnRoomUpdate.Size = new System.Drawing.Size(75, 35);
            this.btnRoomUpdate.TabIndex = 4;
            this.btnRoomUpdate.Text = "Update";
            this.btnRoomUpdate.UseVisualStyleBackColor = false;
            // 
            // btnRoomSave
            // 
            this.btnRoomSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRoomSave.BackColor = System.Drawing.Color.White;
            this.btnRoomSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomSave.Location = new System.Drawing.Point(550, 551);
            this.btnRoomSave.Name = "btnRoomSave";
            this.btnRoomSave.Size = new System.Drawing.Size(75, 35);
            this.btnRoomSave.TabIndex = 5;
            this.btnRoomSave.Text = "Save";
            this.btnRoomSave.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MistyRose;
            this.label2.Location = new System.Drawing.Point(18, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Manage Rooms";
            // 
            // ManageRoomsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRoomSave);
            this.Controls.Add(this.btnRoomUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRoomSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "ManageRoomsControl";
            this.Size = new System.Drawing.Size(1060, 545);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnRoomSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumberCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn BedsCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableBedsCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FloorCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResidentsCol;
        private System.Windows.Forms.Button btnRoomUpdate;
        private System.Windows.Forms.Button btnRoomSave;
        private System.Windows.Forms.Label label2;
    }
}
