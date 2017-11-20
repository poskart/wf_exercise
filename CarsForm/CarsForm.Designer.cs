namespace CarsForm
{
    partial class CarsForm
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.carToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filteredViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStripLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(883, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // carToolStripMenuItem
            // 
            this.carToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCarToolStripMenuItem,
            this.modifyCarToolStripMenuItem,
            this.removeCarToolStripMenuItem});
            this.carToolStripMenuItem.Name = "carToolStripMenuItem";
            this.carToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.carToolStripMenuItem.Text = "Car";
            // 
            // newCarToolStripMenuItem
            // 
            this.newCarToolStripMenuItem.Name = "newCarToolStripMenuItem";
            this.newCarToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.newCarToolStripMenuItem.Text = "New car";
            this.newCarToolStripMenuItem.Click += new System.EventHandler(this.newCarToolStripMenuItem_Click);
            // 
            // modifyCarToolStripMenuItem
            // 
            this.modifyCarToolStripMenuItem.Name = "modifyCarToolStripMenuItem";
            this.modifyCarToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.modifyCarToolStripMenuItem.Text = "Modify car";
            this.modifyCarToolStripMenuItem.Click += new System.EventHandler(this.modifyCarToolStripMenuItem_Click);
            // 
            // removeCarToolStripMenuItem
            // 
            this.removeCarToolStripMenuItem.Name = "removeCarToolStripMenuItem";
            this.removeCarToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.removeCarToolStripMenuItem.Text = "Remove car";
            this.removeCarToolStripMenuItem.Click += new System.EventHandler(this.removeCarToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filteredViewToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // filteredViewToolStripMenuItem
            // 
            this.filteredViewToolStripMenuItem.Name = "filteredViewToolStripMenuItem";
            this.filteredViewToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.filteredViewToolStripMenuItem.Text = "Filtered view";
            this.filteredViewToolStripMenuItem.Click += new System.EventHandler(this.filteredViewToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripLabel1,
            this.statusStripLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 526);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(883, 22);
            this.statusStrip1.TabIndex = 1;
            // 
            // statusStripLabel1
            // 
            this.statusStripLabel1.Name = "statusStripLabel1";
            this.statusStripLabel1.Size = new System.Drawing.Size(39, 17);
            this.statusStripLabel1.Text = "Items:";
            // 
            // statusStripLabel2
            // 
            this.statusStripLabel2.Name = "statusStripLabel2";
            this.statusStripLabel2.Size = new System.Drawing.Size(13, 17);
            this.statusStripLabel2.Text = "0";
            // 
            // CarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 548);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "CarsForm";
            this.Text = "Cars";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CarsForm_FormClosing);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem carToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filteredViewToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLabel2;
    }
}

