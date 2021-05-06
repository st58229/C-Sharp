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
            this.BackButtonLeft = new System.Windows.Forms.Button();
            this.listViewLeft = new System.Windows.Forms.ListView();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.PathtextBoxLeft = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HistoryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HistoryMenuItemLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.HistoryMenuItemRight = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DetailsBoxLeft = new System.Windows.Forms.RichTextBox();
            this.DetailsBoxRight = new System.Windows.Forms.RichTextBox();
            this.PathtextBoxRight = new System.Windows.Forms.TextBox();
            this.listViewRight = new System.Windows.Forms.ListView();
            this.BackButtonRight = new System.Windows.Forms.Button();
            this.btnRemove_left = new System.Windows.Forms.Button();
            this.btnRename_left = new System.Windows.Forms.Button();
            this.btnRename_right = new System.Windows.Forms.Button();
            this.btnRemove_right = new System.Windows.Forms.Button();
            this.btnMove_left = new System.Windows.Forms.Button();
            this.btnCopy_left = new System.Windows.Forms.Button();
            this.btnCopy_right = new System.Windows.Forms.Button();
            this.btnMove_right = new System.Windows.Forms.Button();
            this.ComboBoxDriveRight = new System.Windows.Forms.ComboBox();
            this.ComboBoxDriveLeft = new System.Windows.Forms.ComboBox();
            this.tabControl_detail_left = new System.Windows.Forms.TabControl();
            this.tabPage_detail_left = new System.Windows.Forms.TabPage();
            this.tabPage_hidtory_left = new System.Windows.Forms.TabPage();
            this.listBoxHistoryLeft = new System.Windows.Forms.ListBox();
            this.tabControl_detail_right = new System.Windows.Forms.TabControl();
            this.tabPage_detail_right = new System.Windows.Forms.TabPage();
            this.tabPage_history_right = new System.Windows.Forms.TabPage();
            this.listBoxHistoryRight = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CleanMenuItemLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.CleanMenuItemRight = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabControl_detail_left.SuspendLayout();
            this.tabPage_detail_left.SuspendLayout();
            this.tabPage_hidtory_left.SuspendLayout();
            this.tabControl_detail_right.SuspendLayout();
            this.tabPage_detail_right.SuspendLayout();
            this.tabPage_history_right.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackButtonLeft
            // 
            this.BackButtonLeft.Location = new System.Drawing.Point(12, 30);
            this.BackButtonLeft.Name = "BackButtonLeft";
            this.BackButtonLeft.Size = new System.Drawing.Size(42, 20);
            this.BackButtonLeft.TabIndex = 0;
            this.BackButtonLeft.Text = "Back";
            this.BackButtonLeft.UseVisualStyleBackColor = true;
            this.BackButtonLeft.Click += new System.EventHandler(this.BackButtonLeft_Click);
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
            this.PathtextBoxLeft.Location = new System.Drawing.Point(108, 31);
            this.PathtextBoxLeft.Name = "PathtextBoxLeft";
            this.PathtextBoxLeft.Size = new System.Drawing.Size(448, 20);
            this.PathtextBoxLeft.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HistoryMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1215, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // HistoryMenuItem
            // 
            this.HistoryMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HistoryMenuItemLeft,
            this.CleanMenuItemLeft,
            this.toolStripSeparator1,
            this.HistoryMenuItemRight,
            this.CleanMenuItemRight});
            this.HistoryMenuItem.Name = "HistoryMenuItem";
            this.HistoryMenuItem.Size = new System.Drawing.Size(57, 20);
            this.HistoryMenuItem.Text = "History";
            // 
            // HistoryMenuItemLeft
            // 
            this.HistoryMenuItemLeft.Name = "HistoryMenuItemLeft";
            this.HistoryMenuItemLeft.Size = new System.Drawing.Size(180, 22);
            this.HistoryMenuItemLeft.Text = "Left window";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // HistoryMenuItemRight
            // 
            this.HistoryMenuItemRight.Name = "HistoryMenuItemRight";
            this.HistoryMenuItemRight.Size = new System.Drawing.Size(180, 22);
            this.HistoryMenuItemRight.Text = "Right window";
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
            this.DetailsBoxLeft.Location = new System.Drawing.Point(-3, 0);
            this.DetailsBoxLeft.Name = "DetailsBoxLeft";
            this.DetailsBoxLeft.Size = new System.Drawing.Size(539, 159);
            this.DetailsBoxLeft.TabIndex = 5;
            this.DetailsBoxLeft.Text = "";
            // 
            // DetailsBoxRight
            // 
            this.DetailsBoxRight.Location = new System.Drawing.Point(0, 0);
            this.DetailsBoxRight.Name = "DetailsBoxRight";
            this.DetailsBoxRight.Size = new System.Drawing.Size(536, 153);
            this.DetailsBoxRight.TabIndex = 11;
            this.DetailsBoxRight.Text = "";
            // 
            // PathtextBoxRight
            // 
            this.PathtextBoxRight.Location = new System.Drawing.Point(745, 31);
            this.PathtextBoxRight.Name = "PathtextBoxRight";
            this.PathtextBoxRight.Size = new System.Drawing.Size(448, 20);
            this.PathtextBoxRight.TabIndex = 9;
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
            this.BackButtonRight.Location = new System.Drawing.Point(649, 30);
            this.BackButtonRight.Name = "BackButtonRight";
            this.BackButtonRight.Size = new System.Drawing.Size(42, 20);
            this.BackButtonRight.TabIndex = 7;
            this.BackButtonRight.Text = "Back";
            this.BackButtonRight.UseVisualStyleBackColor = true;
            this.BackButtonRight.Click += new System.EventHandler(this.BackButtonRight_Click);
            // 
            // btnRemove_left
            // 
            this.btnRemove_left.Location = new System.Drawing.Point(562, 113);
            this.btnRemove_left.Name = "btnRemove_left";
            this.btnRemove_left.Size = new System.Drawing.Size(81, 23);
            this.btnRemove_left.TabIndex = 20;
            this.btnRemove_left.Text = "Remove file";
            this.btnRemove_left.UseVisualStyleBackColor = true;
            this.btnRemove_left.Click += new System.EventHandler(this.BtnRemoveLeft_Click);
            // 
            // btnRename_left
            // 
            this.btnRename_left.Location = new System.Drawing.Point(562, 142);
            this.btnRename_left.Name = "btnRename_left";
            this.btnRename_left.Size = new System.Drawing.Size(81, 23);
            this.btnRename_left.TabIndex = 21;
            this.btnRename_left.Text = "Rename file";
            this.btnRename_left.UseVisualStyleBackColor = true;
            this.btnRename_left.Click += new System.EventHandler(this.BtnRenameLeft_Click);
            // 
            // btnRename_right
            // 
            this.btnRename_right.Location = new System.Drawing.Point(562, 330);
            this.btnRename_right.Name = "btnRename_right";
            this.btnRename_right.Size = new System.Drawing.Size(81, 23);
            this.btnRename_right.TabIndex = 23;
            this.btnRename_right.Text = "Rename file";
            this.btnRename_right.UseVisualStyleBackColor = true;
            this.btnRename_right.Click += new System.EventHandler(this.BtnRenameRight_Click);
            // 
            // btnRemove_right
            // 
            this.btnRemove_right.Location = new System.Drawing.Point(562, 301);
            this.btnRemove_right.Name = "btnRemove_right";
            this.btnRemove_right.Size = new System.Drawing.Size(81, 23);
            this.btnRemove_right.TabIndex = 22;
            this.btnRemove_right.Text = "Remove file";
            this.btnRemove_right.UseVisualStyleBackColor = true;
            this.btnRemove_right.Click += new System.EventHandler(this.BtnRemoveRight_Click);
            // 
            // btnMove_left
            // 
            this.btnMove_left.Location = new System.Drawing.Point(562, 171);
            this.btnMove_left.Name = "btnMove_left";
            this.btnMove_left.Size = new System.Drawing.Size(81, 23);
            this.btnMove_left.TabIndex = 24;
            this.btnMove_left.Text = "Move ▷▷";
            this.btnMove_left.UseVisualStyleBackColor = true;
            this.btnMove_left.Click += new System.EventHandler(this.BtnMoveLeft_Click);
            // 
            // btnCopy_left
            // 
            this.btnCopy_left.Location = new System.Drawing.Point(562, 200);
            this.btnCopy_left.Name = "btnCopy_left";
            this.btnCopy_left.Size = new System.Drawing.Size(81, 23);
            this.btnCopy_left.TabIndex = 25;
            this.btnCopy_left.Text = "Copy ▷▷";
            this.btnCopy_left.UseVisualStyleBackColor = true;
            this.btnCopy_left.Click += new System.EventHandler(this.BtnCopyLeft_Click);
            // 
            // btnCopy_right
            // 
            this.btnCopy_right.Location = new System.Drawing.Point(562, 388);
            this.btnCopy_right.Name = "btnCopy_right";
            this.btnCopy_right.Size = new System.Drawing.Size(81, 23);
            this.btnCopy_right.TabIndex = 27;
            this.btnCopy_right.Text = "◁◁ Copy";
            this.btnCopy_right.UseVisualStyleBackColor = true;
            this.btnCopy_right.Click += new System.EventHandler(this.BtnCopyRight_Click);
            // 
            // btnMove_right
            // 
            this.btnMove_right.Location = new System.Drawing.Point(562, 359);
            this.btnMove_right.Name = "btnMove_right";
            this.btnMove_right.Size = new System.Drawing.Size(81, 23);
            this.btnMove_right.TabIndex = 26;
            this.btnMove_right.Text = "◁◁ Move";
            this.btnMove_right.UseVisualStyleBackColor = true;
            this.btnMove_right.Click += new System.EventHandler(this.BtnMoveRight_Click);
            // 
            // ComboBoxDriveRight
            // 
            this.ComboBoxDriveRight.FormattingEnabled = true;
            this.ComboBoxDriveRight.Location = new System.Drawing.Point(698, 29);
            this.ComboBoxDriveRight.Name = "ComboBoxDriveRight";
            this.ComboBoxDriveRight.Size = new System.Drawing.Size(41, 21);
            this.ComboBoxDriveRight.TabIndex = 28;
            // 
            // ComboBoxDriveLeft
            // 
            this.ComboBoxDriveLeft.FormattingEnabled = true;
            this.ComboBoxDriveLeft.Location = new System.Drawing.Point(61, 31);
            this.ComboBoxDriveLeft.Name = "ComboBoxDriveLeft";
            this.ComboBoxDriveLeft.Size = new System.Drawing.Size(41, 21);
            this.ComboBoxDriveLeft.TabIndex = 29;
            // 
            // tabControl_detail_left
            // 
            this.tabControl_detail_left.Controls.Add(this.tabPage_detail_left);
            this.tabControl_detail_left.Controls.Add(this.tabPage_hidtory_left);
            this.tabControl_detail_left.Location = new System.Drawing.Point(12, 476);
            this.tabControl_detail_left.Name = "tabControl_detail_left";
            this.tabControl_detail_left.SelectedIndex = 0;
            this.tabControl_detail_left.Size = new System.Drawing.Size(544, 181);
            this.tabControl_detail_left.TabIndex = 30;
            // 
            // tabPage_detail_left
            // 
            this.tabPage_detail_left.Controls.Add(this.DetailsBoxLeft);
            this.tabPage_detail_left.Location = new System.Drawing.Point(4, 22);
            this.tabPage_detail_left.Name = "tabPage_detail_left";
            this.tabPage_detail_left.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_detail_left.Size = new System.Drawing.Size(536, 155);
            this.tabPage_detail_left.TabIndex = 0;
            this.tabPage_detail_left.Text = "Detail";
            this.tabPage_detail_left.UseVisualStyleBackColor = true;
            // 
            // tabPage_hidtory_left
            // 
            this.tabPage_hidtory_left.Controls.Add(this.listBoxHistoryLeft);
            this.tabPage_hidtory_left.Location = new System.Drawing.Point(4, 22);
            this.tabPage_hidtory_left.Name = "tabPage_hidtory_left";
            this.tabPage_hidtory_left.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_hidtory_left.Size = new System.Drawing.Size(536, 155);
            this.tabPage_hidtory_left.TabIndex = 1;
            this.tabPage_hidtory_left.Text = "History";
            this.tabPage_hidtory_left.UseVisualStyleBackColor = true;
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
            this.tabControl_detail_right.Controls.Add(this.tabPage_detail_right);
            this.tabControl_detail_right.Controls.Add(this.tabPage_history_right);
            this.tabControl_detail_right.Location = new System.Drawing.Point(649, 476);
            this.tabControl_detail_right.Name = "tabControl_detail_right";
            this.tabControl_detail_right.SelectedIndex = 0;
            this.tabControl_detail_right.Size = new System.Drawing.Size(544, 179);
            this.tabControl_detail_right.TabIndex = 31;
            // 
            // tabPage_detail_right
            // 
            this.tabPage_detail_right.Controls.Add(this.DetailsBoxRight);
            this.tabPage_detail_right.Location = new System.Drawing.Point(4, 22);
            this.tabPage_detail_right.Name = "tabPage_detail_right";
            this.tabPage_detail_right.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_detail_right.Size = new System.Drawing.Size(536, 153);
            this.tabPage_detail_right.TabIndex = 0;
            this.tabPage_detail_right.Text = "Detail";
            this.tabPage_detail_right.UseVisualStyleBackColor = true;
            // 
            // tabPage_history_right
            // 
            this.tabPage_history_right.Controls.Add(this.listBoxHistoryRight);
            this.tabPage_history_right.Location = new System.Drawing.Point(4, 22);
            this.tabPage_history_right.Name = "tabPage_history_right";
            this.tabPage_history_right.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_history_right.Size = new System.Drawing.Size(536, 153);
            this.tabPage_history_right.TabIndex = 1;
            this.tabPage_history_right.Text = "History";
            this.tabPage_history_right.UseVisualStyleBackColor = true;
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
            this.CleanMenuItemLeft.Name = "cleanMenuItemLeft";
            this.CleanMenuItemLeft.Size = new System.Drawing.Size(180, 22);
            this.CleanMenuItemLeft.Text = "Clean history (left)";
            // 
            // cleanMenuItemRight
            // 
            this.CleanMenuItemRight.Name = "cleanMenuItemRight";
            this.CleanMenuItemRight.Size = new System.Drawing.Size(180, 22);
            this.CleanMenuItemRight.Text = "Clean history (right)";
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
            this.Controls.Add(this.tabControl_detail_right);
            this.Controls.Add(this.tabControl_detail_left);
            this.Controls.Add(this.ComboBoxDriveLeft);
            this.Controls.Add(this.ComboBoxDriveRight);
            this.Controls.Add(this.btnCopy_right);
            this.Controls.Add(this.btnMove_right);
            this.Controls.Add(this.btnCopy_left);
            this.Controls.Add(this.btnMove_left);
            this.Controls.Add(this.btnRename_right);
            this.Controls.Add(this.btnRemove_right);
            this.Controls.Add(this.btnRename_left);
            this.Controls.Add(this.btnRemove_left);
            this.Controls.Add(this.PathtextBoxRight);
            this.Controls.Add(this.listViewRight);
            this.Controls.Add(this.BackButtonRight);
            this.Controls.Add(this.PathtextBoxLeft);
            this.Controls.Add(this.listViewLeft);
            this.Controls.Add(this.BackButtonLeft);
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
            this.tabControl_detail_left.ResumeLayout(false);
            this.tabPage_detail_left.ResumeLayout(false);
            this.tabPage_hidtory_left.ResumeLayout(false);
            this.tabControl_detail_right.ResumeLayout(false);
            this.tabPage_detail_right.ResumeLayout(false);
            this.tabPage_history_right.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButtonLeft;
        private System.Windows.Forms.ListView listViewLeft;
        private System.Windows.Forms.TextBox PathtextBoxLeft;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HistoryMenuItem;
        private System.Windows.Forms.RichTextBox DetailsBoxLeft;
        private System.Windows.Forms.RichTextBox DetailsBoxRight;
        private System.Windows.Forms.TextBox PathtextBoxRight;
        private System.Windows.Forms.ListView listViewRight;
        private System.Windows.Forms.Button BackButtonRight;
        private System.Windows.Forms.Button btnRemove_left;
        private System.Windows.Forms.Button btnRename_left;
        private System.Windows.Forms.Button btnRename_right;
        private System.Windows.Forms.Button btnRemove_right;
        private System.Windows.Forms.Button btnMove_left;
        private System.Windows.Forms.Button btnCopy_left;
        private System.Windows.Forms.Button btnCopy_right;
        private System.Windows.Forms.Button btnMove_right;
        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.ComboBox ComboBoxDriveRight;
        private System.Windows.Forms.ComboBox ComboBoxDriveLeft;
        private System.Windows.Forms.ToolStripMenuItem HistoryMenuItemLeft;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem HistoryMenuItemRight;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl_detail_left;
        private System.Windows.Forms.TabPage tabPage_detail_left;
        private System.Windows.Forms.TabPage tabPage_hidtory_left;
        private System.Windows.Forms.TabControl tabControl_detail_right;
        private System.Windows.Forms.TabPage tabPage_detail_right;
        private System.Windows.Forms.TabPage tabPage_history_right;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxHistoryLeft;
        private System.Windows.Forms.ListBox listBoxHistoryRight;
        private System.Windows.Forms.ToolStripMenuItem CleanMenuItemLeft;
        private System.Windows.Forms.ToolStripMenuItem CleanMenuItemRight;
    }
}

