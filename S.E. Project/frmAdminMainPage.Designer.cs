namespace S.E.Project
{
    partial class frmAdminMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminMainPage));
            this.lblRole2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panelButton = new System.Windows.Forms.Panel();
            this.lblAboutUs = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnApplicant = new System.Windows.Forms.Button();
            this.btnVenue = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnEvent = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblRole = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearchArch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchArch = new System.Windows.Forms.TextBox();
            this.btnFuneral = new System.Windows.Forms.Button();
            this.btnBaptism = new System.Windows.Forms.Button();
            this.btnWedding = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panelButton.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRole2
            // 
            this.lblRole2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblRole2.Location = new System.Drawing.Point(36, 179);
            this.lblRole2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRole2.Name = "lblRole2";
            this.lblRole2.Size = new System.Drawing.Size(158, 30);
            this.lblRole2.TabIndex = 22;
            this.lblRole2.Text = "Role";
            this.lblRole2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Century", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblName.Location = new System.Drawing.Point(11, 145);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(211, 36);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "Account name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.Color.Black;
            this.panelButton.Controls.Add(this.lblAboutUs);
            this.panelButton.Controls.Add(this.btnLogOut);
            this.panelButton.Controls.Add(this.btnHome);
            this.panelButton.Controls.Add(this.lblRole2);
            this.panelButton.Controls.Add(this.button1);
            this.panelButton.Controls.Add(this.lblName);
            this.panelButton.Controls.Add(this.btnApplicant);
            this.panelButton.Controls.Add(this.btnVenue);
            this.panelButton.Controls.Add(this.button6);
            this.panelButton.Controls.Add(this.btnEvent);
            this.panelButton.Controls.Add(this.btnStaff);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButton.Location = new System.Drawing.Point(0, 0);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(225, 698);
            this.panelButton.TabIndex = 26;
            // 
            // lblAboutUs
            // 
            this.lblAboutUs.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblAboutUs.AutoSize = true;
            this.lblAboutUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAboutUs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblAboutUs.Location = new System.Drawing.Point(75, 673);
            this.lblAboutUs.Name = "lblAboutUs";
            this.lblAboutUs.Size = new System.Drawing.Size(49, 13);
            this.lblAboutUs.TabIndex = 28;
            this.lblAboutUs.Text = "About us";
            this.lblAboutUs.Click += new System.EventHandler(this.lblAboutUs_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.White;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(7, 548);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(212, 41);
            this.btnLogOut.TabIndex = 32;
            this.btnLogOut.Text = "          &Log Out";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(7, 233);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(213, 41);
            this.btnHome.TabIndex = 31;
            this.btnHome.Text = "          &Calendar";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(7, 458);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 41);
            this.button1.TabIndex = 30;
            this.button1.Text = "          &Schedule";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnApplicant
            // 
            this.btnApplicant.BackColor = System.Drawing.Color.White;
            this.btnApplicant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplicant.FlatAppearance.BorderSize = 0;
            this.btnApplicant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplicant.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplicant.ForeColor = System.Drawing.Color.Black;
            this.btnApplicant.Image = ((System.Drawing.Image)(resources.GetObject("btnApplicant.Image")));
            this.btnApplicant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApplicant.Location = new System.Drawing.Point(7, 323);
            this.btnApplicant.Margin = new System.Windows.Forms.Padding(2);
            this.btnApplicant.Name = "btnApplicant";
            this.btnApplicant.Size = new System.Drawing.Size(213, 41);
            this.btnApplicant.TabIndex = 29;
            this.btnApplicant.Text = "          &Applicant";
            this.btnApplicant.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApplicant.UseVisualStyleBackColor = false;
            // 
            // btnVenue
            // 
            this.btnVenue.BackColor = System.Drawing.Color.White;
            this.btnVenue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVenue.FlatAppearance.BorderSize = 0;
            this.btnVenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenue.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenue.ForeColor = System.Drawing.Color.Black;
            this.btnVenue.Image = ((System.Drawing.Image)(resources.GetObject("btnVenue.Image")));
            this.btnVenue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVenue.Location = new System.Drawing.Point(7, 368);
            this.btnVenue.Margin = new System.Windows.Forms.Padding(2);
            this.btnVenue.Name = "btnVenue";
            this.btnVenue.Size = new System.Drawing.Size(213, 41);
            this.btnVenue.TabIndex = 28;
            this.btnVenue.Text = "          &Venue";
            this.btnVenue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVenue.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(7, 503);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(213, 41);
            this.button6.TabIndex = 26;
            this.button6.Text = "          &Certificate";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // btnEvent
            // 
            this.btnEvent.BackColor = System.Drawing.Color.White;
            this.btnEvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEvent.FlatAppearance.BorderSize = 0;
            this.btnEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvent.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvent.ForeColor = System.Drawing.Color.Black;
            this.btnEvent.Image = ((System.Drawing.Image)(resources.GetObject("btnEvent.Image")));
            this.btnEvent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvent.Location = new System.Drawing.Point(7, 413);
            this.btnEvent.Margin = new System.Windows.Forms.Padding(2);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Size = new System.Drawing.Size(213, 41);
            this.btnEvent.TabIndex = 27;
            this.btnEvent.Text = "          &Event";
            this.btnEvent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEvent.UseVisualStyleBackColor = false;
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.White;
            this.btnStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.Black;
            this.btnStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnStaff.Image")));
            this.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.Location = new System.Drawing.Point(7, 278);
            this.btnStaff.Margin = new System.Windows.Forms.Padding(2);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(213, 41);
            this.btnStaff.TabIndex = 25;
            this.btnStaff.Text = "          &Staff";
            this.btnStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.Color.White;
            this.panelStatus.Controls.Add(this.statusStrip1);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatus.Location = new System.Drawing.Point(225, 673);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(887, 25);
            this.panelStatus.TabIndex = 27;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblRole,
            this.toolStripStatusLabel1,
            this.statusDate,
            this.statusTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(887, 25);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblRole
            // 
            this.lblRole.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.Black;
            this.lblRole.Name = "lblRole";
            this.lblRole.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRole.Size = new System.Drawing.Size(218, 20);
            this.lblRole.Spring = true;
            this.lblRole.Text = "Role";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(218, 20);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // statusDate
            // 
            this.statusDate.BackColor = System.Drawing.Color.Transparent;
            this.statusDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusDate.ForeColor = System.Drawing.Color.Black;
            this.statusDate.Name = "statusDate";
            this.statusDate.Size = new System.Drawing.Size(218, 20);
            this.statusDate.Spring = true;
            this.statusDate.Text = "Date";
            // 
            // statusTime
            // 
            this.statusTime.BackColor = System.Drawing.Color.Transparent;
            this.statusTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTime.ForeColor = System.Drawing.Color.Black;
            this.statusTime.Name = "statusTime";
            this.statusTime.Size = new System.Drawing.Size(218, 20);
            this.statusTime.Spring = true;
            this.statusTime.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(225, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 141);
            this.panel1.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(553, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Tel. no. 993-1431";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(469, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Fr. Ramon Barua St., Tetuan, Zamboanga City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(469, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 22);
            this.label3.TabIndex = 34;
            this.label3.Text = "ARCHDIOCESE OF ZAMBOANGA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 37);
            this.label1.TabIndex = 35;
            this.label1.Text = "St. Ignatius of Loyola Parish";
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.White;
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Location = new System.Drawing.Point(127, 2);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(137, 137);
            this.pbLogo.TabIndex = 36;
            this.pbLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSearchArch);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtSearchArch);
            this.panel2.Controls.Add(this.btnFuneral);
            this.panel2.Controls.Add(this.btnBaptism);
            this.panel2.Controls.Add(this.btnWedding);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(225, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(887, 532);
            this.panel2.TabIndex = 33;
            // 
            // btnSearchArch
            // 
            this.btnSearchArch.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchArch.Location = new System.Drawing.Point(768, 122);
            this.btnSearchArch.Name = "btnSearchArch";
            this.btnSearchArch.Size = new System.Drawing.Size(66, 32);
            this.btnSearchArch.TabIndex = 37;
            this.btnSearchArch.Text = "Search ";
            this.btnSearchArch.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 37);
            this.label2.TabIndex = 36;
            this.label2.Text = "Schedule Main Events";
            // 
            // txtSearchArch
            // 
            this.txtSearchArch.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchArch.Location = new System.Drawing.Point(214, 122);
            this.txtSearchArch.Name = "txtSearchArch";
            this.txtSearchArch.Size = new System.Drawing.Size(548, 32);
            this.txtSearchArch.TabIndex = 35;
            this.txtSearchArch.TextChanged += new System.EventHandler(this.txtSearchArch_TextChanged);
            // 
            // btnFuneral
            // 
            this.btnFuneral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFuneral.BackgroundImage")));
            this.btnFuneral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFuneral.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuneral.Location = new System.Drawing.Point(645, 290);
            this.btnFuneral.Name = "btnFuneral";
            this.btnFuneral.Size = new System.Drawing.Size(152, 138);
            this.btnFuneral.TabIndex = 32;
            this.btnFuneral.Text = "FUNERAL";
            this.btnFuneral.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFuneral.UseVisualStyleBackColor = true;
            // 
            // btnBaptism
            // 
            this.btnBaptism.BackColor = System.Drawing.Color.White;
            this.btnBaptism.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBaptism.BackgroundImage")));
            this.btnBaptism.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBaptism.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaptism.Location = new System.Drawing.Point(430, 290);
            this.btnBaptism.Name = "btnBaptism";
            this.btnBaptism.Size = new System.Drawing.Size(152, 138);
            this.btnBaptism.TabIndex = 33;
            this.btnBaptism.Text = "BAPTISM";
            this.btnBaptism.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBaptism.UseVisualStyleBackColor = false;
            // 
            // btnWedding
            // 
            this.btnWedding.BackColor = System.Drawing.Color.White;
            this.btnWedding.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWedding.BackgroundImage")));
            this.btnWedding.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWedding.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWedding.ForeColor = System.Drawing.Color.Black;
            this.btnWedding.Location = new System.Drawing.Point(209, 290);
            this.btnWedding.Name = "btnWedding";
            this.btnWedding.Size = new System.Drawing.Size(152, 138);
            this.btnWedding.TabIndex = 34;
            this.btnWedding.Text = "WEDDING";
            this.btnWedding.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWedding.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(207, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 37);
            this.label6.TabIndex = 36;
            this.label6.Text = "Search Archive";
            // 
            // frmAdminMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1112, 698);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.panelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAdminMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAIN";
            this.Load += new System.EventHandler(this.frmAdminMainPage_Load);
            this.panelButton.ResumeLayout(false);
            this.panelButton.PerformLayout();
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRole2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnApplicant;
        private System.Windows.Forms.Button btnVenue;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnEvent;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusDate;
        private System.Windows.Forms.ToolStripStatusLabel statusTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel lblRole;
        private System.Windows.Forms.Label lblAboutUs;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearchArch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchArch;
        private System.Windows.Forms.Button btnFuneral;
        private System.Windows.Forms.Button btnBaptism;
        private System.Windows.Forms.Button btnWedding;
        private System.Windows.Forms.Label label6;
    }
}