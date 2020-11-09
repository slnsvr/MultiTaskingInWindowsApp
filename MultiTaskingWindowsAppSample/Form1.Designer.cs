namespace MultiTaskingWindowsAppSample
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
            this.btnGetEmployeeDetails = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblEmployeeDetails = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInputID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGetName = new System.Windows.Forms.Label();
            this.txtGetName = new System.Windows.Forms.TextBox();
            this.lblGetGender = new System.Windows.Forms.Label();
            this.txtGetGender = new System.Windows.Forms.TextBox();
            this.lblProcessing = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtGetAge = new System.Windows.Forms.TextBox();
            this.lblGetAge = new System.Windows.Forms.Label();
            this.lblGetID = new System.Windows.Forms.Label();
            this.txtGetID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGetEmployeeDetails
            // 
            this.btnGetEmployeeDetails.Location = new System.Drawing.Point(546, 632);
            this.btnGetEmployeeDetails.Margin = new System.Windows.Forms.Padding(7);
            this.btnGetEmployeeDetails.Name = "btnGetEmployeeDetails";
            this.btnGetEmployeeDetails.Size = new System.Drawing.Size(104, 55);
            this.btnGetEmployeeDetails.TabIndex = 0;
            this.btnGetEmployeeDetails.Text = "Get";
            this.btnGetEmployeeDetails.UseVisualStyleBackColor = true;
            this.btnGetEmployeeDetails.Click += new System.EventHandler(this.btnGetEmployeeDetails_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(253, 113);
            this.lblName.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(108, 39);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(370, 113);
            this.txtName.Margin = new System.Windows.Forms.Padding(7);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(531, 45);
            this.txtName.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(370, 344);
            this.txtID.Margin = new System.Windows.Forms.Padding(7);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(531, 45);
            this.txtID.TabIndex = 3;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(370, 269);
            this.txtAge.Margin = new System.Windows.Forms.Padding(7);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(531, 45);
            this.txtAge.TabIndex = 4;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(370, 188);
            this.txtGender.Margin = new System.Windows.Forms.Padding(7);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(531, 45);
            this.txtGender.TabIndex = 5;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(283, 269);
            this.lblAge.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(78, 39);
            this.lblAge.TabIndex = 6;
            this.lblAge.Text = "Age";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(231, 191);
            this.lblGender.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(130, 39);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "Gender";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(304, 347);
            this.lblID.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(52, 39);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "ID";
            // 
            // lblEmployeeDetails
            // 
            this.lblEmployeeDetails.AutoSize = true;
            this.lblEmployeeDetails.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEmployeeDetails.Location = new System.Drawing.Point(444, 60);
            this.lblEmployeeDetails.Margin = new System.Windows.Forms.Padding(7, 0, 7, 238);
            this.lblEmployeeDetails.Name = "lblEmployeeDetails";
            this.lblEmployeeDetails.Size = new System.Drawing.Size(363, 39);
            this.lblEmployeeDetails.TabIndex = 9;
            this.lblEmployeeDetails.Text = "Enter employee details";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(530, 403);
            this.button2.Margin = new System.Windows.Forms.Padding(7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 55);
            this.button2.TabIndex = 10;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSaveEmployess_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 576);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 39);
            this.label5.TabIndex = 11;
            this.label5.Text = "ID";
            // 
            // txtInputID
            // 
            this.txtInputID.Location = new System.Drawing.Point(370, 573);
            this.txtInputID.Margin = new System.Windows.Forms.Padding(7);
            this.txtInputID.Name = "txtInputID";
            this.txtInputID.Size = new System.Drawing.Size(531, 45);
            this.txtInputID.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(444, 505);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "Get employee details By ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(378, 704);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 39);
            this.label4.TabIndex = 16;
            // 
            // lblGetName
            // 
            this.lblGetName.AutoSize = true;
            this.lblGetName.Location = new System.Drawing.Point(587, 764);
            this.lblGetName.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblGetName.Name = "lblGetName";
            this.lblGetName.Size = new System.Drawing.Size(108, 39);
            this.lblGetName.TabIndex = 19;
            this.lblGetName.Text = "Name";
            // 
            // txtGetName
            // 
            this.txtGetName.Location = new System.Drawing.Point(709, 764);
            this.txtGetName.Margin = new System.Windows.Forms.Padding(7);
            this.txtGetName.Name = "txtGetName";
            this.txtGetName.Size = new System.Drawing.Size(531, 45);
            this.txtGetName.TabIndex = 20;
            // 
            // lblGetGender
            // 
            this.lblGetGender.AutoSize = true;
            this.lblGetGender.Location = new System.Drawing.Point(565, 826);
            this.lblGetGender.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblGetGender.Name = "lblGetGender";
            this.lblGetGender.Size = new System.Drawing.Size(130, 39);
            this.lblGetGender.TabIndex = 21;
            this.lblGetGender.Text = "Gender";
            // 
            // txtGetGender
            // 
            this.txtGetGender.Location = new System.Drawing.Point(710, 820);
            this.txtGetGender.Margin = new System.Windows.Forms.Padding(7);
            this.txtGetGender.Name = "txtGetGender";
            this.txtGetGender.Size = new System.Drawing.Size(531, 45);
            this.txtGetGender.TabIndex = 22;
            // 
            // lblProcessing
            // 
            this.lblProcessing.AutoSize = true;
            this.lblProcessing.Location = new System.Drawing.Point(655, 704);
            this.lblProcessing.Name = "lblProcessing";
            this.lblProcessing.Size = new System.Drawing.Size(52, 39);
            this.lblProcessing.TabIndex = 23;
            this.lblProcessing.Text = "ID";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(709, 632);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 55);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtGetAge
            // 
            this.txtGetAge.Location = new System.Drawing.Point(710, 879);
            this.txtGetAge.Margin = new System.Windows.Forms.Padding(7);
            this.txtGetAge.Name = "txtGetAge";
            this.txtGetAge.Size = new System.Drawing.Size(531, 45);
            this.txtGetAge.TabIndex = 25;
            // 
            // lblGetAge
            // 
            this.lblGetAge.AutoSize = true;
            this.lblGetAge.Location = new System.Drawing.Point(605, 885);
            this.lblGetAge.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblGetAge.Name = "lblGetAge";
            this.lblGetAge.Size = new System.Drawing.Size(78, 39);
            this.lblGetAge.TabIndex = 26;
            this.lblGetAge.Text = "Age";
            // 
            // lblGetID
            // 
            this.lblGetID.AutoSize = true;
            this.lblGetID.Location = new System.Drawing.Point(631, 944);
            this.lblGetID.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblGetID.Name = "lblGetID";
            this.lblGetID.Size = new System.Drawing.Size(52, 39);
            this.lblGetID.TabIndex = 27;
            this.lblGetID.Text = "ID";
            // 
            // txtGetID
            // 
            this.txtGetID.Location = new System.Drawing.Point(709, 938);
            this.txtGetID.Margin = new System.Windows.Forms.Padding(7);
            this.txtGetID.Name = "txtGetID";
            this.txtGetID.Size = new System.Drawing.Size(531, 45);
            this.txtGetID.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1900, 1047);
            this.Controls.Add(this.txtGetID);
            this.Controls.Add(this.lblGetID);
            this.Controls.Add(this.lblGetAge);
            this.Controls.Add(this.txtGetAge);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblProcessing);
            this.Controls.Add(this.txtGetGender);
            this.Controls.Add(this.lblGetGender);
            this.Controls.Add(this.txtGetName);
            this.Controls.Add(this.lblGetName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInputID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblEmployeeDetails);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnGetEmployeeDetails);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form1";
            this.Text = "EmployeeDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetEmployeeDetails;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblEmployeeDetails;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInputID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGetName;
        private System.Windows.Forms.TextBox txtGetName;
        private System.Windows.Forms.Label lblGetGender;
        private System.Windows.Forms.TextBox txtGetGender;
        private System.Windows.Forms.Label lblProcessing;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtGetAge;
        private System.Windows.Forms.Label lblGetAge;
        private System.Windows.Forms.Label lblGetID;
        private System.Windows.Forms.TextBox txtGetID;
    }
}

