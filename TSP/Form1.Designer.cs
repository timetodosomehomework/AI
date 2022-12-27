namespace TSP
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ants = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.eants = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.alpha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.beta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.phe = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pevap = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.length = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iter = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ant = new System.Windows.Forms.RadioButton();
            this.sa = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.antsSet = new System.Windows.Forms.GroupBox();
            this.saSet = new System.Windows.Forms.GroupBox();
            this.alp = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.initT = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.saMaxIter = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.antsSet.SuspendLayout();
            this.saSet.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(232, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(649, 383);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_DefaultValuesNeeded);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество городов:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(393, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(53, 27);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ants
            // 
            this.ants.Location = new System.Drawing.Point(207, 29);
            this.ants.Name = "ants";
            this.ants.Size = new System.Drawing.Size(53, 27);
            this.ants.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Количество муравьев:";
            // 
            // eants
            // 
            this.eants.Location = new System.Drawing.Point(268, 68);
            this.eants.Name = "eants";
            this.eants.Size = new System.Drawing.Size(53, 27);
            this.eants.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Количество элитных муравьев:";
            // 
            // alpha
            // 
            this.alpha.Location = new System.Drawing.Point(123, 107);
            this.alpha.Name = "alpha";
            this.alpha.Size = new System.Drawing.Size(53, 27);
            this.alpha.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Жадность:";
            // 
            // beta
            // 
            this.beta.Location = new System.Drawing.Point(125, 145);
            this.beta.Name = "beta";
            this.beta.Size = new System.Drawing.Size(53, 27);
            this.beta.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Стадность:";
            // 
            // phe
            // 
            this.phe.Location = new System.Drawing.Point(582, 29);
            this.phe.Name = "phe";
            this.phe.Size = new System.Drawing.Size(53, 27);
            this.phe.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(409, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Выделение феромона:";
            // 
            // pevap
            // 
            this.pevap.Location = new System.Drawing.Point(582, 68);
            this.pevap.Name = "pevap";
            this.pevap.Size = new System.Drawing.Size(53, 27);
            this.pevap.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(409, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Испарение феромона:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 680);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 16;
            this.button1.Text = "Запустить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.length);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.path);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(905, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 436);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Результат";
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(112, 199);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(118, 27);
            this.length.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Длина пути:";
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(6, 71);
            this.path.Multiline = true;
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(323, 113);
            this.path.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Найденный путь:";
            // 
            // iter
            // 
            this.iter.Location = new System.Drawing.Point(536, 107);
            this.iter.Name = "iter";
            this.iter.Size = new System.Drawing.Size(53, 27);
            this.iter.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(409, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Макс. итераций:";
            // 
            // ant
            // 
            this.ant.AutoSize = true;
            this.ant.Checked = true;
            this.ant.Location = new System.Drawing.Point(12, 65);
            this.ant.Name = "ant";
            this.ant.Size = new System.Drawing.Size(121, 24);
            this.ant.TabIndex = 20;
            this.ant.TabStop = true;
            this.ant.Text = "Муравьиный";
            this.ant.UseVisualStyleBackColor = true;
            this.ant.CheckedChanged += new System.EventHandler(this.ant_CheckedChanged);
            // 
            // sa
            // 
            this.sa.AutoSize = true;
            this.sa.Location = new System.Drawing.Point(12, 95);
            this.sa.Name = "sa";
            this.sa.Size = new System.Drawing.Size(155, 24);
            this.sa.TabIndex = 21;
            this.sa.Text = "Имитации отжига";
            this.sa.UseVisualStyleBackColor = true;
            this.sa.CheckedChanged += new System.EventHandler(this.sa_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Алгоритм:";
            // 
            // antsSet
            // 
            this.antsSet.Controls.Add(this.label3);
            this.antsSet.Controls.Add(this.ants);
            this.antsSet.Controls.Add(this.label4);
            this.antsSet.Controls.Add(this.eants);
            this.antsSet.Controls.Add(this.iter);
            this.antsSet.Controls.Add(this.label5);
            this.antsSet.Controls.Add(this.label10);
            this.antsSet.Controls.Add(this.alpha);
            this.antsSet.Controls.Add(this.label6);
            this.antsSet.Controls.Add(this.beta);
            this.antsSet.Controls.Add(this.pevap);
            this.antsSet.Controls.Add(this.label7);
            this.antsSet.Controls.Add(this.label8);
            this.antsSet.Controls.Add(this.phe);
            this.antsSet.Location = new System.Drawing.Point(232, 465);
            this.antsSet.Name = "antsSet";
            this.antsSet.Size = new System.Drawing.Size(649, 188);
            this.antsSet.TabIndex = 23;
            this.antsSet.TabStop = false;
            this.antsSet.Text = "Настройки муравьиного алгоритма";
            // 
            // saSet
            // 
            this.saSet.Controls.Add(this.alp);
            this.saSet.Controls.Add(this.label14);
            this.saSet.Controls.Add(this.initT);
            this.saSet.Controls.Add(this.label13);
            this.saSet.Controls.Add(this.saMaxIter);
            this.saSet.Controls.Add(this.label12);
            this.saSet.Location = new System.Drawing.Point(232, 465);
            this.saSet.Name = "saSet";
            this.saSet.Size = new System.Drawing.Size(649, 209);
            this.saSet.TabIndex = 24;
            this.saSet.TabStop = false;
            this.saSet.Text = "Настройки алгоритма имитации отжига";
            // 
            // alp
            // 
            this.alp.Location = new System.Drawing.Point(314, 134);
            this.alp.Name = "alp";
            this.alp.Size = new System.Drawing.Size(53, 27);
            this.alp.TabIndex = 9;
            this.alp.Text = "0,9";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(288, 20);
            this.label14.TabIndex = 8;
            this.label14.Text = "Коэффициент понижения температуры:";
            // 
            // initT
            // 
            this.initT.Location = new System.Drawing.Point(207, 81);
            this.initT.Name = "initT";
            this.initT.Size = new System.Drawing.Size(53, 27);
            this.initT.TabIndex = 7;
            this.initT.Text = "1000";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(181, 20);
            this.label13.TabIndex = 6;
            this.label13.Text = "Начальная температура:";
            // 
            // saMaxIter
            // 
            this.saMaxIter.Location = new System.Drawing.Point(148, 29);
            this.saMaxIter.Name = "saMaxIter";
            this.saMaxIter.Size = new System.Drawing.Size(53, 27);
            this.saMaxIter.TabIndex = 5;
            this.saMaxIter.Text = "100";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Макс. итераций:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 721);
            this.Controls.Add(this.saSet);
            this.Controls.Add(this.antsSet);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.sa);
            this.Controls.Add(this.ant);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Решение задачи коммивояжера";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.antsSet.ResumeLayout(false);
            this.antsSet.PerformLayout();
            this.saSet.ResumeLayout(false);
            this.saSet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox textBox1;
        private TextBox ants;
        private Label label3;
        private TextBox eants;
        private Label label4;
        private TextBox alpha;
        private Label label5;
        private TextBox beta;
        private Label label6;
        private TextBox phe;
        private Label label7;
        private TextBox pevap;
        private Label label8;
        private Button button1;
        private GroupBox groupBox1;
        private TextBox length;
        private Label label9;
        private TextBox path;
        private Label label1;
        private TextBox iter;
        private Label label10;
        private RadioButton ant;
        private RadioButton sa;
        private Label label11;
        private GroupBox antsSet;
        private GroupBox saSet;
        private TextBox saMaxIter;
        private Label label12;
        private TextBox alp;
        private Label label14;
        private TextBox initT;
        private Label label13;
    }
}