
namespace HerbolarioViolero
{
    partial class FormInsertar
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.comboBoxCasas = new System.Windows.Forms.ComboBox();
            this.lblCasaComercial = new System.Windows.Forms.Label();
            this.rbtnAlimentacion = new System.Windows.Forms.RadioButton();
            this.rbtnCorporal = new System.Windows.Forms.RadioButton();
            this.rbtnDeporte = new System.Windows.Forms.RadioButton();
            this.rbtnSuplemento = new System.Windows.Forms.RadioButton();
            this.rbtnEcologico = new System.Windows.Forms.RadioButton();
            this.rbtnAdelgazante = new System.Windows.Forms.RadioButton();
            this.rbtnIntolerancia = new System.Windows.Forms.RadioButton();
            this.groupBoxProducto = new System.Windows.Forms.GroupBox();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtAtributo1 = new System.Windows.Forms.TextBox();
            this.lblAtributo1 = new System.Windows.Forms.Label();
            this.txtAtributo2 = new System.Windows.Forms.TextBox();
            this.lblAtributo2 = new System.Windows.Forms.Label();
            this.listBoxInsertar = new System.Windows.Forms.ListBox();
            this.groupBoxProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(88, 27);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(59, 50);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(41, 73);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(116, 73);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(300, 62);
            this.txtDescripcion.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(116, 48);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(300, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(116, 24);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(52, 20);
            this.txtId.TabIndex = 1;
            // 
            // comboBoxCasas
            // 
            this.comboBoxCasas.FormattingEnabled = true;
            this.comboBoxCasas.Location = new System.Drawing.Point(44, 383);
            this.comboBoxCasas.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCasas.Name = "comboBoxCasas";
            this.comboBoxCasas.Size = new System.Drawing.Size(1037, 21);
            this.comboBoxCasas.TabIndex = 4;
            // 
            // lblCasaComercial
            // 
            this.lblCasaComercial.AutoSize = true;
            this.lblCasaComercial.Location = new System.Drawing.Point(41, 353);
            this.lblCasaComercial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCasaComercial.Name = "lblCasaComercial";
            this.lblCasaComercial.Size = new System.Drawing.Size(86, 13);
            this.lblCasaComercial.TabIndex = 7;
            this.lblCasaComercial.Text = "Casa Comercial: ";
            // 
            // rbtnAlimentacion
            // 
            this.rbtnAlimentacion.AutoSize = true;
            this.rbtnAlimentacion.Checked = true;
            this.rbtnAlimentacion.Location = new System.Drawing.Point(20, 28);
            this.rbtnAlimentacion.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnAlimentacion.Name = "rbtnAlimentacion";
            this.rbtnAlimentacion.Size = new System.Drawing.Size(85, 17);
            this.rbtnAlimentacion.TabIndex = 5;
            this.rbtnAlimentacion.TabStop = true;
            this.rbtnAlimentacion.Text = "Alimentación";
            this.rbtnAlimentacion.UseVisualStyleBackColor = true;
            this.rbtnAlimentacion.CheckedChanged += new System.EventHandler(this.rbtnAlimentacion_CheckedChanged);
            // 
            // rbtnCorporal
            // 
            this.rbtnCorporal.AutoSize = true;
            this.rbtnCorporal.Location = new System.Drawing.Point(235, 28);
            this.rbtnCorporal.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnCorporal.Name = "rbtnCorporal";
            this.rbtnCorporal.Size = new System.Drawing.Size(64, 17);
            this.rbtnCorporal.TabIndex = 9;
            this.rbtnCorporal.TabStop = true;
            this.rbtnCorporal.Text = "Corporal";
            this.rbtnCorporal.UseVisualStyleBackColor = true;
            this.rbtnCorporal.CheckedChanged += new System.EventHandler(this.rbtnCorporal_CheckedChanged);
            // 
            // rbtnDeporte
            // 
            this.rbtnDeporte.AutoSize = true;
            this.rbtnDeporte.Location = new System.Drawing.Point(235, 59);
            this.rbtnDeporte.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnDeporte.Name = "rbtnDeporte";
            this.rbtnDeporte.Size = new System.Drawing.Size(63, 17);
            this.rbtnDeporte.TabIndex = 10;
            this.rbtnDeporte.TabStop = true;
            this.rbtnDeporte.Text = "Deporte";
            this.rbtnDeporte.UseVisualStyleBackColor = true;
            this.rbtnDeporte.CheckedChanged += new System.EventHandler(this.rbtnDeporte_CheckedChanged);
            // 
            // rbtnSuplemento
            // 
            this.rbtnSuplemento.AutoSize = true;
            this.rbtnSuplemento.Location = new System.Drawing.Point(235, 91);
            this.rbtnSuplemento.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnSuplemento.Name = "rbtnSuplemento";
            this.rbtnSuplemento.Size = new System.Drawing.Size(81, 17);
            this.rbtnSuplemento.TabIndex = 11;
            this.rbtnSuplemento.TabStop = true;
            this.rbtnSuplemento.Text = "Suplemento";
            this.rbtnSuplemento.UseVisualStyleBackColor = true;
            this.rbtnSuplemento.CheckedChanged += new System.EventHandler(this.rbtnSuplemento_CheckedChanged);
            // 
            // rbtnEcologico
            // 
            this.rbtnEcologico.AutoSize = true;
            this.rbtnEcologico.Location = new System.Drawing.Point(38, 49);
            this.rbtnEcologico.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnEcologico.Name = "rbtnEcologico";
            this.rbtnEcologico.Size = new System.Drawing.Size(115, 17);
            this.rbtnEcologico.TabIndex = 6;
            this.rbtnEcologico.Text = "Alimento Ecológico";
            this.rbtnEcologico.UseVisualStyleBackColor = true;
            this.rbtnEcologico.CheckedChanged += new System.EventHandler(this.rbtnEcologico_CheckedChanged);
            // 
            // rbtnAdelgazante
            // 
            this.rbtnAdelgazante.AutoSize = true;
            this.rbtnAdelgazante.Location = new System.Drawing.Point(38, 70);
            this.rbtnAdelgazante.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnAdelgazante.Name = "rbtnAdelgazante";
            this.rbtnAdelgazante.Size = new System.Drawing.Size(127, 17);
            this.rbtnAdelgazante.TabIndex = 7;
            this.rbtnAdelgazante.Text = "Alimento Adelgazante";
            this.rbtnAdelgazante.UseVisualStyleBackColor = true;
            this.rbtnAdelgazante.CheckedChanged += new System.EventHandler(this.rbtnAdelgazante_CheckedChanged);
            // 
            // rbtnIntolerancia
            // 
            this.rbtnIntolerancia.AutoSize = true;
            this.rbtnIntolerancia.Location = new System.Drawing.Point(38, 91);
            this.rbtnIntolerancia.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnIntolerancia.Name = "rbtnIntolerancia";
            this.rbtnIntolerancia.Size = new System.Drawing.Size(148, 17);
            this.rbtnIntolerancia.TabIndex = 8;
            this.rbtnIntolerancia.Text = "Alimento Apto Intolerencia";
            this.rbtnIntolerancia.UseVisualStyleBackColor = true;
            this.rbtnIntolerancia.CheckedChanged += new System.EventHandler(this.rbtnIntolerancia_CheckedChanged);
            // 
            // groupBoxProducto
            // 
            this.groupBoxProducto.Controls.Add(this.rbtnEcologico);
            this.groupBoxProducto.Controls.Add(this.rbtnIntolerancia);
            this.groupBoxProducto.Controls.Add(this.rbtnAlimentacion);
            this.groupBoxProducto.Controls.Add(this.rbtnCorporal);
            this.groupBoxProducto.Controls.Add(this.rbtnAdelgazante);
            this.groupBoxProducto.Controls.Add(this.rbtnDeporte);
            this.groupBoxProducto.Controls.Add(this.rbtnSuplemento);
            this.groupBoxProducto.Location = new System.Drawing.Point(24, 152);
            this.groupBoxProducto.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxProducto.Name = "groupBoxProducto";
            this.groupBoxProducto.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxProducto.Size = new System.Drawing.Size(390, 122);
            this.groupBoxProducto.TabIndex = 5;
            this.groupBoxProducto.TabStop = false;
            this.groupBoxProducto.Text = "Tipo de producto";
            // 
            // btnAnadir
            // 
            this.btnAnadir.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadir.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAnadir.Location = new System.Drawing.Point(891, 409);
            this.btnAnadir.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(118, 43);
            this.btnAnadir.TabIndex = 14;
            this.btnAnadir.Text = "Añadir";
            this.btnAnadir.UseVisualStyleBackColor = true;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(1025, 423);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(56, 27);
            this.btnVolver.TabIndex = 15;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtAtributo1
            // 
            this.txtAtributo1.Location = new System.Drawing.Point(108, 287);
            this.txtAtributo1.Margin = new System.Windows.Forms.Padding(2);
            this.txtAtributo1.Name = "txtAtributo1";
            this.txtAtributo1.Size = new System.Drawing.Size(306, 20);
            this.txtAtributo1.TabIndex = 12;
            // 
            // lblAtributo1
            // 
            this.lblAtributo1.Location = new System.Drawing.Point(21, 293);
            this.lblAtributo1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAtributo1.Name = "lblAtributo1";
            this.lblAtributo1.Size = new System.Drawing.Size(76, 14);
            this.lblAtributo1.TabIndex = 14;
            this.lblAtributo1.Text = "Atributo 1";
            this.lblAtributo1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtAtributo2
            // 
            this.txtAtributo2.Location = new System.Drawing.Point(108, 320);
            this.txtAtributo2.Margin = new System.Windows.Forms.Padding(2);
            this.txtAtributo2.Name = "txtAtributo2";
            this.txtAtributo2.Size = new System.Drawing.Size(306, 20);
            this.txtAtributo2.TabIndex = 16;
            this.txtAtributo2.Visible = false;
            // 
            // lblAtributo2
            // 
            this.lblAtributo2.Location = new System.Drawing.Point(21, 326);
            this.lblAtributo2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAtributo2.Name = "lblAtributo2";
            this.lblAtributo2.Size = new System.Drawing.Size(76, 14);
            this.lblAtributo2.TabIndex = 17;
            this.lblAtributo2.Text = "Atributo 2";
            this.lblAtributo2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblAtributo2.Visible = false;
            // 
            // listBoxInsertar
            // 
            this.listBoxInsertar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxInsertar.FormattingEnabled = true;
            this.listBoxInsertar.Location = new System.Drawing.Point(510, 24);
            this.listBoxInsertar.Name = "listBoxInsertar";
            this.listBoxInsertar.Size = new System.Drawing.Size(571, 342);
            this.listBoxInsertar.TabIndex = 18;
            // 
            // FormInsertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1104, 461);
            this.Controls.Add(this.listBoxInsertar);
            this.Controls.Add(this.txtAtributo2);
            this.Controls.Add(this.lblAtributo2);
            this.Controls.Add(this.txtAtributo1);
            this.Controls.Add(this.lblAtributo1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(this.groupBoxProducto);
            this.Controls.Add(this.lblCasaComercial);
            this.Controls.Add(this.comboBoxCasas);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblId);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormInsertar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInsertar";
            this.groupBoxProducto.ResumeLayout(false);
            this.groupBoxProducto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox comboBoxCasas;
        private System.Windows.Forms.Label lblCasaComercial;
        private System.Windows.Forms.RadioButton rbtnAlimentacion;
        private System.Windows.Forms.RadioButton rbtnCorporal;
        private System.Windows.Forms.RadioButton rbtnDeporte;
        private System.Windows.Forms.RadioButton rbtnSuplemento;
        private System.Windows.Forms.RadioButton rbtnEcologico;
        private System.Windows.Forms.RadioButton rbtnAdelgazante;
        private System.Windows.Forms.RadioButton rbtnIntolerancia;
        private System.Windows.Forms.GroupBox groupBoxProducto;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtAtributo1;
        private System.Windows.Forms.Label lblAtributo1;
        private System.Windows.Forms.TextBox txtAtributo2;
        private System.Windows.Forms.Label lblAtributo2;
        private System.Windows.Forms.ListBox listBoxInsertar;
    }
}