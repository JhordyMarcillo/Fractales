namespace C__Proyecto_Final
{
    partial class FrmFractales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFractales));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnColorFractal = new System.Windows.Forms.Button();
            this.numericUpDownIterations = new System.Windows.Forms.NumericUpDown();
            this.btnColorBackground = new System.Windows.Forms.Button();
            this.btnFractal1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.Iteracciones = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterations)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Iteracciones);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnColorFractal);
            this.groupBox1.Controls.Add(this.numericUpDownIterations);
            this.groupBox1.Controls.Add(this.btnColorBackground);
            this.groupBox1.Controls.Add(this.btnFractal1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btnSalir
            // 
            resources.ApplyResources(this.btnSalir, "btnSalir");
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnColorFractal
            // 
            this.btnColorFractal.BackColor = System.Drawing.Color.AliceBlue;
            resources.ApplyResources(this.btnColorFractal, "btnColorFractal");
            this.btnColorFractal.Name = "btnColorFractal";
            this.btnColorFractal.UseVisualStyleBackColor = false;
            this.btnColorFractal.Click += new System.EventHandler(this.btnColorFractal_Click);
            // 
            // numericUpDownIterations
            // 
            resources.ApplyResources(this.numericUpDownIterations, "numericUpDownIterations");
            this.numericUpDownIterations.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownIterations.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownIterations.Name = "numericUpDownIterations";
            this.numericUpDownIterations.ValueChanged += new System.EventHandler(this.numericUpDownIterations_ValueChanged);
            // 
            // btnColorBackground
            // 
            this.btnColorBackground.BackColor = System.Drawing.Color.AliceBlue;
            resources.ApplyResources(this.btnColorBackground, "btnColorBackground");
            this.btnColorBackground.Name = "btnColorBackground";
            this.btnColorBackground.UseVisualStyleBackColor = false;
            this.btnColorBackground.Click += new System.EventHandler(this.btnColorBackground_Click);
            // 
            // btnFractal1
            // 
            this.btnFractal1.BackColor = System.Drawing.Color.AliceBlue;
            resources.ApplyResources(this.btnFractal1, "btnFractal1");
            this.btnFractal1.Name = "btnFractal1";
            this.btnFractal1.UseVisualStyleBackColor = false;
            this.btnFractal1.Click += new System.EventHandler(this.btnFractal1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picCanvas);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // picCanvas
            // 
            resources.ApplyResources(this.picCanvas, "picCanvas");
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.TabStop = false;
            // 
            // Iteracciones
            // 
            resources.ApplyResources(this.Iteracciones, "Iteracciones");
            this.Iteracciones.Name = "Iteracciones";
            // 
            // FrmFractales
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FrmFractales";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterations)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFractal1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.NumericUpDown numericUpDownIterations;
        private System.Windows.Forms.Button btnColorBackground;
        private System.Windows.Forms.Button btnColorFractal;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label Iteracciones;
    }
}

