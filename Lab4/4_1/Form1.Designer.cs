namespace Lab4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.replace = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.index = new System.Windows.Forms.Button();
            this.length = new System.Windows.Forms.Button();
            this.g = new System.Windows.Forms.Button();
            this.s = new System.Windows.Forms.Button();
            this.phrase = new System.Windows.Forms.Button();
            this.word = new System.Windows.Forms.Button();
            this.textbox = new System.Windows.Forms.TextBox();
            this.C = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // replace
            // 
            this.replace.Location = new System.Drawing.Point(27, 222);
            this.replace.Name = "replace";
            this.replace.Size = new System.Drawing.Size(180, 40);
            this.replace.TabIndex = 1;
            this.replace.Text = "Замена подстроки";
            this.replace.UseVisualStyleBackColor = true;
            this.replace.Click += new System.EventHandler(this.replace_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(27, 274);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(180, 40);
            this.delete.TabIndex = 2;
            this.delete.Text = "Удаление подстроки";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button2_Click);
            // 
            // index
            // 
            this.index.Location = new System.Drawing.Point(399, 274);
            this.index.Name = "index";
            this.index.Size = new System.Drawing.Size(180, 40);
            this.index.TabIndex = 3;
            this.index.Text = "Символ по индексу";
            this.index.UseVisualStyleBackColor = true;
            this.index.Click += new System.EventHandler(this.button3_Click);
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(399, 222);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(180, 40);
            this.length.TabIndex = 4;
            this.length.Text = "Длина строки";
            this.length.UseVisualStyleBackColor = true;
            this.length.Click += new System.EventHandler(this.button4_Click);
            // 
            // g
            // 
            this.g.Location = new System.Drawing.Point(213, 274);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(180, 40);
            this.g.TabIndex = 5;
            this.g.Text = "Кол-во гласных";
            this.g.UseVisualStyleBackColor = true;
            this.g.Click += new System.EventHandler(this.button5_Click);
            // 
            // s
            // 
            this.s.Location = new System.Drawing.Point(213, 222);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(180, 40);
            this.s.TabIndex = 6;
            this.s.Text = "Кол-во согласных";
            this.s.UseVisualStyleBackColor = true;
            this.s.Click += new System.EventHandler(this.s_Click);
            // 
            // phrase
            // 
            this.phrase.Location = new System.Drawing.Point(585, 274);
            this.phrase.Name = "phrase";
            this.phrase.Size = new System.Drawing.Size(180, 40);
            this.phrase.TabIndex = 7;
            this.phrase.Text = "Кол-во предложений";
            this.phrase.UseVisualStyleBackColor = true;
            this.phrase.Click += new System.EventHandler(this.phrase_Click);
            // 
            // word
            // 
            this.word.Location = new System.Drawing.Point(585, 222);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(180, 40);
            this.word.TabIndex = 8;
            this.word.Text = "Кол-во слов";
            this.word.UseVisualStyleBackColor = true;
            this.word.Click += new System.EventHandler(this.word_Click);
            // 
            // textbox
            // 
            this.textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textbox.Location = new System.Drawing.Point(27, 52);
            this.textbox.Multiline = true;
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(738, 50);
            this.textbox.TabIndex = 9;
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(27, 176);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(75, 40);
            this.C.TabIndex = 10;
            this.C.Text = "С";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.button9_Click);
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(27, 337);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(738, 50);
            this.result.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.C);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.word);
            this.Controls.Add(this.phrase);
            this.Controls.Add(this.s);
            this.Controls.Add(this.g);
            this.Controls.Add(this.length);
            this.Controls.Add(this.index);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.replace);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button replace;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button index;
        private System.Windows.Forms.Button length;
        private System.Windows.Forms.Button g;
        private System.Windows.Forms.Button s;
        private System.Windows.Forms.Button phrase;
        private System.Windows.Forms.Button word;
        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.TextBox result;
    }
}

