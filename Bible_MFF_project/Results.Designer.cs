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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Results));
            this.button_backToMenu = new System.Windows.Forms.Button();
            this.button_saveFile = new System.Windows.Forms.Button();
            this.richTextBox_results = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_backToMenu
            // 
            resources.ApplyResources(this.button_backToMenu, "button_backToMenu");
            this.button_backToMenu.Name = "button_backToMenu";
            this.button_backToMenu.UseVisualStyleBackColor = true;
            this.button_backToMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_saveFile
            // 
            resources.ApplyResources(this.button_saveFile, "button_saveFile");
            this.button_saveFile.Name = "button_saveFile";
            this.button_saveFile.UseVisualStyleBackColor = true;
            this.button_saveFile.Click += new System.EventHandler(this.button_saveFile_Click);
            // 
            // richTextBox_results
            // 
            resources.ApplyResources(this.richTextBox_results, "richTextBox_results");
            this.richTextBox_results.Name = "richTextBox_results";
            this.richTextBox_results.TextChanged += new System.EventHandler(this.richTextBox_results_TextChanged);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_newSearch);
            // 
            // Results
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox_results);
            this.Controls.Add(this.button_saveFile);
            this.Controls.Add(this.button_backToMenu);
            this.Name = "Results";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Results_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_backToMenu;
        private System.Windows.Forms.Button button_saveFile;
        private System.Windows.Forms.RichTextBox richTextBox_results;
        private System.Windows.Forms.Button button1;
    }
}