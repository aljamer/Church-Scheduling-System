namespace S.E.Project
{
    partial class frmAdminMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminMain));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblName = new System.Windows.Forms.ToolStripDropDownButton();
            this.accountDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.STchangePass = new System.Windows.Forms.ToolStripMenuItem();
            this.STLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblAboutUs = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnEvent = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.home1 = new S.E.Project.Home();
            this.ucCalendar1 = new S.E.Project.ucCalendar();
            this.ucEvent1 = new S.E.Project.ucEvent();
            this.ucCertificate1 = new S.E.Project.ucCertificate();
            this.home2 = new S.E.Project.Home();
            this.ucStaff1 = new S.E.Project.ucStaff();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ucStaff1);
            this.panel2.Controls.Add(this.home2);
            this.panel2.Controls.Add(this.ucCertificate1);
            this.panel2.Controls.Add(this.ucEvent1);
            this.panel2.Controls.Add(this.ucCalendar1);
            this.panel2.Controls.Add(this.home1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.statusStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(264, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1241, 846);
            this.panel2.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1209, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(32, 817);
            this.panel4.TabIndex = 14;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.lblName,
            this.toolStripStatusLabel1,
            this.statusDate,
            this.statusTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 817);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1241, 29);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(63, 24);
            this.toolStripStatusLabel2.Text = "User :";
            // 
            // lblName
            // 
            this.lblName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblName.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountDetailsToolStripMenuItem,
            this.STchangePass,
            this.STLogout});
            this.lblName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 27);
            this.lblName.Text = "Account ";
            // 
            // accountDetailsToolStripMenuItem
            // 
            this.accountDetailsToolStripMenuItem.Name = "accountDetailsToolStripMenuItem";
            this.accountDetailsToolStripMenuItem.Size = new System.Drawing.Size(247, 28);
            this.accountDetailsToolStripMenuItem.Text = "Account Details";
            // 
            // STchangePass
            // 
            this.STchangePass.Name = "STchangePass";
            this.STchangePass.Size = new System.Drawing.Size(247, 28);
            this.STchangePass.Text = "Change Password";
            // 
            // STLogout
            // 
            this.STLogout.Name = "STLogout";
            this.STLogout.Size = new System.Drawing.Size(247, 28);
            this.STLogout.Text = "Logout";
            this.STLogout.Click += new System.EventHandler(this.STLogout_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(308, 24);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // statusDate
            // 
            this.statusDate.BackColor = System.Drawing.Color.Transparent;
            this.statusDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusDate.ForeColor = System.Drawing.Color.White;
            this.statusDate.Name = "statusDate";
            this.statusDate.Size = new System.Drawing.Size(308, 24);
            this.statusDate.Spring = true;
            this.statusDate.Text = "Date";
            // 
            // statusTime
            // 
            this.statusTime.BackColor = System.Drawing.Color.Transparent;
            this.statusTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTime.ForeColor = System.Drawing.Color.White;
            this.statusTime.Name = "statusTime";
            this.statusTime.Size = new System.Drawing.Size(308, 24);
            this.statusTime.Spring = true;
            this.statusTime.Text = "Time";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.btnEvent);
            this.panel1.Controls.Add(this.btnStaff);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 846);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblAboutUs);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 816);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(264, 30);
            this.panel3.TabIndex = 38;
            // 
            // lblAboutUs
            // 
            this.lblAboutUs.AutoSize = true;
            this.lblAboutUs.BackColor = System.Drawing.Color.Transparent;
            this.lblAboutUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAboutUs.ForeColor = System.Drawing.Color.White;
            this.lblAboutUs.Location = new System.Drawing.Point(100, 5);
            this.lblAboutUs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAboutUs.Name = "lblAboutUs";
            this.lblAboutUs.Size = new System.Drawing.Size(64, 17);
            this.lblAboutUs.TabIndex = 10;
            this.lblAboutUs.Text = "About us";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(29, 287);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(205, 73);
            this.button2.TabIndex = 0;
            this.button2.Text = " &Home";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(29, 373);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(205, 73);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "&Schedule";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(29, 631);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(205, 73);
            this.button6.TabIndex = 7;
            this.button6.Text = "&Certificate";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnEvent
            // 
            this.btnEvent.BackColor = System.Drawing.Color.White;
            this.btnEvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEvent.FlatAppearance.BorderSize = 0;
            this.btnEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvent.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvent.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnEvent.Image = ((System.Drawing.Image)(resources.GetObject("btnEvent.Image")));
            this.btnEvent.Location = new System.Drawing.Point(29, 545);
            this.btnEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Size = new System.Drawing.Size(205, 73);
            this.btnEvent.TabIndex = 5;
            this.btnEvent.Text = "&Event";
            this.btnEvent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEvent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEvent.UseVisualStyleBackColor = false;
            this.btnEvent.Click += new System.EventHandler(this.btnEvent_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.White;
            this.btnStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnStaff.Image")));
            this.btnStaff.Location = new System.Drawing.Point(29, 459);
            this.btnStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(205, 73);
            this.btnStaff.TabIndex = 2;
            this.btnStaff.Text = "&User";
            this.btnStaff.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // home1
            // 
            this.home1.BackColor = System.Drawing.Color.White;
            this.home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home1.Location = new System.Drawing.Point(0, 0);
            this.home1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(1209, 817);
            this.home1.TabIndex = 15;
            // 
            // ucCalendar1
            // 
            this.ucCalendar1.BackColor = System.Drawing.Color.White;
            this.ucCalendar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCalendar1.Location = new System.Drawing.Point(0, 0);
            this.ucCalendar1.Name = "ucCalendar1";
            this.ucCalendar1.Size = new System.Drawing.Size(1209, 817);
            this.ucCalendar1.TabIndex = 16;
            // 
            // ucEvent1
            // 
            this.ucEvent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucEvent1.Location = new System.Drawing.Point(0, 0);
            this.ucEvent1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucEvent1.Name = "ucEvent1";
            this.ucEvent1.Size = new System.Drawing.Size(1209, 817);
            this.ucEvent1.TabIndex = 17;
            // 
            // ucCertificate1
            // 
            this.ucCertificate1.BackColor = System.Drawing.Color.White;
            this.ucCertificate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCertificate1.Location = new System.Drawing.Point(0, 0);
            this.ucCertificate1.Name = "ucCertificate1";
            this.ucCertificate1.Size = new System.Drawing.Size(1209, 817);
            this.ucCertificate1.TabIndex = 18;
            // 
            // home2
            // 
            this.home2.BackColor = System.Drawing.Color.White;
            this.home2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home2.Location = new System.Drawing.Point(0, 0);
            this.home2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.home2.Name = "home2";
            this.home2.Size = new System.Drawing.Size(1209, 817);
            this.home2.TabIndex = 19;
            // 
            // ucStaff1
            // 
            this.ucStaff1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucStaff1.Location = new System.Drawing.Point(0, 0);
            this.ucStaff1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucStaff1.Name = "ucStaff1";
            this.ucStaff1.Size = new System.Drawing.Size(1209, 817);
            this.ucStaff1.TabIndex = 20;
            // 
            // frmAdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 846);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Church Event Management System";
            this.Load += new System.EventHandler(this.frmAdminMain_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnEvent;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusDate;
        private System.Windows.Forms.ToolStripStatusLabel statusTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripDropDownButton lblName;
        private System.Windows.Forms.ToolStripMenuItem STchangePass;
        private System.Windows.Forms.ToolStripMenuItem STLogout;
        private System.Windows.Forms.ToolStripMenuItem accountDetailsToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblAboutUs;
        private System.Windows.Forms.Panel panel4;
        private Home home1;
        private Home home2;
        private ucCertificate ucCertificate1;
        private ucEvent ucEvent1;
        private ucCalendar ucCalendar1;
        private ucStaff ucStaff1;
    }
}