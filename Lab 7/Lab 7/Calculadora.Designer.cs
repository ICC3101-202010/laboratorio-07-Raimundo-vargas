﻿namespace Lab_7
{
    partial class Calculadora
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.dply = new System.Windows.Forms.TextBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btndivision = new System.Windows.Forms.Button();
            this.btncoma = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnmultiplicar = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnborrar1 = new System.Windows.Forms.Button();
            this.btnsuma = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            this.btnigual = new System.Windows.Forms.Button();
            this.btnhistorial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dply
            // 
            this.dply.Location = new System.Drawing.Point(12, 21);
            this.dply.Name = "dply";
            this.dply.ReadOnly = true;
            this.dply.Size = new System.Drawing.Size(290, 22);
            this.dply.TabIndex = 0;
            this.dply.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dply.TextChanged += new System.EventHandler(this.dply_TextChanged);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(242, 143);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(60, 54);
            this.btnlimpiar.TabIndex = 1;
            this.btnlimpiar.Text = "AC";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(12, 143);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(60, 54);
            this.btn7.TabIndex = 2;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 216);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(60, 54);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 290);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(60, 54);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(12, 366);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(60, 54);
            this.btn0.TabIndex = 5;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(87, 290);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(60, 54);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(87, 216);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(60, 54);
            this.btn5.TabIndex = 8;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(87, 143);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(60, 54);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btndivision
            // 
            this.btndivision.Location = new System.Drawing.Point(242, 72);
            this.btndivision.Name = "btndivision";
            this.btndivision.Size = new System.Drawing.Size(60, 54);
            this.btndivision.TabIndex = 6;
            this.btndivision.Text = "/";
            this.btndivision.UseVisualStyleBackColor = true;
            this.btndivision.Click += new System.EventHandler(this.btndivision_Click);
            // 
            // btncoma
            // 
            this.btncoma.Location = new System.Drawing.Point(165, 366);
            this.btncoma.Name = "btncoma";
            this.btncoma.Size = new System.Drawing.Size(60, 54);
            this.btncoma.TabIndex = 15;
            this.btncoma.Text = ".";
            this.btncoma.UseVisualStyleBackColor = true;
            this.btncoma.Click += new System.EventHandler(this.btncoma_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(165, 290);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(60, 54);
            this.btn3.TabIndex = 14;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(165, 216);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(60, 54);
            this.btn6.TabIndex = 13;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(165, 143);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(60, 54);
            this.btn9.TabIndex = 12;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnmultiplicar
            // 
            this.btnmultiplicar.Location = new System.Drawing.Point(165, 72);
            this.btnmultiplicar.Name = "btnmultiplicar";
            this.btnmultiplicar.Size = new System.Drawing.Size(60, 54);
            this.btnmultiplicar.TabIndex = 11;
            this.btnmultiplicar.Text = "*";
            this.btnmultiplicar.UseVisualStyleBackColor = true;
            this.btnmultiplicar.Click += new System.EventHandler(this.btnmultiplicar_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(242, 366);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(60, 54);
            this.btnAnterior.TabIndex = 20;
            this.btnAnterior.Text = "Ans";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnigual_Click);
            // 
            // btnborrar1
            // 
            this.btnborrar1.Location = new System.Drawing.Point(242, 216);
            this.btnborrar1.Name = "btnborrar1";
            this.btnborrar1.Size = new System.Drawing.Size(60, 54);
            this.btnborrar1.TabIndex = 18;
            this.btnborrar1.Text = "DEL";
            this.btnborrar1.UseVisualStyleBackColor = true;
            this.btnborrar1.Click += new System.EventHandler(this.btnborrar1_Click);
            // 
            // btnsuma
            // 
            this.btnsuma.Location = new System.Drawing.Point(12, 72);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(60, 54);
            this.btnsuma.TabIndex = 17;
            this.btnsuma.Text = "+";
            this.btnsuma.UseVisualStyleBackColor = true;
            this.btnsuma.Click += new System.EventHandler(this.btnsuma_Click);
            // 
            // btnresta
            // 
            this.btnresta.Location = new System.Drawing.Point(87, 72);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(60, 54);
            this.btnresta.TabIndex = 16;
            this.btnresta.Text = "-";
            this.btnresta.UseVisualStyleBackColor = true;
            this.btnresta.Click += new System.EventHandler(this.btnresta_Click);
            // 
            // btnigual
            // 
            this.btnigual.Location = new System.Drawing.Point(87, 366);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(60, 54);
            this.btnigual.TabIndex = 22;
            this.btnigual.Text = "=";
            this.btnigual.UseVisualStyleBackColor = true;
            this.btnigual.Click += new System.EventHandler(this.btnigual_Click_1);
            // 
            // btnhistorial
            // 
            this.btnhistorial.Location = new System.Drawing.Point(242, 290);
            this.btnhistorial.Name = "btnhistorial";
            this.btnhistorial.Size = new System.Drawing.Size(60, 54);
            this.btnhistorial.TabIndex = 23;
            this.btnhistorial.Text = "Hist";
            this.btnhistorial.UseVisualStyleBackColor = true;
            this.btnhistorial.Click += new System.EventHandler(this.btnhistorial_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(318, 435);
            this.Controls.Add(this.btnhistorial);
            this.Controls.Add(this.btnigual);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnborrar1);
            this.Controls.Add(this.btnsuma);
            this.Controls.Add(this.btnresta);
            this.Controls.Add(this.btncoma);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnmultiplicar);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btndivision);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.dply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dply;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btndivision;
        private System.Windows.Forms.Button btncoma;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnmultiplicar;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnborrar1;
        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.Button btnresta;
        private System.Windows.Forms.Button btnigual;
        private System.Windows.Forms.Button btnhistorial;
    }
}

