namespace Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bt_soma = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.TextBox();
            this.bt_subtrai = new System.Windows.Forms.Button();
            this.bt_multiplica = new System.Windows.Forms.Button();
            this.bt_divide = new System.Windows.Forms.Button();
            this.bt_umporx = new System.Windows.Forms.Button();
            this.bt_potencia = new System.Windows.Forms.Button();
            this.bt_0 = new System.Windows.Forms.Button();
            this.bt_1 = new System.Windows.Forms.Button();
            this.bt_2 = new System.Windows.Forms.Button();
            this.bt_3 = new System.Windows.Forms.Button();
            this.bt_4 = new System.Windows.Forms.Button();
            this.bt_5 = new System.Windows.Forms.Button();
            this.bt_6 = new System.Windows.Forms.Button();
            this.bt_7 = new System.Windows.Forms.Button();
            this.bt_8 = new System.Windows.Forms.Button();
            this.bt_9 = new System.Windows.Forms.Button();
            this.bt_porcento = new System.Windows.Forms.Button();
            this.bt_virgula = new System.Windows.Forms.Button();
            this.bt_invertesinal = new System.Windows.Forms.Button();
            this.bt_ce = new System.Windows.Forms.Button();
            this.bt_c = new System.Windows.Forms.Button();
            this.bt_menosum = new System.Windows.Forms.Button();
            this.bt_raiz = new System.Windows.Forms.Button();
            this.bt_resultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_soma
            // 
            this.bt_soma.BackColor = System.Drawing.Color.DarkMagenta;
            this.bt_soma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_soma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_soma.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_soma.ForeColor = System.Drawing.Color.Plum;
            this.bt_soma.Location = new System.Drawing.Point(462, 374);
            this.bt_soma.Name = "bt_soma";
            this.bt_soma.Size = new System.Drawing.Size(52, 52);
            this.bt_soma.TabIndex = 11;
            this.bt_soma.Text = "+";
            this.bt_soma.UseVisualStyleBackColor = false;
            this.bt_soma.Click += new System.EventHandler(this.bt_soma_Click);
            // 
            // txt
            // 
            this.txt.BackColor = System.Drawing.Color.LightPink;
            this.txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt.ForeColor = System.Drawing.Color.Purple;
            this.txt.Location = new System.Drawing.Point(288, 60);
            this.txt.Multiline = true;
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(226, 64);
            this.txt.TabIndex = 0;
            this.txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // bt_subtrai
            // 
            this.bt_subtrai.BackColor = System.Drawing.Color.DarkMagenta;
            this.bt_subtrai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_subtrai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_subtrai.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_subtrai.ForeColor = System.Drawing.Color.Plum;
            this.bt_subtrai.Location = new System.Drawing.Point(462, 316);
            this.bt_subtrai.Name = "bt_subtrai";
            this.bt_subtrai.Size = new System.Drawing.Size(52, 52);
            this.bt_subtrai.TabIndex = 12;
            this.bt_subtrai.Text = "-";
            this.bt_subtrai.UseVisualStyleBackColor = false;
            this.bt_subtrai.Click += new System.EventHandler(this.bt_subtrai_Click);
            // 
            // bt_multiplica
            // 
            this.bt_multiplica.BackColor = System.Drawing.Color.DarkMagenta;
            this.bt_multiplica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_multiplica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_multiplica.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_multiplica.ForeColor = System.Drawing.Color.Plum;
            this.bt_multiplica.Location = new System.Drawing.Point(462, 258);
            this.bt_multiplica.Name = "bt_multiplica";
            this.bt_multiplica.Size = new System.Drawing.Size(52, 52);
            this.bt_multiplica.TabIndex = 13;
            this.bt_multiplica.Text = "x";
            this.bt_multiplica.UseVisualStyleBackColor = false;
            this.bt_multiplica.Click += new System.EventHandler(this.bt_multiplica_Click);
            // 
            // bt_divide
            // 
            this.bt_divide.BackColor = System.Drawing.Color.DarkMagenta;
            this.bt_divide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_divide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_divide.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_divide.ForeColor = System.Drawing.Color.Plum;
            this.bt_divide.Location = new System.Drawing.Point(462, 200);
            this.bt_divide.Name = "bt_divide";
            this.bt_divide.Size = new System.Drawing.Size(52, 52);
            this.bt_divide.TabIndex = 14;
            this.bt_divide.Text = " /";
            this.bt_divide.UseVisualStyleBackColor = false;
            this.bt_divide.Click += new System.EventHandler(this.bt_divide_Click);
            // 
            // bt_umporx
            // 
            this.bt_umporx.BackColor = System.Drawing.Color.DarkMagenta;
            this.bt_umporx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_umporx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_umporx.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_umporx.ForeColor = System.Drawing.Color.Plum;
            this.bt_umporx.Location = new System.Drawing.Point(288, 200);
            this.bt_umporx.Name = "bt_umporx";
            this.bt_umporx.Size = new System.Drawing.Size(52, 52);
            this.bt_umporx.TabIndex = 17;
            this.bt_umporx.Text = "1/x";
            this.bt_umporx.UseVisualStyleBackColor = false;
            this.bt_umporx.Click += new System.EventHandler(this.bt_umporx_Click);
            // 
            // bt_potencia
            // 
            this.bt_potencia.BackColor = System.Drawing.Color.DarkMagenta;
            this.bt_potencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_potencia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_potencia.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_potencia.ForeColor = System.Drawing.Color.Plum;
            this.bt_potencia.Location = new System.Drawing.Point(346, 200);
            this.bt_potencia.Name = "bt_potencia";
            this.bt_potencia.Size = new System.Drawing.Size(52, 52);
            this.bt_potencia.TabIndex = 16;
            this.bt_potencia.Text = "^";
            this.bt_potencia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_potencia.UseVisualStyleBackColor = false;
            this.bt_potencia.Click += new System.EventHandler(this.bt_potencia_Click);
            // 
            // bt_0
            // 
            this.bt_0.BackColor = System.Drawing.Color.Violet;
            this.bt_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_0.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_0.ForeColor = System.Drawing.Color.Purple;
            this.bt_0.Location = new System.Drawing.Point(346, 432);
            this.bt_0.Name = "bt_0";
            this.bt_0.Size = new System.Drawing.Size(52, 52);
            this.bt_0.TabIndex = 1;
            this.bt_0.Text = " 0";
            this.bt_0.UseVisualStyleBackColor = false;
            this.bt_0.Click += new System.EventHandler(this.bt_0_Click);
            // 
            // bt_1
            // 
            this.bt_1.BackColor = System.Drawing.Color.Violet;
            this.bt_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_1.ForeColor = System.Drawing.Color.Purple;
            this.bt_1.Location = new System.Drawing.Point(288, 374);
            this.bt_1.Name = "bt_1";
            this.bt_1.Size = new System.Drawing.Size(52, 52);
            this.bt_1.TabIndex = 2;
            this.bt_1.Text = " 1";
            this.bt_1.UseVisualStyleBackColor = false;
            this.bt_1.Click += new System.EventHandler(this.bt_1_Click);
            // 
            // bt_2
            // 
            this.bt_2.BackColor = System.Drawing.Color.Violet;
            this.bt_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_2.ForeColor = System.Drawing.Color.Purple;
            this.bt_2.Location = new System.Drawing.Point(346, 374);
            this.bt_2.Name = "bt_2";
            this.bt_2.Size = new System.Drawing.Size(52, 52);
            this.bt_2.TabIndex = 3;
            this.bt_2.Text = "2";
            this.bt_2.UseVisualStyleBackColor = false;
            this.bt_2.Click += new System.EventHandler(this.bt_2_Click);
            // 
            // bt_3
            // 
            this.bt_3.BackColor = System.Drawing.Color.Violet;
            this.bt_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_3.ForeColor = System.Drawing.Color.Purple;
            this.bt_3.Location = new System.Drawing.Point(404, 374);
            this.bt_3.Name = "bt_3";
            this.bt_3.Size = new System.Drawing.Size(52, 52);
            this.bt_3.TabIndex = 4;
            this.bt_3.Text = "3";
            this.bt_3.UseVisualStyleBackColor = false;
            this.bt_3.Click += new System.EventHandler(this.bt_3_Click);
            // 
            // bt_4
            // 
            this.bt_4.BackColor = System.Drawing.Color.Violet;
            this.bt_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_4.ForeColor = System.Drawing.Color.Purple;
            this.bt_4.Location = new System.Drawing.Point(288, 316);
            this.bt_4.Name = "bt_4";
            this.bt_4.Size = new System.Drawing.Size(52, 52);
            this.bt_4.TabIndex = 5;
            this.bt_4.Text = "4";
            this.bt_4.UseVisualStyleBackColor = false;
            this.bt_4.Click += new System.EventHandler(this.bt_4_Click);
            // 
            // bt_5
            // 
            this.bt_5.BackColor = System.Drawing.Color.Violet;
            this.bt_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_5.ForeColor = System.Drawing.Color.Purple;
            this.bt_5.Location = new System.Drawing.Point(346, 316);
            this.bt_5.Name = "bt_5";
            this.bt_5.Size = new System.Drawing.Size(52, 52);
            this.bt_5.TabIndex = 6;
            this.bt_5.Text = "5";
            this.bt_5.UseVisualStyleBackColor = false;
            this.bt_5.Click += new System.EventHandler(this.bt_5_Click);
            // 
            // bt_6
            // 
            this.bt_6.BackColor = System.Drawing.Color.Violet;
            this.bt_6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_6.ForeColor = System.Drawing.Color.Purple;
            this.bt_6.Location = new System.Drawing.Point(404, 316);
            this.bt_6.Name = "bt_6";
            this.bt_6.Size = new System.Drawing.Size(52, 52);
            this.bt_6.TabIndex = 7;
            this.bt_6.Text = "6";
            this.bt_6.UseVisualStyleBackColor = false;
            this.bt_6.Click += new System.EventHandler(this.bt_6_Click);
            // 
            // bt_7
            // 
            this.bt_7.BackColor = System.Drawing.Color.Violet;
            this.bt_7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_7.ForeColor = System.Drawing.Color.Purple;
            this.bt_7.Location = new System.Drawing.Point(288, 258);
            this.bt_7.Name = "bt_7";
            this.bt_7.Size = new System.Drawing.Size(52, 52);
            this.bt_7.TabIndex = 8;
            this.bt_7.Text = "7";
            this.bt_7.UseVisualStyleBackColor = false;
            this.bt_7.Click += new System.EventHandler(this.bt_7_Click);
            // 
            // bt_8
            // 
            this.bt_8.BackColor = System.Drawing.Color.Violet;
            this.bt_8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_8.ForeColor = System.Drawing.Color.Purple;
            this.bt_8.Location = new System.Drawing.Point(346, 258);
            this.bt_8.Name = "bt_8";
            this.bt_8.Size = new System.Drawing.Size(52, 52);
            this.bt_8.TabIndex = 9;
            this.bt_8.Text = "8";
            this.bt_8.UseVisualStyleBackColor = false;
            this.bt_8.Click += new System.EventHandler(this.bt_8_Click);
            // 
            // bt_9
            // 
            this.bt_9.BackColor = System.Drawing.Color.Violet;
            this.bt_9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_9.ForeColor = System.Drawing.Color.Purple;
            this.bt_9.Location = new System.Drawing.Point(404, 258);
            this.bt_9.Name = "bt_9";
            this.bt_9.Size = new System.Drawing.Size(52, 52);
            this.bt_9.TabIndex = 10;
            this.bt_9.Text = "9";
            this.bt_9.UseVisualStyleBackColor = false;
            this.bt_9.Click += new System.EventHandler(this.bt_9_Click);
            // 
            // bt_porcento
            // 
            this.bt_porcento.BackColor = System.Drawing.Color.DarkMagenta;
            this.bt_porcento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_porcento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_porcento.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_porcento.ForeColor = System.Drawing.Color.Plum;
            this.bt_porcento.Location = new System.Drawing.Point(288, 142);
            this.bt_porcento.Name = "bt_porcento";
            this.bt_porcento.Size = new System.Drawing.Size(52, 52);
            this.bt_porcento.TabIndex = 21;
            this.bt_porcento.Text = "%";
            this.bt_porcento.UseVisualStyleBackColor = false;
            this.bt_porcento.Click += new System.EventHandler(this.bt_porcento_Click);
            // 
            // bt_virgula
            // 
            this.bt_virgula.BackColor = System.Drawing.Color.Violet;
            this.bt_virgula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_virgula.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_virgula.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_virgula.ForeColor = System.Drawing.Color.Purple;
            this.bt_virgula.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_virgula.Location = new System.Drawing.Point(404, 432);
            this.bt_virgula.Name = "bt_virgula";
            this.bt_virgula.Size = new System.Drawing.Size(52, 52);
            this.bt_virgula.TabIndex = 23;
            this.bt_virgula.Text = ",";
            this.bt_virgula.UseVisualStyleBackColor = false;
            this.bt_virgula.Click += new System.EventHandler(this.bt_virgula_Click);
            // 
            // bt_invertesinal
            // 
            this.bt_invertesinal.BackColor = System.Drawing.Color.Violet;
            this.bt_invertesinal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_invertesinal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_invertesinal.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_invertesinal.ForeColor = System.Drawing.Color.Purple;
            this.bt_invertesinal.Location = new System.Drawing.Point(288, 432);
            this.bt_invertesinal.Name = "bt_invertesinal";
            this.bt_invertesinal.Size = new System.Drawing.Size(52, 52);
            this.bt_invertesinal.TabIndex = 22;
            this.bt_invertesinal.Text = " +/-";
            this.bt_invertesinal.UseVisualStyleBackColor = false;
            this.bt_invertesinal.Click += new System.EventHandler(this.bt_invertesinal_Click);
            // 
            // bt_ce
            // 
            this.bt_ce.BackColor = System.Drawing.Color.DarkMagenta;
            this.bt_ce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_ce.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_ce.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_ce.ForeColor = System.Drawing.Color.Plum;
            this.bt_ce.Location = new System.Drawing.Point(346, 142);
            this.bt_ce.Name = "bt_ce";
            this.bt_ce.Size = new System.Drawing.Size(52, 52);
            this.bt_ce.TabIndex = 20;
            this.bt_ce.Text = "CE";
            this.bt_ce.UseVisualStyleBackColor = false;
            this.bt_ce.Click += new System.EventHandler(this.bt_ce_Click);
            // 
            // bt_c
            // 
            this.bt_c.BackColor = System.Drawing.Color.DarkMagenta;
            this.bt_c.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_c.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_c.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_c.ForeColor = System.Drawing.Color.Plum;
            this.bt_c.Location = new System.Drawing.Point(404, 142);
            this.bt_c.Name = "bt_c";
            this.bt_c.Size = new System.Drawing.Size(52, 52);
            this.bt_c.TabIndex = 19;
            this.bt_c.Text = "C";
            this.bt_c.UseVisualStyleBackColor = false;
            this.bt_c.Click += new System.EventHandler(this.bt_c_Click);
            // 
            // bt_menosum
            // 
            this.bt_menosum.BackColor = System.Drawing.Color.DarkMagenta;
            this.bt_menosum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_menosum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_menosum.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_menosum.ForeColor = System.Drawing.Color.Plum;
            this.bt_menosum.Image = ((System.Drawing.Image)(resources.GetObject("bt_menosum.Image")));
            this.bt_menosum.Location = new System.Drawing.Point(462, 142);
            this.bt_menosum.Name = "bt_menosum";
            this.bt_menosum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_menosum.Size = new System.Drawing.Size(52, 52);
            this.bt_menosum.TabIndex = 18;
            this.bt_menosum.UseVisualStyleBackColor = false;
            this.bt_menosum.Click += new System.EventHandler(this.bt_menosum_Click);
            // 
            // bt_raiz
            // 
            this.bt_raiz.BackColor = System.Drawing.Color.DarkMagenta;
            this.bt_raiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_raiz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_raiz.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_raiz.ForeColor = System.Drawing.Color.Plum;
            this.bt_raiz.Location = new System.Drawing.Point(404, 200);
            this.bt_raiz.Name = "bt_raiz";
            this.bt_raiz.Size = new System.Drawing.Size(52, 52);
            this.bt_raiz.TabIndex = 15;
            this.bt_raiz.Text = "√";
            this.bt_raiz.UseVisualStyleBackColor = false;
            this.bt_raiz.Click += new System.EventHandler(this.bt_raiz_Click);
            // 
            // bt_resultado
            // 
            this.bt_resultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bt_resultado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_resultado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_resultado.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_resultado.ForeColor = System.Drawing.Color.Thistle;
            this.bt_resultado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_resultado.Location = new System.Drawing.Point(462, 432);
            this.bt_resultado.Name = "bt_resultado";
            this.bt_resultado.Size = new System.Drawing.Size(52, 52);
            this.bt_resultado.TabIndex = 24;
            this.bt_resultado.Text = "=";
            this.bt_resultado.UseVisualStyleBackColor = false;
            this.bt_resultado.Click += new System.EventHandler(this.bt_resultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(828, 556);
            this.Controls.Add(this.bt_resultado);
            this.Controls.Add(this.bt_ce);
            this.Controls.Add(this.bt_c);
            this.Controls.Add(this.bt_menosum);
            this.Controls.Add(this.bt_raiz);
            this.Controls.Add(this.bt_invertesinal);
            this.Controls.Add(this.bt_virgula);
            this.Controls.Add(this.bt_porcento);
            this.Controls.Add(this.bt_9);
            this.Controls.Add(this.bt_8);
            this.Controls.Add(this.bt_7);
            this.Controls.Add(this.bt_6);
            this.Controls.Add(this.bt_5);
            this.Controls.Add(this.bt_4);
            this.Controls.Add(this.bt_3);
            this.Controls.Add(this.bt_2);
            this.Controls.Add(this.bt_1);
            this.Controls.Add(this.bt_0);
            this.Controls.Add(this.bt_potencia);
            this.Controls.Add(this.bt_umporx);
            this.Controls.Add(this.bt_divide);
            this.Controls.Add(this.bt_multiplica);
            this.Controls.Add(this.bt_subtrai);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.bt_soma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bt_soma;
        private TextBox txt;
        private Button bt_subtrai;
        private Button bt_multiplica;
        private Button bt_divide;
        private Button bt_umporx;
        private Button bt_potencia;
        private Button bt_0;
        private Button bt_1;
        private Button bt_2;
        private Button bt_3;
        private Button bt_4;
        private Button bt_5;
        private Button bt_6;
        private Button bt_7;
        private Button bt_8;
        private Button bt_9;
        private Button bt_porcento;
        private Button bt_virgula;
        private Button bt_invertesinal;
        private Button bt_ce;
        private Button bt_c;
        private Button bt_menosum;
        private Button bt_raiz;
        private Button bt_resultado;
    }
}