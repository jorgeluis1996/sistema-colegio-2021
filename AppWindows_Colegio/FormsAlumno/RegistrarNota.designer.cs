
namespace AppWindows_Colegio
{
    partial class RegistarNotas
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
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.txtRetro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.cbxfinal = new System.Windows.Forms.ComboBox();
            this.cbxnota3 = new System.Windows.Forms.ComboBox();
            this.cbxnota2 = new System.Windows.Forms.ComboBox();
            this.cbxNota1 = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cursoBEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.txtRetro);
            this.grpDatos.Controls.Add(this.label8);
            this.grpDatos.Controls.Add(this.cboPeriodo);
            this.grpDatos.Controls.Add(this.cboCurso);
            this.grpDatos.Controls.Add(this.cbxfinal);
            this.grpDatos.Controls.Add(this.cbxnota3);
            this.grpDatos.Controls.Add(this.cbxnota2);
            this.grpDatos.Controls.Add(this.cbxNota1);
            this.grpDatos.Controls.Add(this.lblName);
            this.grpDatos.Controls.Add(this.lblCodigo);
            this.grpDatos.Controls.Add(this.label10);
            this.grpDatos.Controls.Add(this.label6);
            this.grpDatos.Controls.Add(this.label7);
            this.grpDatos.Controls.Add(this.label2);
            this.grpDatos.Controls.Add(this.label1);
            this.grpDatos.Controls.Add(this.label3);
            this.grpDatos.Controls.Add(this.label4);
            this.grpDatos.Controls.Add(this.label5);
            this.grpDatos.Controls.Add(this.btnGuardar);
            this.grpDatos.Controls.Add(this.btnCancelar);
            this.grpDatos.Location = new System.Drawing.Point(12, 12);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(488, 318);
            this.grpDatos.TabIndex = 2;
            this.grpDatos.TabStop = false;
            this.grpDatos.Enter += new System.EventHandler(this.grpDatos_Enter);
            // 
            // txtRetro
            // 
            this.txtRetro.Location = new System.Drawing.Point(143, 217);
            this.txtRetro.Name = "txtRetro";
            this.txtRetro.Size = new System.Drawing.Size(312, 20);
            this.txtRetro.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(23, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 15);
            this.label8.TabIndex = 32;
            this.label8.Text = "Retroalimentación:";
            // 
            // cboCurso
            // 
            this.cboCurso.DisplayMember = "IdCurso";
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(73, 80);
            this.cboCurso.Margin = new System.Windows.Forms.Padding(2);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(145, 21);
            this.cboCurso.TabIndex = 30;
            this.cboCurso.ValueMember = "IdCurso";
            // 
            // cbxfinal
            // 
            this.cbxfinal.FormattingEnabled = true;
            this.cbxfinal.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbxfinal.Location = new System.Drawing.Point(307, 159);
            this.cbxfinal.Margin = new System.Windows.Forms.Padding(2);
            this.cbxfinal.Name = "cbxfinal";
            this.cbxfinal.Size = new System.Drawing.Size(92, 21);
            this.cbxfinal.TabIndex = 26;
            // 
            // cbxnota3
            // 
            this.cbxnota3.FormattingEnabled = true;
            this.cbxnota3.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbxnota3.Location = new System.Drawing.Point(307, 126);
            this.cbxnota3.Margin = new System.Windows.Forms.Padding(2);
            this.cbxnota3.Name = "cbxnota3";
            this.cbxnota3.Size = new System.Drawing.Size(92, 21);
            this.cbxnota3.TabIndex = 26;
            // 
            // cbxnota2
            // 
            this.cbxnota2.FormattingEnabled = true;
            this.cbxnota2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbxnota2.Location = new System.Drawing.Point(126, 159);
            this.cbxnota2.Margin = new System.Windows.Forms.Padding(2);
            this.cbxnota2.Name = "cbxnota2";
            this.cbxnota2.Size = new System.Drawing.Size(92, 21);
            this.cbxnota2.TabIndex = 26;
            // 
            // cbxNota1
            // 
            this.cbxNota1.FormattingEnabled = true;
            this.cbxNota1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbxNota1.Location = new System.Drawing.Point(126, 126);
            this.cbxNota1.Margin = new System.Windows.Forms.Padding(2);
            this.cbxNota1.Name = "cbxNota1";
            this.cbxNota1.Size = new System.Drawing.Size(92, 21);
            this.cbxNota1.TabIndex = 26;
            // 
            // lblName
            // 
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblName.Location = new System.Drawing.Point(224, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(243, 20);
            this.lblName.TabIndex = 24;
            // 
            // lblCodigo
            // 
            this.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCodigo.Location = new System.Drawing.Point(73, 30);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(64, 20);
            this.lblCodigo.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(164, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Nombre:";
            this.label10.Click += new System.EventHandler(this.label6_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(17, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Codigo:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(251, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "FINAL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(251, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "EP3:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(70, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "EP2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(70, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "EP1:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(17, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Curso:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Location = new System.Drawing.Point(256, 264);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(94, 26);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(361, 264);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 26);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cursoBEBindingSource
            // 
            this.cursoBEBindingSource.DataSource = typeof(AppWindows_Colegio.ProxyCurso.CursoBE);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(251, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Periodo:";
            // 
            // cboPeriodo
            // 
            this.cboPeriodo.DisplayMember = "IdCurso";
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Location = new System.Drawing.Point(310, 78);
            this.cboPeriodo.Margin = new System.Windows.Forms.Padding(2);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(145, 21);
            this.cboPeriodo.TabIndex = 30;
            this.cboPeriodo.ValueMember = "IdCurso";
            // 
            // RegistarNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 349);
            this.Controls.Add(this.grpDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistarNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Nota";
            this.Load += new System.EventHandler(this.RegistarNotas_Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxNota1;
        private System.Windows.Forms.ComboBox cboCurso;
        internal System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource cursoBEBindingSource;
        private System.Windows.Forms.ComboBox cbxfinal;
        private System.Windows.Forms.ComboBox cbxnota3;
        private System.Windows.Forms.ComboBox cbxnota2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRetro;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Button btnGuardar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cboPeriodo;
        internal System.Windows.Forms.Label label4;
    }
}