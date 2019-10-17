namespace S.E.Project
{
    partial class frmStaffMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaffMain));
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucCertificate1 = new S.E.Project.ucCertificate();
            this.ucSchedule1 = new S.E.Project.ucSchedule();
            this.ucHome1 = new S.E.Project.ucCalendar();
            this.ucApplicant1 = new S.E.Project.ucApplicant();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnApplicant = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(16, 623);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(324, 50);
            this.button1.TabIndex = 11;
            this.button1.Text = "          &Schedule";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ucHome1);
            this.panel2.Controls.Add(this.ucApplicant1);
            this.panel2.Controls.Add(this.ucCertificate1);
            this.panel2.Controls.Add(this.ucSchedule1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(340, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1584, 1055);
            this.panel2.TabIndex = 9;
            // 
            // ucCertificate1
            // 
            this.ucCertificate1.BackColor = System.Drawing.Color.White;
            this.ucCertificate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCertificate1.Location = new System.Drawing.Point(0, 0);
            this.ucCertificate1.Name = "ucCertificate1";
            this.ucCertificate1.Size = new System.Drawing.Size(1584, 1055);
            this.ucCertificate1.TabIndex = 10;
            // 
            // ucSchedule1
            // 
            this.ucSchedule1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSchedule1.Location = new System.Drawing.Point(0, 0);
            this.ucSchedule1.Name = "ucSchedule1";
            this.ucSchedule1.Size = new System.Drawing.Size(1584, 1055);
            this.ucSchedule1.TabIndex = 9;
            // 
            // ucHome1
            // 
            this.ucHome1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ucHome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucHome1.Location = new System.Drawing.Point(0, 0);
            this.ucHome1.Name = "ucHome1";
            this.ucHome1.Size = new System.Drawing.Size(1584, 1055);
            this.ucHome1.TabIndex = 4;
            // 
            // ucApplicant1
            // 
            this.ucApplicant1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucApplicant1.Location = new System.Drawing.Point(0, 0);
            this.ucApplicant1.Name = "ucApplicant1";
            this.ucApplicant1.Size = new System.Drawing.Size(1584, 1055);
            this.ucApplicant1.TabIndex = 8;
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(16, 323);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(324, 50);
            this.btnHome.TabIndex = 12;
            this.btnHome.Text = "          &Calendar";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblRole
            // 
            this.lblRole.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(11, 266);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(306, 37);
            this.lblRole.TabIndex = 10;
            this.lblRole.Text = "dwa";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(11, 229);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(306, 37);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "da";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(25, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(263, 214);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // btnApplicant
            // 
            this.btnApplicant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplicant.FlatAppearance.BorderSize = 0;
            this.btnApplicant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplicant.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplicant.ForeColor = System.Drawing.Color.Black;
            this.btnApplicant.Image = ((System.Drawing.Image)(resources.GetObject("btnApplicant.Image")));
            this.btnApplicant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApplicant.Location = new System.Drawing.Point(16, 473);
            this.btnApplicant.Name = "btnApplicant";
            this.btnApplicant.Size = new System.Drawing.Size(324, 50);
            this.btnApplicant.TabIndex = 7;
            this.btnApplicant.Text = "          &Applicant";
            this.btnApplicant.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApplicant.UseVisualStyleBackColor = true;
            this.btnApplicant.Click += new System.EventHandler(this.btnApplicant_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(13, 773);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(324, 50);
            this.button6.TabIndex = 4;
            this.button6.Text = "          &Certificate";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(16, 923);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(324, 50);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "          &Log Out";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblRole);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnApplicant);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 1055);
            this.panel1.TabIndex = 8;
            // 
            // frmStaffMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmStaffMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStaffMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmStaffMain_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private ucCalendar ucHome1;
        private ucApplicant ucApplicant1;
        private ucSchedule ucSchedule1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnApplicant;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panel1;
        private ucCertificate ucCertificate1;
    }
}