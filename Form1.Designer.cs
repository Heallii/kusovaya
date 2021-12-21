namespace ParticlesCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbSize = new System.Windows.Forms.TrackBar();
            this.lblDirection = new System.Windows.Forms.Label();
            this.tbHorizontal = new System.Windows.Forms.TrackBar();
            this.tbVertical = new System.Windows.Forms.TrackBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblSize = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbHorizontal2 = new System.Windows.Forms.TrackBar();
            this.lblSize2 = new System.Windows.Forms.Label();
            this.tbVertical2 = new System.Windows.Forms.TrackBar();
            this.tbSize2 = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbHorizontal3 = new System.Windows.Forms.TrackBar();
            this.lblSize3 = new System.Windows.Forms.Label();
            this.tbVertical3 = new System.Windows.Forms.TrackBar();
            this.tbSize3 = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHorizontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVertical)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbHorizontal2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVertical2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSize2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbHorizontal3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVertical3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSize3)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(11, 8);
            this.picDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(630, 395);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.Click += new System.EventHandler(this.picDisplay_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbSize
            // 
            this.tbSize.AutoSize = false;
            this.tbSize.Location = new System.Drawing.Point(51, 87);
            this.tbSize.Margin = new System.Windows.Forms.Padding(2);
            this.tbSize.Maximum = 250;
            this.tbSize.Minimum = 50;
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(162, 32);
            this.tbSize.TabIndex = 1;
            this.tbSize.Value = 100;
            this.tbSize.Scroll += new System.EventHandler(this.tbSize_Scroll);
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(4, 95);
            this.lblDirection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(46, 13);
            this.lblDirection.TabIndex = 2;
            this.lblDirection.Text = "Размер";
            // 
            // tbHorizontal
            // 
            this.tbHorizontal.AutoSize = false;
            this.tbHorizontal.Location = new System.Drawing.Point(39, 25);
            this.tbHorizontal.Margin = new System.Windows.Forms.Padding(2);
            this.tbHorizontal.Maximum = 100;
            this.tbHorizontal.Name = "tbHorizontal";
            this.tbHorizontal.Size = new System.Drawing.Size(174, 29);
            this.tbHorizontal.TabIndex = 3;
            this.tbHorizontal.Value = 50;
            this.tbHorizontal.Scroll += new System.EventHandler(this.tbHorizontal_Scroll);
            // 
            // tbVertical
            // 
            this.tbVertical.AutoSize = false;
            this.tbVertical.Location = new System.Drawing.Point(39, 58);
            this.tbVertical.Margin = new System.Windows.Forms.Padding(2);
            this.tbVertical.Maximum = 100;
            this.tbVertical.Name = "tbVertical";
            this.tbVertical.Size = new System.Drawing.Size(174, 35);
            this.tbVertical.TabIndex = 4;
            this.tbVertical.Value = 50;
            this.tbVertical.Scroll += new System.EventHandler(this.tbVertical_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Цвет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 25);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "Цвет";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(221, 25);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 29);
            this.button3.TabIndex = 7;
            this.button3.Text = "Цвет";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(217, 95);
            this.lblSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(25, 13);
            this.lblSize.TabIndex = 9;
            this.lblSize.Text = "100";
            this.lblSize.Click += new System.EventHandler(this.lblSize_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbHorizontal);
            this.groupBox1.Controls.Add(this.lblSize);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbVertical);
            this.groupBox1.Controls.Add(this.tbSize);
            this.groupBox1.Controls.Add(this.lblDirection);
            this.groupBox1.Location = new System.Drawing.Point(645, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(319, 129);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Точка 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "X";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbHorizontal2);
            this.groupBox2.Controls.Add(this.lblSize2);
            this.groupBox2.Controls.Add(this.tbVertical2);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.tbSize2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(645, 141);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(319, 129);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Точка 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "X";
            // 
            // tbHorizontal2
            // 
            this.tbHorizontal2.AutoSize = false;
            this.tbHorizontal2.Location = new System.Drawing.Point(39, 25);
            this.tbHorizontal2.Margin = new System.Windows.Forms.Padding(2);
            this.tbHorizontal2.Maximum = 100;
            this.tbHorizontal2.Name = "tbHorizontal2";
            this.tbHorizontal2.Size = new System.Drawing.Size(174, 29);
            this.tbHorizontal2.TabIndex = 3;
            this.tbHorizontal2.Value = 25;
            this.tbHorizontal2.Scroll += new System.EventHandler(this.tbHorizontal2_Scroll);
            // 
            // lblSize2
            // 
            this.lblSize2.AutoSize = true;
            this.lblSize2.Location = new System.Drawing.Point(217, 95);
            this.lblSize2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSize2.Name = "lblSize2";
            this.lblSize2.Size = new System.Drawing.Size(25, 13);
            this.lblSize2.TabIndex = 9;
            this.lblSize2.Text = "100";
            // 
            // tbVertical2
            // 
            this.tbVertical2.AutoSize = false;
            this.tbVertical2.Location = new System.Drawing.Point(39, 58);
            this.tbVertical2.Margin = new System.Windows.Forms.Padding(2);
            this.tbVertical2.Maximum = 100;
            this.tbVertical2.Name = "tbVertical2";
            this.tbVertical2.Size = new System.Drawing.Size(174, 35);
            this.tbVertical2.TabIndex = 4;
            this.tbVertical2.Value = 50;
            this.tbVertical2.Scroll += new System.EventHandler(this.tbVertical2_Scroll);
            // 
            // tbSize2
            // 
            this.tbSize2.AutoSize = false;
            this.tbSize2.Location = new System.Drawing.Point(51, 87);
            this.tbSize2.Margin = new System.Windows.Forms.Padding(2);
            this.tbSize2.Maximum = 250;
            this.tbSize2.Minimum = 50;
            this.tbSize2.Name = "tbSize2";
            this.tbSize2.Size = new System.Drawing.Size(162, 32);
            this.tbSize2.TabIndex = 1;
            this.tbSize2.Value = 100;
            this.tbSize2.Scroll += new System.EventHandler(this.tbSize2_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 95);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Размер";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tbHorizontal3);
            this.groupBox3.Controls.Add(this.lblSize3);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.tbVertical3);
            this.groupBox3.Controls.Add(this.tbSize3);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(645, 274);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(319, 129);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Точка 3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 58);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "X";
            // 
            // tbHorizontal3
            // 
            this.tbHorizontal3.AutoSize = false;
            this.tbHorizontal3.Location = new System.Drawing.Point(39, 25);
            this.tbHorizontal3.Margin = new System.Windows.Forms.Padding(2);
            this.tbHorizontal3.Maximum = 100;
            this.tbHorizontal3.Name = "tbHorizontal3";
            this.tbHorizontal3.Size = new System.Drawing.Size(174, 29);
            this.tbHorizontal3.TabIndex = 3;
            this.tbHorizontal3.Value = 75;
            this.tbHorizontal3.Scroll += new System.EventHandler(this.tbHorizontal3_Scroll);
            // 
            // lblSize3
            // 
            this.lblSize3.AutoSize = true;
            this.lblSize3.Location = new System.Drawing.Point(217, 95);
            this.lblSize3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSize3.Name = "lblSize3";
            this.lblSize3.Size = new System.Drawing.Size(25, 13);
            this.lblSize3.TabIndex = 9;
            this.lblSize3.Text = "100";
            // 
            // tbVertical3
            // 
            this.tbVertical3.AutoSize = false;
            this.tbVertical3.Location = new System.Drawing.Point(39, 58);
            this.tbVertical3.Margin = new System.Windows.Forms.Padding(2);
            this.tbVertical3.Maximum = 100;
            this.tbVertical3.Name = "tbVertical3";
            this.tbVertical3.Size = new System.Drawing.Size(174, 35);
            this.tbVertical3.TabIndex = 4;
            this.tbVertical3.Value = 50;
            this.tbVertical3.Scroll += new System.EventHandler(this.tbVertical3_Scroll);
            // 
            // tbSize3
            // 
            this.tbSize3.AutoSize = false;
            this.tbSize3.Location = new System.Drawing.Point(51, 87);
            this.tbSize3.Margin = new System.Windows.Forms.Padding(2);
            this.tbSize3.Maximum = 250;
            this.tbSize3.Minimum = 50;
            this.tbSize3.Name = "tbSize3";
            this.tbSize3.Size = new System.Drawing.Size(162, 29);
            this.tbSize3.TabIndex = 1;
            this.tbSize3.Value = 100;
            this.tbSize3.Scroll += new System.EventHandler(this.tbSize3_Scroll);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 95);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Размер";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 419);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picDisplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Разноцветный снег";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHorizontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVertical)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbHorizontal2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVertical2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSize2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbHorizontal3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVertical3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSize3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar tbSize;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.TrackBar tbHorizontal;
        private System.Windows.Forms.TrackBar tbVertical;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar tbHorizontal2;
        private System.Windows.Forms.Label lblSize2;
        private System.Windows.Forms.TrackBar tbVertical2;
        private System.Windows.Forms.TrackBar tbSize2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar tbHorizontal3;
        private System.Windows.Forms.Label lblSize3;
        private System.Windows.Forms.TrackBar tbVertical3;
        private System.Windows.Forms.TrackBar tbSize3;
        private System.Windows.Forms.Label label11;
    }
}

