namespace ProyectoAdo
{
    partial class Form09ClasesEnfermo
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
            this.lsvEnfermos = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsvEnfermos
            // 
            this.lsvEnfermos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader3});
            this.lsvEnfermos.HideSelection = false;
            this.lsvEnfermos.Location = new System.Drawing.Point(40, 60);
            this.lsvEnfermos.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lsvEnfermos.Name = "lsvEnfermos";
            this.lsvEnfermos.Size = new System.Drawing.Size(496, 257);
            this.lsvEnfermos.TabIndex = 0;
            this.lsvEnfermos.UseCompatibleStateImageBehavior = false;
            this.lsvEnfermos.View = System.Windows.Forms.View.Details;
            this.lsvEnfermos.SelectedIndexChanged += new System.EventHandler(this.lsvEnfermos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enfermos";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Descripcion";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Apellido";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Direccion";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fecha";
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(56, 344);
            this.btEliminar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(113, 35);
            this.btEliminar.TabIndex = 2;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // Form09ClasesEnfermo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 421);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsvEnfermos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form09ClasesEnfermo";
            this.Text = "Form09ClasesEnfermo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvEnfermos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btEliminar;
    }
}