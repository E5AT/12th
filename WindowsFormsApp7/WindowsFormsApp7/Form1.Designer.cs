namespace WindowsFormsApp7
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
            this.nextQuestion = new System.Windows.Forms.Button();
            this.questionText = new System.Windows.Forms.RichTextBox();
            this.remainingQuestionsText = new System.Windows.Forms.Label();
            this.questionNoText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.g = new System.Windows.Forms.RadioButton();
            this.v = new System.Windows.Forms.RadioButton();
            this.a = new System.Windows.Forms.RadioButton();
            this.b = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // nextQuestion
            // 
            this.nextQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextQuestion.Location = new System.Drawing.Point(273, 248);
            this.nextQuestion.Name = "nextQuestion";
            this.nextQuestion.Size = new System.Drawing.Size(146, 76);
            this.nextQuestion.TabIndex = 0;
            this.nextQuestion.Text = "Следващ въпрос";
            this.nextQuestion.UseVisualStyleBackColor = true;
            this.nextQuestion.Click += new System.EventHandler(this.nextQuestion_Click);
            // 
            // questionText
            // 
            this.questionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionText.Location = new System.Drawing.Point(23, 50);
            this.questionText.Name = "questionText";
            this.questionText.Size = new System.Drawing.Size(396, 192);
            this.questionText.TabIndex = 1;
            this.questionText.Text = "";
            // 
            // remainingQuestionsText
            // 
            this.remainingQuestionsText.AutoSize = true;
            this.remainingQuestionsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.remainingQuestionsText.Location = new System.Drawing.Point(193, 9);
            this.remainingQuestionsText.Name = "remainingQuestionsText";
            this.remainingQuestionsText.Size = new System.Drawing.Size(226, 25);
            this.remainingQuestionsText.TabIndex = 6;
            this.remainingQuestionsText.Text = "Оставащи въпроси: 5";
            // 
            // questionNoText
            // 
            this.questionNoText.AutoSize = true;
            this.questionNoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionNoText.Location = new System.Drawing.Point(18, 22);
            this.questionNoText.Name = "questionNoText";
            this.questionNoText.Size = new System.Drawing.Size(104, 25);
            this.questionNoText.TabIndex = 7;
            this.questionNoText.Text = "Въпрос 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(39, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Отговор:";
            // 
            // g
            // 
            this.g.AutoSize = true;
            this.g.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.g.Location = new System.Drawing.Point(136, 326);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(38, 29);
            this.g.TabIndex = 5;
            this.g.TabStop = true;
            this.g.Text = "г";
            this.g.UseVisualStyleBackColor = true;
            // 
            // v
            // 
            this.v.AutoSize = true;
            this.v.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.v.Location = new System.Drawing.Point(136, 303);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(41, 29);
            this.v.TabIndex = 4;
            this.v.TabStop = true;
            this.v.Text = "в";
            this.v.UseVisualStyleBackColor = true;
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a.Location = new System.Drawing.Point(135, 257);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(42, 29);
            this.a.TabIndex = 2;
            this.a.TabStop = true;
            this.a.Text = "а";
            this.a.UseVisualStyleBackColor = true;
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b.Location = new System.Drawing.Point(136, 280);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(42, 29);
            this.b.TabIndex = 3;
            this.b.TabStop = true;
            this.b.Text = "б";
            this.b.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 450);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.v);
            this.Controls.Add(this.g);
            this.Controls.Add(this.questionNoText);
            this.Controls.Add(this.remainingQuestionsText);
            this.Controls.Add(this.questionText);
            this.Controls.Add(this.nextQuestion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextQuestion;
        private System.Windows.Forms.RichTextBox questionText;
        private System.Windows.Forms.Label remainingQuestionsText;
        private System.Windows.Forms.Label questionNoText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton g;
        private System.Windows.Forms.RadioButton v;
        private System.Windows.Forms.RadioButton a;
        private System.Windows.Forms.RadioButton b;
    }
}

