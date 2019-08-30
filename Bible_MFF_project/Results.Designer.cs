namespace Bible_MFF_project
{
    partial class Results
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
            this.button_backToMenu = new System.Windows.Forms.Button();
            this.button_saveFile = new System.Windows.Forms.Button();
            this.richTextBox_results = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button_backToMenu
            // 
            this.button_backToMenu.Location = new System.Drawing.Point(651, 403);
            this.button_backToMenu.Name = "button_backToMenu";
            this.button_backToMenu.Size = new System.Drawing.Size(137, 38);
            this.button_backToMenu.TabIndex = 1;
            this.button_backToMenu.Text = "Zpět do menu";
            this.button_backToMenu.UseVisualStyleBackColor = true;
            this.button_backToMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_saveFile
            // 
            this.button_saveFile.Location = new System.Drawing.Point(650, 457);
            this.button_saveFile.Name = "button_saveFile";
            this.button_saveFile.Size = new System.Drawing.Size(137, 38);
            this.button_saveFile.TabIndex = 2;
            this.button_saveFile.Text = "Uložit";
            this.button_saveFile.UseVisualStyleBackColor = true;
            this.button_saveFile.Click += new System.EventHandler(this.button_saveFile_Click);
            // 
            // richTextBox_results
            // 
            this.richTextBox_results.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_results.Name = "richTextBox_results";
            this.richTextBox_results.Size = new System.Drawing.Size(644, 509);
            this.richTextBox_results.TabIndex = 3;
            this.richTextBox_results.Text = "";
            this.richTextBox_results.TextChanged += new System.EventHandler(this.richTextBox_results_TextChanged);
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.richTextBox_results);
            this.Controls.Add(this.button_saveFile);
            this.Controls.Add(this.button_backToMenu);
            this.Name = "Results";
            this.Text = "Results";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_backToMenu;
        private System.Windows.Forms.Button button_saveFile;
        private System.Windows.Forms.RichTextBox richTextBox_results;
    }
}