﻿namespace ssdump
{
    partial class ssdumpGUI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editHostsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHost = new System.Windows.Forms.Label();
            this.cboHostList = new System.Windows.Forms.ComboBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.ckbNoData = new System.Windows.Forms.CheckBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.lblTables = new System.Windows.Forms.Label();
            this.txtTables = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnExecute = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNoData = new System.Windows.Forms.Label();
            this.gpbConnectionSettings = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblEncryption = new System.Windows.Forms.Label();
            this.txtTimeout = new System.Windows.Forms.TextBox();
            this.ckbEncryption = new System.Windows.Forms.CheckBox();
            this.lblTimeout = new System.Windows.Forms.Label();
            this.lblCreateDatabase = new System.Windows.Forms.Label();
            this.ckbCreateDatabase = new System.Windows.Forms.CheckBox();
            this.lblCreateUser = new System.Windows.Forms.Label();
            this.ckbCreateUser = new System.Windows.Forms.CheckBox();
            this.lblMaxPacket = new System.Windows.Forms.Label();
            this.txtMaxPacket = new System.Windows.Forms.TextBox();
            this.lblWinAuth = new System.Windows.Forms.Label();
            this.ckbUseWinAuth = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gpbConnectionSettings.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editHostsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // editHostsToolStripMenuItem
            // 
            this.editHostsToolStripMenuItem.Name = "editHostsToolStripMenuItem";
            this.editHostsToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.editHostsToolStripMenuItem.Text = "Edit Host List";
            this.editHostsToolStripMenuItem.Click += new System.EventHandler(this.editHostsToolStripMenuItem_Click);
            // 
            // lblHost
            // 
            this.lblHost.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(3, 7);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(32, 13);
            this.lblHost.TabIndex = 1;
            this.lblHost.Text = "Host:";
            this.lblHost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboHostList
            // 
            this.cboHostList.FormattingEnabled = true;
            this.cboHostList.Location = new System.Drawing.Point(90, 3);
            this.cboHostList.Name = "cboHostList";
            this.cboHostList.Size = new System.Drawing.Size(121, 21);
            this.cboHostList.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(3, 53);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username:";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(90, 50);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(121, 20);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(90, 76);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(121, 20);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(3, 79);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ckbNoData
            // 
            this.ckbNoData.AutoSize = true;
            this.ckbNoData.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbNoData.Location = new System.Drawing.Point(181, 3);
            this.ckbNoData.Name = "ckbNoData";
            this.ckbNoData.Size = new System.Drawing.Size(15, 14);
            this.ckbNoData.TabIndex = 8;
            this.ckbNoData.UseVisualStyleBackColor = true;
            this.ckbNoData.CheckedChanged += new System.EventHandler(this.ckbNoData_CheckedChanged);
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(90, 102);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(121, 20);
            this.txtDatabase.TabIndex = 10;
            this.txtDatabase.TextChanged += new System.EventHandler(this.txtDatabase_TextChanged);
            // 
            // lblDatabase
            // 
            this.lblDatabase.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(3, 107);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(56, 13);
            this.lblDatabase.TabIndex = 9;
            this.lblDatabase.Text = "Database:";
            this.lblDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTables
            // 
            this.lblTables.AutoSize = true;
            this.lblTables.Location = new System.Drawing.Point(23, 171);
            this.lblTables.Name = "lblTables";
            this.lblTables.Size = new System.Drawing.Size(42, 13);
            this.lblTables.TabIndex = 11;
            this.lblTables.Text = "Tables:";
            // 
            // txtTables
            // 
            this.txtTables.Location = new System.Drawing.Point(26, 188);
            this.txtTables.Multiline = true;
            this.txtTables.Name = "txtTables";
            this.txtTables.Size = new System.Drawing.Size(216, 76);
            this.txtTables.TabIndex = 12;
            this.txtTables.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(26, 498);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(216, 23);
            this.btnExecute.TabIndex = 15;
            this.btnExecute.Text = "Save SQL Server Dump to a File...";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.27778F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.72222F));
            this.tableLayoutPanel1.Controls.Add(this.ckbUseWinAuth, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblWinAuth, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPassword, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblPassword, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cboHostList, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblHost, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblUsername, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtUsername, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtDatabase, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDatabase, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(26, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(216, 128);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(26, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 100);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.2549F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.7451F));
            this.tableLayoutPanel2.Controls.Add(this.lblCreateUser, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.ckbCreateDatabase, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblCreateDatabase, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ckbNoData, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblNoData, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ckbCreateUser, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(204, 70);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblNoData
            // 
            this.lblNoData.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNoData.AutoSize = true;
            this.lblNoData.Location = new System.Drawing.Point(3, 5);
            this.lblNoData.Name = "lblNoData";
            this.lblNoData.Size = new System.Drawing.Size(119, 13);
            this.lblNoData.TabIndex = 9;
            this.lblNoData.Text = "Schema Only (No Data)";
            this.lblNoData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gpbConnectionSettings
            // 
            this.gpbConnectionSettings.Controls.Add(this.tableLayoutPanel3);
            this.gpbConnectionSettings.Location = new System.Drawing.Point(26, 385);
            this.gpbConnectionSettings.Name = "gpbConnectionSettings";
            this.gpbConnectionSettings.Size = new System.Drawing.Size(216, 100);
            this.gpbConnectionSettings.TabIndex = 19;
            this.gpbConnectionSettings.TabStop = false;
            this.gpbConnectionSettings.Text = "Connection Settings";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.5098F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.4902F));
            this.tableLayoutPanel3.Controls.Add(this.lblMaxPacket, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtTimeout, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblTimeout, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblEncryption, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.ckbEncryption, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtMaxPacket, 1, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 12);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.34426F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.65574F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(204, 82);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // lblEncryption
            // 
            this.lblEncryption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEncryption.AutoSize = true;
            this.lblEncryption.Location = new System.Drawing.Point(3, 3);
            this.lblEncryption.Name = "lblEncryption";
            this.lblEncryption.Size = new System.Drawing.Size(135, 13);
            this.lblEncryption.TabIndex = 14;
            this.lblEncryption.Text = "Use encrypted connection:";
            this.lblEncryption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTimeout
            // 
            this.txtTimeout.Location = new System.Drawing.Point(154, 22);
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.Size = new System.Drawing.Size(43, 20);
            this.txtTimeout.TabIndex = 12;
            this.txtTimeout.Text = "60";
            // 
            // ckbEncryption
            // 
            this.ckbEncryption.AutoSize = true;
            this.ckbEncryption.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbEncryption.Location = new System.Drawing.Point(154, 3);
            this.ckbEncryption.Name = "ckbEncryption";
            this.ckbEncryption.Size = new System.Drawing.Size(15, 13);
            this.ckbEncryption.TabIndex = 13;
            this.ckbEncryption.UseVisualStyleBackColor = true;
            this.ckbEncryption.CheckedChanged += new System.EventHandler(this.ckbEncryption_CheckedChanged);
            // 
            // lblTimeout
            // 
            this.lblTimeout.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTimeout.AutoSize = true;
            this.lblTimeout.Location = new System.Drawing.Point(3, 27);
            this.lblTimeout.Name = "lblTimeout";
            this.lblTimeout.Size = new System.Drawing.Size(127, 13);
            this.lblTimeout.TabIndex = 11;
            this.lblTimeout.Text = "Connection timeout (sec):";
            this.lblTimeout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCreateDatabase
            // 
            this.lblCreateDatabase.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCreateDatabase.AutoSize = true;
            this.lblCreateDatabase.Location = new System.Drawing.Point(3, 28);
            this.lblCreateDatabase.Name = "lblCreateDatabase";
            this.lblCreateDatabase.Size = new System.Drawing.Size(151, 13);
            this.lblCreateDatabase.TabIndex = 10;
            this.lblCreateDatabase.Text = "Include CREATE DATABASE:";
            this.lblCreateDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ckbCreateDatabase
            // 
            this.ckbCreateDatabase.AutoSize = true;
            this.ckbCreateDatabase.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbCreateDatabase.Location = new System.Drawing.Point(181, 26);
            this.ckbCreateDatabase.Name = "ckbCreateDatabase";
            this.ckbCreateDatabase.Size = new System.Drawing.Size(15, 14);
            this.ckbCreateDatabase.TabIndex = 11;
            this.ckbCreateDatabase.UseVisualStyleBackColor = true;
            this.ckbCreateDatabase.CheckedChanged += new System.EventHandler(this.ckbCreateDatabase_CheckedChanged);
            // 
            // lblCreateUser
            // 
            this.lblCreateUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCreateUser.AutoSize = true;
            this.lblCreateUser.Location = new System.Drawing.Point(3, 51);
            this.lblCreateUser.Name = "lblCreateUser";
            this.lblCreateUser.Size = new System.Drawing.Size(124, 13);
            this.lblCreateUser.TabIndex = 12;
            this.lblCreateUser.Text = "Include CREATE USER:";
            this.lblCreateUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ckbCreateUser
            // 
            this.ckbCreateUser.AutoSize = true;
            this.ckbCreateUser.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbCreateUser.Location = new System.Drawing.Point(181, 49);
            this.ckbCreateUser.Name = "ckbCreateUser";
            this.ckbCreateUser.Size = new System.Drawing.Size(15, 14);
            this.ckbCreateUser.TabIndex = 13;
            this.ckbCreateUser.UseVisualStyleBackColor = true;
            this.ckbCreateUser.CheckedChanged += new System.EventHandler(this.ckbCreateUser_CheckedChanged);
            // 
            // lblMaxPacket
            // 
            this.lblMaxPacket.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMaxPacket.AutoSize = true;
            this.lblMaxPacket.Location = new System.Drawing.Point(3, 58);
            this.lblMaxPacket.Name = "lblMaxPacket";
            this.lblMaxPacket.Size = new System.Drawing.Size(98, 13);
            this.lblMaxPacket.TabIndex = 15;
            this.lblMaxPacket.Text = "Max packet length:";
            this.lblMaxPacket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaxPacket
            // 
            this.txtMaxPacket.Location = new System.Drawing.Point(154, 51);
            this.txtMaxPacket.Name = "txtMaxPacket";
            this.txtMaxPacket.Size = new System.Drawing.Size(43, 20);
            this.txtMaxPacket.TabIndex = 16;
            this.txtMaxPacket.TextChanged += new System.EventHandler(this.txtMaxPacket_TextChanged);
            // 
            // lblWinAuth
            // 
            this.lblWinAuth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblWinAuth.AutoSize = true;
            this.lblWinAuth.Location = new System.Drawing.Point(3, 30);
            this.lblWinAuth.Name = "lblWinAuth";
            this.lblWinAuth.Size = new System.Drawing.Size(76, 13);
            this.lblWinAuth.TabIndex = 11;
            this.lblWinAuth.Text = "Use Win Auth:";
            this.lblWinAuth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblWinAuth.Click += new System.EventHandler(this.label1_Click);
            // 
            // ckbUseWinAuth
            // 
            this.ckbUseWinAuth.AutoSize = true;
            this.ckbUseWinAuth.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbUseWinAuth.Checked = true;
            this.ckbUseWinAuth.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbUseWinAuth.Location = new System.Drawing.Point(90, 30);
            this.ckbUseWinAuth.Name = "ckbUseWinAuth";
            this.ckbUseWinAuth.Size = new System.Drawing.Size(15, 14);
            this.ckbUseWinAuth.TabIndex = 12;
            this.ckbUseWinAuth.UseVisualStyleBackColor = true;
            this.ckbUseWinAuth.CheckedChanged += new System.EventHandler(this.ckbUseWinAuth_CheckedChanged);
            // 
            // ssdumpGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 536);
            this.Controls.Add(this.gpbConnectionSettings);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.txtTables);
            this.Controls.Add(this.lblTables);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 575);
            this.MinimumSize = new System.Drawing.Size(400, 575);
            this.Name = "ssdumpGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ssdump (SQL Server Dump)";
            this.Activated += new System.EventHandler(this.ssdumpGUI_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.gpbConnectionSettings.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editHostsToolStripMenuItem;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.ComboBox cboHostList;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.CheckBox ckbNoData;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Label lblTables;
        private System.Windows.Forms.TextBox txtTables;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblNoData;
        private System.Windows.Forms.Label lblCreateUser;
        private System.Windows.Forms.CheckBox ckbCreateDatabase;
        private System.Windows.Forms.Label lblCreateDatabase;
        private System.Windows.Forms.CheckBox ckbCreateUser;
        private System.Windows.Forms.GroupBox gpbConnectionSettings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblMaxPacket;
        private System.Windows.Forms.TextBox txtTimeout;
        private System.Windows.Forms.Label lblTimeout;
        private System.Windows.Forms.Label lblEncryption;
        private System.Windows.Forms.CheckBox ckbEncryption;
        private System.Windows.Forms.TextBox txtMaxPacket;
        private System.Windows.Forms.Label lblWinAuth;
        private System.Windows.Forms.CheckBox ckbUseWinAuth;
    }
}