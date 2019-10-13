namespace Bible_MFF_project
{
    partial class Searcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Searcher));
            this.checkBox_exact_match = new System.Windows.Forms.CheckBox();
            this.checkBox_flexibleWordsPosition = new System.Windows.Forms.CheckBox();
            this.checkBox_MultiplePatterns = new System.Windows.Forms.CheckBox();
            this.checkBox_WithoutDiacritic = new System.Windows.Forms.CheckBox();
            this.label_mode = new System.Windows.Forms.Label();
            this.label_select = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.label_language = new System.Windows.Forms.Label();
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.ltranslation = new System.Windows.Forms.Label();
            this.listBox_languages = new System.Windows.Forms.ListBox();
            this.checkedListBox_translation = new System.Windows.Forms.CheckedListBox();
            this.checkBox_translationAll = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_toSmallLetters = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBox_exact_match
            // 
            resources.ApplyResources(this.checkBox_exact_match, "checkBox_exact_match");
            this.checkBox_exact_match.Checked = true;
            this.checkBox_exact_match.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_exact_match.Name = "checkBox_exact_match";
            this.checkBox_exact_match.UseVisualStyleBackColor = true;
            this.checkBox_exact_match.CheckedChanged += new System.EventHandler(this.checkBox_exact_match_CheckedChanged);
            // 
            // checkBox_flexibleWordsPosition
            // 
            resources.ApplyResources(this.checkBox_flexibleWordsPosition, "checkBox_flexibleWordsPosition");
            this.checkBox_flexibleWordsPosition.Name = "checkBox_flexibleWordsPosition";
            this.checkBox_flexibleWordsPosition.UseVisualStyleBackColor = true;
            this.checkBox_flexibleWordsPosition.CheckedChanged += new System.EventHandler(this.CheckBox_flexibleWordsPosition_CheckedChanged);
            // 
            // checkBox_MultiplePatterns
            // 
            resources.ApplyResources(this.checkBox_MultiplePatterns, "checkBox_MultiplePatterns");
            this.checkBox_MultiplePatterns.Name = "checkBox_MultiplePatterns";
            this.checkBox_MultiplePatterns.UseVisualStyleBackColor = true;
            this.checkBox_MultiplePatterns.CheckedChanged += new System.EventHandler(this.checkBox_MultiplePatterns_CheckedChanged);
            // 
            // checkBox_WithoutDiacritic
            // 
            resources.ApplyResources(this.checkBox_WithoutDiacritic, "checkBox_WithoutDiacritic");
            this.checkBox_WithoutDiacritic.Name = "checkBox_WithoutDiacritic";
            this.checkBox_WithoutDiacritic.UseVisualStyleBackColor = true;
            // 
            // label_mode
            // 
            resources.ApplyResources(this.label_mode, "label_mode");
            this.label_mode.Name = "label_mode";
            this.label_mode.Click += new System.EventHandler(this.label_mode_Click);
            // 
            // label_select
            // 
            resources.ApplyResources(this.label_select, "label_select");
            this.label_select.Name = "label_select";
            // 
            // button_search
            // 
            resources.ApplyResources(this.button_search, "button_search");
            this.button_search.Name = "button_search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // label_language
            // 
            resources.ApplyResources(this.label_language, "label_language");
            this.label_language.Name = "label_language";
            // 
            // textBox_Input
            // 
            this.textBox_Input.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.textBox_Input, "textBox_Input");
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            // 
            // ltranslation
            // 
            resources.ApplyResources(this.ltranslation, "ltranslation");
            this.ltranslation.Name = "ltranslation";
            this.ltranslation.Click += new System.EventHandler(this.ltranslation_Click);
            // 
            // listBox_languages
            // 
            this.listBox_languages.BackColor = System.Drawing.SystemColors.Window;
            this.listBox_languages.FormattingEnabled = true;
            resources.ApplyResources(this.listBox_languages, "listBox_languages");
            this.listBox_languages.Name = "listBox_languages";
            this.listBox_languages.SelectedIndexChanged += new System.EventHandler(this.listBox_languages_SelectedIndexChanged);
            // 
            // checkedListBox_translation
            // 
            this.checkedListBox_translation.FormattingEnabled = true;
            resources.ApplyResources(this.checkedListBox_translation, "checkedListBox_translation");
            this.checkedListBox_translation.Name = "checkedListBox_translation";
            this.checkedListBox_translation.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_translation_SelectedIndexChanged);
            // 
            // checkBox_translationAll
            // 
            resources.ApplyResources(this.checkBox_translationAll, "checkBox_translationAll");
            this.checkBox_translationAll.Name = "checkBox_translationAll";
            this.checkBox_translationAll.UseVisualStyleBackColor = true;
            this.checkBox_translationAll.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // checkBox_toSmallLetters
            // 
            resources.ApplyResources(this.checkBox_toSmallLetters, "checkBox_toSmallLetters");
            this.checkBox_toSmallLetters.Name = "checkBox_toSmallLetters";
            this.checkBox_toSmallLetters.UseVisualStyleBackColor = true;
            this.checkBox_toSmallLetters.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // Searcher
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox_toSmallLetters);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_translationAll);
            this.Controls.Add(this.checkedListBox_translation);
            this.Controls.Add(this.listBox_languages);
            this.Controls.Add(this.ltranslation);
            this.Controls.Add(this.textBox_Input);
            this.Controls.Add(this.label_language);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.label_select);
            this.Controls.Add(this.label_mode);
            this.Controls.Add(this.checkBox_WithoutDiacritic);
            this.Controls.Add(this.checkBox_MultiplePatterns);
            this.Controls.Add(this.checkBox_flexibleWordsPosition);
            this.Controls.Add(this.checkBox_exact_match);
            this.Name = "Searcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Searcher_FormClosing);
            this.Load += new System.EventHandler(this.Searcher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox_exact_match;
        private System.Windows.Forms.CheckBox checkBox_flexibleWordsPosition;
        private System.Windows.Forms.CheckBox checkBox_MultiplePatterns;
        private System.Windows.Forms.CheckBox checkBox_WithoutDiacritic;
        private System.Windows.Forms.Label label_mode;
        private System.Windows.Forms.Label label_select;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Label label_language;
        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.Label ltranslation;
        private System.Windows.Forms.ListBox listBox_languages;
        private System.Windows.Forms.CheckedListBox checkedListBox_translation;
        private System.Windows.Forms.CheckBox checkBox_translationAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_toSmallLetters;
    }
}

