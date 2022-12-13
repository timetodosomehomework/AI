namespace Gentic_Alghorithm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.expression = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.leftBorder = new System.Windows.Forms.TextBox();
            this.rightBorder = new System.Windows.Forms.TextBox();
            this.n = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.populationCapacity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.selection = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.TextBox();
            this.CO = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.alpha = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lambda = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.P = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Pm = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.eps = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gap = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.argName = new System.Windows.Forms.ColumnHeader();
            this.argValue = new System.Windows.Forms.ColumnHeader();
            this.y = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.bits = new System.Windows.Forms.RadioButton();
            this.real = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.P0 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.precision = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Функция:";
            // 
            // expression
            // 
            this.expression.Location = new System.Drawing.Point(138, 25);
            this.expression.Name = "expression";
            this.expression.Size = new System.Drawing.Size(243, 27);
            this.expression.TabIndex = 1;
            this.expression.Text = "x1^2+3*x2^2+2*x1*x2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Интервал:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "(";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = ";";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = ")";
            // 
            // leftBorder
            // 
            this.leftBorder.Location = new System.Drawing.Point(165, 62);
            this.leftBorder.Name = "leftBorder";
            this.leftBorder.Size = new System.Drawing.Size(87, 27);
            this.leftBorder.TabIndex = 6;
            this.leftBorder.Text = "-0,1163";
            // 
            // rightBorder
            // 
            this.rightBorder.Location = new System.Drawing.Point(275, 62);
            this.rightBorder.Name = "rightBorder";
            this.rightBorder.Size = new System.Drawing.Size(87, 27);
            this.rightBorder.TabIndex = 7;
            this.rightBorder.Text = "0,2558";
            // 
            // n
            // 
            this.n.Location = new System.Drawing.Point(243, 223);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(87, 27);
            this.n.TabIndex = 8;
            this.n.Text = "100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Количество популяций:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Особей в популяции:";
            // 
            // populationCapacity
            // 
            this.populationCapacity.Location = new System.Drawing.Point(227, 258);
            this.populationCapacity.Name = "populationCapacity";
            this.populationCapacity.Size = new System.Drawing.Size(87, 27);
            this.populationCapacity.TabIndex = 10;
            this.populationCapacity.Text = "20";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Селекция:";
            // 
            // selection
            // 
            this.selection.FormattingEnabled = true;
            this.selection.Items.AddRange(new object[] {
            "Турнирный отбор"});
            this.selection.Location = new System.Drawing.Point(147, 332);
            this.selection.Name = "selection";
            this.selection.Size = new System.Drawing.Size(183, 28);
            this.selection.TabIndex = 13;
            this.selection.Text = "Турнирный отбор";
            this.selection.SelectedIndexChanged += new System.EventHandler(this.selection_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(63, 378);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Размер турнира:";
            // 
            // t
            // 
            this.t.Location = new System.Drawing.Point(193, 371);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(87, 27);
            this.t.TabIndex = 16;
            this.t.Text = "2";
            // 
            // CO
            // 
            this.CO.FormattingEnabled = true;
            this.CO.Items.AddRange(new object[] {
            "2-точечный кроссинговер",
            "Арифметический кроссинговер",
            "BLX-a кроссинговер"});
            this.CO.Location = new System.Drawing.Point(177, 409);
            this.CO.Name = "CO";
            this.CO.Size = new System.Drawing.Size(226, 28);
            this.CO.TabIndex = 19;
            this.CO.Text = "2-точечный кроссинговер";
            this.CO.SelectedIndexChanged += new System.EventHandler(this.CO_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(63, 417);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Скрещивание:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(63, 558);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Альфа:";
            // 
            // alpha
            // 
            this.alpha.Enabled = false;
            this.alpha.Location = new System.Drawing.Point(125, 551);
            this.alpha.Name = "alpha";
            this.alpha.Size = new System.Drawing.Size(87, 27);
            this.alpha.TabIndex = 22;
            this.alpha.Text = "0,001";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(63, 521);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 20);
            this.label13.TabIndex = 21;
            this.label13.Text = "Лямбда:";
            // 
            // lambda
            // 
            this.lambda.Enabled = false;
            this.lambda.Location = new System.Drawing.Point(135, 514);
            this.lambda.Name = "lambda";
            this.lambda.Size = new System.Drawing.Size(87, 27);
            this.lambda.TabIndex = 20;
            this.lambda.Text = "0,5";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(63, 592);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(198, 20);
            this.label14.TabIndex = 25;
            this.label14.Text = "Вероятность скрещивания:";
            // 
            // P
            // 
            this.P.Location = new System.Drawing.Point(267, 585);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(87, 27);
            this.P.TabIndex = 24;
            this.P.Text = "0,7";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(62, 630);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(163, 20);
            this.label15.TabIndex = 27;
            this.label15.Text = "Вероятность мутации:";
            // 
            // Pm
            // 
            this.Pm.Location = new System.Drawing.Point(231, 623);
            this.Pm.Name = "Pm";
            this.Pm.Size = new System.Drawing.Size(87, 27);
            this.Pm.TabIndex = 26;
            this.Pm.Text = "0,5";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(61, 670);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 20);
            this.label16.TabIndex = 29;
            this.label16.Text = "Эпсилон:";
            // 
            // eps
            // 
            this.eps.Location = new System.Drawing.Point(139, 663);
            this.eps.Name = "eps";
            this.eps.Size = new System.Drawing.Size(87, 27);
            this.eps.TabIndex = 28;
            this.eps.Text = "0,01";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.precision);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.P0);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.real);
            this.groupBox1.Controls.Add(this.bits);
            this.groupBox1.Controls.Add(this.gap);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.expression);
            this.groupBox1.Controls.Add(this.eps);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Pm);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.P);
            this.groupBox1.Controls.Add(this.leftBorder);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.rightBorder);
            this.groupBox1.Controls.Add(this.alpha);
            this.groupBox1.Controls.Add(this.n);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lambda);
            this.groupBox1.Controls.Add(this.populationCapacity);
            this.groupBox1.Controls.Add(this.CO);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.selection);
            this.groupBox1.Controls.Add(this.t);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 768);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройка алгоритма";
            // 
            // gap
            // 
            this.gap.Location = new System.Drawing.Point(213, 293);
            this.gap.Name = "gap";
            this.gap.Size = new System.Drawing.Size(87, 27);
            this.gap.TabIndex = 31;
            this.gap.Text = "1";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(63, 300);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(144, 20);
            this.label18.TabIndex = 32;
            this.label18.Text = "Разрыв поколений:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 715);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 30;
            this.button1.Text = "Запустить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Controls.Add(this.y);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Location = new System.Drawing.Point(480, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 767);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Найденные значения";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.argName,
            this.argValue});
            this.listView1.Location = new System.Drawing.Point(28, 68);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(360, 148);
            this.listView1.TabIndex = 32;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // argName
            // 
            this.argName.Text = "Переменная";
            this.argName.Width = 118;
            // 
            // argValue
            // 
            this.argValue.Text = "Значение";
            this.argValue.Width = 250;
            // 
            // y
            // 
            this.y.Location = new System.Drawing.Point(179, 24);
            this.y.Name = "y";
            this.y.ReadOnly = true;
            this.y.Size = new System.Drawing.Size(209, 27);
            this.y.TabIndex = 30;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(28, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(145, 20);
            this.label17.TabIndex = 31;
            this.label17.Text = "Минимум функции:";
            // 
            // bits
            // 
            this.bits.AutoSize = true;
            this.bits.Location = new System.Drawing.Point(63, 126);
            this.bits.Name = "bits";
            this.bits.Size = new System.Drawing.Size(197, 24);
            this.bits.TabIndex = 33;
            this.bits.Text = "Битовое представление";
            this.bits.UseVisualStyleBackColor = true;
            this.bits.CheckedChanged += new System.EventHandler(this.bits_CheckedChanged);
            // 
            // real
            // 
            this.real.AutoSize = true;
            this.real.Checked = true;
            this.real.Location = new System.Drawing.Point(63, 156);
            this.real.Name = "real";
            this.real.Size = new System.Drawing.Size(240, 24);
            this.real.TabIndex = 34;
            this.real.TabStop = true;
            this.real.Text = "Вещественное представление";
            this.real.UseVisualStyleBackColor = true;
            this.real.CheckedChanged += new System.EventHandler(this.real_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Кодирование информации:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(63, 449);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(307, 20);
            this.label19.TabIndex = 37;
            this.label19.Text = "Вероятность независимого наследования:";
            // 
            // P0
            // 
            this.P0.Enabled = false;
            this.P0.Location = new System.Drawing.Point(65, 479);
            this.P0.Name = "P0";
            this.P0.Size = new System.Drawing.Size(87, 27);
            this.P0.TabIndex = 36;
            this.P0.Text = "0,5";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(63, 197);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(76, 20);
            this.label20.TabIndex = 39;
            this.label20.Text = "Точность:";
            // 
            // precision
            // 
            this.precision.Enabled = false;
            this.precision.Location = new System.Drawing.Point(145, 190);
            this.precision.Name = "precision";
            this.precision.Size = new System.Drawing.Size(87, 27);
            this.precision.TabIndex = 38;
            this.precision.Text = "0,01";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 792);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Нахождение глобального минимума функции на заданном отрезке";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private TextBox expression;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox leftBorder;
        private TextBox rightBorder;
        private TextBox n;
        private Label label6;
        private Label label7;
        private TextBox populationCapacity;
        private Label label8;
        private ComboBox selection;
        private Label label10;
        private TextBox t;
        private ComboBox CO;
        private Label label11;
        private Label label12;
        private TextBox alpha;
        private Label label13;
        private TextBox lambda;
        private Label label14;
        private TextBox P;
        private Label label15;
        private TextBox Pm;
        private Label label16;
        private TextBox eps;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListView listView1;
        private ColumnHeader argName;
        private ColumnHeader argValue;
        private TextBox y;
        private Label label17;
        private Button button1;
        private TextBox gap;
        private Label label18;
        private Label label9;
        private RadioButton real;
        private RadioButton bits;
        private Label label19;
        private TextBox P0;
        private Label label20;
        private TextBox precision;
    }
}