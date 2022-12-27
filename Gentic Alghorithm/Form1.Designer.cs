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
            this.n = new System.Windows.Forms.TextBox();
            this.lpopulation = new System.Windows.Forms.Label();
            this.lcapacity = new System.Windows.Forms.Label();
            this.populationCapacity = new System.Windows.Forms.TextBox();
            this.lselection = new System.Windows.Forms.Label();
            this.selection = new System.Windows.Forms.ComboBox();
            this.ltsize = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.TextBox();
            this.CO = new System.Windows.Forms.ComboBox();
            this.lcbreed = new System.Windows.Forms.Label();
            this.lalpha = new System.Windows.Forms.Label();
            this.alpha = new System.Windows.Forms.TextBox();
            this.llambda = new System.Windows.Forms.Label();
            this.lambda = new System.Windows.Forms.TextBox();
            this.lps = new System.Windows.Forms.Label();
            this.P = new System.Windows.Forms.TextBox();
            this.lpm = new System.Windows.Forms.Label();
            this.Pm = new System.Windows.Forms.TextBox();
            this.le = new System.Windows.Forms.Label();
            this.eps = new System.Windows.Forms.TextBox();
            this.algSettings = new System.Windows.Forms.GroupBox();
            this.findArgs = new System.Windows.Forms.Button();
            this.intervals = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lprecision = new System.Windows.Forms.Label();
            this.precision = new System.Windows.Forms.TextBox();
            this.lpnn = new System.Windows.Forms.Label();
            this.P0 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.real = new System.Windows.Forms.RadioButton();
            this.bits = new System.Windows.Forms.RadioButton();
            this.gap = new System.Windows.Forms.TextBox();
            this.lgap = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.beeSet = new System.Windows.Forms.GroupBox();
            this.beeb = new System.Windows.Forms.Button();
            this.bpromising = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.belite = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.promising = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.elite = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.scouts = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maxIter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rs = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.bintervals = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.bexp = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.func = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.argName = new System.Windows.Forms.ColumnHeader();
            this.argValue = new System.Windows.Forms.ColumnHeader();
            this.y = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ga = new System.Windows.Forms.RadioButton();
            this.ba = new System.Windows.Forms.RadioButton();
            this.algSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervals)).BeginInit();
            this.beeSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bintervals)).BeginInit();
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
            // n
            // 
            this.n.Location = new System.Drawing.Point(238, 396);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(87, 27);
            this.n.TabIndex = 8;
            this.n.Text = "100";
            // 
            // lpopulation
            // 
            this.lpopulation.AutoSize = true;
            this.lpopulation.Location = new System.Drawing.Point(58, 403);
            this.lpopulation.Name = "lpopulation";
            this.lpopulation.Size = new System.Drawing.Size(174, 20);
            this.lpopulation.TabIndex = 9;
            this.lpopulation.Text = "Количество популяций:";
            // 
            // lcapacity
            // 
            this.lcapacity.AutoSize = true;
            this.lcapacity.Location = new System.Drawing.Point(58, 438);
            this.lcapacity.Name = "lcapacity";
            this.lcapacity.Size = new System.Drawing.Size(158, 20);
            this.lcapacity.TabIndex = 11;
            this.lcapacity.Text = "Особей в популяции:";
            // 
            // populationCapacity
            // 
            this.populationCapacity.Location = new System.Drawing.Point(222, 431);
            this.populationCapacity.Name = "populationCapacity";
            this.populationCapacity.Size = new System.Drawing.Size(87, 27);
            this.populationCapacity.TabIndex = 10;
            this.populationCapacity.Text = "20";
            // 
            // lselection
            // 
            this.lselection.AutoSize = true;
            this.lselection.Location = new System.Drawing.Point(58, 513);
            this.lselection.Name = "lselection";
            this.lselection.Size = new System.Drawing.Size(78, 20);
            this.lselection.TabIndex = 12;
            this.lselection.Text = "Селекция:";
            // 
            // selection
            // 
            this.selection.FormattingEnabled = true;
            this.selection.Items.AddRange(new object[] {
            "Турнирный отбор"});
            this.selection.Location = new System.Drawing.Point(142, 505);
            this.selection.Name = "selection";
            this.selection.Size = new System.Drawing.Size(183, 28);
            this.selection.TabIndex = 13;
            this.selection.Text = "Турнирный отбор";
            this.selection.SelectedIndexChanged += new System.EventHandler(this.selection_SelectedIndexChanged);
            // 
            // ltsize
            // 
            this.ltsize.AutoSize = true;
            this.ltsize.Location = new System.Drawing.Point(58, 551);
            this.ltsize.Name = "ltsize";
            this.ltsize.Size = new System.Drawing.Size(124, 20);
            this.ltsize.TabIndex = 17;
            this.ltsize.Text = "Размер турнира:";
            // 
            // t
            // 
            this.t.Location = new System.Drawing.Point(188, 544);
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
            this.CO.Location = new System.Drawing.Point(172, 582);
            this.CO.Name = "CO";
            this.CO.Size = new System.Drawing.Size(256, 28);
            this.CO.TabIndex = 19;
            this.CO.Text = "2-точечный кроссинговер";
            this.CO.SelectedIndexChanged += new System.EventHandler(this.CO_SelectedIndexChanged);
            // 
            // lcbreed
            // 
            this.lcbreed.AutoSize = true;
            this.lcbreed.Location = new System.Drawing.Point(58, 590);
            this.lcbreed.Name = "lcbreed";
            this.lcbreed.Size = new System.Drawing.Size(108, 20);
            this.lcbreed.TabIndex = 18;
            this.lcbreed.Text = "Скрещивание:";
            // 
            // lalpha
            // 
            this.lalpha.AutoSize = true;
            this.lalpha.Location = new System.Drawing.Point(58, 731);
            this.lalpha.Name = "lalpha";
            this.lalpha.Size = new System.Drawing.Size(56, 20);
            this.lalpha.TabIndex = 23;
            this.lalpha.Text = "Альфа:";
            // 
            // alpha
            // 
            this.alpha.Enabled = false;
            this.alpha.Location = new System.Drawing.Point(120, 724);
            this.alpha.Name = "alpha";
            this.alpha.Size = new System.Drawing.Size(87, 27);
            this.alpha.TabIndex = 22;
            this.alpha.Text = "0,001";
            // 
            // llambda
            // 
            this.llambda.AutoSize = true;
            this.llambda.Location = new System.Drawing.Point(58, 694);
            this.llambda.Name = "llambda";
            this.llambda.Size = new System.Drawing.Size(66, 20);
            this.llambda.TabIndex = 21;
            this.llambda.Text = "Лямбда:";
            // 
            // lambda
            // 
            this.lambda.Enabled = false;
            this.lambda.Location = new System.Drawing.Point(130, 687);
            this.lambda.Name = "lambda";
            this.lambda.Size = new System.Drawing.Size(87, 27);
            this.lambda.TabIndex = 20;
            this.lambda.Text = "0,5";
            // 
            // lps
            // 
            this.lps.AutoSize = true;
            this.lps.Location = new System.Drawing.Point(58, 765);
            this.lps.Name = "lps";
            this.lps.Size = new System.Drawing.Size(198, 20);
            this.lps.TabIndex = 25;
            this.lps.Text = "Вероятность скрещивания:";
            // 
            // P
            // 
            this.P.Location = new System.Drawing.Point(262, 758);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(87, 27);
            this.P.TabIndex = 24;
            this.P.Text = "0,7";
            // 
            // lpm
            // 
            this.lpm.AutoSize = true;
            this.lpm.Location = new System.Drawing.Point(57, 803);
            this.lpm.Name = "lpm";
            this.lpm.Size = new System.Drawing.Size(163, 20);
            this.lpm.TabIndex = 27;
            this.lpm.Text = "Вероятность мутации:";
            // 
            // Pm
            // 
            this.Pm.Location = new System.Drawing.Point(226, 796);
            this.Pm.Name = "Pm";
            this.Pm.Size = new System.Drawing.Size(87, 27);
            this.Pm.TabIndex = 26;
            this.Pm.Text = "0,5";
            // 
            // le
            // 
            this.le.AutoSize = true;
            this.le.Location = new System.Drawing.Point(56, 843);
            this.le.Name = "le";
            this.le.Size = new System.Drawing.Size(72, 20);
            this.le.TabIndex = 29;
            this.le.Text = "Эпсилон:";
            // 
            // eps
            // 
            this.eps.Location = new System.Drawing.Point(134, 836);
            this.eps.Name = "eps";
            this.eps.Size = new System.Drawing.Size(87, 27);
            this.eps.TabIndex = 28;
            this.eps.Text = "0,01";
            // 
            // algSettings
            // 
            this.algSettings.Controls.Add(this.findArgs);
            this.algSettings.Controls.Add(this.intervals);
            this.algSettings.Controls.Add(this.lprecision);
            this.algSettings.Controls.Add(this.precision);
            this.algSettings.Controls.Add(this.lpnn);
            this.algSettings.Controls.Add(this.P0);
            this.algSettings.Controls.Add(this.label9);
            this.algSettings.Controls.Add(this.real);
            this.algSettings.Controls.Add(this.bits);
            this.algSettings.Controls.Add(this.gap);
            this.algSettings.Controls.Add(this.lgap);
            this.algSettings.Controls.Add(this.button1);
            this.algSettings.Controls.Add(this.label1);
            this.algSettings.Controls.Add(this.le);
            this.algSettings.Controls.Add(this.expression);
            this.algSettings.Controls.Add(this.eps);
            this.algSettings.Controls.Add(this.lpm);
            this.algSettings.Controls.Add(this.Pm);
            this.algSettings.Controls.Add(this.lps);
            this.algSettings.Controls.Add(this.P);
            this.algSettings.Controls.Add(this.lalpha);
            this.algSettings.Controls.Add(this.alpha);
            this.algSettings.Controls.Add(this.n);
            this.algSettings.Controls.Add(this.llambda);
            this.algSettings.Controls.Add(this.lpopulation);
            this.algSettings.Controls.Add(this.lambda);
            this.algSettings.Controls.Add(this.populationCapacity);
            this.algSettings.Controls.Add(this.CO);
            this.algSettings.Controls.Add(this.lcapacity);
            this.algSettings.Controls.Add(this.lcbreed);
            this.algSettings.Controls.Add(this.lselection);
            this.algSettings.Controls.Add(this.ltsize);
            this.algSettings.Controls.Add(this.selection);
            this.algSettings.Controls.Add(this.t);
            this.algSettings.Location = new System.Drawing.Point(291, 12);
            this.algSettings.Name = "algSettings";
            this.algSettings.Size = new System.Drawing.Size(548, 930);
            this.algSettings.TabIndex = 30;
            this.algSettings.TabStop = false;
            this.algSettings.Text = "Настройка алгоритма";
            // 
            // findArgs
            // 
            this.findArgs.Location = new System.Drawing.Point(59, 68);
            this.findArgs.Name = "findArgs";
            this.findArgs.Size = new System.Drawing.Size(216, 29);
            this.findArgs.TabIndex = 40;
            this.findArgs.Text = "Сосчитать переменные";
            this.findArgs.UseVisualStyleBackColor = true;
            this.findArgs.Click += new System.EventHandler(this.findArgs_Click);
            // 
            // intervals
            // 
            this.intervals.AllowUserToAddRows = false;
            this.intervals.AllowUserToDeleteRows = false;
            this.intervals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.intervals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.intervals.Location = new System.Drawing.Point(60, 109);
            this.intervals.Name = "intervals";
            this.intervals.RowHeadersWidth = 51;
            this.intervals.RowTemplate.Height = 29;
            this.intervals.Size = new System.Drawing.Size(430, 158);
            this.intervals.TabIndex = 35;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Переменная";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Левая граница";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Правая граница";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // lprecision
            // 
            this.lprecision.AutoSize = true;
            this.lprecision.Location = new System.Drawing.Point(58, 370);
            this.lprecision.Name = "lprecision";
            this.lprecision.Size = new System.Drawing.Size(76, 20);
            this.lprecision.TabIndex = 39;
            this.lprecision.Text = "Точность:";
            // 
            // precision
            // 
            this.precision.Enabled = false;
            this.precision.Location = new System.Drawing.Point(140, 363);
            this.precision.Name = "precision";
            this.precision.Size = new System.Drawing.Size(87, 27);
            this.precision.TabIndex = 38;
            this.precision.Text = "0,01";
            // 
            // lpnn
            // 
            this.lpnn.AutoSize = true;
            this.lpnn.Location = new System.Drawing.Point(58, 622);
            this.lpnn.Name = "lpnn";
            this.lpnn.Size = new System.Drawing.Size(307, 20);
            this.lpnn.TabIndex = 37;
            this.lpnn.Text = "Вероятность независимого наследования:";
            // 
            // P0
            // 
            this.P0.Enabled = false;
            this.P0.Location = new System.Drawing.Point(60, 652);
            this.P0.Name = "P0";
            this.P0.Size = new System.Drawing.Size(87, 27);
            this.P0.TabIndex = 36;
            this.P0.Text = "0,5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Кодирование информации:";
            // 
            // real
            // 
            this.real.AutoSize = true;
            this.real.Checked = true;
            this.real.Location = new System.Drawing.Point(58, 329);
            this.real.Name = "real";
            this.real.Size = new System.Drawing.Size(240, 24);
            this.real.TabIndex = 34;
            this.real.TabStop = true;
            this.real.Text = "Вещественное представление";
            this.real.UseVisualStyleBackColor = true;
            this.real.CheckedChanged += new System.EventHandler(this.real_CheckedChanged);
            // 
            // bits
            // 
            this.bits.AutoSize = true;
            this.bits.Location = new System.Drawing.Point(58, 299);
            this.bits.Name = "bits";
            this.bits.Size = new System.Drawing.Size(197, 24);
            this.bits.TabIndex = 33;
            this.bits.Text = "Битовое представление";
            this.bits.UseVisualStyleBackColor = true;
            this.bits.CheckedChanged += new System.EventHandler(this.bits_CheckedChanged);
            // 
            // gap
            // 
            this.gap.Location = new System.Drawing.Point(208, 466);
            this.gap.Name = "gap";
            this.gap.Size = new System.Drawing.Size(87, 27);
            this.gap.TabIndex = 31;
            this.gap.Text = "1";
            // 
            // lgap
            // 
            this.lgap.AutoSize = true;
            this.lgap.Location = new System.Drawing.Point(58, 473);
            this.lgap.Name = "lgap";
            this.lgap.Size = new System.Drawing.Size(144, 20);
            this.lgap.TabIndex = 32;
            this.lgap.Text = "Разрыв поколений:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 880);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 30;
            this.button1.Text = "Запустить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // beeSet
            // 
            this.beeSet.Controls.Add(this.beeb);
            this.beeSet.Controls.Add(this.bpromising);
            this.beeSet.Controls.Add(this.label10);
            this.beeSet.Controls.Add(this.belite);
            this.beeSet.Controls.Add(this.label8);
            this.beeSet.Controls.Add(this.promising);
            this.beeSet.Controls.Add(this.label5);
            this.beeSet.Controls.Add(this.elite);
            this.beeSet.Controls.Add(this.label7);
            this.beeSet.Controls.Add(this.scouts);
            this.beeSet.Controls.Add(this.label4);
            this.beeSet.Controls.Add(this.maxIter);
            this.beeSet.Controls.Add(this.label3);
            this.beeSet.Controls.Add(this.rs);
            this.beeSet.Controls.Add(this.label2);
            this.beeSet.Controls.Add(this.button2);
            this.beeSet.Controls.Add(this.bintervals);
            this.beeSet.Controls.Add(this.label6);
            this.beeSet.Controls.Add(this.bexp);
            this.beeSet.Location = new System.Drawing.Point(263, 12);
            this.beeSet.Name = "beeSet";
            this.beeSet.Size = new System.Drawing.Size(576, 930);
            this.beeSet.TabIndex = 35;
            this.beeSet.TabStop = false;
            this.beeSet.Text = "Настройка алгоритма";
            // 
            // beeb
            // 
            this.beeb.Location = new System.Drawing.Point(231, 723);
            this.beeb.Name = "beeb";
            this.beeb.Size = new System.Drawing.Size(94, 29);
            this.beeb.TabIndex = 55;
            this.beeb.Text = "Запустить";
            this.beeb.UseVisualStyleBackColor = true;
            this.beeb.Click += new System.EventHandler(this.beeb_Click);
            // 
            // bpromising
            // 
            this.bpromising.Location = new System.Drawing.Point(308, 667);
            this.bpromising.Name = "bpromising";
            this.bpromising.Size = new System.Drawing.Size(72, 27);
            this.bpromising.TabIndex = 54;
            this.bpromising.Text = "6";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(61, 674);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(241, 20);
            this.label10.TabIndex = 53;
            this.label10.Text = "Пчел на перспективных участках:";
            // 
            // belite
            // 
            this.belite.Location = new System.Drawing.Point(257, 629);
            this.belite.Name = "belite";
            this.belite.Size = new System.Drawing.Size(72, 27);
            this.belite.TabIndex = 52;
            this.belite.Text = "10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 636);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 20);
            this.label8.TabIndex = 51;
            this.label8.Text = "Пчел на элитных участках:";
            // 
            // promising
            // 
            this.promising.Location = new System.Drawing.Point(335, 591);
            this.promising.Name = "promising";
            this.promising.Size = new System.Drawing.Size(72, 27);
            this.promising.TabIndex = 50;
            this.promising.Text = "3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 598);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(268, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "Количество перспективных участков:";
            // 
            // elite
            // 
            this.elite.Location = new System.Drawing.Point(285, 552);
            this.elite.Name = "elite";
            this.elite.Size = new System.Drawing.Size(72, 27);
            this.elite.TabIndex = 48;
            this.elite.Text = "2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 559);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "Количество элитных участков:";
            // 
            // scouts
            // 
            this.scouts.Location = new System.Drawing.Point(252, 514);
            this.scouts.Name = "scouts";
            this.scouts.Size = new System.Drawing.Size(72, 27);
            this.scouts.TabIndex = 46;
            this.scouts.Text = "20";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 521);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Количество разведчиков:";
            // 
            // maxIter
            // 
            this.maxIter.Location = new System.Drawing.Point(232, 476);
            this.maxIter.Name = "maxIter";
            this.maxIter.Size = new System.Drawing.Size(72, 27);
            this.maxIter.TabIndex = 44;
            this.maxIter.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 483);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Макс. число итераций:";
            // 
            // rs
            // 
            this.rs.AllowUserToAddRows = false;
            this.rs.AllowUserToDeleteRows = false;
            this.rs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.rs.Location = new System.Drawing.Point(60, 312);
            this.rs.Name = "rs";
            this.rs.RowHeadersWidth = 51;
            this.rs.RowTemplate.Height = 29;
            this.rs.Size = new System.Drawing.Size(430, 158);
            this.rs.TabIndex = 42;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Переменная";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Элитный участок";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Перспективный участок";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Радиусы участков:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(59, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 29);
            this.button2.TabIndex = 40;
            this.button2.Text = "Сосчитать переменные";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bintervals
            // 
            this.bintervals.AllowUserToAddRows = false;
            this.bintervals.AllowUserToDeleteRows = false;
            this.bintervals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bintervals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.bintervals.Location = new System.Drawing.Point(60, 109);
            this.bintervals.Name = "bintervals";
            this.bintervals.RowHeadersWidth = 51;
            this.bintervals.RowTemplate.Height = 29;
            this.bintervals.Size = new System.Drawing.Size(430, 158);
            this.bintervals.TabIndex = 35;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Переменная";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Левая граница";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Правая граница";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Функция:";
            // 
            // bexp
            // 
            this.bexp.Location = new System.Drawing.Point(138, 25);
            this.bexp.Name = "bexp";
            this.bexp.Size = new System.Drawing.Size(243, 27);
            this.bexp.TabIndex = 1;
            this.bexp.Text = "x1^2+3*x2^2+2*x1*x2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.func);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Controls.Add(this.y);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Location = new System.Drawing.Point(866, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 930);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Найденные значения";
            // 
            // func
            // 
            this.func.Enabled = false;
            this.func.Location = new System.Drawing.Point(260, 240);
            this.func.Name = "func";
            this.func.Size = new System.Drawing.Size(100, 27);
            this.func.TabIndex = 34;
            this.func.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(28, 247);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(226, 20);
            this.label21.TabIndex = 33;
            this.label21.Text = "Вычислений целевой функции:";
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(236, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "Выбор алгоритма оптимизации:";
            // 
            // ga
            // 
            this.ga.AutoSize = true;
            this.ga.Checked = true;
            this.ga.Location = new System.Drawing.Point(12, 57);
            this.ga.Name = "ga";
            this.ga.Size = new System.Drawing.Size(195, 24);
            this.ga.TabIndex = 33;
            this.ga.TabStop = true;
            this.ga.Text = "Генетический алгоритм";
            this.ga.UseVisualStyleBackColor = true;
            this.ga.CheckedChanged += new System.EventHandler(this.ga_CheckedChanged);
            // 
            // ba
            // 
            this.ba.AutoSize = true;
            this.ba.Location = new System.Drawing.Point(12, 87);
            this.ba.Name = "ba";
            this.ba.Size = new System.Drawing.Size(173, 24);
            this.ba.TabIndex = 34;
            this.ba.Text = "Пчелиный алгоритм";
            this.ba.UseVisualStyleBackColor = true;
            this.ba.CheckedChanged += new System.EventHandler(this.ba_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 954);
            this.Controls.Add(this.beeSet);
            this.Controls.Add(this.ba);
            this.Controls.Add(this.ga);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.algSettings);
            this.Name = "Form1";
            this.Text = "Нахождение глобального минимума функции на заданном отрезке";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.algSettings.ResumeLayout(false);
            this.algSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervals)).EndInit();
            this.beeSet.ResumeLayout(false);
            this.beeSet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bintervals)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox expression;
        private TextBox n;
        private Label lpopulation;
        private Label lcapacity;
        private TextBox populationCapacity;
        private Label lselection;
        private ComboBox selection;
        private Label ltsize;
        private TextBox t;
        private ComboBox CO;
        private Label lcbreed;
        private Label lalpha;
        private TextBox alpha;
        private Label llambda;
        private TextBox lambda;
        private Label lps;
        private TextBox P;
        private Label lpm;
        private TextBox Pm;
        private Label le;
        private TextBox eps;
        private GroupBox algSettings;
        private GroupBox groupBox2;
        private ListView listView1;
        private ColumnHeader argName;
        private ColumnHeader argValue;
        private TextBox y;
        private Label label17;
        private Button button1;
        private TextBox gap;
        private Label lgap;
        private Label label9;
        private RadioButton real;
        private RadioButton bits;
        private Label lpnn;
        private TextBox P0;
        private Label lprecision;
        private TextBox precision;
        private TextBox func;
        private Label label21;
        private Button findArgs;
        private DataGridView intervals;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private GroupBox beeSet;
        private DataGridView rs;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private Label label2;
        private Button button2;
        private DataGridView bintervals;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Label label6;
        private TextBox bexp;
        private TextBox maxIter;
        private Label label3;
        private TextBox promising;
        private Label label5;
        private TextBox elite;
        private Label label7;
        private TextBox scouts;
        private Label label4;
        private TextBox bpromising;
        private Label label10;
        private TextBox belite;
        private Label label8;
        private Button beeb;
        private Label label11;
        private RadioButton ga;
        private RadioButton ba;
    }
}