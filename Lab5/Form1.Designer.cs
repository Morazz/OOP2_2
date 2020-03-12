namespace Lab5
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
            this.components = new System.ComponentModel.Container();
            this.time = new System.Windows.Forms.MonthCalendar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.name = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.Label();
            this.tb2 = new System.Windows.Forms.TrackBar();
            this.amount = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.TrackBar();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.w = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.cb = new System.Windows.Forms.ComboBox();
            this.write = new System.Windows.Forms.Button();
            this.read = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.add = new System.Windows.Forms.Button();
            this.numb = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            this.SuspendLayout();
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(261, 37);
            this.time.Name = "time";
            this.time.TabIndex = 0;
            this.time.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.time_DateChanged);
            this.time.Validating += new System.ComponentModel.CancelEventHandler(this.time_Validating);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kitchen",
            "Bathroom",
            "Bedroom",
            "Watercloset",
            "Lounge"});
            this.comboBox1.Location = new System.Drawing.Point(25, 147);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(190, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(22, 17);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(45, 17);
            this.name.TabIndex = 2;
            this.name.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Location = new System.Drawing.Point(22, 72);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(58, 17);
            this.number.TabIndex = 4;
            this.number.Text = "Number";
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(25, 387);
            this.tb2.Maximum = 100;
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(190, 56);
            this.tb2.TabIndex = 6;
            this.tb2.Scroll += new System.EventHandler(this.tb2_Scroll);
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Location = new System.Drawing.Point(22, 354);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(56, 17);
            this.amount.TabIndex = 7;
            this.amount.Text = "Amount";
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Location = new System.Drawing.Point(22, 292);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(52, 17);
            this.weight.TabIndex = 9;
            this.weight.Text = "Weight";
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(25, 312);
            this.tb.Maximum = 100;
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(190, 56);
            this.tb.TabIndex = 8;
            this.tb.Scroll += new System.EventHandler(this.tb_Scroll);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(25, 202);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(190, 22);
            this.textBox3.TabIndex = 11;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.Validating += new System.ComponentModel.CancelEventHandler(this.textBox3_Validating_1);
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(22, 181);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(40, 17);
            this.price.TabIndex = 10;
            this.price.Text = "Price";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Location = new System.Drawing.Point(22, 127);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(40, 17);
            this.type.TabIndex = 12;
            this.type.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Amount";
            // 
            // w
            // 
            this.w.AutoSize = true;
            this.w.Location = new System.Drawing.Point(189, 292);
            this.w.Name = "w";
            this.w.Size = new System.Drawing.Size(16, 17);
            this.w.TabIndex = 14;
            this.w.Text = "0";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(189, 367);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(16, 17);
            this.a.TabIndex = 15;
            this.a.Text = "0";
            // 
            // cb
            // 
            this.cb.FormattingEnabled = true;
            this.cb.Items.AddRange(new object[] {
            "Add new..."});
            this.cb.Location = new System.Drawing.Point(261, 257);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(192, 24);
            this.cb.TabIndex = 16;
            this.cb.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // write
            // 
            this.write.Location = new System.Drawing.Point(261, 302);
            this.write.Name = "write";
            this.write.Size = new System.Drawing.Size(192, 23);
            this.write.TabIndex = 18;
            this.write.Text = "Write to file";
            this.write.UseVisualStyleBackColor = true;
            this.write.Click += new System.EventHandler(this.write_Click);
            // 
            // read
            // 
            this.read.Location = new System.Drawing.Point(261, 331);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(192, 23);
            this.read.TabIndex = 19;
            this.read.Text = "Read from file";
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(25, 231);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(82, 21);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Portable";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(25, 260);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(49, 21);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Big";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(261, 387);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(192, 23);
            this.add.TabIndex = 23;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // numb
            // 
            this.numb.Location = new System.Drawing.Point(25, 92);
            this.numb.Mask = "00000";
            this.numb.Name = "numb";
            this.numb.Size = new System.Drawing.Size(190, 22);
            this.numb.TabIndex = 22;
            this.numb.ValidatingType = typeof(int);
            this.numb.TextChanged += new System.EventHandler(this.numb_TextChanged);
            this.numb.Validating += new System.ComponentModel.CancelEventHandler(this.numb_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.add);
            this.Controls.Add(this.numb);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.read);
            this.Controls.Add(this.write);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.a);
            this.Controls.Add(this.w);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.type);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.price);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.number);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.time);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar time;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.TrackBar tb2;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.TrackBar tb;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label w;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.Button write;
        private System.Windows.Forms.Button read;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.MaskedTextBox numb;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
    }
}

