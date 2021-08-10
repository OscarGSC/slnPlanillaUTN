namespace PlanillaUTN.Layers.UI
{
    partial class frmNombramientos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNombramientos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbSeleccionadas = new System.Windows.Forms.ListBox();
            this.gbDisponibles = new System.Windows.Forms.GroupBox();
            this.lbDisponibles = new System.Windows.Forms.ListBox();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbDisponibles.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbSeleccionadas);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(265, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(160, 140);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionadas";
            // 
            // lbSeleccionadas
            // 
            this.lbSeleccionadas.FormattingEnabled = true;
            this.lbSeleccionadas.ItemHeight = 16;
            this.lbSeleccionadas.Location = new System.Drawing.Point(13, 26);
            this.lbSeleccionadas.Margin = new System.Windows.Forms.Padding(1);
            this.lbSeleccionadas.Name = "lbSeleccionadas";
            this.lbSeleccionadas.Size = new System.Drawing.Size(135, 84);
            this.lbSeleccionadas.TabIndex = 1;
            // 
            // gbDisponibles
            // 
            this.gbDisponibles.Controls.Add(this.lbDisponibles);
            this.gbDisponibles.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDisponibles.Location = new System.Drawing.Point(20, 22);
            this.gbDisponibles.Margin = new System.Windows.Forms.Padding(1);
            this.gbDisponibles.Name = "gbDisponibles";
            this.gbDisponibles.Padding = new System.Windows.Forms.Padding(1);
            this.gbDisponibles.Size = new System.Drawing.Size(160, 140);
            this.gbDisponibles.TabIndex = 12;
            this.gbDisponibles.TabStop = false;
            this.gbDisponibles.Text = "Disponibles";
            // 
            // lbDisponibles
            // 
            this.lbDisponibles.FormattingEnabled = true;
            this.lbDisponibles.ItemHeight = 16;
            this.lbDisponibles.Location = new System.Drawing.Point(13, 26);
            this.lbDisponibles.Margin = new System.Windows.Forms.Padding(1);
            this.lbDisponibles.Name = "lbDisponibles";
            this.lbDisponibles.Size = new System.Drawing.Size(135, 84);
            this.lbDisponibles.TabIndex = 0;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "circle-with-an-arrow-pointing-to-left.png");
            this.imageList.Images.SetKeyName(1, "arrow-pointing-right-in-a-circle.png");
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ImageKey = "circle-with-an-arrow-pointing-to-left.png";
            this.btnEliminar.ImageList = this.imageList;
            this.btnEliminar.Location = new System.Drawing.Point(197, 97);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(1);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(53, 42);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ImageIndex = 1;
            this.btnAgregar.ImageList = this.imageList;
            this.btnAgregar.Location = new System.Drawing.Point(197, 41);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(1);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(53, 42);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmNombramientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 185);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbDisponibles);
            this.Name = "frmNombramientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nombramientos";
            this.Load += new System.EventHandler(this.frmNombramientos_Load);
            this.groupBox1.ResumeLayout(false);
            this.gbDisponibles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbSeleccionadas;
        private System.Windows.Forms.GroupBox gbDisponibles;
        private System.Windows.Forms.ListBox lbDisponibles;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
    }
}