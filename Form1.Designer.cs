namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtNationalNumber = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblNationalId = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblMassage = new System.Windows.Forms.Label();
            this.radioButtonSexMale = new System.Windows.Forms.RadioButton();
            this.radioButtonSexFemale = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(524, 15);
            this.txtFirstName.MaxLength = 20;
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 23);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFirstName_KeyDown);
            // 
            // txtNationalNumber
            // 
            this.txtNationalNumber.Location = new System.Drawing.Point(524, 147);
            this.txtNationalNumber.MaxLength = 10;
            this.txtNationalNumber.Name = "txtNationalNumber";
            this.txtNationalNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNationalNumber.Size = new System.Drawing.Size(100, 23);
            this.txtNationalNumber.TabIndex = 7;
            this.txtNationalNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNationalNumber_KeyPress);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(524, 103);
            this.txtPhoneNumber.MaxLength = 12;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 23);
            this.txtPhoneNumber.TabIndex = 5;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(524, 57);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 23);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(708, 197);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(43, 15);
            this.lblSex.TabIndex = 8;
            this.lblSex.Text = "جنسیت";
            // 
            // lblNationalId
            // 
            this.lblNationalId.AutoSize = true;
            this.lblNationalId.Location = new System.Drawing.Point(706, 147);
            this.lblNationalId.Name = "lblNationalId";
            this.lblNationalId.Size = new System.Drawing.Size(40, 15);
            this.lblNationalId.TabIndex = 6;
            this.lblNationalId.Text = "کدملی";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(653, 103);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(93, 15);
            this.lblPhoneNumber.TabIndex = 4;
            this.lblPhoneNumber.Text = "شماره تلفن همراه";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(677, 57);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(69, 15);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "نام خانوادگی";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(725, 15);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(21, 15);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "نام";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(538, 262);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 10;
            this.btnShow.Text = "نمایش";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblMassage
            // 
            this.lblMassage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMassage.BackColor = System.Drawing.Color.Red;
            this.lblMassage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMassage.Location = new System.Drawing.Point(45, 331);
            this.lblMassage.Name = "lblMassage";
            this.lblMassage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMassage.Size = new System.Drawing.Size(701, 29);
            this.lblMassage.TabIndex = 11;
            this.lblMassage.Text = "جواب";
            this.lblMassage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMassage.UseMnemonic = false;
            // 
            // radioButtonSexMale
            // 
            this.radioButtonSexMale.AutoSize = true;
            this.radioButtonSexMale.Location = new System.Drawing.Point(475, 211);
            this.radioButtonSexMale.Name = "radioButtonSexMale";
            this.radioButtonSexMale.Size = new System.Drawing.Size(49, 19);
            this.radioButtonSexMale.TabIndex = 17;
            this.radioButtonSexMale.TabStop = true;
            this.radioButtonSexMale.Text = "مذکر";
            this.radioButtonSexMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonSexFemale
            // 
            this.radioButtonSexFemale.AutoSize = true;
            this.radioButtonSexFemale.Location = new System.Drawing.Point(571, 211);
            this.radioButtonSexFemale.Name = "radioButtonSexFemale";
            this.radioButtonSexFemale.Size = new System.Drawing.Size(53, 19);
            this.radioButtonSexFemale.TabIndex = 16;
            this.radioButtonSexFemale.TabStop = true;
            this.radioButtonSexFemale.Text = "مونث";
            this.radioButtonSexFemale.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButtonSexMale);
            this.Controls.Add(this.radioButtonSexFemale);
            this.Controls.Add(this.lblMassage);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblNationalId);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtNationalNumber);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فرم اطلاعات دانشجو";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private TextBox txtFirstName;
        private TextBox txtNationalNumber;
        private TextBox txtPhoneNumber;
        private TextBox txtLastName;
        private Label lblSex;
        private Label lblNationalId;
        private Label lblPhoneNumber;
        private Label lblLastName;
        private Label lblFirstName;
        private Button btnShow;
        private Label lblMassage;
        private RadioButton radioButtonSexMale;
        private RadioButton radioButtonSexFemale;
    }
}