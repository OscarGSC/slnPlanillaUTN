namespace PlanillaUTN.Layers.UI
{
    partial class frmCalcularSalarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCalcularSalario = new System.Windows.Forms.Button();
            this.btnNombramientos = new System.Windows.Forms.Button();
            this.gbDocentes = new System.Windows.Forms.GroupBox();
            this.dgvDocentes = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRealizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDocentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcularSalario
            // 
            this.btnCalcularSalario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularSalario.Location = new System.Drawing.Point(339, 243);
            this.btnCalcularSalario.Margin = new System.Windows.Forms.Padding(1);
            this.btnCalcularSalario.Name = "btnCalcularSalario";
            this.btnCalcularSalario.Size = new System.Drawing.Size(121, 31);
            this.btnCalcularSalario.TabIndex = 45;
            this.btnCalcularSalario.Text = "Calcular Salario";
            this.btnCalcularSalario.UseVisualStyleBackColor = true;
            this.btnCalcularSalario.Click += new System.EventHandler(this.btnCalcularSalario_Click);
            // 
            // btnNombramientos
            // 
            this.btnNombramientos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNombramientos.Location = new System.Drawing.Point(197, 243);
            this.btnNombramientos.Margin = new System.Windows.Forms.Padding(1);
            this.btnNombramientos.Name = "btnNombramientos";
            this.btnNombramientos.Size = new System.Drawing.Size(121, 31);
            this.btnNombramientos.TabIndex = 44;
            this.btnNombramientos.Text = "Nombramientos";
            this.btnNombramientos.UseVisualStyleBackColor = true;
            this.btnNombramientos.Click += new System.EventHandler(this.btnNombramientos_Click);
            // 
            // gbDocentes
            // 
            this.gbDocentes.Controls.Add(this.dgvDocentes);
            this.gbDocentes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDocentes.Location = new System.Drawing.Point(10, 10);
            this.gbDocentes.Margin = new System.Windows.Forms.Padding(1);
            this.gbDocentes.Name = "gbDocentes";
            this.gbDocentes.Padding = new System.Windows.Forms.Padding(1);
            this.gbDocentes.Size = new System.Drawing.Size(639, 213);
            this.gbDocentes.TabIndex = 43;
            this.gbDocentes.TabStop = false;
            this.gbDocentes.Text = "Docentes";
            // 
            // dgvDocentes
            // 
            this.dgvDocentes.AllowUserToAddRows = false;
            this.dgvDocentes.AllowUserToDeleteRows = false;
            this.dgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colDesc,
            this.colRealizado,
            this.colCategoria,
            this.colIngreso,
            this.colEmail});
            this.dgvDocentes.Location = new System.Drawing.Point(13, 26);
            this.dgvDocentes.Margin = new System.Windows.Forms.Padding(1);
            this.dgvDocentes.MultiSelect = false;
            this.dgvDocentes.Name = "dgvDocentes";
            this.dgvDocentes.ReadOnly = true;
            this.dgvDocentes.RowHeadersVisible = false;
            this.dgvDocentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocentes.Size = new System.Drawing.Size(613, 172);
            this.dgvDocentes.TabIndex = 0;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Identificación";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colDesc
            // 
            this.colDesc.DataPropertyName = "Nombre";
            this.colDesc.HeaderText = "Nombre";
            this.colDesc.Name = "colDesc";
            this.colDesc.ReadOnly = true;
            // 
            // colRealizado
            // 
            this.colRealizado.DataPropertyName = "Apellido";
            this.colRealizado.HeaderText = "Apellido";
            this.colRealizado.Name = "colRealizado";
            this.colRealizado.ReadOnly = true;
            // 
            // colCategoria
            // 
            this.colCategoria.DataPropertyName = "nombreCategoria";
            this.colCategoria.HeaderText = "Categoría";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            // 
            // colIngreso
            // 
            this.colIngreso.DataPropertyName = "FechaIngreso";
            dataGridViewCellStyle1.Format = "d";
            this.colIngreso.DefaultCellStyle = dataGridViewCellStyle1;
            this.colIngreso.HeaderText = "Ingreso";
            this.colIngreso.Name = "colIngreso";
            this.colIngreso.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // frmCalcularSalarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 288);
            this.Controls.Add(this.btnCalcularSalario);
            this.Controls.Add(this.btnNombramientos);
            this.Controls.Add(this.gbDocentes);
            this.Name = "frmCalcularSalarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular Salarios";
            this.Load += new System.EventHandler(this.frmCalcularSalarios_Load);
            this.gbDocentes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularSalario;
        private System.Windows.Forms.Button btnNombramientos;
        private System.Windows.Forms.GroupBox gbDocentes;
        private System.Windows.Forms.DataGridView dgvDocentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRealizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
    }
}