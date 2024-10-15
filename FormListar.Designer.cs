namespace HerbolarioViolero
{
    partial class FormListar
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
            this.groupBoxProducto = new System.Windows.Forms.GroupBox();
            this.rbtnIntolerancia = new System.Windows.Forms.RadioButton();
            this.rbtnEcologico = new System.Windows.Forms.RadioButton();
            this.rbtnAdelgazante = new System.Windows.Forms.RadioButton();
            this.rbtnAlimentacion = new System.Windows.Forms.RadioButton();
            this.rbtnCorporal = new System.Windows.Forms.RadioButton();
            this.rbtnDeporte = new System.Windows.Forms.RadioButton();
            this.rbtnSuplemento = new System.Windows.Forms.RadioButton();
            this.buttonListar = new System.Windows.Forms.Button();
            this.listBoxListar = new System.Windows.Forms.ListBox();
            this.buttonVolverListar = new System.Windows.Forms.Button();
            this.groupBoxProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxProducto
            // 
            this.groupBoxProducto.Controls.Add(this.rbtnIntolerancia);
            this.groupBoxProducto.Controls.Add(this.rbtnEcologico);
            this.groupBoxProducto.Controls.Add(this.rbtnAdelgazante);
            this.groupBoxProducto.Controls.Add(this.rbtnAlimentacion);
            this.groupBoxProducto.Controls.Add(this.rbtnCorporal);
            this.groupBoxProducto.Controls.Add(this.rbtnDeporte);
            this.groupBoxProducto.Controls.Add(this.rbtnSuplemento);
            this.groupBoxProducto.Location = new System.Drawing.Point(32, 27);
            this.groupBoxProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxProducto.Name = "groupBoxProducto";
            this.groupBoxProducto.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxProducto.Size = new System.Drawing.Size(187, 240);
            this.groupBoxProducto.TabIndex = 26;
            this.groupBoxProducto.TabStop = false;
            this.groupBoxProducto.Text = "Tipo de producto";
            // 
            // rbtnIntolerancia
            // 
            this.rbtnIntolerancia.AutoSize = true;
            this.rbtnIntolerancia.Location = new System.Drawing.Point(23, 85);
            this.rbtnIntolerancia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnIntolerancia.Name = "rbtnIntolerancia";
            this.rbtnIntolerancia.Size = new System.Drawing.Size(80, 17);
            this.rbtnIntolerancia.TabIndex = 8;
            this.rbtnIntolerancia.Text = "Intolerencia";
            this.rbtnIntolerancia.UseVisualStyleBackColor = true;
            // 
            // rbtnEcologico
            // 
            this.rbtnEcologico.AutoSize = true;
            this.rbtnEcologico.Location = new System.Drawing.Point(23, 45);
            this.rbtnEcologico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnEcologico.Name = "rbtnEcologico";
            this.rbtnEcologico.Size = new System.Drawing.Size(72, 17);
            this.rbtnEcologico.TabIndex = 6;
            this.rbtnEcologico.Text = "Ecológico";
            this.rbtnEcologico.UseVisualStyleBackColor = true;
            // 
            // rbtnAdelgazante
            // 
            this.rbtnAdelgazante.AutoSize = true;
            this.rbtnAdelgazante.Location = new System.Drawing.Point(23, 65);
            this.rbtnAdelgazante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnAdelgazante.Name = "rbtnAdelgazante";
            this.rbtnAdelgazante.Size = new System.Drawing.Size(84, 17);
            this.rbtnAdelgazante.TabIndex = 7;
            this.rbtnAdelgazante.Text = "Adelgazante";
            this.rbtnAdelgazante.UseVisualStyleBackColor = true;
            // 
            // rbtnAlimentacion
            // 
            this.rbtnAlimentacion.AutoSize = true;
            this.rbtnAlimentacion.Checked = true;
            this.rbtnAlimentacion.Location = new System.Drawing.Point(23, 24);
            this.rbtnAlimentacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnAlimentacion.Name = "rbtnAlimentacion";
            this.rbtnAlimentacion.Size = new System.Drawing.Size(85, 17);
            this.rbtnAlimentacion.TabIndex = 5;
            this.rbtnAlimentacion.TabStop = true;
            this.rbtnAlimentacion.Text = "Alimentación";
            this.rbtnAlimentacion.UseVisualStyleBackColor = true;
            // 
            // rbtnCorporal
            // 
            this.rbtnCorporal.AutoSize = true;
            this.rbtnCorporal.Location = new System.Drawing.Point(23, 107);
            this.rbtnCorporal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnCorporal.Name = "rbtnCorporal";
            this.rbtnCorporal.Size = new System.Drawing.Size(64, 17);
            this.rbtnCorporal.TabIndex = 9;
            this.rbtnCorporal.TabStop = true;
            this.rbtnCorporal.Text = "Corporal";
            this.rbtnCorporal.UseVisualStyleBackColor = true;
            // 
            // rbtnDeporte
            // 
            this.rbtnDeporte.AutoSize = true;
            this.rbtnDeporte.Location = new System.Drawing.Point(23, 128);
            this.rbtnDeporte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnDeporte.Name = "rbtnDeporte";
            this.rbtnDeporte.Size = new System.Drawing.Size(63, 17);
            this.rbtnDeporte.TabIndex = 10;
            this.rbtnDeporte.TabStop = true;
            this.rbtnDeporte.Text = "Deporte";
            this.rbtnDeporte.UseVisualStyleBackColor = true;
            // 
            // rbtnSuplemento
            // 
            this.rbtnSuplemento.AutoSize = true;
            this.rbtnSuplemento.Location = new System.Drawing.Point(22, 148);
            this.rbtnSuplemento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnSuplemento.Name = "rbtnSuplemento";
            this.rbtnSuplemento.Size = new System.Drawing.Size(81, 17);
            this.rbtnSuplemento.TabIndex = 11;
            this.rbtnSuplemento.TabStop = true;
            this.rbtnSuplemento.Text = "Suplemento";
            this.rbtnSuplemento.UseVisualStyleBackColor = true;
            // 
            // buttonListar
            // 
            this.buttonListar.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold);
            this.buttonListar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonListar.Location = new System.Drawing.Point(30, 364);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(97, 47);
            this.buttonListar.TabIndex = 27;
            this.buttonListar.Text = "Filtrar";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // listBoxListar
            // 
            this.listBoxListar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxListar.FormattingEnabled = true;
            this.listBoxListar.Location = new System.Drawing.Point(318, 27);
            this.listBoxListar.Name = "listBoxListar";
            this.listBoxListar.Size = new System.Drawing.Size(737, 381);
            this.listBoxListar.TabIndex = 35;
            // 
            // buttonVolverListar
            // 
            this.buttonVolverListar.Location = new System.Drawing.Point(171, 380);
            this.buttonVolverListar.Name = "buttonVolverListar";
            this.buttonVolverListar.Size = new System.Drawing.Size(79, 27);
            this.buttonVolverListar.TabIndex = 36;
            this.buttonVolverListar.Text = "Volver";
            this.buttonVolverListar.UseVisualStyleBackColor = true;
            // 
            // FormListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1104, 461);
            this.Controls.Add(this.buttonVolverListar);
            this.Controls.Add(this.listBoxListar);
            this.Controls.Add(this.buttonListar);
            this.Controls.Add(this.groupBoxProducto);
            this.Name = "FormListar";
            this.Text = "FormListar";
            this.groupBoxProducto.ResumeLayout(false);
            this.groupBoxProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxProducto;
        private System.Windows.Forms.RadioButton rbtnCorporal;
        private System.Windows.Forms.RadioButton rbtnDeporte;
        private System.Windows.Forms.RadioButton rbtnSuplemento;
        private System.Windows.Forms.RadioButton rbtnIntolerancia;
        private System.Windows.Forms.RadioButton rbtnEcologico;
        private System.Windows.Forms.RadioButton rbtnAdelgazante;
        private System.Windows.Forms.RadioButton rbtnAlimentacion;
        private System.Windows.Forms.Button buttonListar;
        private System.Windows.Forms.ListBox listBoxListar;
        private System.Windows.Forms.Button buttonVolverListar;
    }
}