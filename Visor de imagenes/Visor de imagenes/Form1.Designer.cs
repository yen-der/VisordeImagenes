namespace Visor_de_Imagenes
{
    partial class Form1
    {
        /// <summary>
        /// Variable requerida por el diseñador.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberar recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// Método requerido para soporte del Diseñador.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.checkBoxNormal = new System.Windows.Forms.CheckBox();
            this.checkBoxGrises = new System.Windows.Forms.CheckBox();
            this.radioButtonCentrada = new System.Windows.Forms.RadioButton();
            this.radioButtonAjustar = new System.Windows.Forms.RadioButton();
            this.radioButtonZoom = new System.Windows.Forms.RadioButton();
            this.btnSeleccionarCarpeta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(13, 318);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(600, 84);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnPrimero
            // 
            this.btnPrimero.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPrimero.Location = new System.Drawing.Point(12, 408);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(75, 30);
            this.btnPrimero.TabIndex = 2;
            this.btnPrimero.Text = "Primero";
            this.btnPrimero.UseVisualStyleBackColor = false;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAnterior.Location = new System.Drawing.Point(93, 408);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 30);
            this.btnAnterior.TabIndex = 3;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSiguiente.Location = new System.Drawing.Point(174, 408);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 30);
            this.btnSiguiente.TabIndex = 4;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUltimo.Location = new System.Drawing.Point(255, 408);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(75, 30);
            this.btnUltimo.TabIndex = 5;
            this.btnUltimo.Text = "Último";
            this.btnUltimo.UseVisualStyleBackColor = false;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // checkBoxNormal
            // 
            this.checkBoxNormal.AutoSize = true;
            this.checkBoxNormal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBoxNormal.Location = new System.Drawing.Point(629, 223);
            this.checkBoxNormal.Name = "checkBoxNormal";
            this.checkBoxNormal.Size = new System.Drawing.Size(85, 24);
            this.checkBoxNormal.TabIndex = 6;
            this.checkBoxNormal.Text = "Normal";
            this.checkBoxNormal.UseVisualStyleBackColor = false;
            this.checkBoxNormal.CheckedChanged += new System.EventHandler(this.checkBoxNormal_CheckedChanged);
            // 
            // checkBoxGrises
            // 
            this.checkBoxGrises.AutoSize = true;
            this.checkBoxGrises.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.checkBoxGrises.Location = new System.Drawing.Point(629, 275);
            this.checkBoxGrises.Name = "checkBoxGrises";
            this.checkBoxGrises.Size = new System.Drawing.Size(134, 24);
            this.checkBoxGrises.TabIndex = 7;
            this.checkBoxGrises.Text = "Escala de gris";
            this.checkBoxGrises.UseVisualStyleBackColor = false;
            this.checkBoxGrises.CheckedChanged += new System.EventHandler(this.checkBoxGrises_CheckedChanged);
            // 
            // radioButtonCentrada
            // 
            this.radioButtonCentrada.AutoSize = true;
            this.radioButtonCentrada.Location = new System.Drawing.Point(629, 73);
            this.radioButtonCentrada.Name = "radioButtonCentrada";
            this.radioButtonCentrada.Size = new System.Drawing.Size(100, 24);
            this.radioButtonCentrada.TabIndex = 8;
            this.radioButtonCentrada.TabStop = true;
            this.radioButtonCentrada.Text = "Centrada";
            this.radioButtonCentrada.UseVisualStyleBackColor = true;
            this.radioButtonCentrada.CheckedChanged += new System.EventHandler(this.radioButtonCentrada_CheckedChanged);
            // 
            // radioButtonAjustar
            // 
            this.radioButtonAjustar.AutoSize = true;
            this.radioButtonAjustar.Location = new System.Drawing.Point(629, 122);
            this.radioButtonAjustar.Name = "radioButtonAjustar";
            this.radioButtonAjustar.Size = new System.Drawing.Size(84, 24);
            this.radioButtonAjustar.TabIndex = 9;
            this.radioButtonAjustar.TabStop = true;
            this.radioButtonAjustar.Text = "Ajustar";
            this.radioButtonAjustar.UseVisualStyleBackColor = true;
            this.radioButtonAjustar.CheckedChanged += new System.EventHandler(this.radioButtonAjustar_CheckedChanged);
            // 
            // radioButtonZoom
            // 
            this.radioButtonZoom.AutoSize = true;
            this.radioButtonZoom.Checked = true;
            this.radioButtonZoom.Location = new System.Drawing.Point(629, 171);
            this.radioButtonZoom.Name = "radioButtonZoom";
            this.radioButtonZoom.Size = new System.Drawing.Size(75, 24);
            this.radioButtonZoom.TabIndex = 10;
            this.radioButtonZoom.TabStop = true;
            this.radioButtonZoom.Text = "Zoom";
            this.radioButtonZoom.UseVisualStyleBackColor = true;
            this.radioButtonZoom.CheckedChanged += new System.EventHandler(this.radioButtonZoom_CheckedChanged);
            // 
            // btnSeleccionarCarpeta
            // 
            this.btnSeleccionarCarpeta.BackColor = System.Drawing.SystemColors.Info;
            this.btnSeleccionarCarpeta.Location = new System.Drawing.Point(336, 408);
            this.btnSeleccionarCarpeta.Name = "btnSeleccionarCarpeta";
            this.btnSeleccionarCarpeta.Size = new System.Drawing.Size(137, 30);
            this.btnSeleccionarCarpeta.TabIndex = 11;
            this.btnSeleccionarCarpeta.Text = "BotonCarpeta";
            this.btnSeleccionarCarpeta.UseVisualStyleBackColor = false;
            this.btnSeleccionarCarpeta.Click += new System.EventHandler(this.btnSeleccionarCarpeta_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(776, 456);
            this.Controls.Add(this.btnSeleccionarCarpeta);
            this.Controls.Add(this.radioButtonZoom);
            this.Controls.Add(this.radioButtonAjustar);
            this.Controls.Add(this.radioButtonCentrada);
            this.Controls.Add(this.checkBoxGrises);
            this.Controls.Add(this.checkBoxNormal);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Visor de Imágenes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.CheckBox checkBoxNormal;
        private System.Windows.Forms.CheckBox checkBoxGrises;
        private System.Windows.Forms.RadioButton radioButtonCentrada;
        private System.Windows.Forms.RadioButton radioButtonAjustar;
        private System.Windows.Forms.RadioButton radioButtonZoom;
        private System.Windows.Forms.Button btnSeleccionarCarpeta;
    }
}
