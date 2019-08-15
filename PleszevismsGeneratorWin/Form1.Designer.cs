namespace PleszevismsGeneratorWin
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.everydayGroupBox = new System.Windows.Forms.GroupBox();
            this.everydayButton = new System.Windows.Forms.Button();
            this.everydayTextBox = new System.Windows.Forms.RichTextBox();
            this.pleszetonGroupBox = new System.Windows.Forms.GroupBox();
            this.uniqueCheckBox = new System.Windows.Forms.CheckBox();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.felietonLength = new System.Windows.Forms.NumericUpDown();
            this.felietonButton = new System.Windows.Forms.Button();
            this.felietonTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.everydayGroupBox.SuspendLayout();
            this.pleszetonGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.felietonLength)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // everydayGroupBox
            // 
            this.everydayGroupBox.AutoSize = true;
            this.everydayGroupBox.Controls.Add(this.everydayButton);
            this.everydayGroupBox.Controls.Add(this.everydayTextBox);
            this.everydayGroupBox.Location = new System.Drawing.Point(12, 72);
            this.everydayGroupBox.Name = "everydayGroupBox";
            this.everydayGroupBox.Size = new System.Drawing.Size(504, 134);
            this.everydayGroupBox.TabIndex = 0;
            this.everydayGroupBox.TabStop = false;
            this.everydayGroupBox.Text = "Pleszewizm na każdy dzień";
            // 
            // everydayButton
            // 
            this.everydayButton.Location = new System.Drawing.Point(422, 92);
            this.everydayButton.Name = "everydayButton";
            this.everydayButton.Size = new System.Drawing.Size(75, 23);
            this.everydayButton.TabIndex = 1;
            this.everydayButton.Text = "Generuj";
            this.everydayButton.UseVisualStyleBackColor = true;
            this.everydayButton.Click += new System.EventHandler(this.everydayButton_Click);
            // 
            // everydayTextBox
            // 
            this.everydayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.everydayTextBox.Location = new System.Drawing.Point(6, 19);
            this.everydayTextBox.Name = "everydayTextBox";
            this.everydayTextBox.ReadOnly = true;
            this.everydayTextBox.Size = new System.Drawing.Size(492, 67);
            this.everydayTextBox.TabIndex = 0;
            this.everydayTextBox.Text = "";
            // 
            // pleszetonGroupBox
            // 
            this.pleszetonGroupBox.AutoSize = true;
            this.pleszetonGroupBox.Controls.Add(this.uniqueCheckBox);
            this.pleszetonGroupBox.Controls.Add(this.lengthLabel);
            this.pleszetonGroupBox.Controls.Add(this.felietonLength);
            this.pleszetonGroupBox.Controls.Add(this.felietonButton);
            this.pleszetonGroupBox.Controls.Add(this.felietonTextBox);
            this.pleszetonGroupBox.Location = new System.Drawing.Point(12, 200);
            this.pleszetonGroupBox.Name = "pleszetonGroupBox";
            this.pleszetonGroupBox.Size = new System.Drawing.Size(504, 466);
            this.pleszetonGroupBox.TabIndex = 1;
            this.pleszetonGroupBox.TabStop = false;
            this.pleszetonGroupBox.Text = "Soczysty pleszeton";
            // 
            // uniqueCheckBox
            // 
            this.uniqueCheckBox.AutoSize = true;
            this.uniqueCheckBox.Location = new System.Drawing.Point(207, 411);
            this.uniqueCheckBox.Name = "uniqueCheckBox";
            this.uniqueCheckBox.Size = new System.Drawing.Size(96, 17);
            this.uniqueCheckBox.TabIndex = 5;
            this.uniqueCheckBox.Text = "Bez powtórzeń";
            this.uniqueCheckBox.UseVisualStyleBackColor = true;
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(320, 412);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(48, 13);
            this.lengthLabel.TabIndex = 4;
            this.lengthLabel.Text = "Długość";
            // 
            // felietonLength
            // 
            this.felietonLength.Location = new System.Drawing.Point(374, 410);
            this.felietonLength.Name = "felietonLength";
            this.felietonLength.Size = new System.Drawing.Size(42, 20);
            this.felietonLength.TabIndex = 3;
            // 
            // felietonButton
            // 
            this.felietonButton.Location = new System.Drawing.Point(422, 410);
            this.felietonButton.Name = "felietonButton";
            this.felietonButton.Size = new System.Drawing.Size(75, 23);
            this.felietonButton.TabIndex = 2;
            this.felietonButton.Text = "Generuj";
            this.felietonButton.UseVisualStyleBackColor = true;
            this.felietonButton.Click += new System.EventHandler(this.felietonButton_Click);
            // 
            // felietonTextBox
            // 
            this.felietonTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.felietonTextBox.Location = new System.Drawing.Point(6, 19);
            this.felietonTextBox.Name = "felietonTextBox";
            this.felietonTextBox.ReadOnly = true;
            this.felietonTextBox.Size = new System.Drawing.Size(491, 385);
            this.felietonTextBox.TabIndex = 0;
            this.felietonTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wygeneruj sobie:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(528, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.openToolStripMenuItem.Text = "Otwórz...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 672);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pleszetonGroupBox);
            this.Controls.Add(this.everydayGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Generator pleszewizmów";
            this.everydayGroupBox.ResumeLayout(false);
            this.pleszetonGroupBox.ResumeLayout(false);
            this.pleszetonGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.felietonLength)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox everydayGroupBox;
        private System.Windows.Forms.GroupBox pleszetonGroupBox;
        private System.Windows.Forms.Button everydayButton;
        private System.Windows.Forms.RichTextBox everydayTextBox;
        private System.Windows.Forms.Button felietonButton;
        private System.Windows.Forms.RichTextBox felietonTextBox;
        private System.Windows.Forms.CheckBox uniqueCheckBox;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.NumericUpDown felietonLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    }
}

