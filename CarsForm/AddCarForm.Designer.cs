namespace CarsForm
{
    partial class AddCarForm : UpdateableView
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
            this.labelBrand = new System.Windows.Forms.Label();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.textBoxMaxSpeed = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxCarType = new System.Windows.Forms.ComboBox();
            this.dateTimePickerCarProduction = new System.Windows.Forms.DateTimePicker();
            this.carEditFormOKButton = new System.Windows.Forms.Button();
            this.carEditFormCancelButton = new System.Windows.Forms.Button();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrand.Location = new System.Drawing.Point(19, 20);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(55, 19);
            this.labelBrand.TabIndex = 0;
            this.labelBrand.Text = "Brand: ";
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Location = new System.Drawing.Point(175, 20);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(147, 20);
            this.textBoxBrand.TabIndex = 1;
            // 
            // textBoxMaxSpeed
            // 
            this.textBoxMaxSpeed.Location = new System.Drawing.Point(175, 61);
            this.textBoxMaxSpeed.Name = "textBoxMaxSpeed";
            this.textBoxMaxSpeed.Size = new System.Drawing.Size(147, 20);
            this.textBoxMaxSpeed.TabIndex = 3;
            this.textBoxMaxSpeed.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxMaxSpeed_Validating);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Calibri", 12F);
            this.labelDate.Location = new System.Drawing.Point(19, 99);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(119, 19);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "Production date: ";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Calibri", 12F);
            this.labelType.Location = new System.Drawing.Point(19, 137);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(43, 19);
            this.labelType.TabIndex = 5;
            this.labelType.Text = "Type:";
            // 
            // comboBoxCarType
            // 
            this.comboBoxCarType.FormattingEnabled = true;
            this.comboBoxCarType.Items.AddRange(new object[] {
            "Car",
            "Truck",
            "Two-wheel vehicle"});
            this.comboBoxCarType.Location = new System.Drawing.Point(175, 134);
            this.comboBoxCarType.Name = "comboBoxCarType";
            this.comboBoxCarType.Size = new System.Drawing.Size(147, 21);
            this.comboBoxCarType.TabIndex = 6;
            this.comboBoxCarType.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxCarType_Validating);
            // 
            // dateTimePickerCarProduction
            // 
            this.dateTimePickerCarProduction.Location = new System.Drawing.Point(175, 96);
            this.dateTimePickerCarProduction.Name = "dateTimePickerCarProduction";
            this.dateTimePickerCarProduction.Size = new System.Drawing.Size(147, 20);
            this.dateTimePickerCarProduction.TabIndex = 7;
            // 
            // carEditFormOKButton
            // 
            this.carEditFormOKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.carEditFormOKButton.Location = new System.Drawing.Point(79, 180);
            this.carEditFormOKButton.Name = "carEditFormOKButton";
            this.carEditFormOKButton.Size = new System.Drawing.Size(75, 23);
            this.carEditFormOKButton.TabIndex = 8;
            this.carEditFormOKButton.Text = "Add";
            this.carEditFormOKButton.UseVisualStyleBackColor = true;
            this.carEditFormOKButton.Click += new System.EventHandler(this.carEditFormOKButton_Click);
            // 
            // carEditFormCancelButton
            // 
            this.carEditFormCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.carEditFormCancelButton.Location = new System.Drawing.Point(221, 180);
            this.carEditFormCancelButton.Name = "carEditFormCancelButton";
            this.carEditFormCancelButton.Size = new System.Drawing.Size(75, 23);
            this.carEditFormCancelButton.TabIndex = 9;
            this.carEditFormCancelButton.Text = "Close";
            this.carEditFormCancelButton.UseVisualStyleBackColor = true;
            this.carEditFormCancelButton.Click += new System.EventHandler(this.carEditFormCancelButton_Click);
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.AutoSize = true;
            this.labelMaxSpeed.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxSpeed.Location = new System.Drawing.Point(19, 61);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(88, 19);
            this.labelMaxSpeed.TabIndex = 2;
            this.labelMaxSpeed.Text = "Max speed: ";
            // 
            // AddCarForm
            // 
            this.AcceptButton = this.carEditFormOKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.carEditFormCancelButton;
            this.ClientSize = new System.Drawing.Size(382, 373);
            this.Controls.Add(this.carEditFormCancelButton);
            this.Controls.Add(this.carEditFormOKButton);
            this.Controls.Add(this.dateTimePickerCarProduction);
            this.Controls.Add(this.comboBoxCarType);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.textBoxMaxSpeed);
            this.Controls.Add(this.labelMaxSpeed);
            this.Controls.Add(this.textBoxBrand);
            this.Controls.Add(this.labelBrand);
            this.Name = "AddCarForm";
            this.Text = "Car";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.TextBox textBoxMaxSpeed;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxCarType;
        private System.Windows.Forms.DateTimePicker dateTimePickerCarProduction;
        private System.Windows.Forms.Button carEditFormOKButton;
        private System.Windows.Forms.Button carEditFormCancelButton;
        private System.Windows.Forms.Label labelMaxSpeed;
    }
}