namespace Cshrp_Semestralni_prace
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BackButton_left = new System.Windows.Forms.Button();
            this.listView_left = new System.Windows.Forms.ListView();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.PathtextBox_left = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.GoButton_left = new System.Windows.Forms.Button();
            this.DetailsBox_left = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.DetailsBox_right = new System.Windows.Forms.RichTextBox();
            this.GoButton_right = new System.Windows.Forms.Button();
            this.PathtextBox_right = new System.Windows.Forms.TextBox();
            this.BackButton_right = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btnRemove_left = new System.Windows.Forms.Button();
            this.btnRename_left = new System.Windows.Forms.Button();
            this.btnRename_right = new System.Windows.Forms.Button();
            this.btnRemove_right = new System.Windows.Forms.Button();
            this.btnMove_left = new System.Windows.Forms.Button();
            this.btnCopy_left = new System.Windows.Forms.Button();
            this.btnCopy_right = new System.Windows.Forms.Button();
            this.btnMove_right = new System.Windows.Forms.Button();
            this.listView_right = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackButton_left
            // 
            this.BackButton_left.Location = new System.Drawing.Point(12, 30);
            this.BackButton_left.Name = "BackButton_left";
            this.BackButton_left.Size = new System.Drawing.Size(42, 20);
            this.BackButton_left.TabIndex = 0;
            this.BackButton_left.Text = "Back";
            this.BackButton_left.UseVisualStyleBackColor = true;
            this.BackButton_left.Click += new System.EventHandler(this.BackButton_left_Click);
            // 
            // listView_left
            // 
            this.listView_left.HideSelection = false;
            this.listView_left.LargeImageList = this.iconList;
            this.listView_left.Location = new System.Drawing.Point(12, 56);
            this.listView_left.Name = "listView_left";
            this.listView_left.Size = new System.Drawing.Size(544, 414);
            this.listView_left.SmallImageList = this.iconList;
            this.listView_left.TabIndex = 1;
            this.listView_left.UseCompatibleStateImageBehavior = false;
            this.listView_left.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView_left_ItemSelectionChanged);
            this.listView_left.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_left_MouseDoubleClick);
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "folder.png");
            // 
            // PathtextBox_left
            // 
            this.PathtextBox_left.Location = new System.Drawing.Point(60, 30);
            this.PathtextBox_left.Name = "PathtextBox_left";
            this.PathtextBox_left.Size = new System.Drawing.Size(448, 20);
            this.PathtextBox_left.TabIndex = 2;
            this.PathtextBox_left.TextChanged += new System.EventHandler(this.PathtextBox_left_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1205, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(125, 20);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(125, 20);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // GoButton_left
            // 
            this.GoButton_left.Location = new System.Drawing.Point(514, 30);
            this.GoButton_left.Name = "GoButton_left";
            this.GoButton_left.Size = new System.Drawing.Size(42, 20);
            this.GoButton_left.TabIndex = 4;
            this.GoButton_left.Text = "Go";
            this.GoButton_left.UseVisualStyleBackColor = true;
            this.GoButton_left.Click += new System.EventHandler(this.GoButton_left_Click);
            // 
            // DetailsBox_left
            // 
            this.DetailsBox_left.Location = new System.Drawing.Point(12, 503);
            this.DetailsBox_left.Name = "DetailsBox_left";
            this.DetailsBox_left.Size = new System.Drawing.Size(544, 208);
            this.DetailsBox_left.TabIndex = 5;
            this.DetailsBox_left.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 714);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1205, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // DetailsBox_right
            // 
            this.DetailsBox_right.Location = new System.Drawing.Point(649, 503);
            this.DetailsBox_right.Name = "DetailsBox_right";
            this.DetailsBox_right.Size = new System.Drawing.Size(544, 208);
            this.DetailsBox_right.TabIndex = 11;
            this.DetailsBox_right.Text = "";
            // 
            // GoButton_right
            // 
            this.GoButton_right.Location = new System.Drawing.Point(1151, 30);
            this.GoButton_right.Name = "GoButton_right";
            this.GoButton_right.Size = new System.Drawing.Size(42, 20);
            this.GoButton_right.TabIndex = 10;
            this.GoButton_right.Text = "Go";
            this.GoButton_right.UseVisualStyleBackColor = true;
            this.GoButton_right.Click += new System.EventHandler(this.GoButton_right_Click);
            // 
            // PathtextBox_right
            // 
            this.PathtextBox_right.Location = new System.Drawing.Point(697, 30);
            this.PathtextBox_right.Name = "PathtextBox_right";
            this.PathtextBox_right.Size = new System.Drawing.Size(448, 20);
            this.PathtextBox_right.TabIndex = 9;
            this.PathtextBox_right.TextChanged += new System.EventHandler(this.PathtextBox_right_TextChanged);
            // 
            // BackButton_right
            // 
            this.BackButton_right.Location = new System.Drawing.Point(649, 30);
            this.BackButton_right.Name = "BackButton_right";
            this.BackButton_right.Size = new System.Drawing.Size(42, 20);
            this.BackButton_right.TabIndex = 7;
            this.BackButton_right.Text = "Back";
            this.BackButton_right.UseVisualStyleBackColor = true;
            this.BackButton_right.Click += new System.EventHandler(this.BackButton_right_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Remove left";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(562, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Remove right";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(562, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Copy to <";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(562, 135);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Copy to >";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(562, 334);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 23);
            this.button5.TabIndex = 19;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(562, 294);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(81, 23);
            this.button6.TabIndex = 18;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(562, 255);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(81, 23);
            this.button7.TabIndex = 17;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(562, 215);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(81, 23);
            this.button8.TabIndex = 16;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // btnRemove_left
            // 
            this.btnRemove_left.Location = new System.Drawing.Point(12, 474);
            this.btnRemove_left.Name = "btnRemove_left";
            this.btnRemove_left.Size = new System.Drawing.Size(81, 23);
            this.btnRemove_left.TabIndex = 20;
            this.btnRemove_left.Text = "Remove";
            this.btnRemove_left.UseVisualStyleBackColor = true;
            this.btnRemove_left.Click += new System.EventHandler(this.btnRemove_left_Click);
            // 
            // btnRename_left
            // 
            this.btnRename_left.Location = new System.Drawing.Point(99, 474);
            this.btnRename_left.Name = "btnRename_left";
            this.btnRename_left.Size = new System.Drawing.Size(81, 23);
            this.btnRename_left.TabIndex = 21;
            this.btnRename_left.Text = "Rename";
            this.btnRename_left.UseVisualStyleBackColor = true;
            this.btnRename_left.Click += new System.EventHandler(this.btnRename_left_Click);
            // 
            // btnRename_right
            // 
            this.btnRename_right.Location = new System.Drawing.Point(736, 474);
            this.btnRename_right.Name = "btnRename_right";
            this.btnRename_right.Size = new System.Drawing.Size(81, 23);
            this.btnRename_right.TabIndex = 23;
            this.btnRename_right.Text = "Rename";
            this.btnRename_right.UseVisualStyleBackColor = true;
            this.btnRename_right.Click += new System.EventHandler(this.btnRename_right_Click);
            // 
            // btnRemove_right
            // 
            this.btnRemove_right.Location = new System.Drawing.Point(649, 474);
            this.btnRemove_right.Name = "btnRemove_right";
            this.btnRemove_right.Size = new System.Drawing.Size(81, 23);
            this.btnRemove_right.TabIndex = 22;
            this.btnRemove_right.Text = "Remove";
            this.btnRemove_right.UseVisualStyleBackColor = true;
            this.btnRemove_right.Click += new System.EventHandler(this.btnRemove_right_Click);
            // 
            // btnMove_left
            // 
            this.btnMove_left.Location = new System.Drawing.Point(186, 474);
            this.btnMove_left.Name = "btnMove_left";
            this.btnMove_left.Size = new System.Drawing.Size(81, 23);
            this.btnMove_left.TabIndex = 24;
            this.btnMove_left.Text = "Move";
            this.btnMove_left.UseVisualStyleBackColor = true;
            this.btnMove_left.Click += new System.EventHandler(this.btnMove_left_Click);
            // 
            // btnCopy_left
            // 
            this.btnCopy_left.Location = new System.Drawing.Point(273, 474);
            this.btnCopy_left.Name = "btnCopy_left";
            this.btnCopy_left.Size = new System.Drawing.Size(81, 23);
            this.btnCopy_left.TabIndex = 25;
            this.btnCopy_left.Text = "Copy";
            this.btnCopy_left.UseVisualStyleBackColor = true;
            this.btnCopy_left.Click += new System.EventHandler(this.btnCopy_left_Click);
            // 
            // btnCopy_right
            // 
            this.btnCopy_right.Location = new System.Drawing.Point(910, 474);
            this.btnCopy_right.Name = "btnCopy_right";
            this.btnCopy_right.Size = new System.Drawing.Size(81, 23);
            this.btnCopy_right.TabIndex = 27;
            this.btnCopy_right.Text = "Copy";
            this.btnCopy_right.UseVisualStyleBackColor = true;
            this.btnCopy_right.Click += new System.EventHandler(this.btnCopy_right_Click);
            // 
            // btnMove_right
            // 
            this.btnMove_right.Location = new System.Drawing.Point(823, 474);
            this.btnMove_right.Name = "btnMove_right";
            this.btnMove_right.Size = new System.Drawing.Size(81, 23);
            this.btnMove_right.TabIndex = 26;
            this.btnMove_right.Text = "Move";
            this.btnMove_right.UseVisualStyleBackColor = true;
            this.btnMove_right.Click += new System.EventHandler(this.btnMove_right_Click);
            // 
            // listView_right
            // 
            this.listView_right.HideSelection = false;
            this.listView_right.LargeImageList = this.iconList;
            this.listView_right.Location = new System.Drawing.Point(649, 54);
            this.listView_right.Name = "listView_right";
            this.listView_right.Size = new System.Drawing.Size(544, 414);
            this.listView_right.SmallImageList = this.iconList;
            this.listView_right.TabIndex = 28;
            this.listView_right.UseCompatibleStateImageBehavior = false;
            this.listView_right.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView_right_ItemSelectionChanged);
            this.listView_right.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_right_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 739);
            this.Controls.Add(this.listView_right);
            this.Controls.Add(this.btnCopy_right);
            this.Controls.Add(this.btnMove_right);
            this.Controls.Add(this.btnCopy_left);
            this.Controls.Add(this.btnMove_left);
            this.Controls.Add(this.btnRename_right);
            this.Controls.Add(this.btnRemove_right);
            this.Controls.Add(this.btnRename_left);
            this.Controls.Add(this.btnRemove_left);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DetailsBox_right);
            this.Controls.Add(this.GoButton_right);
            this.Controls.Add(this.PathtextBox_right);
            this.Controls.Add(this.BackButton_right);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.DetailsBox_left);
            this.Controls.Add(this.GoButton_left);
            this.Controls.Add(this.PathtextBox_left);
            this.Controls.Add(this.listView_left);
            this.Controls.Add(this.BackButton_left);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton_left;
        private System.Windows.Forms.ListView listView_left;
        private System.Windows.Forms.TextBox PathtextBox_left;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button GoButton_left;
        private System.Windows.Forms.RichTextBox DetailsBox_left;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.RichTextBox DetailsBox_right;
        private System.Windows.Forms.Button GoButton_right;
        private System.Windows.Forms.TextBox PathtextBox_right;
        private System.Windows.Forms.Button BackButton_right;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnRemove_left;
        private System.Windows.Forms.Button btnRename_left;
        private System.Windows.Forms.Button btnRename_right;
        private System.Windows.Forms.Button btnRemove_right;
        private System.Windows.Forms.Button btnMove_left;
        private System.Windows.Forms.Button btnCopy_left;
        private System.Windows.Forms.Button btnCopy_right;
        private System.Windows.Forms.Button btnMove_right;
        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.ListView listView_right;
    }
}

