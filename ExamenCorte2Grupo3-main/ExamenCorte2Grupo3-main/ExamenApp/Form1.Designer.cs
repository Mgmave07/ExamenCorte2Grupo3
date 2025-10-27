namespace ExamenApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.cmbUrgencia = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lbNormal = new System.Windows.Forms.ListBox();
            this.lbUrgencia = new System.Windows.Forms.ListBox();
            this.btnAtender = new System.Windows.Forms.Button();
            this.lblAtendiendo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del paciente:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(148, 41);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(194, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // cmbUrgencia
            // 
            this.cmbUrgencia.FormattingEnabled = true;
            this.cmbUrgencia.Items.AddRange(new object[] {
            "Normal",
            "Emergencia"});
            this.cmbUrgencia.Location = new System.Drawing.Point(148, 75);
            this.cmbUrgencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbUrgencia.Name = "cmbUrgencia";
            this.cmbUrgencia.Size = new System.Drawing.Size(146, 21);
            this.cmbUrgencia.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(136, 112);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 20);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar paciente";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lbNormal
            // 
            this.lbNormal.FormattingEnabled = true;
            this.lbNormal.Location = new System.Drawing.Point(52, 173);
            this.lbNormal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbNormal.Name = "lbNormal";
            this.lbNormal.Size = new System.Drawing.Size(112, 212);
            this.lbNormal.TabIndex = 4;
            // 
            // lbUrgencia
            // 
            this.lbUrgencia.FormattingEnabled = true;
            this.lbUrgencia.Location = new System.Drawing.Point(298, 173);
            this.lbUrgencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbUrgencia.Name = "lbUrgencia";
            this.lbUrgencia.Size = new System.Drawing.Size(110, 212);
            this.lbUrgencia.TabIndex = 5;
            // 
            // btnAtender
            // 
            this.btnAtender.Location = new System.Drawing.Point(256, 114);
            this.btnAtender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(86, 19);
            this.btnAtender.TabIndex = 6;
            this.btnAtender.Text = "Atender Paciente";
            this.btnAtender.UseVisualStyleBackColor = true;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // lblAtendiendo
            // 
            this.lblAtendiendo.AutoSize = true;
            this.lblAtendiendo.Location = new System.Drawing.Point(9, 148);
            this.lblAtendiendo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAtendiendo.Name = "lblAtendiendo";
            this.lblAtendiendo.Size = new System.Drawing.Size(97, 13);
            this.lblAtendiendo.TabIndex = 7;
            this.lblAtendiendo.Text = "Paciente Atendido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tipo de paciente:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 427);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAtendiendo);
            this.Controls.Add(this.btnAtender);
            this.Controls.Add(this.lbUrgencia);
            this.Controls.Add(this.lbNormal);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbUrgencia);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Gestión de Pacientes - Urgencias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.ComboBox cmbUrgencia;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lbNormal;
        private System.Windows.Forms.ListBox lbUrgencia;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.Label lblAtendiendo;
        private System.Windows.Forms.Label label2;
    }
}


