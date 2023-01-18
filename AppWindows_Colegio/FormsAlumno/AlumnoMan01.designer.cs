
using System;

namespace AppWindows_Colegio
{
    partial class AlumnoMan01Gnral
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnTopAlumnoGnral = new System.Windows.Forms.DataGridView();
            this.IdAlumnoGnral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoGnral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombresGnral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidosGnral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentoIdentidadGnral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimientoGnral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SexoGnral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CiudadGnral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionGnral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1Gnral = new System.Windows.Forms.Label();
            this.lblRegistrosGneral = new System.Windows.Forms.Label();
            this.label2Gnral = new System.Windows.Forms.Label();
            this.txtFiltroGnral = new System.Windows.Forms.TextBox();
            this.btnInsertarGnral = new System.Windows.Forms.Button();
            this.btnActualizarGnral = new System.Windows.Forms.Button();
            this.btnEliminarGnral = new System.Windows.Forms.Button();
            this.btnRegistrarNotas = new System.Windows.Forms.Button();
            this.btnVerNotas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnTopAlumnoGnral)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTopAlumnoGnral
            // 
            this.btnTopAlumnoGnral.AllowUserToAddRows = false;
            this.btnTopAlumnoGnral.AllowUserToDeleteRows = false;
            this.btnTopAlumnoGnral.AllowUserToResizeColumns = false;
            this.btnTopAlumnoGnral.AllowUserToResizeRows = false;
            this.btnTopAlumnoGnral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTopAlumnoGnral.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.btnTopAlumnoGnral.BackgroundColor = System.Drawing.Color.Snow;
            this.btnTopAlumnoGnral.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnTopAlumnoGnral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.btnTopAlumnoGnral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAlumnoGnral,
            this.CodigoGnral,
            this.NombresGnral,
            this.ApellidosGnral,
            this.DocumentoIdentidadGnral,
            this.FechaNacimientoGnral,
            this.SexoGnral,
            this.CiudadGnral,
            this.DireccionGnral});
            this.btnTopAlumnoGnral.GridColor = System.Drawing.SystemColors.ControlLight;
            this.btnTopAlumnoGnral.Location = new System.Drawing.Point(26, 63);
            this.btnTopAlumnoGnral.MultiSelect = false;
            this.btnTopAlumnoGnral.Name = "btnTopAlumnoGnral";
            this.btnTopAlumnoGnral.ReadOnly = true;
            this.btnTopAlumnoGnral.RowHeadersVisible = false;
            this.btnTopAlumnoGnral.RowHeadersWidth = 51;
            this.btnTopAlumnoGnral.Size = new System.Drawing.Size(878, 422);
            this.btnTopAlumnoGnral.TabIndex = 0;
            // 
            // IdAlumnoGnral
            // 
            this.IdAlumnoGnral.DataPropertyName = "Mvarid_alumno";
            this.IdAlumnoGnral.FillWeight = 48.76091F;
            this.IdAlumnoGnral.HeaderText = "ID";
            this.IdAlumnoGnral.MinimumWidth = 6;
            this.IdAlumnoGnral.Name = "IdAlumnoGnral";
            this.IdAlumnoGnral.ReadOnly = true;
            // 
            // CodigoGnral
            // 
            this.CodigoGnral.DataPropertyName = "Mvarcod_al";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CodigoGnral.DefaultCellStyle = dataGridViewCellStyle1;
            this.CodigoGnral.FillWeight = 85.13406F;
            this.CodigoGnral.HeaderText = "Codigo";
            this.CodigoGnral.MinimumWidth = 6;
            this.CodigoGnral.Name = "CodigoGnral";
            this.CodigoGnral.ReadOnly = true;
            // 
            // NombresGnral
            // 
            this.NombresGnral.DataPropertyName = "Mvarnom_al";
            this.NombresGnral.FillWeight = 113.9786F;
            this.NombresGnral.HeaderText = "Nombres";
            this.NombresGnral.MinimumWidth = 6;
            this.NombresGnral.Name = "NombresGnral";
            this.NombresGnral.ReadOnly = true;
            // 
            // ApellidosGnral
            // 
            this.ApellidosGnral.DataPropertyName = "Mvarape_al";
            this.ApellidosGnral.FillWeight = 113.9786F;
            this.ApellidosGnral.HeaderText = "Apellidos";
            this.ApellidosGnral.MinimumWidth = 6;
            this.ApellidosGnral.Name = "ApellidosGnral";
            this.ApellidosGnral.ReadOnly = true;
            // 
            // DocumentoIdentidadGnral
            // 
            this.DocumentoIdentidadGnral.DataPropertyName = "Mvardocide_al";
            this.DocumentoIdentidadGnral.FillWeight = 82.23352F;
            this.DocumentoIdentidadGnral.HeaderText = "DNI";
            this.DocumentoIdentidadGnral.MinimumWidth = 6;
            this.DocumentoIdentidadGnral.Name = "DocumentoIdentidadGnral";
            this.DocumentoIdentidadGnral.ReadOnly = true;
            // 
            // FechaNacimientoGnral
            // 
            this.FechaNacimientoGnral.DataPropertyName = "Mvarfecnac_al";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "d";
            this.FechaNacimientoGnral.DefaultCellStyle = dataGridViewCellStyle2;
            this.FechaNacimientoGnral.FillWeight = 113.9786F;
            this.FechaNacimientoGnral.HeaderText = "Fecha Nacimiento";
            this.FechaNacimientoGnral.MinimumWidth = 6;
            this.FechaNacimientoGnral.Name = "FechaNacimientoGnral";
            this.FechaNacimientoGnral.ReadOnly = true;
            // 
            // SexoGnral
            // 
            this.SexoGnral.DataPropertyName = "Mvarsex_al";
            this.SexoGnral.FillWeight = 113.9786F;
            this.SexoGnral.HeaderText = "Sexo";
            this.SexoGnral.MinimumWidth = 6;
            this.SexoGnral.Name = "SexoGnral";
            this.SexoGnral.ReadOnly = true;
            // 
            // CiudadGnral
            // 
            this.CiudadGnral.DataPropertyName = "Mvarnom_distrito";
            this.CiudadGnral.FillWeight = 113.9786F;
            this.CiudadGnral.HeaderText = "Ciudad";
            this.CiudadGnral.MinimumWidth = 6;
            this.CiudadGnral.Name = "CiudadGnral";
            this.CiudadGnral.ReadOnly = true;
            // 
            // DireccionGnral
            // 
            this.DireccionGnral.DataPropertyName = "Mvardir_al";
            this.DireccionGnral.FillWeight = 113.9786F;
            this.DireccionGnral.HeaderText = "Direccion";
            this.DireccionGnral.MinimumWidth = 6;
            this.DireccionGnral.Name = "DireccionGnral";
            this.DireccionGnral.ReadOnly = true;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSalir.Location = new System.Drawing.Point(930, 431);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(126, 38);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Volver al inicio";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1Gnral
            // 
            this.label1Gnral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1Gnral.AutoSize = true;
            this.label1Gnral.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label1Gnral.Location = new System.Drawing.Point(732, 502);
            this.label1Gnral.Name = "label1Gnral";
            this.label1Gnral.Size = new System.Drawing.Size(107, 15);
            this.label1Gnral.TabIndex = 5;
            this.label1Gnral.Text = "Registros totales:";
            // 
            // lblRegistrosGneral
            // 
            this.lblRegistrosGneral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistrosGneral.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRegistrosGneral.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblRegistrosGneral.Location = new System.Drawing.Point(850, 498);
            this.lblRegistrosGneral.Name = "lblRegistrosGneral";
            this.lblRegistrosGneral.Size = new System.Drawing.Size(54, 20);
            this.lblRegistrosGneral.TabIndex = 6;
            // 
            // label2Gnral
            // 
            this.label2Gnral.AutoSize = true;
            this.label2Gnral.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label2Gnral.Location = new System.Drawing.Point(26, 24);
            this.label2Gnral.Name = "label2Gnral";
            this.label2Gnral.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.label2Gnral.Size = new System.Drawing.Size(153, 21);
            this.label2Gnral.TabIndex = 7;
            this.label2Gnral.Text = "Ingrese inicial de apellido:";
            // 
            // txtFiltroGnral
            // 
            this.txtFiltroGnral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltroGnral.Location = new System.Drawing.Point(185, 25);
            this.txtFiltroGnral.Name = "txtFiltroGnral";
            this.txtFiltroGnral.Size = new System.Drawing.Size(329, 20);
            this.txtFiltroGnral.TabIndex = 8;
            this.txtFiltroGnral.TextChanged += new System.EventHandler(this.txtFiltroGnral_TextChanged);
            // 
            // btnInsertarGnral
            // 
            this.btnInsertarGnral.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInsertarGnral.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarGnral.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnInsertarGnral.Location = new System.Drawing.Point(928, 78);
            this.btnInsertarGnral.Name = "btnInsertarGnral";
            this.btnInsertarGnral.Size = new System.Drawing.Size(128, 39);
            this.btnInsertarGnral.TabIndex = 1;
            this.btnInsertarGnral.Text = "Registrar alumno";
            this.btnInsertarGnral.UseVisualStyleBackColor = false;
            this.btnInsertarGnral.Click += new System.EventHandler(this.btnInsertarGnral_Click);
            // 
            // btnActualizarGnral
            // 
            this.btnActualizarGnral.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnActualizarGnral.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarGnral.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnActualizarGnral.Location = new System.Drawing.Point(930, 123);
            this.btnActualizarGnral.Name = "btnActualizarGnral";
            this.btnActualizarGnral.Size = new System.Drawing.Size(126, 41);
            this.btnActualizarGnral.TabIndex = 2;
            this.btnActualizarGnral.Text = "Actualizar datos";
            this.btnActualizarGnral.UseVisualStyleBackColor = false;
            this.btnActualizarGnral.Click += new System.EventHandler(this.btnActualizarGnral_Click);
            // 
            // btnEliminarGnral
            // 
            this.btnEliminarGnral.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarGnral.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminarGnral.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnEliminarGnral.Location = new System.Drawing.Point(930, 170);
            this.btnEliminarGnral.Name = "btnEliminarGnral";
            this.btnEliminarGnral.Size = new System.Drawing.Size(126, 40);
            this.btnEliminarGnral.TabIndex = 4;
            this.btnEliminarGnral.Text = "Cambiar estado";
            this.btnEliminarGnral.UseVisualStyleBackColor = false;
            this.btnEliminarGnral.Click += new System.EventHandler(this.btnEliminarGnral_Click);
            // 
            // btnRegistrarNotas
            // 
            this.btnRegistrarNotas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistrarNotas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarNotas.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnRegistrarNotas.Location = new System.Drawing.Point(930, 253);
            this.btnRegistrarNotas.Name = "btnRegistrarNotas";
            this.btnRegistrarNotas.Size = new System.Drawing.Size(126, 39);
            this.btnRegistrarNotas.TabIndex = 10;
            this.btnRegistrarNotas.Text = "Registrar Notas";
            this.btnRegistrarNotas.UseVisualStyleBackColor = false;
            this.btnRegistrarNotas.Click += new System.EventHandler(this.btnRegistrarNotas_Click);
            // 
            // btnVerNotas
            // 
            this.btnVerNotas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVerNotas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnVerNotas.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnVerNotas.Location = new System.Drawing.Point(930, 298);
            this.btnVerNotas.Name = "btnVerNotas";
            this.btnVerNotas.Size = new System.Drawing.Size(126, 39);
            this.btnVerNotas.TabIndex = 10;
            this.btnVerNotas.Text = "Ver Notas";
            this.btnVerNotas.UseVisualStyleBackColor = false;
            this.btnVerNotas.Click += new System.EventHandler(this.btnVerNotas_Click);
            // 
            // AlumnoMan01Gnral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1074, 530);
            this.Controls.Add(this.btnVerNotas);
            this.Controls.Add(this.btnRegistrarNotas);
            this.Controls.Add(this.btnInsertarGnral);
            this.Controls.Add(this.txtFiltroGnral);
            this.Controls.Add(this.label2Gnral);
            this.Controls.Add(this.lblRegistrosGneral);
            this.Controls.Add(this.label1Gnral);
            this.Controls.Add(this.btnEliminarGnral);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizarGnral);
            this.Controls.Add(this.btnTopAlumnoGnral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlumnoMan01Gnral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Alumnos";
            this.Load += new System.EventHandler(this.AlumnoMan01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnTopAlumnoGnral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView btnTopAlumnoGnral;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1Gnral;
        private System.Windows.Forms.Label lblRegistrosGneral;
        private System.Windows.Forms.Label label2Gnral;
        private System.Windows.Forms.TextBox txtFiltroGnral;
        private System.Windows.Forms.Button btnInsertarGnral;
        private System.Windows.Forms.Button btnActualizarGnral;
        private System.Windows.Forms.Button btnEliminarGnral;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAlumnoGnral;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoGnral;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombresGnral;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidosGnral;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentoIdentidadGnral;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimientoGnral;
        private System.Windows.Forms.DataGridViewTextBoxColumn SexoGnral;
        private System.Windows.Forms.DataGridViewTextBoxColumn CiudadGnral;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionGnral;
        private System.Windows.Forms.Button btnRegistrarNotas;
        private System.Windows.Forms.Button btnVerNotas;
    }
}