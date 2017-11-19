namespace CarsForm
{
    partial class RemoveCarForm : UpdateableView
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
            this.helperLabel = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
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
            this.carsListView.Size = new System.Drawing.Size(335, 460);
            this.carsListView.TabIndex = 0;
            this.carsListView.UseCompatibleStateImageBehavior = false;
            this.carsListView.View = System.Windows.Forms.View.Details;
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
            // helperLabel
            // 
            this.helperLabel.AutoSize = true;
            this.helperLabel.Location = new System.Drawing.Point(371, 45);
            this.helperLabel.Name = "helperLabel";
            this.helperLabel.Size = new System.Drawing.Size(234, 13);
            this.helperLabel.TabIndex = 1;
            this.helperLabel.Text = "Select car to remove and press \'Remove\' button";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(451, 94);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // RemoveCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(632, 513);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.helperLabel);
            this.Controls.Add(this.carsListView);
            this.Name = "RemoveCarForm";
            this.Text = "Cars to remove";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView carsListView;
        private System.Windows.Forms.ColumnHeader columnHeaderBrand;
        private System.Windows.Forms.ColumnHeader columnHeaderMaxSpeed;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.ColumnHeader columnHeaderType;
        private System.Windows.Forms.Label helperLabel;
        private System.Windows.Forms.Button removeButton;
    }
}