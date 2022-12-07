namespace TZCars {
    partial class UpdateCarForm {
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
            this.label1 = new System.Windows.Forms.Label();
            this.rendszam = new System.Windows.Forms.TextBox();
            this.forgalomba = new System.Windows.Forms.CheckBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.modifyCar = new System.Windows.Forms.Button();
            this.markak = new System.Windows.Forms.ComboBox();
            this.evjarat = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.utolsoMuszaki = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tulajdonosNeve = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Rendszám";
            // 
            // rendszam
            // 
            this.rendszam.Location = new System.Drawing.Point(152, 31);
            this.rendszam.Name = "rendszam";
            this.rendszam.Size = new System.Drawing.Size(263, 22);
            this.rendszam.TabIndex = 28;
            this.rendszam.WordWrap = false;
            this.rendszam.TextChanged += new System.EventHandler(this.data_TextChanged);
            // 
            // forgalomba
            // 
            this.forgalomba.AutoSize = true;
            this.forgalomba.Location = new System.Drawing.Point(152, 230);
            this.forgalomba.Name = "forgalomba";
            this.forgalomba.Size = new System.Drawing.Size(132, 20);
            this.forgalomba.TabIndex = 27;
            this.forgalomba.Text = "Forgalomban van";
            this.forgalomba.UseVisualStyleBackColor = true;
            this.forgalomba.CheckedChanged += new System.EventHandler(this.data_TextChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(278, 267);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(215, 40);
            this.cancelButton.TabIndex = 26;
            this.cancelButton.Text = "Mégse";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // modifyCar
            // 
            this.modifyCar.Enabled = false;
            this.modifyCar.Location = new System.Drawing.Point(36, 267);
            this.modifyCar.Name = "modifyCar";
            this.modifyCar.Size = new System.Drawing.Size(215, 40);
            this.modifyCar.TabIndex = 25;
            this.modifyCar.Text = "Módosítás elfogadása";
            this.modifyCar.UseVisualStyleBackColor = true;
            this.modifyCar.Click += new System.EventHandler(this.modifyCar_Click);
            // 
            // markak
            // 
            this.markak.FormattingEnabled = true;
            this.markak.Items.AddRange(new object[] {
            "Audi",
            "BMW",
            "Honda",
            "Hyundai",
            "Opel",
            "Peugeot",
            "Renault",
            "Skoda",
            "Suzuki"});
            this.markak.Location = new System.Drawing.Point(152, 71);
            this.markak.Name = "markak";
            this.markak.Size = new System.Drawing.Size(263, 24);
            this.markak.Sorted = true;
            this.markak.TabIndex = 24;
            this.markak.TextChanged += new System.EventHandler(this.data_TextChanged);
            // 
            // evjarat
            // 
            this.evjarat.Location = new System.Drawing.Point(152, 192);
            this.evjarat.MaxDate = new System.DateTime(2022, 12, 7, 0, 0, 0, 0);
            this.evjarat.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.evjarat.Name = "evjarat";
            this.evjarat.Size = new System.Drawing.Size(263, 22);
            this.evjarat.TabIndex = 23;
            this.evjarat.Value = new System.DateTime(2022, 12, 7, 0, 0, 0, 0);
            this.evjarat.ValueChanged += new System.EventHandler(this.data_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Évjárat";
            // 
            // utolsoMuszaki
            // 
            this.utolsoMuszaki.Location = new System.Drawing.Point(152, 151);
            this.utolsoMuszaki.MaxDate = new System.DateTime(2022, 12, 7, 0, 0, 0, 0);
            this.utolsoMuszaki.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.utolsoMuszaki.Name = "utolsoMuszaki";
            this.utolsoMuszaki.Size = new System.Drawing.Size(263, 22);
            this.utolsoMuszaki.TabIndex = 21;
            this.utolsoMuszaki.Value = new System.DateTime(2022, 12, 7, 0, 0, 0, 0);
            this.utolsoMuszaki.ValueChanged += new System.EventHandler(this.data_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Utolsó műszaki";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tulajdonos neve";
            // 
            // tulajdonosNeve
            // 
            this.tulajdonosNeve.Location = new System.Drawing.Point(152, 112);
            this.tulajdonosNeve.Margin = new System.Windows.Forms.Padding(4);
            this.tulajdonosNeve.MaxLength = 300;
            this.tulajdonosNeve.Name = "tulajdonosNeve";
            this.tulajdonosNeve.Size = new System.Drawing.Size(263, 22);
            this.tulajdonosNeve.TabIndex = 18;
            this.tulajdonosNeve.WordWrap = false;
            this.tulajdonosNeve.TextChanged += new System.EventHandler(this.data_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Márka neve";
            // 
            // UpdateCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 338);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rendszam);
            this.Controls.Add(this.forgalomba);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.modifyCar);
            this.Controls.Add(this.markak);
            this.Controls.Add(this.evjarat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.utolsoMuszaki);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tulajdonosNeve);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "UpdateCarForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Autó frissítése";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rendszam;
        private System.Windows.Forms.CheckBox forgalomba;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button modifyCar;
        private System.Windows.Forms.ComboBox markak;
        private System.Windows.Forms.DateTimePicker evjarat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker utolsoMuszaki;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tulajdonosNeve;
        private System.Windows.Forms.Label label2;
    }
}