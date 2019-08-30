namespace Bible_MFF_project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkBox_exact_match = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label_mode = new System.Windows.Forms.Label();
            this.label_select = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.label_language = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.ltranslation = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBox_exact_match
            // 
            this.checkBox_exact_match.AutoSize = true;
            this.checkBox_exact_match.Checked = true;
            this.checkBox_exact_match.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_exact_match.Location = new System.Drawing.Point(35, 214);
            this.checkBox_exact_match.Name = "checkBox_exact_match";
            this.checkBox_exact_match.Size = new System.Drawing.Size(133, 24);
            this.checkBox_exact_match.TabIndex = 1;
            this.checkBox_exact_match.Text = "Přesná shoda";
            this.checkBox_exact_match.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(35, 244);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(165, 24);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Rozmezí 5-ti veršů";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(35, 274);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(143, 24);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Volný slovosled";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(35, 304);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(113, 24);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(35, 336);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(113, 24);
            this.checkBox5.TabIndex = 5;
            this.checkBox5.Text = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // label_mode
            // 
            this.label_mode.AutoSize = true;
            this.label_mode.Location = new System.Drawing.Point(81, 142);
            this.label_mode.Name = "label_mode";
            this.label_mode.Size = new System.Drawing.Size(40, 20);
            this.label_mode.TabIndex = 6;
            this.label_mode.Text = "mód";
            // 
            // label_select
            // 
            this.label_select.AutoSize = true;
            this.label_select.Location = new System.Drawing.Point(414, 142);
            this.label_select.Name = "label_select";
            this.label_select.Size = new System.Drawing.Size(0, 20);
            this.label_select.TabIndex = 7;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(853, 509);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(103, 37);
            this.button_search.TabIndex = 8;
            this.button_search.Text = "Hledej";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // label_language
            // 
            this.label_language.AutoSize = true;
            this.label_language.Location = new System.Drawing.Point(711, 67);
            this.label_language.Name = "label_language";
            this.label_language.Size = new System.Drawing.Size(44, 20);
            this.label_language.TabIndex = 10;
            this.label_language.Text = "jazyk";
            this.label_language.Click += new System.EventHandler(this.label_language_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.ForeColor = System.Drawing.Color.Black;
            this.textBoxInput.Location = new System.Drawing.Point(238, 263);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(804, 82);
            this.textBoxInput.TabIndex = 11;
            this.textBoxInput.Text = "Hledaný text";
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            // 
            // ltranslation
            // 
            this.ltranslation.AutoSize = true;
            this.ltranslation.Location = new System.Drawing.Point(353, 67);
            this.ltranslation.Name = "ltranslation";
            this.ltranslation.Size = new System.Drawing.Size(61, 20);
            this.ltranslation.TabIndex = 12;
            this.ltranslation.Text = "překlad";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(332, 176);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 24);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox_Result
            // 
            this.textBox_Result.Location = new System.Drawing.Point(57, 386);
            this.textBox_Result.Multiline = true;
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.ReadOnly = true;
            this.textBox_Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Result.Size = new System.Drawing.Size(774, 160);
            this.textBox_Result.TabIndex = 14;
            this.textBox_Result.TextChanged += new System.EventHandler(this.textBox_Result_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 615);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.ltranslation);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.label_language);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.label_select);
            this.Controls.Add(this.label_mode);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox_exact_match);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Explora verbum";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox_exact_match;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Label label_mode;
        private System.Windows.Forms.Label label_select;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Label label_language;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label ltranslation;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox_Result;
    }
}

