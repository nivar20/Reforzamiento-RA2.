namespace Prueba
{
    partial class btnLimpiar
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
            this.txtHijos = new System.Windows.Forms.TextBox();
            this.txtSueldoBruto = new System.Windows.Forms.TextBox();
            this.txtIncentivoHijos = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lbl_Cantidaddehijos = new System.Windows.Forms.Label();
            this.lbl_Sueldobruto = new System.Windows.Forms.Label();
            this.lbl_Incentivosporhijos = new System.Windows.Forms.Label();
            this.lbl_DescuentoSFS = new System.Windows.Forms.Label();
            this.txtSFS = new System.Windows.Forms.TextBox();
            this.lbl_DescuentoAFP = new System.Windows.Forms.Label();
            this.txtAFP = new System.Windows.Forms.TextBox();
            this.lbl_Sueldoneto = new System.Windows.Forms.Label();
            this.txtSueldoNeto = new System.Windows.Forms.TextBox();
            this.lbl_Totaldescuentos = new System.Windows.Forms.Label();
            this.txtDescuentos = new System.Windows.Forms.TextBox();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lbl_SueldoNetoEmpleado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHijos
            // 
            this.txtHijos.Location = new System.Drawing.Point(155, 100);
            this.txtHijos.Name = "txtHijos";
            this.txtHijos.Size = new System.Drawing.Size(100, 20);
            this.txtHijos.TabIndex = 0;
            this.txtHijos.Text = "0";
            // 
            // txtSueldoBruto
            // 
            this.txtSueldoBruto.Location = new System.Drawing.Point(155, 46);
            this.txtSueldoBruto.Name = "txtSueldoBruto";
            this.txtSueldoBruto.Size = new System.Drawing.Size(100, 20);
            this.txtSueldoBruto.TabIndex = 1;
            // 
            // txtIncentivoHijos
            // 
            this.txtIncentivoHijos.Location = new System.Drawing.Point(155, 154);
            this.txtIncentivoHijos.Name = "txtIncentivoHijos";
            this.txtIncentivoHijos.ReadOnly = true;
            this.txtIncentivoHijos.Size = new System.Drawing.Size(100, 20);
            this.txtIncentivoHijos.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCalcular.Location = new System.Drawing.Point(320, 310);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(123, 36);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lbl_Cantidaddehijos
            // 
            this.lbl_Cantidaddehijos.AutoSize = true;
            this.lbl_Cantidaddehijos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_Cantidaddehijos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cantidaddehijos.Location = new System.Drawing.Point(12, 100);
            this.lbl_Cantidaddehijos.Name = "lbl_Cantidaddehijos";
            this.lbl_Cantidaddehijos.Size = new System.Drawing.Size(128, 19);
            this.lbl_Cantidaddehijos.TabIndex = 4;
            this.lbl_Cantidaddehijos.Text = "Cantidad de hijos:";
            // 
            // lbl_Sueldobruto
            // 
            this.lbl_Sueldobruto.AutoSize = true;
            this.lbl_Sueldobruto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_Sueldobruto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sueldobruto.Location = new System.Drawing.Point(24, 45);
            this.lbl_Sueldobruto.Name = "lbl_Sueldobruto";
            this.lbl_Sueldobruto.Size = new System.Drawing.Size(96, 19);
            this.lbl_Sueldobruto.TabIndex = 5;
            this.lbl_Sueldobruto.Text = "Sueldo bruto:";
            // 
            // lbl_Incentivosporhijos
            // 
            this.lbl_Incentivosporhijos.AutoSize = true;
            this.lbl_Incentivosporhijos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_Incentivosporhijos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Incentivosporhijos.Location = new System.Drawing.Point(12, 155);
            this.lbl_Incentivosporhijos.Name = "lbl_Incentivosporhijos";
            this.lbl_Incentivosporhijos.Size = new System.Drawing.Size(135, 19);
            this.lbl_Incentivosporhijos.TabIndex = 6;
            this.lbl_Incentivosporhijos.Text = "Incentivo por hijos:";
            // 
            // lbl_DescuentoSFS
            // 
            this.lbl_DescuentoSFS.AutoSize = true;
            this.lbl_DescuentoSFS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_DescuentoSFS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescuentoSFS.Location = new System.Drawing.Point(12, 210);
            this.lbl_DescuentoSFS.Name = "lbl_DescuentoSFS";
            this.lbl_DescuentoSFS.Size = new System.Drawing.Size(111, 19);
            this.lbl_DescuentoSFS.TabIndex = 8;
            this.lbl_DescuentoSFS.Text = "Descuento SFS:";
            // 
            // txtSFS
            // 
            this.txtSFS.Location = new System.Drawing.Point(155, 209);
            this.txtSFS.Name = "txtSFS";
            this.txtSFS.ReadOnly = true;
            this.txtSFS.Size = new System.Drawing.Size(100, 20);
            this.txtSFS.TabIndex = 7;
            // 
            // lbl_DescuentoAFP
            // 
            this.lbl_DescuentoAFP.AutoSize = true;
            this.lbl_DescuentoAFP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_DescuentoAFP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescuentoAFP.Location = new System.Drawing.Point(12, 267);
            this.lbl_DescuentoAFP.Name = "lbl_DescuentoAFP";
            this.lbl_DescuentoAFP.Size = new System.Drawing.Size(115, 19);
            this.lbl_DescuentoAFP.TabIndex = 10;
            this.lbl_DescuentoAFP.Text = "Descuento AFP:";
            // 
            // txtAFP
            // 
            this.txtAFP.Location = new System.Drawing.Point(155, 268);
            this.txtAFP.Name = "txtAFP";
            this.txtAFP.ReadOnly = true;
            this.txtAFP.Size = new System.Drawing.Size(100, 20);
            this.txtAFP.TabIndex = 9;
            // 
            // lbl_Sueldoneto
            // 
            this.lbl_Sueldoneto.AutoSize = true;
            this.lbl_Sueldoneto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_Sueldoneto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sueldoneto.Location = new System.Drawing.Point(24, 382);
            this.lbl_Sueldoneto.Name = "lbl_Sueldoneto";
            this.lbl_Sueldoneto.Size = new System.Drawing.Size(89, 19);
            this.lbl_Sueldoneto.TabIndex = 12;
            this.lbl_Sueldoneto.Text = "Sueldo neto:";
            // 
            // txtSueldoNeto
            // 
            this.txtSueldoNeto.Location = new System.Drawing.Point(155, 383);
            this.txtSueldoNeto.Name = "txtSueldoNeto";
            this.txtSueldoNeto.ReadOnly = true;
            this.txtSueldoNeto.Size = new System.Drawing.Size(100, 20);
            this.txtSueldoNeto.TabIndex = 11;
            // 
            // lbl_Totaldescuentos
            // 
            this.lbl_Totaldescuentos.AutoSize = true;
            this.lbl_Totaldescuentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_Totaldescuentos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Totaldescuentos.Location = new System.Drawing.Point(10, 327);
            this.lbl_Totaldescuentos.Name = "lbl_Totaldescuentos";
            this.lbl_Totaldescuentos.Size = new System.Drawing.Size(121, 19);
            this.lbl_Totaldescuentos.TabIndex = 14;
            this.lbl_Totaldescuentos.Text = "Total descuentos:";
            // 
            // txtDescuentos
            // 
            this.txtDescuentos.Location = new System.Drawing.Point(155, 326);
            this.txtDescuentos.Name = "txtDescuentos";
            this.txtDescuentos.ReadOnly = true;
            this.txtDescuentos.Size = new System.Drawing.Size(100, 20);
            this.txtDescuentos.TabIndex = 13;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Limpiar.Location = new System.Drawing.Point(625, 310);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(110, 36);
            this.btn_Limpiar.TabIndex = 15;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = false;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCerrar.Location = new System.Drawing.Point(467, 310);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(115, 36);
            this.btnCerrar.TabIndex = 16;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // lbl_SueldoNetoEmpleado
            // 
            this.lbl_SueldoNetoEmpleado.AutoSize = true;
            this.lbl_SueldoNetoEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_SueldoNetoEmpleado.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SueldoNetoEmpleado.Location = new System.Drawing.Point(297, 22);
            this.lbl_SueldoNetoEmpleado.Name = "lbl_SueldoNetoEmpleado";
            this.lbl_SueldoNetoEmpleado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_SueldoNetoEmpleado.Size = new System.Drawing.Size(269, 31);
            this.lbl_SueldoNetoEmpleado.TabIndex = 17;
            this.lbl_SueldoNetoEmpleado.Text = "Sueldo Neto Empleado";
            // 
            // btnLimpiar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(879, 577);
            this.Controls.Add(this.lbl_SueldoNetoEmpleado);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.lbl_Totaldescuentos);
            this.Controls.Add(this.txtDescuentos);
            this.Controls.Add(this.lbl_Sueldoneto);
            this.Controls.Add(this.txtSueldoNeto);
            this.Controls.Add(this.lbl_DescuentoAFP);
            this.Controls.Add(this.txtAFP);
            this.Controls.Add(this.lbl_DescuentoSFS);
            this.Controls.Add(this.txtSFS);
            this.Controls.Add(this.lbl_Incentivosporhijos);
            this.Controls.Add(this.lbl_Sueldobruto);
            this.Controls.Add(this.lbl_Cantidaddehijos);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtIncentivoHijos);
            this.Controls.Add(this.txtSueldoBruto);
            this.Controls.Add(this.txtHijos);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "btnLimpiar";
            this.Text = "Cálculo de sueldo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHijos;
        private System.Windows.Forms.TextBox txtSueldoBruto;
        private System.Windows.Forms.TextBox txtIncentivoHijos;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lbl_Cantidaddehijos;
        private System.Windows.Forms.Label lbl_Sueldobruto;
        private System.Windows.Forms.Label lbl_Incentivosporhijos;
        private System.Windows.Forms.Label lbl_DescuentoSFS;
        private System.Windows.Forms.TextBox txtSFS;
        private System.Windows.Forms.Label lbl_DescuentoAFP;
        private System.Windows.Forms.TextBox txtAFP;
        private System.Windows.Forms.Label lbl_Sueldoneto;
        private System.Windows.Forms.TextBox txtSueldoNeto;
        private System.Windows.Forms.Label lbl_Totaldescuentos;
        private System.Windows.Forms.TextBox txtDescuentos;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lbl_SueldoNetoEmpleado;
    }
}

