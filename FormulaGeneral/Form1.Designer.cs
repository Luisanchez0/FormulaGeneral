
namespace FormulaGeneral
{
    partial class Form1
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
            this.lb_Title = new System.Windows.Forms.Label();
            this.lbl_a = new System.Windows.Forms.Label();
            this.lb_b = new System.Windows.Forms.Label();
            this.lb_c = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_a = new System.Windows.Forms.TextBox();
            this.tb_B = new System.Windows.Forms.TextBox();
            this.tb_C = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.tb_X2 = new System.Windows.Forms.TextBox();
            this.tb_X1 = new System.Windows.Forms.TextBox();
            this.lb_x2 = new System.Windows.Forms.Label();
            this.lb_x1 = new System.Windows.Forms.Label();
            this.bt_Limpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.Location = new System.Drawing.Point(90, 32);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(462, 31);
            this.lb_Title.TabIndex = 0;
            this.lb_Title.Text = "CALCULADORA DE FORMULA GENERAL";
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.Location = new System.Drawing.Point(120, 133);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(22, 20);
            this.lbl_a.TabIndex = 1;
            this.lbl_a.Text = "a:";
            // 
            // lb_b
            // 
            this.lb_b.AutoSize = true;
            this.lb_b.Location = new System.Drawing.Point(120, 188);
            this.lb_b.Name = "lb_b";
            this.lb_b.Size = new System.Drawing.Size(22, 20);
            this.lb_b.TabIndex = 2;
            this.lb_b.Text = "b:";
            // 
            // lb_c
            // 
            this.lb_c.AutoSize = true;
            this.lb_c.Location = new System.Drawing.Point(120, 248);
            this.lb_c.Name = "lb_c";
            this.lb_c.Size = new System.Drawing.Size(21, 20);
            this.lb_c.TabIndex = 3;
            this.lb_c.Text = "c:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "INGRESA LOS VALORES:";
            // 
            // tb_a
            // 
            this.tb_a.Location = new System.Drawing.Point(158, 126);
            this.tb_a.Name = "tb_a";
            this.tb_a.Size = new System.Drawing.Size(100, 26);
            this.tb_a.TabIndex = 5;
            // 
            // tb_B
            // 
            this.tb_B.Location = new System.Drawing.Point(158, 182);
            this.tb_B.Name = "tb_B";
            this.tb_B.Size = new System.Drawing.Size(100, 26);
            this.tb_B.TabIndex = 6;
            // 
            // tb_C
            // 
            this.tb_C.Location = new System.Drawing.Point(158, 242);
            this.tb_C.Name = "tb_C";
            this.tb_C.Size = new System.Drawing.Size(100, 26);
            this.tb_C.TabIndex = 7;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(419, 133);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(100, 35);
            this.btn_Calcular.TabIndex = 8;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // tb_X2
            // 
            this.tb_X2.Location = new System.Drawing.Point(419, 241);
            this.tb_X2.Name = "tb_X2";
            this.tb_X2.Size = new System.Drawing.Size(100, 26);
            this.tb_X2.TabIndex = 12;
            // 
            // tb_X1
            // 
            this.tb_X1.Location = new System.Drawing.Point(419, 185);
            this.tb_X1.Name = "tb_X1";
            this.tb_X1.Size = new System.Drawing.Size(100, 26);
            this.tb_X1.TabIndex = 11;
            // 
            // lb_x2
            // 
            this.lb_x2.AutoSize = true;
            this.lb_x2.Location = new System.Drawing.Point(381, 247);
            this.lb_x2.Name = "lb_x2";
            this.lb_x2.Size = new System.Drawing.Size(25, 20);
            this.lb_x2.TabIndex = 10;
            this.lb_x2.Text = "x2";
            // 
            // lb_x1
            // 
            this.lb_x1.AutoSize = true;
            this.lb_x1.Location = new System.Drawing.Point(381, 192);
            this.lb_x1.Name = "lb_x1";
            this.lb_x1.Size = new System.Drawing.Size(29, 20);
            this.lb_x1.TabIndex = 9;
            this.lb_x1.Text = "x1:";
            // 
            // bt_Limpiar
            // 
            this.bt_Limpiar.Location = new System.Drawing.Point(528, 402);
            this.bt_Limpiar.Name = "bt_Limpiar";
            this.bt_Limpiar.Size = new System.Drawing.Size(75, 35);
            this.bt_Limpiar.TabIndex = 13;
            this.bt_Limpiar.Text = "Limpiar";
            this.bt_Limpiar.UseVisualStyleBackColor = true;
            this.bt_Limpiar.Click += new System.EventHandler(this.bt_Limpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(652, 477);
            this.Controls.Add(this.bt_Limpiar);
            this.Controls.Add(this.tb_X2);
            this.Controls.Add(this.tb_X1);
            this.Controls.Add(this.lb_x2);
            this.Controls.Add(this.lb_x1);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.tb_C);
            this.Controls.Add(this.tb_B);
            this.Controls.Add(this.tb_a);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_c);
            this.Controls.Add(this.lb_b);
            this.Controls.Add(this.lbl_a);
            this.Controls.Add(this.lb_Title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Label lbl_a;
        private System.Windows.Forms.Label lb_b;
        private System.Windows.Forms.Label lb_c;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_a;
        private System.Windows.Forms.TextBox tb_B;
        private System.Windows.Forms.TextBox tb_C;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.TextBox tb_X2;
        private System.Windows.Forms.TextBox tb_X1;
        private System.Windows.Forms.Label lb_x2;
        private System.Windows.Forms.Label lb_x1;
        private System.Windows.Forms.Button bt_Limpiar;
    }
}

