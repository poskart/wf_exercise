namespace CarsForm
{
    partial class EditCarForm : UpdateableView
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
            this.carsListView = new System.Windows.Forms.ListView();
            this.columnHeaderBrand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMaxSpeed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxCarType = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.dateTimePickerCarProduction = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxMaxSpeed = new System.Windows.Forms.TextBox();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.labelBrand = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.carEditFormOKButton = new System.Windows.Forms.Button();
            this.carEditFormCancelButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.option1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subOptionX1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subOptionX2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anotherViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // carsListView
            // 
            this.carsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderBrand,
            this.columnHeaderMaxSpeed,
            this.columnHeaderDate,
            this.columnHeaderType});
            this.carsListView.Location = new System.Drawing.Point(12, 28);
            this.carsListView.Name = "carsListView";
            this.carsListView.Size = new System.Drawing.Size(335, 454);
            this.carsListView.TabIndex = 0;
            this.carsListView.UseCompatibleStateImageBehavior = false;
            this.carsListView.View = System.Windows.Forms.View.Details;
            this.carsListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.carsListView_ItemSelectionChanged);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(394, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(343, 302);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.comboBoxCarType, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelType, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePickerCarProduction, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelDate, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxMaxSpeed, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelMaxSpeed, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxBrand, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelBrand, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 78);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(337, 221);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // comboBoxCarType
            // 
            this.comboBoxCarType.FormattingEnabled = true;
            this.comboBoxCarType.Items.AddRange(new object[] {
            "Car",
            "Truck",
            "Two-wheel vehicle"});
            this.comboBoxCarType.Location = new System.Drawing.Point(171, 168);
            this.comboBoxCarType.Name = "comboBoxCarType";
            this.comboBoxCarType.Size = new System.Drawing.Size(147, 21);
            this.comboBoxCarType.TabIndex = 10;
            this.comboBoxCarType.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxCarType_Validating);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Calibri", 12F);
            this.labelType.Location = new System.Drawing.Point(3, 165);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(43, 19);
            this.labelType.TabIndex = 9;
            this.labelType.Text = "Type:";
            // 
            // dateTimePickerCarProduction
            // 
            this.dateTimePickerCarProduction.Location = new System.Drawing.Point(171, 113);
            this.dateTimePickerCarProduction.Name = "dateTimePickerCarProduction";
            this.dateTimePickerCarProduction.Size = new System.Drawing.Size(147, 20);
            this.dateTimePickerCarProduction.TabIndex = 8;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Calibri", 12F);
            this.labelDate.Location = new System.Drawing.Point(3, 110);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(119, 19);
            this.labelDate.TabIndex = 5;
            this.labelDate.Text = "Production date: ";
            // 
            // textBoxMaxSpeed
            // 
            this.textBoxMaxSpeed.Location = new System.Drawing.Point(171, 58);
            this.textBoxMaxSpeed.Name = "textBoxMaxSpeed";
            this.textBoxMaxSpeed.Size = new System.Drawing.Size(147, 20);
            this.textBoxMaxSpeed.TabIndex = 4;
            this.textBoxMaxSpeed.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxMaxSpeed_Validating);
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.AutoSize = true;
            this.labelMaxSpeed.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxSpeed.Location = new System.Drawing.Point(3, 55);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(88, 19);
            this.labelMaxSpeed.TabIndex = 3;
            this.labelMaxSpeed.Text = "Max speed: ";
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Location = new System.Drawing.Point(171, 3);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(147, 20);
            this.textBoxBrand.TabIndex = 2;
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrand.Location = new System.Drawing.Point(3, 0);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(55, 19);
            this.labelBrand.TabIndex = 1;
            this.labelBrand.Text = "Brand: ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insert new car parameters:";
            // 
            // carEditFormOKButton
            // 
            this.carEditFormOKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.carEditFormOKButton.Location = new System.Drawing.Point(404, 450);
            this.carEditFormOKButton.Name = "carEditFormOKButton";
            this.carEditFormOKButton.Size = new System.Drawing.Size(75, 23);
            this.carEditFormOKButton.TabIndex = 13;
            this.carEditFormOKButton.Text = "Apply";
            this.carEditFormOKButton.UseVisualStyleBackColor = true;
            this.carEditFormOKButton.Click += new System.EventHandler(this.carEditFormOKButton_Click);
            // 
            // carEditFormCancelButton
            // 
            this.carEditFormCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.carEditFormCancelButton.Location = new System.Drawing.Point(640, 450);
            this.carEditFormCancelButton.Name = "carEditFormCancelButton";
            this.carEditFormCancelButton.Size = new System.Drawing.Size(75, 23);
            this.carEditFormCancelButton.TabIndex = 14;
            this.carEditFormCancelButton.Text = "Close";
            this.carEditFormCancelButton.UseVisualStyleBackColor = true;
            this.carEditFormCancelButton.Click += new System.EventHandler(this.carEditFormCancelButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 491);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(774, 22);
            this.statusStrip1.TabIndex = 15;
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
            this.optionXToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // option1ToolStripMenuItem
            // 
            this.option1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subOptionX1ToolStripMenuItem,
            this.subOptionX2ToolStripMenuItem});
            this.option1ToolStripMenuItem.Name = "option1ToolStripMenuItem";
            this.option1ToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.option1ToolStripMenuItem.Text = "Option1";
            // 
            // optionXToolStripMenuItem
            // 
            this.optionXToolStripMenuItem.Name = "optionXToolStripMenuItem";
            this.optionXToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.optionXToolStripMenuItem.Text = "OptionX";
            // 
            // subOptionX1ToolStripMenuItem
            // 
            this.subOptionX1ToolStripMenuItem.Name = "subOptionX1ToolStripMenuItem";
            this.subOptionX1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.subOptionX1ToolStripMenuItem.Text = "SubOptionX1";
            // 
            // subOptionX2ToolStripMenuItem
            // 
            this.subOptionX2ToolStripMenuItem.Name = "subOptionX2ToolStripMenuItem";
            this.subOptionX2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.subOptionX2ToolStripMenuItem.Text = "SubOptionX2";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anotherViewToolStripMenuItem});
            this.viewToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // anotherViewToolStripMenuItem
            // 
            this.anotherViewToolStripMenuItem.Name = "anotherViewToolStripMenuItem";
            this.anotherViewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.anotherViewToolStripMenuItem.Text = "AnotherView";
            // 
            // EditCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(774, 513);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.carEditFormCancelButton);
            this.Controls.Add(this.carEditFormOKButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.carsListView);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EditCarForm";
            this.Text = "Cars to modify";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView carsListView;
        private System.Windows.Forms.ColumnHeader columnHeaderBrand;
        private System.Windows.Forms.ColumnHeader columnHeaderMaxSpeed;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.ColumnHeader columnHeaderType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.Label labelMaxSpeed;
        private System.Windows.Forms.TextBox textBoxMaxSpeed;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerCarProduction;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxCarType;
        private System.Windows.Forms.Button carEditFormOKButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button carEditFormCancelButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem option1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subOptionX1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subOptionX2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anotherViewToolStripMenuItem;
    }
}