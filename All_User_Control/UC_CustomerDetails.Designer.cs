namespace Quan_Ly_Khach_San_2024.All_User_Control
{
    partial class UC_CustomerDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.gvThongTinKH = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cbbTimKH = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvThongTinKH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thông Tin Chi Tiết Khách Hàng";
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTimKiem.Location = new System.Drawing.Point(732, 71);
            this.lblTimKiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(101, 28);
            this.lblTimKiem.TabIndex = 5;
            this.lblTimKiem.Text = "Tìm Kiếm";
            // 
            // gvThongTinKH
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gvThongTinKH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvThongTinKH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvThongTinKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvThongTinKH.ColumnHeadersHeight = 4;
            this.gvThongTinKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvThongTinKH.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvThongTinKH.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvThongTinKH.Location = new System.Drawing.Point(22, 196);
            this.gvThongTinKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gvThongTinKH.Name = "gvThongTinKH";
            this.gvThongTinKH.RowHeadersVisible = false;
            this.gvThongTinKH.RowHeadersWidth = 51;
            this.gvThongTinKH.Size = new System.Drawing.Size(1472, 385);
            this.gvThongTinKH.TabIndex = 7;
            this.gvThongTinKH.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gvThongTinKH.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gvThongTinKH.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gvThongTinKH.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gvThongTinKH.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gvThongTinKH.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gvThongTinKH.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvThongTinKH.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gvThongTinKH.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvThongTinKH.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvThongTinKH.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gvThongTinKH.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gvThongTinKH.ThemeStyle.HeaderStyle.Height = 4;
            this.gvThongTinKH.ThemeStyle.ReadOnly = false;
            this.gvThongTinKH.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gvThongTinKH.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvThongTinKH.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvThongTinKH.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvThongTinKH.ThemeStyle.RowsStyle.Height = 22;
            this.gvThongTinKH.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvThongTinKH.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvThongTinKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvThongTinKH_CellContentClick);
            // 
            // cbbTimKH
            // 
            this.cbbTimKH.BackColor = System.Drawing.Color.Transparent;
            this.cbbTimKH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTimKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimKH.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTimKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTimKH.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbTimKH.ForeColor = System.Drawing.Color.Black;
            this.cbbTimKH.ItemHeight = 30;
            this.cbbTimKH.Items.AddRange(new object[] {
            "All Customer Details",
            "In Hotel Customer",
            "CheckOut Customer"});
            this.cbbTimKH.Location = new System.Drawing.Point(736, 102);
            this.cbbTimKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbTimKH.Name = "cbbTimKH";
            this.cbbTimKH.Size = new System.Drawing.Size(432, 36);
            this.cbbTimKH.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbbTimKH.TabIndex = 6;
            // 
            // UC_CustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gvThongTinKH);
            this.Controls.Add(this.cbbTimKH);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_CustomerDetails";
            this.Size = new System.Drawing.Size(1529, 607);
            ((System.ComponentModel.ISupportInitialize)(this.gvThongTinKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTimKiem;
        private Guna.UI2.WinForms.Guna2DataGridView gvThongTinKH;
        private Guna.UI2.WinForms.Guna2ComboBox cbbTimKH;
    }
}
