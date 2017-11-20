namespace CarsForm
{
    partial class FilteredView : UpdateableView
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
            this.filteredCarsListView = new System.Windows.Forms.ListView();
            this.columnHeaderBrand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMaxSpeed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lessFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.moreFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.carSpeedLabelMoreLess = new System.Windows.Forms.Label();
            this.thanLabelMoreLess = new System.Windows.Forms.Label();
            this.speedFilterTextBox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.option1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subOption1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subOption2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.option2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lessmoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // filteredCarsListView
            // 
            this.filteredCarsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderBrand,
            this.columnHeaderMaxSpeed,
            this.columnHeaderDate,
            this.columnHeaderType});
            this.filteredCarsListView.Location = new System.Drawing.Point(12, 43);
            this.filteredCarsListView.Name = "filteredCarsListView";
            this.filteredCarsListView.Size = new System.Drawing.Size(335, 445);
            this.filteredCarsListView.TabIndex = 0;
            this.filteredCarsListView.UseCompatibleStateImageBehavior = false;
            this.filteredCarsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderBrand
            // 
            this.columnHeaderBrand.Text = "Brand";
            // 
            // columnHeaderMaxSpeed
            // 
            this.columnHeaderMaxSpeed.Text = "Max speed";
            // 
            // columnHeaderDate
            // 
            this.columnHeaderDate.Text = "Date";
            // 
            // columnHeaderType
            // 
            this.columnHeaderType.Text = "Type";
            // 
            // lessFilterCheckBox
            // 
            this.lessFilterCheckBox.AutoSize = true;
            this.lessFilterCheckBox.Location = new System.Drawing.Point(381, 73);
            this.lessFilterCheckBox.Name = "lessFilterCheckBox";
            this.lessFilterCheckBox.Size = new System.Drawing.Size(44, 17);
            this.lessFilterCheckBox.TabIndex = 1;
            this.lessFilterCheckBox.Text = "less";
            this.lessFilterCheckBox.UseVisualStyleBackColor = true;
            this.lessFilterCheckBox.CheckedChanged += new System.EventHandler(this.lessFilterCheckBox_CheckedChanged);
            // 
            // moreFilterCheckBox
            // 
            this.moreFilterCheckBox.AutoSize = true;
            this.moreFilterCheckBox.Checked = true;
            this.moreFilterCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.moreFilterCheckBox.Location = new System.Drawing.Point(381, 96);
            this.moreFilterCheckBox.Name = "moreFilterCheckBox";
            this.moreFilterCheckBox.Size = new System.Drawing.Size(49, 17);
            this.moreFilterCheckBox.TabIndex = 2;
            this.moreFilterCheckBox.Text = "more";
            this.moreFilterCheckBox.UseVisualStyleBackColor = true;
            this.moreFilterCheckBox.CheckedChanged += new System.EventHandler(this.moreFilterCheckBox_CheckedChanged);
            // 
            // carSpeedLabelMoreLess
            // 
            this.carSpeedLabelMoreLess.AutoSize = true;
            this.carSpeedLabelMoreLess.Location = new System.Drawing.Point(378, 43);
            this.carSpeedLabelMoreLess.Name = "carSpeedLabelMoreLess";
            this.carSpeedLabelMoreLess.Size = new System.Drawing.Size(77, 13);
            this.carSpeedLabelMoreLess.TabIndex = 3;
            this.carSpeedLabelMoreLess.Text = "Car max speed";
            // 
            // thanLabelMoreLess
            // 
            this.thanLabelMoreLess.AutoSize = true;
            this.thanLabelMoreLess.Location = new System.Drawing.Point(449, 86);
            this.thanLabelMoreLess.Name = "thanLabelMoreLess";
            this.thanLabelMoreLess.Size = new System.Drawing.Size(28, 13);
            this.thanLabelMoreLess.TabIndex = 4;
            this.thanLabelMoreLess.Text = "than";
            // 
            // speedFilterTextBox
            // 
            this.speedFilterTextBox.Location = new System.Drawing.Point(505, 83);
            this.speedFilterTextBox.Name = "speedFilterTextBox";
            this.speedFilterTextBox.Size = new System.Drawing.Size(100, 20);
            this.speedFilterTextBox.TabIndex = 5;
            this.speedFilterTextBox.Text = "0";
            this.speedFilterTextBox.TextChanged += new System.EventHandler(this.speedFilterTextBox_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 503);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(632, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Items:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabel2.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.option1ToolStripMenuItem,
            this.option2ToolStripMenuItem,
            this.lessmoreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // option1ToolStripMenuItem
            // 
            this.option1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subOption1ToolStripMenuItem,
            this.subOption2ToolStripMenuItem});
            this.option1ToolStripMenuItem.Name = "option1ToolStripMenuItem";
            this.option1ToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.option1ToolStripMenuItem.Text = "Option1";
            // 
            // subOption1ToolStripMenuItem
            // 
            this.subOption1ToolStripMenuItem.Name = "subOption1ToolStripMenuItem";
            this.subOption1ToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.subOption1ToolStripMenuItem.Text = "SubOption1";
            // 
            // subOption2ToolStripMenuItem
            // 
            this.subOption2ToolStripMenuItem.Name = "subOption2ToolStripMenuItem";
            this.subOption2ToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.subOption2ToolStripMenuItem.Text = "SubOption2";
            // 
            // option2ToolStripMenuItem
            // 
            this.option2ToolStripMenuItem.Name = "option2ToolStripMenuItem";
            this.option2ToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.option2ToolStripMenuItem.Text = "Option2";
            // 
            // lessmoreToolStripMenuItem
            // 
            this.lessmoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lessToolStripMenuItem,
            this.moreToolStripMenuItem});
            this.lessmoreToolStripMenuItem.Name = "lessmoreToolStripMenuItem";
            this.lessmoreToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.lessmoreToolStripMenuItem.Text = "Less/more";
            // 
            // lessToolStripMenuItem
            // 
            this.lessToolStripMenuItem.Name = "lessToolStripMenuItem";
            this.lessToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.lessToolStripMenuItem.Text = "Less";
            this.lessToolStripMenuItem.Click += new System.EventHandler(this.lessToolStripMenuItem_Click);
            // 
            // moreToolStripMenuItem
            // 
            this.moreToolStripMenuItem.Name = "moreToolStripMenuItem";
            this.moreToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.moreToolStripMenuItem.Text = "More";
            this.moreToolStripMenuItem.Click += new System.EventHandler(this.moreToolStripMenuItem_Click);
            // 
            // FilteredView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(632, 525);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.speedFilterTextBox);
            this.Controls.Add(this.thanLabelMoreLess);
            this.Controls.Add(this.carSpeedLabelMoreLess);
            this.Controls.Add(this.moreFilterCheckBox);
            this.Controls.Add(this.lessFilterCheckBox);
            this.Controls.Add(this.filteredCarsListView);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FilteredView";
            this.Text = "Filtered Cars";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FilteredView_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView filteredCarsListView;
        private System.Windows.Forms.ColumnHeader columnHeaderBrand;
        private System.Windows.Forms.ColumnHeader columnHeaderMaxSpeed;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.ColumnHeader columnHeaderType;
        private System.Windows.Forms.CheckBox lessFilterCheckBox;
        private System.Windows.Forms.CheckBox moreFilterCheckBox;
        private System.Windows.Forms.Label carSpeedLabelMoreLess;
        private System.Windows.Forms.Label thanLabelMoreLess;
        private System.Windows.Forms.TextBox speedFilterTextBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem option1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subOption1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subOption2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem option2ToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem lessmoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moreToolStripMenuItem;
    }
}