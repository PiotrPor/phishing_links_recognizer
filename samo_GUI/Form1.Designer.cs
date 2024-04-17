
namespace samo_GUI
{
    partial class Form1
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
            this.LabelPolaAdresu = new System.Windows.Forms.Label();
            this.PoleAdresu = new System.Windows.Forms.TextBox();
            this.CheckBoxInnych = new System.Windows.Forms.CheckBox();
            this.przycisk = new System.Windows.Forms.Button();
            this.PoleWyniku = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // LabelPolaAdresu
            // 
            this.LabelPolaAdresu.AutoSize = true;
            this.LabelPolaAdresu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPolaAdresu.Location = new System.Drawing.Point(13, 13);
            this.LabelPolaAdresu.Name = "LabelPolaAdresu";
            this.LabelPolaAdresu.Size = new System.Drawing.Size(131, 20);
            this.LabelPolaAdresu.TabIndex = 0;
            this.LabelPolaAdresu.Text = "Wpisz adres tutaj";
            // 
            // PoleAdresu
            // 
            this.PoleAdresu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoleAdresu.Location = new System.Drawing.Point(16, 36);
            this.PoleAdresu.Name = "PoleAdresu";
            this.PoleAdresu.Size = new System.Drawing.Size(607, 26);
            this.PoleAdresu.TabIndex = 1;
            this.PoleAdresu.WordWrap = false;
            // 
            // CheckBoxInnych
            // 
            this.CheckBoxInnych.AutoSize = true;
            this.CheckBoxInnych.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxInnych.Location = new System.Drawing.Point(13, 68);
            this.CheckBoxInnych.Name = "CheckBoxInnych";
            this.CheckBoxInnych.Size = new System.Drawing.Size(161, 24);
            this.CheckBoxInnych.TabIndex = 2;
            this.CheckBoxInnych.Text = "Zapytaj inne strony";
            this.CheckBoxInnych.UseVisualStyleBackColor = true;
            this.CheckBoxInnych.CheckedChanged += new System.EventHandler(this.CheckBoxInnych_CheckedChanged);
            // 
            // przycisk
            // 
            this.przycisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.przycisk.Location = new System.Drawing.Point(12, 98);
            this.przycisk.Name = "przycisk";
            this.przycisk.Size = new System.Drawing.Size(252, 35);
            this.przycisk.TabIndex = 3;
            this.przycisk.Text = "Sprawdz";
            this.przycisk.UseVisualStyleBackColor = true;
            this.przycisk.Click += new System.EventHandler(this.przycisk_Click);
            // 
            // PoleWyniku
            // 
            this.PoleWyniku.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoleWyniku.Location = new System.Drawing.Point(17, 158);
            this.PoleWyniku.Name = "PoleWyniku";
            this.PoleWyniku.Size = new System.Drawing.Size(418, 212);
            this.PoleWyniku.TabIndex = 4;
            this.PoleWyniku.Text = "";
            this.PoleWyniku.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.PoleWyniku);
            this.Controls.Add(this.przycisk);
            this.Controls.Add(this.CheckBoxInnych);
            this.Controls.Add(this.PoleAdresu);
            this.Controls.Add(this.LabelPolaAdresu);
            this.Name = "Form1";
            this.Text = "Wykrywacz URL szkodliwych stron";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelPolaAdresu;
        private System.Windows.Forms.TextBox PoleAdresu;
        private System.Windows.Forms.CheckBox CheckBoxInnych;
        private System.Windows.Forms.Button przycisk;
        private System.Windows.Forms.RichTextBox PoleWyniku;
    }
}

