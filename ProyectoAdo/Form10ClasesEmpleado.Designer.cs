namespace ProyectoAdo
{
    partial class Form10ClasesEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lsvEmpleados = new System.Windows.Forms.ListView();
            this.txtIncremento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btIncrementar = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbOficios = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oficios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empleados";
            // 
            // lsvEmpleados
            // 
            this.lsvEmpleados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader7});
            this.lsvEmpleados.HideSelection = false;
            this.lsvEmpleados.Location = new System.Drawing.Point(38, 136);
            this.lsvEmpleados.Name = "lsvEmpleados";
            this.lsvEmpleados.Size = new System.Drawing.Size(422, 205);
            this.lsvEmpleados.TabIndex = 0;
            this.lsvEmpleados.UseCompatibleStateImageBehavior = false;
            this.lsvEmpleados.View = System.Windows.Forms.View.Details;
            // 
            // txtIncremento
            // 
            this.txtIncremento.Location = new System.Drawing.Point(248, 58);
            this.txtIncremento.Name = "txtIncremento";
            this.txtIncremento.Size = new System.Drawing.Size(143, 20);
            this.txtIncremento.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Incremento salarial:";
            // 
            // btIncrementar
            // 
            this.btIncrementar.Location = new System.Drawing.Point(248, 85);
            this.btIncrementar.Name = "btIncrementar";
            this.btIncrementar.Size = new System.Drawing.Size(143, 23);
            this.btIncrementar.TabIndex = 6;
            this.btIncrementar.Text = "Incrementar Salarios";
            this.btIncrementar.UseVisualStyleBackColor = true;
            this.btIncrementar.Click += new System.EventHandler(this.btIncrementar_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "IDEMPLEADO";
            this.columnHeader1.Width = 94;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "APELLIDO";
            this.columnHeader2.Width = 102;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "OFICIO";
            this.columnHeader3.Width = 99;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "SALARIO";
            // 
            // cbOficios
            // 
            this.cbOficios.FormattingEnabled = true;
            this.cbOficios.Location = new System.Drawing.Point(41, 56);
            this.cbOficios.Name = "cbOficios";
            this.cbOficios.Size = new System.Drawing.Size(121, 21);
            this.cbOficios.TabIndex = 7;
            this.cbOficios.SelectedIndexChanged += new System.EventHandler(this.cbOficios_SelectedIndexChanged);
            // 
            // Form10ClasesEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 374);
            this.Controls.Add(this.cbOficios);
            this.Controls.Add(this.btIncrementar);
            this.Controls.Add(this.txtIncremento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lsvEmpleados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form10ClasesEmpleado";
            this.Text = "Form10ClasesEmpleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lsvEmpleados;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txtIncremento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btIncrementar;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ComboBox cbOficios;
    }
}