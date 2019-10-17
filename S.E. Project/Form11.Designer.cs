namespace S.E.Project
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.group1 = new System.Windows.Forms.GroupBox();
            this.group2 = new System.Windows.Forms.GroupBox();
            this.group3 = new System.Windows.Forms.GroupBox();
            this.lvwReq = new System.Windows.Forms.ListView();
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtEventDesc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEventID = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.listView4 = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button4 = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.group4 = new System.Windows.Forms.GroupBox();
            this.button13 = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.group3.SuspendLayout();
            this.group4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(526, 450);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(103, 60);
            this.btnNext.TabIndex = 1;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.White;
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.Location = new System.Drawing.Point(403, 450);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(103, 60);
            this.btnPrev.TabIndex = 2;
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // group1
            // 
            this.group1.Controls.Add(this.button7);
            this.group1.Controls.Add(this.listView4);
            this.group1.Controls.Add(this.button4);
            this.group1.Controls.Add(this.btnView);
            this.group1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group1.Location = new System.Drawing.Point(109, 67);
            this.group1.Name = "group1";
            this.group1.Size = new System.Drawing.Size(571, 262);
            this.group1.TabIndex = 158;
            this.group1.TabStop = false;
            this.group1.Text = "Applicant Details";
            // 
            // group2
            // 
            this.group2.Controls.Add(this.button8);
            this.group2.Controls.Add(this.button3);
            this.group2.Controls.Add(this.txtEventDesc);
            this.group2.Controls.Add(this.label12);
            this.group2.Controls.Add(this.txtEventName);
            this.group2.Controls.Add(this.label14);
            this.group2.Controls.Add(this.txtEventID);
            this.group2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group2.Location = new System.Drawing.Point(71, 67);
            this.group2.Name = "group2";
            this.group2.Size = new System.Drawing.Size(580, 262);
            this.group2.TabIndex = 159;
            this.group2.TabStop = false;
            this.group2.Text = "Event Details";
            // 
            // group3
            // 
            this.group3.Controls.Add(this.lvwReq);
            this.group3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group3.Location = new System.Drawing.Point(93, 67);
            this.group3.Name = "group3";
            this.group3.Size = new System.Drawing.Size(581, 262);
            this.group3.TabIndex = 160;
            this.group3.TabStop = false;
            this.group3.Text = "Requirements Details";
            // 
            // lvwReq
            // 
            this.lvwReq.CheckBoxes = true;
            this.lvwReq.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader19,
            this.columnHeader1,
            this.columnHeader2});
            this.lvwReq.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwReq.FullRowSelect = true;
            this.lvwReq.GridLines = true;
            this.lvwReq.Location = new System.Drawing.Point(24, 37);
            this.lvwReq.Name = "lvwReq";
            this.lvwReq.Size = new System.Drawing.Size(500, 192);
            this.lvwReq.TabIndex = 0;
            this.lvwReq.UseCompatibleStateImageBehavior = false;
            this.lvwReq.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "#";
            this.columnHeader19.Width = 54;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Requirement Name";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Requirement Type";
            this.columnHeader2.Width = 244;
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(266, 192);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(135, 37);
            this.button8.TabIndex = 93;
            this.button8.Text = "&Remove";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Century", 12F);
            this.button3.Location = new System.Drawing.Point(407, 191);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 37);
            this.button3.TabIndex = 92;
            this.button3.Text = "&Browse";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtEventDesc
            // 
            this.txtEventDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventDesc.Location = new System.Drawing.Point(251, 81);
            this.txtEventDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtEventDesc.Multiline = true;
            this.txtEventDesc.Name = "txtEventDesc";
            this.txtEventDesc.ReadOnly = true;
            this.txtEventDesc.Size = new System.Drawing.Size(291, 78);
            this.txtEventDesc.TabIndex = 90;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(24, 33);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 29);
            this.label12.TabIndex = 72;
            this.label12.Text = "Event Name :";
            // 
            // txtEventName
            // 
            this.txtEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventName.Location = new System.Drawing.Point(251, 33);
            this.txtEventName.Margin = new System.Windows.Forms.Padding(4);
            this.txtEventName.Multiline = true;
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.ReadOnly = true;
            this.txtEventName.Size = new System.Drawing.Size(291, 29);
            this.txtEventName.TabIndex = 71;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(24, 71);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(149, 29);
            this.label14.TabIndex = 68;
            this.label14.Text = "Description :";
            // 
            // txtEventID
            // 
            this.txtEventID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventID.Location = new System.Drawing.Point(251, 33);
            this.txtEventID.Margin = new System.Windows.Forms.Padding(4);
            this.txtEventID.Multiline = true;
            this.txtEventID.Name = "txtEventID";
            this.txtEventID.ReadOnly = true;
            this.txtEventID.Size = new System.Drawing.Size(98, 29);
            this.txtEventID.TabIndex = 94;
            this.txtEventID.Visible = false;
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(266, 191);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(135, 37);
            this.button7.TabIndex = 93;
            this.button7.Text = "&Remove";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // listView4
            // 
            this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listView4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView4.GridLines = true;
            this.listView4.Location = new System.Drawing.Point(28, 37);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(514, 122);
            this.listView4.TabIndex = 92;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "#";
            this.columnHeader8.Width = 54;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Lastname";
            this.columnHeader9.Width = 105;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Firstname";
            this.columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "M.I.";
            this.columnHeader11.Width = 85;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Address";
            this.columnHeader12.Width = 157;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(407, 191);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 37);
            this.button4.TabIndex = 90;
            this.button4.Text = "&Browse";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnView
            // 
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(125, 192);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(135, 37);
            this.btnView.TabIndex = 89;
            this.btnView.Text = "&Add New";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // group4
            // 
            this.group4.Controls.Add(this.button13);
            this.group4.Controls.Add(this.listView2);
            this.group4.Controls.Add(this.button5);
            this.group4.Controls.Add(this.button6);
            this.group4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group4.Location = new System.Drawing.Point(87, 67);
            this.group4.Name = "group4";
            this.group4.Size = new System.Drawing.Size(581, 317);
            this.group4.TabIndex = 162;
            this.group4.TabStop = false;
            this.group4.Text = "Participants Details";
            // 
            // button13
            // 
            this.button13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button13.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(266, 250);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(135, 37);
            this.button13.TabIndex = 92;
            this.button13.Text = "&Remove";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17});
            this.listView2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(34, 35);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(508, 194);
            this.listView2.TabIndex = 91;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "#";
            this.columnHeader13.Width = 48;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Lastname";
            this.columnHeader14.Width = 106;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Firstname";
            this.columnHeader15.Width = 110;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "M.I.";
            this.columnHeader16.Width = 71;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Description";
            this.columnHeader17.Width = 168;
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Century", 12F);
            this.button5.Location = new System.Drawing.Point(407, 250);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 37);
            this.button5.TabIndex = 90;
            this.button5.Text = "&Browse";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Century", 12F);
            this.button6.Location = new System.Drawing.Point(125, 250);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(135, 37);
            this.button6.TabIndex = 89;
            this.button6.Text = "&Add New";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(756, 605);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.group1);
            this.Controls.Add(this.group4);
            this.Controls.Add(this.group3);
            this.Controls.Add(this.group2);
            this.Name = "Form11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form11_Load);
            this.group1.ResumeLayout(false);
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.group3.ResumeLayout(false);
            this.group4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.GroupBox group1;
        public System.Windows.Forms.Button button7;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button btnView;
        private System.Windows.Forms.GroupBox group2;
        public System.Windows.Forms.Button button8;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox txtEventDesc;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txtEventID;
        private System.Windows.Forms.GroupBox group3;
        private System.Windows.Forms.ListView lvwReq;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox group4;
        public System.Windows.Forms.Button button13;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button button6;
    }
}