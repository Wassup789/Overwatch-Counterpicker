namespace Overwatch_Team_Overview
{
    partial class MainForm
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
            System.Windows.Forms.ListViewGroup listViewGroup16 = new System.Windows.Forms.ListViewGroup("Enemies (Data by Unknown)", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup17 = new System.Windows.Forms.ListViewGroup("Overall", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup18 = new System.Windows.Forms.ListViewGroup("Waiting for User to Refresh", System.Windows.Forms.HorizontalAlignment.Left);
            this.mainListView = new System.Windows.Forms.ListView();
            this.columnHeaderEnemy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.refreshButtonValue = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.requirementsGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.viewInstructionsButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wassup789StripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualGroupBox = new System.Windows.Forms.GroupBox();
            this.enemy0ComboBox = new System.Windows.Forms.ComboBox();
            this.enemy1ComboBox = new System.Windows.Forms.ComboBox();
            this.enemy2ComboBox = new System.Windows.Forms.ComboBox();
            this.enemy3ComboBox = new System.Windows.Forms.ComboBox();
            this.enemy4ComboBox = new System.Windows.Forms.ComboBox();
            this.enemy5ComboBox = new System.Windows.Forms.ComboBox();
            this.settingsGroupBox.SuspendLayout();
            this.requirementsGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.manualGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainListView
            // 
            this.mainListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderEnemy,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21});
            listViewGroup16.Header = "Enemies (Data by Unknown)";
            listViewGroup16.Name = "listViewGroupEnemy";
            listViewGroup17.Header = "Overall";
            listViewGroup17.Name = "listViewGroupOverall";
            listViewGroup18.Header = "Waiting for User to Refresh";
            listViewGroup18.Name = "listViewGroupWaiting";
            this.mainListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup16,
            listViewGroup17,
            listViewGroup18});
            this.mainListView.Location = new System.Drawing.Point(12, 27);
            this.mainListView.Name = "mainListView";
            this.mainListView.Size = new System.Drawing.Size(1328, 210);
            this.mainListView.TabIndex = 0;
            this.mainListView.UseCompatibleStateImageBehavior = false;
            this.mainListView.View = System.Windows.Forms.View.Details;
            this.mainListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.mainListView_ItemSelectionChanged);
            // 
            // columnHeaderEnemy
            // 
            this.columnHeaderEnemy.Text = "Enemy Team";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Genji";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "McCree";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Pharah";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Reaper";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Soldier: 76";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tracer";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Bastion";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Hanzo";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Junkrat";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Mei";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Torbjorn";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Widowmaker";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "D.Va";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Reinhardt";
            this.columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Roadhog";
            this.columnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Winston";
            this.columnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Zarya";
            this.columnHeader17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Lucio";
            this.columnHeader18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Mercy";
            this.columnHeader19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Symmetra";
            this.columnHeader20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Zenyatta";
            this.columnHeader21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.settingsGroupBox.Controls.Add(this.saveSettingsButton);
            this.settingsGroupBox.Controls.Add(this.refreshButtonValue);
            this.settingsGroupBox.Controls.Add(this.label6);
            this.settingsGroupBox.Location = new System.Drawing.Point(12, 243);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Size = new System.Drawing.Size(292, 62);
            this.settingsGroupBox.TabIndex = 1;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "Settings";
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveSettingsButton.Location = new System.Drawing.Point(211, 33);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.saveSettingsButton.TabIndex = 6;
            this.saveSettingsButton.Text = "Save";
            this.saveSettingsButton.UseVisualStyleBackColor = true;
            this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // refreshButtonValue
            // 
            this.refreshButtonValue.FormattingEnabled = true;
            this.refreshButtonValue.Items.AddRange(new object[] {
            "G",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "-",
            "=",
            "[",
            "]",
            "\\",
            ";",
            "\'",
            ",",
            ".",
            "/"});
            this.refreshButtonValue.Location = new System.Drawing.Point(96, 22);
            this.refreshButtonValue.Name = "refreshButtonValue";
            this.refreshButtonValue.Size = new System.Drawing.Size(70, 21);
            this.refreshButtonValue.TabIndex = 5;
            this.refreshButtonValue.SelectedIndexChanged += new System.EventHandler(this.refreshButtonValue_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Refresh Key: ";
            // 
            // requirementsGroupBox
            // 
            this.requirementsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.requirementsGroupBox.Controls.Add(this.label4);
            this.requirementsGroupBox.Controls.Add(this.label3);
            this.requirementsGroupBox.Controls.Add(this.label2);
            this.requirementsGroupBox.Controls.Add(this.label1);
            this.requirementsGroupBox.Location = new System.Drawing.Point(1053, 243);
            this.requirementsGroupBox.Name = "requirementsGroupBox";
            this.requirementsGroupBox.Size = new System.Drawing.Size(287, 62);
            this.requirementsGroupBox.TabIndex = 2;
            this.requirementsGroupBox.TabStop = false;
            this.requirementsGroupBox.Text = "Requirements";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Borderless Windowed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Required Screen Mode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "1920x1080";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recommended Resolution:";
            // 
            // viewInstructionsButton
            // 
            this.viewInstructionsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewInstructionsButton.Location = new System.Drawing.Point(6, 19);
            this.viewInstructionsButton.Name = "viewInstructionsButton";
            this.viewInstructionsButton.Size = new System.Drawing.Size(148, 32);
            this.viewInstructionsButton.TabIndex = 5;
            this.viewInstructionsButton.Text = "View Instructions";
            this.viewInstructionsButton.UseVisualStyleBackColor = true;
            this.viewInstructionsButton.Click += new System.EventHandler(this.viewInstructionsButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.viewInstructionsButton);
            this.groupBox1.Location = new System.Drawing.Point(310, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 62);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Instructions";
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1352, 24);
            this.mainMenuStrip.TabIndex = 7;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editDataToolStripMenuItem,
            this.reloadDataToolStripMenuItem,
            this.debugToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // editDataToolStripMenuItem
            // 
            this.editDataToolStripMenuItem.Name = "editDataToolStripMenuItem";
            this.editDataToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.editDataToolStripMenuItem.Text = "Edit Data";
            this.editDataToolStripMenuItem.Click += new System.EventHandler(this.editDataToolStripMenuItem_Click);
            // 
            // reloadDataToolStripMenuItem
            // 
            this.reloadDataToolStripMenuItem.Name = "reloadDataToolStripMenuItem";
            this.reloadDataToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.reloadDataToolStripMenuItem.Text = "Reload Data";
            this.reloadDataToolStripMenuItem.ToolTipText = "Reloads the data.json file";
            this.reloadDataToolStripMenuItem.Click += new System.EventHandler(this.reloadDataToolStripMenuItem_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.debugToolStripMenuItem.Text = "Debug Mode";
            this.debugToolStripMenuItem.Click += new System.EventHandler(this.debugToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionStripMenuItem,
            this.wassup789StripMenuItem,
            this.dataStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // versionStripMenuItem
            // 
            this.versionStripMenuItem.Name = "versionStripMenuItem";
            this.versionStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.versionStripMenuItem.Text = "Version 1.0.0.0";
            this.versionStripMenuItem.Click += new System.EventHandler(this.versionStripMenuItem_Click);
            // 
            // wassup789StripMenuItem
            // 
            this.wassup789StripMenuItem.Name = "wassup789StripMenuItem";
            this.wassup789StripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.wassup789StripMenuItem.Text = "by Wassup789";
            this.wassup789StripMenuItem.Click += new System.EventHandler(this.wassup789StripMenuItem_Click);
            // 
            // dataStripMenuItem
            // 
            this.dataStripMenuItem.Name = "dataStripMenuItem";
            this.dataStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.dataStripMenuItem.Text = "Data by Unknown";
            this.dataStripMenuItem.Click += new System.EventHandler(this.dataStripMenuItem_Click);
            // 
            // manualGroupBox
            // 
            this.manualGroupBox.Controls.Add(this.enemy5ComboBox);
            this.manualGroupBox.Controls.Add(this.enemy4ComboBox);
            this.manualGroupBox.Controls.Add(this.enemy3ComboBox);
            this.manualGroupBox.Controls.Add(this.enemy2ComboBox);
            this.manualGroupBox.Controls.Add(this.enemy1ComboBox);
            this.manualGroupBox.Controls.Add(this.enemy0ComboBox);
            this.manualGroupBox.Location = new System.Drawing.Point(476, 243);
            this.manualGroupBox.Name = "manualGroupBox";
            this.manualGroupBox.Size = new System.Drawing.Size(571, 62);
            this.manualGroupBox.TabIndex = 8;
            this.manualGroupBox.TabStop = false;
            this.manualGroupBox.Text = "Manual Edit";
            // 
            // enemy0ComboBox
            // 
            this.enemy0ComboBox.FormattingEnabled = true;
            this.enemy0ComboBox.Location = new System.Drawing.Point(6, 22);
            this.enemy0ComboBox.Name = "enemy0ComboBox";
            this.enemy0ComboBox.Size = new System.Drawing.Size(85, 21);
            this.enemy0ComboBox.TabIndex = 0;
            this.enemy0ComboBox.SelectedIndexChanged += new System.EventHandler(this.enemy0ComboBox_SelectedIndexChanged);
            // 
            // enemy1ComboBox
            // 
            this.enemy1ComboBox.FormattingEnabled = true;
            this.enemy1ComboBox.Location = new System.Drawing.Point(97, 22);
            this.enemy1ComboBox.Name = "enemy1ComboBox";
            this.enemy1ComboBox.Size = new System.Drawing.Size(85, 21);
            this.enemy1ComboBox.TabIndex = 1;
            this.enemy1ComboBox.SelectedIndexChanged += new System.EventHandler(this.enemy1ComboBox_SelectedIndexChanged);
            // 
            // enemy2ComboBox
            // 
            this.enemy2ComboBox.FormattingEnabled = true;
            this.enemy2ComboBox.Location = new System.Drawing.Point(188, 22);
            this.enemy2ComboBox.Name = "enemy2ComboBox";
            this.enemy2ComboBox.Size = new System.Drawing.Size(85, 21);
            this.enemy2ComboBox.TabIndex = 2;
            this.enemy2ComboBox.SelectedIndexChanged += new System.EventHandler(this.enemy2ComboBox_SelectedIndexChanged);
            // 
            // enemy3ComboBox
            // 
            this.enemy3ComboBox.FormattingEnabled = true;
            this.enemy3ComboBox.Location = new System.Drawing.Point(279, 22);
            this.enemy3ComboBox.Name = "enemy3ComboBox";
            this.enemy3ComboBox.Size = new System.Drawing.Size(85, 21);
            this.enemy3ComboBox.TabIndex = 3;
            this.enemy3ComboBox.SelectedIndexChanged += new System.EventHandler(this.enemy3ComboBox_SelectedIndexChanged);
            // 
            // enemy4ComboBox
            // 
            this.enemy4ComboBox.FormattingEnabled = true;
            this.enemy4ComboBox.Location = new System.Drawing.Point(370, 22);
            this.enemy4ComboBox.Name = "enemy4ComboBox";
            this.enemy4ComboBox.Size = new System.Drawing.Size(85, 21);
            this.enemy4ComboBox.TabIndex = 4;
            this.enemy4ComboBox.SelectedIndexChanged += new System.EventHandler(this.enemy4ComboBox_SelectedIndexChanged);
            // 
            // enemy5ComboBox
            // 
            this.enemy5ComboBox.FormattingEnabled = true;
            this.enemy5ComboBox.Location = new System.Drawing.Point(461, 22);
            this.enemy5ComboBox.Name = "enemy5ComboBox";
            this.enemy5ComboBox.Size = new System.Drawing.Size(85, 21);
            this.enemy5ComboBox.TabIndex = 5;
            this.enemy5ComboBox.SelectedIndexChanged += new System.EventHandler(this.enemy5ComboBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 311);
            this.Controls.Add(this.manualGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.requirementsGroupBox);
            this.Controls.Add(this.settingsGroupBox);
            this.Controls.Add(this.mainListView);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Overwatch Counterpicker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.settingsGroupBox.ResumeLayout(false);
            this.settingsGroupBox.PerformLayout();
            this.requirementsGroupBox.ResumeLayout(false);
            this.requirementsGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.manualGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView mainListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeaderEnemy;
        private System.Windows.Forms.GroupBox settingsGroupBox;
        private System.Windows.Forms.GroupBox requirementsGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox refreshButtonValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveSettingsButton;
        private System.Windows.Forms.Button viewInstructionsButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wassup789StripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.GroupBox manualGroupBox;
        private System.Windows.Forms.ComboBox enemy0ComboBox;
        private System.Windows.Forms.ComboBox enemy4ComboBox;
        private System.Windows.Forms.ComboBox enemy3ComboBox;
        private System.Windows.Forms.ComboBox enemy2ComboBox;
        private System.Windows.Forms.ComboBox enemy1ComboBox;
        private System.Windows.Forms.ComboBox enemy5ComboBox;
    }
}

