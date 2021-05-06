namespace Cshrp_Semestralni_prace
{
    partial class ManagerForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.backButtonLeft = new System.Windows.Forms.Button();
            this.listViewLeft = new System.Windows.Forms.ListView();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.pathtextBoxLeft = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.historyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyMenuItemLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.historyMenuItemRight = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsBoxLeft = new System.Windows.Forms.RichTextBox();
            this.detailsBoxRight = new System.Windows.Forms.RichTextBox();
            this.pathtextBoxRight = new System.Windows.Forms.TextBox();
            this.listViewRight = new System.Windows.Forms.ListView();
            this.backButtonRight = new System.Windows.Forms.Button();
            this.btnRemoveLeft = new System.Windows.Forms.Button();
            this.btnRenameLeft = new System.Windows.Forms.Button();
            this.btnRenameRight = new System.Windows.Forms.Button();
            this.btnRemoveRight = new System.Windows.Forms.Button();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.btnCopyLeft = new System.Windows.Forms.Button();
            this.btnCopyRight = new System.Windows.Forms.Button();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.comboBoxDriveRight = new System.Windows.Forms.ComboBox();
            this.comboBoxDriveLeft = new System.Windows.Forms.ComboBox();
            this.tabControlDetailLeft = new System.Windows.Forms.TabControl();
            this.tabPageDetailLeft = new System.Windows.Forms.TabPage();
            this.tabPageHistoryLeft = new System.Windows.Forms.TabPage();
            this.listBoxHistoryLeft = new System.Windows.Forms.ListBox();
            this.tabControlDetailRight = new System.Windows.Forms.TabControl();
            this.tabPageDetailRight = new System.Windows.Forms.TabPage();
            this.tabPageHistoryRight = new System.Windows.Forms.TabPage();
            this.listBoxHistoryRight = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cleanMenuItemLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanMenuItemRight = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabControlDetailLeft.SuspendLayout();
            this.tabPageDetailLeft.SuspendLayout();
            this.tabPageHistoryLeft.SuspendLayout();
            this.tabControlDetailRight.SuspendLayout();
            this.tabPageDetailRight.SuspendLayout();
            this.tabPageHistoryRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackButtonLeft
            // 
            this.backButtonLeft.Location = new System.Drawing.Point(12, 30);
            this.backButtonLeft.Name = "BackButtonLeft";
            this.backButtonLeft.Size = new System.Drawing.Size(42, 20);
            this.backButtonLeft.TabIndex = 0;
            this.backButtonLeft.Text = "Back";
            this.backButtonLeft.UseVisualStyleBackColor = true;
            this.backButtonLeft.Click += new System.EventHandler(this.BackButtonLeft_Click);
            // 
            // listViewLeft
            // 
            this.listViewLeft.HideSelection = false;
            this.listViewLeft.LargeImageList = this.iconList;
            this.listViewLeft.Location = new System.Drawing.Point(12, 56);
            this.listViewLeft.MultiSelect = false;
            this.listViewLeft.Name = "listViewLeft";
            this.listViewLeft.Size = new System.Drawing.Size(544, 414);
            this.listViewLeft.SmallImageList = this.iconList;
            this.listViewLeft.TabIndex = 1;
            this.listViewLeft.UseCompatibleStateImageBehavior = false;
            this.listViewLeft.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListViewLeft_ItemSelectionChanged);
            this.listViewLeft.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListViewLeft_MouseDoubleClick);
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "folder.png");
            // 
            // PathtextBoxLeft
            // 
            this.pathtextBoxLeft.Location = new System.Drawing.Point(108, 31);
            this.pathtextBoxLeft.Name = "PathtextBoxLeft";
            this.pathtextBoxLeft.Size = new System.Drawing.Size(448, 20);
            this.pathtextBoxLeft.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1215, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // HistoryMenuItem
            // 
            this.historyMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyMenuItemLeft,
            this.cleanMenuItemLeft,
            this.toolStripSeparator1,
            this.historyMenuItemRight,
            this.cleanMenuItemRight});
            this.historyMenuItem.Name = "HistoryMenuItem";
            this.historyMenuItem.Size = new System.Drawing.Size(57, 20);
            this.historyMenuItem.Text = "History";
            // 
            // HistoryMenuItemLeft
            // 
            this.historyMenuItemLeft.Name = "HistoryMenuItemLeft";
            this.historyMenuItemLeft.Size = new System.Drawing.Size(180, 22);
            this.historyMenuItemLeft.Text = "Left window";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // HistoryMenuItemRight
            // 
            this.historyMenuItemRight.Name = "HistoryMenuItemRight";
            this.historyMenuItemRight.Size = new System.Drawing.Size(180, 22);
            this.historyMenuItemRight.Text = "Right window";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // DetailsBoxLeft
            // 
            this.detailsBoxLeft.Location = new System.Drawing.Point(-3, 0);
            this.detailsBoxLeft.Name = "DetailsBoxLeft";
            this.detailsBoxLeft.Size = new System.Drawing.Size(539, 159);
            this.detailsBoxLeft.TabIndex = 5;
            this.detailsBoxLeft.Text = "";
            // 
            // DetailsBoxRight
            // 
            this.detailsBoxRight.Location = new System.Drawing.Point(0, 0);
            this.detailsBoxRight.Name = "DetailsBoxRight";
            this.detailsBoxRight.Size = new System.Drawing.Size(536, 153);
            this.detailsBoxRight.TabIndex = 11;
            this.detailsBoxRight.Text = "";
            // 
            // PathtextBoxRight
            // 
            this.pathtextBoxRight.Location = new System.Drawing.Point(745, 31);
            this.pathtextBoxRight.Name = "PathtextBoxRight";
            this.pathtextBoxRight.Size = new System.Drawing.Size(448, 20);
            this.pathtextBoxRight.TabIndex = 9;
            // 
            // listViewRight
            // 
            this.listViewRight.HideSelection = false;
            this.listViewRight.LargeImageList = this.iconList;
            this.listViewRight.Location = new System.Drawing.Point(649, 56);
            this.listViewRight.MultiSelect = false;
            this.listViewRight.Name = "listViewRight";
            this.listViewRight.Size = new System.Drawing.Size(544, 414);
            this.listViewRight.SmallImageList = this.iconList;
            this.listViewRight.TabIndex = 8;
            this.listViewRight.UseCompatibleStateImageBehavior = false;
            this.listViewRight.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListViewRight_ItemSelectionChanged);
            this.listViewRight.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListViewRight_MouseDoubleClick);
            // 
            // BackButtonRight
            // 
            this.backButtonRight.Location = new System.Drawing.Point(649, 30);
            this.backButtonRight.Name = "BackButtonRight";
            this.backButtonRight.Size = new System.Drawing.Size(42, 20);
            this.backButtonRight.TabIndex = 7;
            this.backButtonRight.Text = "Back";
            this.backButtonRight.UseVisualStyleBackColor = true;
            this.backButtonRight.Click += new System.EventHandler(this.BackButtonRight_Click);
            // 
            // btnRemove_left
            // 
            this.btnRemoveLeft.Location = new System.Drawing.Point(562, 113);
            this.btnRemoveLeft.Name = "btnRemove_left";
            this.btnRemoveLeft.Size = new System.Drawing.Size(81, 23);
            this.btnRemoveLeft.TabIndex = 20;
            this.btnRemoveLeft.Text = "Remove file";
            this.btnRemoveLeft.UseVisualStyleBackColor = true;
            this.btnRemoveLeft.Click += new System.EventHandler(this.BtnRemoveLeft_Click);
            // 
            // btnRename_left
            // 
            this.btnRenameLeft.Location = new System.Drawing.Point(562, 142);
            this.btnRenameLeft.Name = "btnRename_left";
            this.btnRenameLeft.Size = new System.Drawing.Size(81, 23);
            this.btnRenameLeft.TabIndex = 21;
            this.btnRenameLeft.Text = "Rename file";
            this.btnRenameLeft.UseVisualStyleBackColor = true;
            this.btnRenameLeft.Click += new System.EventHandler(this.BtnRenameLeft_Click);
            // 
            // btnRename_right
            // 
            this.btnRenameRight.Location = new System.Drawing.Point(562, 330);
            this.btnRenameRight.Name = "btnRename_right";
            this.btnRenameRight.Size = new System.Drawing.Size(81, 23);
            this.btnRenameRight.TabIndex = 23;
            this.btnRenameRight.Text = "Rename file";
            this.btnRenameRight.UseVisualStyleBackColor = true;
            this.btnRenameRight.Click += new System.EventHandler(this.BtnRenameRight_Click);
            // 
            // btnRemove_right
            // 
            this.btnRemoveRight.Location = new System.Drawing.Point(562, 301);
            this.btnRemoveRight.Name = "btnRemove_right";
            this.btnRemoveRight.Size = new System.Drawing.Size(81, 23);
            this.btnRemoveRight.TabIndex = 22;
            this.btnRemoveRight.Text = "Remove file";
            this.btnRemoveRight.UseVisualStyleBackColor = true;
            this.btnRemoveRight.Click += new System.EventHandler(this.BtnRemoveRight_Click);
            // 
            // btnMove_left
            // 
            this.btnMoveLeft.Location = new System.Drawing.Point(562, 171);
            this.btnMoveLeft.Name = "btnMove_left";
            this.btnMoveLeft.Size = new System.Drawing.Size(81, 23);
            this.btnMoveLeft.TabIndex = 24;
            this.btnMoveLeft.Text = "Move ▷▷";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            this.btnMoveLeft.Click += new System.EventHandler(this.BtnMoveLeft_Click);
            // 
            // btnCopy_left
            // 
            this.btnCopyLeft.Location = new System.Drawing.Point(562, 200);
            this.btnCopyLeft.Name = "btnCopy_left";
            this.btnCopyLeft.Size = new System.Drawing.Size(81, 23);
            this.btnCopyLeft.TabIndex = 25;
            this.btnCopyLeft.Text = "Copy ▷▷";
            this.btnCopyLeft.UseVisualStyleBackColor = true;
            this.btnCopyLeft.Click += new System.EventHandler(this.BtnCopyLeft_Click);
            // 
            // btnCopy_right
            // 
            this.btnCopyRight.Location = new System.Drawing.Point(562, 388);
            this.btnCopyRight.Name = "btnCopy_right";
            this.btnCopyRight.Size = new System.Drawing.Size(81, 23);
            this.btnCopyRight.TabIndex = 27;
            this.btnCopyRight.Text = "◁◁ Copy";
            this.btnCopyRight.UseVisualStyleBackColor = true;
            this.btnCopyRight.Click += new System.EventHandler(this.BtnCopyRight_Click);
            // 
            // btnMove_right
            // 
            this.btnMoveRight.Location = new System.Drawing.Point(562, 359);
            this.btnMoveRight.Name = "btnMove_right";
            this.btnMoveRight.Size = new System.Drawing.Size(81, 23);
            this.btnMoveRight.TabIndex = 26;
            this.btnMoveRight.Text = "◁◁ Move";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += new System.EventHandler(this.BtnMoveRight_Click);
            // 
            // ComboBoxDriveRight
            // 
            this.comboBoxDriveRight.FormattingEnabled = true;
            this.comboBoxDriveRight.Location = new System.Drawing.Point(698, 29);
            this.comboBoxDriveRight.Name = "ComboBoxDriveRight";
            this.comboBoxDriveRight.Size = new System.Drawing.Size(41, 21);
            this.comboBoxDriveRight.TabIndex = 28;
            // 
            // ComboBoxDriveLeft
            // 
            this.comboBoxDriveLeft.FormattingEnabled = true;
            this.comboBoxDriveLeft.Location = new System.Drawing.Point(61, 31);
            this.comboBoxDriveLeft.Name = "ComboBoxDriveLeft";
            this.comboBoxDriveLeft.Size = new System.Drawing.Size(41, 21);
            this.comboBoxDriveLeft.TabIndex = 29;
            // 
            // tabControl_detail_left
            // 
            this.tabControlDetailLeft.Controls.Add(this.tabPageDetailLeft);
            this.tabControlDetailLeft.Controls.Add(this.tabPageHistoryLeft);
            this.tabControlDetailLeft.Location = new System.Drawing.Point(12, 476);
            this.tabControlDetailLeft.Name = "tabControl_detail_left";
            this.tabControlDetailLeft.SelectedIndex = 0;
            this.tabControlDetailLeft.Size = new System.Drawing.Size(544, 181);
            this.tabControlDetailLeft.TabIndex = 30;
            // 
            // tabPage_detail_left
            // 
            this.tabPageDetailLeft.Controls.Add(this.detailsBoxLeft);
            this.tabPageDetailLeft.Location = new System.Drawing.Point(4, 22);
            this.tabPageDetailLeft.Name = "tabPage_detail_left";
            this.tabPageDetailLeft.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDetailLeft.Size = new System.Drawing.Size(536, 155);
            this.tabPageDetailLeft.TabIndex = 0;
            this.tabPageDetailLeft.Text = "Detail";
            this.tabPageDetailLeft.UseVisualStyleBackColor = true;
            // 
            // tabPage_hidtory_left
            // 
            this.tabPageHistoryLeft.Controls.Add(this.listBoxHistoryLeft);
            this.tabPageHistoryLeft.Location = new System.Drawing.Point(4, 22);
            this.tabPageHistoryLeft.Name = "tabPage_hidtory_left";
            this.tabPageHistoryLeft.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHistoryLeft.Size = new System.Drawing.Size(536, 155);
            this.tabPageHistoryLeft.TabIndex = 1;
            this.tabPageHistoryLeft.Text = "History";
            this.tabPageHistoryLeft.UseVisualStyleBackColor = true;
            // 
            // listBoxHistoryLeft
            // 
            this.listBoxHistoryLeft.FormattingEnabled = true;
            this.listBoxHistoryLeft.Location = new System.Drawing.Point(0, 0);
            this.listBoxHistoryLeft.Name = "listBoxHistoryLeft";
            this.listBoxHistoryLeft.Size = new System.Drawing.Size(536, 147);
            this.listBoxHistoryLeft.TabIndex = 0;
            this.listBoxHistoryLeft.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxHistoryLeft_MouseDoubleClick);
            // 
            // tabControl_detail_right
            // 
            this.tabControlDetailRight.Controls.Add(this.tabPageDetailRight);
            this.tabControlDetailRight.Controls.Add(this.tabPageHistoryRight);
            this.tabControlDetailRight.Location = new System.Drawing.Point(649, 476);
            this.tabControlDetailRight.Name = "tabControl_detail_right";
            this.tabControlDetailRight.SelectedIndex = 0;
            this.tabControlDetailRight.Size = new System.Drawing.Size(544, 179);
            this.tabControlDetailRight.TabIndex = 31;
            // 
            // tabPage_detail_right
            // 
            this.tabPageDetailRight.Controls.Add(this.detailsBoxRight);
            this.tabPageDetailRight.Location = new System.Drawing.Point(4, 22);
            this.tabPageDetailRight.Name = "tabPage_detail_right";
            this.tabPageDetailRight.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDetailRight.Size = new System.Drawing.Size(536, 153);
            this.tabPageDetailRight.TabIndex = 0;
            this.tabPageDetailRight.Text = "Detail";
            this.tabPageDetailRight.UseVisualStyleBackColor = true;
            // 
            // tabPage_history_right
            // 
            this.tabPageHistoryRight.Controls.Add(this.listBoxHistoryRight);
            this.tabPageHistoryRight.Location = new System.Drawing.Point(4, 22);
            this.tabPageHistoryRight.Name = "tabPage_history_right";
            this.tabPageHistoryRight.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHistoryRight.Size = new System.Drawing.Size(536, 153);
            this.tabPageHistoryRight.TabIndex = 1;
            this.tabPageHistoryRight.Text = "History";
            this.tabPageHistoryRight.UseVisualStyleBackColor = true;
            // 
            // listBoxHistoryRight
            // 
            this.listBoxHistoryRight.FormattingEnabled = true;
            this.listBoxHistoryRight.Location = new System.Drawing.Point(0, 0);
            this.listBoxHistoryRight.Name = "listBoxHistoryRight";
            this.listBoxHistoryRight.Size = new System.Drawing.Size(536, 147);
            this.listBoxHistoryRight.TabIndex = 36;
            this.listBoxHistoryRight.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxHistoryRight_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(570, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Left window";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 641);
            this.splitter1.TabIndex = 33;
            this.splitter1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(562, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 2);
            this.label2.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(570, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Right window";
            // 
            // cleanMenuItemLeft
            // 
            this.cleanMenuItemLeft.Name = "cleanMenuItemLeft";
            this.cleanMenuItemLeft.Size = new System.Drawing.Size(180, 22);
            this.cleanMenuItemLeft.Text = "Clean history (left)";
            // 
            // cleanMenuItemRight
            // 
            this.cleanMenuItemRight.Name = "cleanMenuItemRight";
            this.cleanMenuItemRight.Size = new System.Drawing.Size(180, 22);
            this.cleanMenuItemRight.Text = "Clean history (right)";
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 665);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControlDetailRight);
            this.Controls.Add(this.tabControlDetailLeft);
            this.Controls.Add(this.comboBoxDriveLeft);
            this.Controls.Add(this.comboBoxDriveRight);
            this.Controls.Add(this.btnCopyRight);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.btnCopyLeft);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.btnRenameRight);
            this.Controls.Add(this.btnRemoveRight);
            this.Controls.Add(this.btnRenameLeft);
            this.Controls.Add(this.btnRemoveLeft);
            this.Controls.Add(this.pathtextBoxRight);
            this.Controls.Add(this.listViewRight);
            this.Controls.Add(this.backButtonRight);
            this.Controls.Add(this.pathtextBoxLeft);
            this.Controls.Add(this.listViewLeft);
            this.Controls.Add(this.backButtonLeft);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManagerForm";
            this.Text = "GFM - File Manager v.1.3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlDetailLeft.ResumeLayout(false);
            this.tabPageDetailLeft.ResumeLayout(false);
            this.tabPageHistoryLeft.ResumeLayout(false);
            this.tabControlDetailRight.ResumeLayout(false);
            this.tabPageDetailRight.ResumeLayout(false);
            this.tabPageHistoryRight.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButtonLeft;
        private System.Windows.Forms.ListView listViewLeft;
        private System.Windows.Forms.TextBox pathtextBoxLeft;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem historyMenuItem;
        private System.Windows.Forms.RichTextBox detailsBoxLeft;
        private System.Windows.Forms.RichTextBox detailsBoxRight;
        private System.Windows.Forms.TextBox pathtextBoxRight;
        private System.Windows.Forms.ListView listViewRight;
        private System.Windows.Forms.Button backButtonRight;
        private System.Windows.Forms.Button btnRemoveLeft;
        private System.Windows.Forms.Button btnRenameLeft;
        private System.Windows.Forms.Button btnRenameRight;
        private System.Windows.Forms.Button btnRemoveRight;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.Button btnCopyLeft;
        private System.Windows.Forms.Button btnCopyRight;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.ComboBox comboBoxDriveRight;
        private System.Windows.Forms.ComboBox comboBoxDriveLeft;
        private System.Windows.Forms.ToolStripMenuItem historyMenuItemLeft;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem historyMenuItemRight;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlDetailLeft;
        private System.Windows.Forms.TabPage tabPageDetailLeft;
        private System.Windows.Forms.TabPage tabPageHistoryLeft;
        private System.Windows.Forms.TabControl tabControlDetailRight;
        private System.Windows.Forms.TabPage tabPageDetailRight;
        private System.Windows.Forms.TabPage tabPageHistoryRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxHistoryLeft;
        private System.Windows.Forms.ListBox listBoxHistoryRight;
        private System.Windows.Forms.ToolStripMenuItem cleanMenuItemLeft;
        private System.Windows.Forms.ToolStripMenuItem cleanMenuItemRight;
    }
}

