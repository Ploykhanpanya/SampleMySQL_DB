namespace SampleMySQL_DB
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmployeeAddr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmployeePhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmployeeSal = new System.Windows.Forms.TextBox();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ข้อมูลลูกค้า";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(115, 106);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(130, 20);
            this.txtEmployeeID.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(170, 387);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "บันทึก";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "รหัสพนักงาน";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ชื่อ";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(115, 132);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(152, 20);
            this.txtEmployeeName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ที่อยู่";
            // 
            // txtEmployeeAddr
            // 
            this.txtEmployeeAddr.Location = new System.Drawing.Point(115, 158);
            this.txtEmployeeAddr.Name = "txtEmployeeAddr";
            this.txtEmployeeAddr.Size = new System.Drawing.Size(331, 20);
            this.txtEmployeeAddr.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "เบอร์โทรศัพท์";
            // 
            // txtEmployeePhone
            // 
            this.txtEmployeePhone.Location = new System.Drawing.Point(115, 184);
            this.txtEmployeePhone.Name = "txtEmployeePhone";
            this.txtEmployeePhone.Size = new System.Drawing.Size(152, 20);
            this.txtEmployeePhone.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "เงินเดือน";
            // 
            // txtEmployeeSal
            // 
            this.txtEmployeeSal.Location = new System.Drawing.Point(346, 132);
            this.txtEmployeeSal.Name = "txtEmployeeSal";
            this.txtEmployeeSal.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeSal.TabIndex = 10;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(46, 221);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.Size = new System.Drawing.Size(401, 150);
            this.dgvEmployee.TabIndex = 12;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(251, 387);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "ล้าง";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 567);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmployeeSal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmployeePhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmployeeAddr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmployeeAddr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmployeePhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmployeeSal;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Button btnClear;
    }
}

