namespace TZCars {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autokGrid = new System.Windows.Forms.DataGridView();
            this.removeAll = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autokGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlToolStripMenuItem,
            this.addNewMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fájlToolStripMenuItem
            // 
            this.fájlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeMenuItem});
            this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            this.fájlToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fájlToolStripMenuItem.Text = "Fájl";
            // 
            // closeMenuItem
            // 
            this.closeMenuItem.Name = "closeMenuItem";
            this.closeMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeMenuItem.Text = "Bezárás";
            this.closeMenuItem.Click += new System.EventHandler(this.closeMenuItem_click);
            // 
            // addNewMenuItem
            // 
            this.addNewMenuItem.Name = "addNewMenuItem";
            this.addNewMenuItem.Size = new System.Drawing.Size(93, 20);
            this.addNewMenuItem.Text = "Új hozzáadása";
            this.addNewMenuItem.Click += new System.EventHandler(this.addNewMenuItem_Click);
            // 
            // autokGrid
            // 
            this.autokGrid.AllowUserToAddRows = false;
            this.autokGrid.AllowUserToDeleteRows = false;
            this.autokGrid.AllowUserToOrderColumns = true;
            this.autokGrid.BackgroundColor = System.Drawing.Color.White;
            this.autokGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.autokGrid.Location = new System.Drawing.Point(16, 50);
            this.autokGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.autokGrid.MultiSelect = false;
            this.autokGrid.Name = "autokGrid";
            this.autokGrid.ReadOnly = true;
            this.autokGrid.Size = new System.Drawing.Size(1033, 356);
            this.autokGrid.TabIndex = 1;
            // 
            // removeAll
            // 
            this.removeAll.Location = new System.Drawing.Point(17, 426);
            this.removeAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeAll.Name = "removeAll";
            this.removeAll.Size = new System.Drawing.Size(263, 50);
            this.removeAll.TabIndex = 2;
            this.removeAll.Text = "Összes eltávolítása";
            this.removeAll.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 501);
            this.Controls.Add(this.removeAll);
            this.Controls.Add(this.autokGrid);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autók";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autokGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewMenuItem;
        private System.Windows.Forms.DataGridView autokGrid;
        private System.Windows.Forms.Button removeAll;
    }
}

