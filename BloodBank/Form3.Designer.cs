namespace project2
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bloodType = new System.Windows.Forms.Label();
            this.socialID = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.donationDate = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Records";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.donationDate);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.phoneNumber);
            this.groupBox1.Controls.Add(this.surname);
            this.groupBox1.Controls.Add(this.Email);
            this.groupBox1.Controls.Add(this.socialID);
            this.groupBox1.Controls.Add(this.bloodType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.id);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(9, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(490, 343);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Records";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(4, 18);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 19);
            this.button4.TabIndex = 1;
            this.button4.Text = "<<";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(430, 18);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 19);
            this.button3.TabIndex = 0;
            this.button3.Text = ">>";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Maiandra GD", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(368, 385);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back to menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Maiandra GD", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(9, 385);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(263, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "N/N";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(6, 65);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(18, 13);
            this.id.TabIndex = 4;
            this.id.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "label5";
            // 
            // bloodType
            // 
            this.bloodType.AutoSize = true;
            this.bloodType.Location = new System.Drawing.Point(6, 230);
            this.bloodType.Name = "bloodType";
            this.bloodType.Size = new System.Drawing.Size(61, 13);
            this.bloodType.TabIndex = 7;
            this.bloodType.Text = "Blood Type";
            // 
            // socialID
            // 
            this.socialID.AutoSize = true;
            this.socialID.Location = new System.Drawing.Point(6, 143);
            this.socialID.Name = "socialID";
            this.socialID.Size = new System.Drawing.Size(50, 13);
            this.socialID.TabIndex = 8;
            this.socialID.Text = "Social ID";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(6, 203);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 9;
            this.Email.Text = "Email";
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Location = new System.Drawing.Point(6, 115);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(47, 13);
            this.surname.TabIndex = 10;
            this.surname.Text = "surname";
            // 
            // phoneNumber
            // 
            this.phoneNumber.AutoSize = true;
            this.phoneNumber.Location = new System.Drawing.Point(6, 172);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(76, 13);
            this.phoneNumber.TabIndex = 11;
            this.phoneNumber.Text = "Phone number";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(5, 90);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(33, 13);
            this.name.TabIndex = 12;
            this.name.Text = "name";
            // 
            // donationDate
            // 
            this.donationDate.AutoSize = true;
            this.donationDate.Location = new System.Drawing.Point(5, 254);
            this.donationDate.Name = "donationDate";
            this.donationDate.Size = new System.Drawing.Size(74, 13);
            this.donationDate.TabIndex = 13;
            this.donationDate.Text = "Donation date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(118, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(118, 143);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "label14";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(118, 172);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "label15";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(118, 203);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "label16";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(118, 230);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 18;
            this.label17.Text = "label17";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(118, 254);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 19;
            this.label18.Text = "label18";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 424);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label donationDate;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label phoneNumber;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label socialID;
        private System.Windows.Forms.Label bloodType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label id;
    }
}