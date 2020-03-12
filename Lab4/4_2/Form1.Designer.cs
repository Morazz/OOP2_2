namespace Lab4_2
{
    partial class Collection
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
            this.generate = new System.Windows.Forms.Button();
            this.asc = new System.Windows.Forms.Button();
            this.desc = new System.Windows.Forms.Button();
            this.size = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.TextBox();
            this.minim = new System.Windows.Forms.Button();
            this.maxi = new System.Windows.Forms.Button();
            this.range = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.ListBox();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.cl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(267, 78);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(110, 40);
            this.generate.TabIndex = 0;
            this.generate.Text = "Generate";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // asc
            // 
            this.asc.Location = new System.Drawing.Point(12, 9);
            this.asc.Name = "asc";
            this.asc.Size = new System.Drawing.Size(110, 40);
            this.asc.TabIndex = 1;
            this.asc.Text = "Ascending";
            this.asc.UseVisualStyleBackColor = true;
            this.asc.Click += new System.EventHandler(this.asc_Click);
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(12, 55);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(110, 40);
            this.desc.TabIndex = 2;
            this.desc.Text = "Descending";
            this.desc.UseVisualStyleBackColor = true;
            this.desc.Click += new System.EventHandler(this.desc_Click);
            // 
            // size
            // 
            this.size.AutoSize = true;
            this.size.Location = new System.Drawing.Point(390, 21);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(35, 17);
            this.size.TabIndex = 3;
            this.size.Text = "Size";
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(318, 41);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(173, 22);
            this.tb.TabIndex = 4;
            // 
            // minim
            // 
            this.minim.Location = new System.Drawing.Point(678, 9);
            this.minim.Name = "minim";
            this.minim.Size = new System.Drawing.Size(110, 40);
            this.minim.TabIndex = 6;
            this.minim.Text = "Min";
            this.minim.UseVisualStyleBackColor = true;
            this.minim.Click += new System.EventHandler(this.minim_Click);
            // 
            // maxi
            // 
            this.maxi.Location = new System.Drawing.Point(678, 55);
            this.maxi.Name = "maxi";
            this.maxi.Size = new System.Drawing.Size(110, 40);
            this.maxi.TabIndex = 7;
            this.maxi.Text = "Max";
            this.maxi.UseVisualStyleBackColor = true;
            this.maxi.Click += new System.EventHandler(this.maxi_Click);
            // 
            // range
            // 
            this.range.Location = new System.Drawing.Point(678, 101);
            this.range.Name = "range";
            this.range.Size = new System.Drawing.Size(110, 40);
            this.range.TabIndex = 8;
            this.range.Text = "Range";
            this.range.UseVisualStyleBackColor = true;
            this.range.Click += new System.EventHandler(this.range_Click);
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.ItemHeight = 16;
            this.lb1.Location = new System.Drawing.Point(39, 159);
            this.lb1.Name = "lb1";
            this.lb1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lb1.Size = new System.Drawing.Size(320, 260);
            this.lb1.TabIndex = 9;
            // 
            // lb2
            // 
            this.lb2.FormattingEnabled = true;
            this.lb2.ItemHeight = 16;
            this.lb2.Location = new System.Drawing.Point(449, 159);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(320, 260);
            this.lb2.TabIndex = 10;
            // 
            // cl
            // 
            this.cl.Location = new System.Drawing.Point(437, 78);
            this.cl.Name = "cl";
            this.cl.Size = new System.Drawing.Size(110, 40);
            this.cl.TabIndex = 11;
            this.cl.Text = "Clear";
            this.cl.UseVisualStyleBackColor = true;
            this.cl.Click += new System.EventHandler(this.cl_Click);
            // 
            // Collection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cl);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.range);
            this.Controls.Add(this.maxi);
            this.Controls.Add(this.minim);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.size);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.asc);
            this.Controls.Add(this.generate);
            this.Name = "Collection";
            this.Text = "Collection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Button asc;
        private System.Windows.Forms.Button desc;
        private System.Windows.Forms.Label size;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Button minim;
        private System.Windows.Forms.Button maxi;
        private System.Windows.Forms.Button range;
        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.ListBox lb2;
        private System.Windows.Forms.Button cl;
    }
}

