﻿namespace CarsForm
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
            this.SuspendLayout();
            // 
            // filteredCarsListView
            // 
            this.filteredCarsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderBrand,
            this.columnHeaderMaxSpeed,
            this.columnHeaderDate,
            this.columnHeaderType});
            this.filteredCarsListView.Location = new System.Drawing.Point(12, 28);
            this.filteredCarsListView.Name = "filteredCarsListView";
            this.filteredCarsListView.Size = new System.Drawing.Size(335, 460);
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
            this.lessFilterCheckBox.Location = new System.Drawing.Point(382, 58);
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
            this.moreFilterCheckBox.Location = new System.Drawing.Point(382, 81);
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
            this.carSpeedLabelMoreLess.Location = new System.Drawing.Point(379, 28);
            this.carSpeedLabelMoreLess.Name = "carSpeedLabelMoreLess";
            this.carSpeedLabelMoreLess.Size = new System.Drawing.Size(77, 13);
            this.carSpeedLabelMoreLess.TabIndex = 3;
            this.carSpeedLabelMoreLess.Text = "Car max speed";
            // 
            // thanLabelMoreLess
            // 
            this.thanLabelMoreLess.AutoSize = true;
            this.thanLabelMoreLess.Location = new System.Drawing.Point(450, 71);
            this.thanLabelMoreLess.Name = "thanLabelMoreLess";
            this.thanLabelMoreLess.Size = new System.Drawing.Size(28, 13);
            this.thanLabelMoreLess.TabIndex = 4;
            this.thanLabelMoreLess.Text = "than";
            // 
            // speedFilterTextBox
            // 
            this.speedFilterTextBox.Location = new System.Drawing.Point(506, 68);
            this.speedFilterTextBox.Name = "speedFilterTextBox";
            this.speedFilterTextBox.Size = new System.Drawing.Size(100, 20);
            this.speedFilterTextBox.TabIndex = 5;
            this.speedFilterTextBox.Text = "0";
            this.speedFilterTextBox.TextChanged += new System.EventHandler(this.speedFilterTextBox_TextChanged);
            // 
            // FilteredView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(632, 513);
            this.Controls.Add(this.speedFilterTextBox);
            this.Controls.Add(this.thanLabelMoreLess);
            this.Controls.Add(this.carSpeedLabelMoreLess);
            this.Controls.Add(this.moreFilterCheckBox);
            this.Controls.Add(this.lessFilterCheckBox);
            this.Controls.Add(this.filteredCarsListView);
            this.Name = "FilteredView";
            this.Text = "Filtered Cars";
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
    }
}