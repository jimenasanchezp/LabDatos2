using System.Drawing;
using System.Windows.Forms;

namespace LabDatos2
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

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.pnlAccent = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblSeccionRegistro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPosicion = new System.Windows.Forms.TextBox();
            this.divReg = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.divLote = new System.Windows.Forms.Panel();
            this.lblLote = new System.Windows.Forms.Label();
            this.txtTamañoLote = new System.Windows.Forms.TextBox();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.lblSeccionBusqueda = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuscarId = new System.Windows.Forms.TextBox();
            this.btnBuscarSecuencial = new System.Windows.Forms.Button();
            this.btnBuscarIndexado = new System.Windows.Forms.Button();
            this.divRes = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblTimingTitle = new System.Windows.Forms.Label();
            this.lblTiempoSecuencial = new System.Windows.Forms.Label();
            this.lblTiempoIndexado = new System.Windows.Forms.Label();
            this.divOps = new System.Windows.Forms.Panel();
            this.lblSeccionOps = new System.Windows.Forms.Label();
            this.btnMigrarSql = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.dgvCiudadanos = new System.Windows.Forms.DataGridView();
            this.sepLC = new System.Windows.Forms.Panel();
            this.sepCR = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudadanos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            this.pnlHeader.Controls.Add(this.pnlAccent);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1270, 70);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(20, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(271, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "El Arquitecto de Datos";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(175)))), ((int)(((byte)(190)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(22, 42);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(240, 20);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Gestión y búsqueda de ciudadanos";
            // 
            // pnlAccent
            // 
            this.pnlAccent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(100)))), ((int)(((byte)(130)))));
            this.pnlAccent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAccent.Location = new System.Drawing.Point(0, 67);
            this.pnlAccent.Name = "pnlAccent";
            this.pnlAccent.Size = new System.Drawing.Size(1270, 3);
            this.pnlAccent.TabIndex = 2;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.Controls.Add(this.lblSeccionRegistro);
            this.pnlLeft.Controls.Add(this.label1);
            this.pnlLeft.Controls.Add(this.txtId);
            this.pnlLeft.Controls.Add(this.label2);
            this.pnlLeft.Controls.Add(this.txtNombre);
            this.pnlLeft.Controls.Add(this.label3);
            this.pnlLeft.Controls.Add(this.txtEdad);
            this.pnlLeft.Controls.Add(this.label4);
            this.pnlLeft.Controls.Add(this.txtPosicion);
            this.pnlLeft.Controls.Add(this.divReg);
            this.pnlLeft.Controls.Add(this.btnGuardar);
            this.pnlLeft.Controls.Add(this.btnEditar);
            this.pnlLeft.Controls.Add(this.btnEliminar);
            this.pnlLeft.Controls.Add(this.btnCargar);
            this.pnlLeft.Controls.Add(this.btnVaciar);
            this.pnlLeft.Controls.Add(this.divLote);
            this.pnlLeft.Location = new System.Drawing.Point(12, 82);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(258, 500);
            this.pnlLeft.TabIndex = 1;
            // 
            // lblSeccionRegistro
            // 
            this.lblSeccionRegistro.AutoSize = true;
            this.lblSeccionRegistro.BackColor = System.Drawing.Color.Transparent;
            this.lblSeccionRegistro.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblSeccionRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(85)))), ((int)(((byte)(112)))));
            this.lblSeccionRegistro.Location = new System.Drawing.Point(16, 18);
            this.lblSeccionRegistro.Name = "lblSeccionRegistro";
            this.lblSeccionRegistro.Size = new System.Drawing.Size(75, 19);
            this.lblSeccionRegistro.TabIndex = 0;
            this.lblSeccionRegistro.Text = "REGISTRO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.label1.Location = new System.Drawing.Point(16, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(85)))), ((int)(((byte)(112)))));
            this.txtId.Location = new System.Drawing.Point(16, 62);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(224, 30);
            this.txtId.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.label2.Location = new System.Drawing.Point(16, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOMBRE";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.txtNombre.Location = new System.Drawing.Point(16, 116);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(224, 30);
            this.txtNombre.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.label3.Location = new System.Drawing.Point(16, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "EDAD";
            // 
            // txtEdad
            // 
            this.txtEdad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEdad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEdad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.txtEdad.Location = new System.Drawing.Point(16, 170);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(224, 30);
            this.txtEdad.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.label4.Location = new System.Drawing.Point(16, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "POSICIÓN";
            // 
            // txtPosicion
            // 
            this.txtPosicion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtPosicion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPosicion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPosicion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.txtPosicion.Location = new System.Drawing.Point(16, 224);
            this.txtPosicion.Name = "txtPosicion";
            this.txtPosicion.Size = new System.Drawing.Size(224, 30);
            this.txtPosicion.TabIndex = 3;
            // 
            // divReg
            // 
            this.divReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
            this.divReg.Location = new System.Drawing.Point(16, 264);
            this.divReg.Name = "divReg";
            this.divReg.Size = new System.Drawing.Size(224, 1);
            this.divReg.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(100)))), ((int)(((byte)(130)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(16, 276);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(224, 34);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar Registro";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(120)))), ((int)(((byte)(155)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(120)))), ((int)(((byte)(155)))));
            this.btnEditar.Location = new System.Drawing.Point(16, 320);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(108, 30);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.btnEliminar.Location = new System.Drawing.Point(132, 320);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(108, 30);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.White;
            this.btnCargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(85)))), ((int)(((byte)(112)))));
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnCargar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(85)))), ((int)(((byte)(112)))));
            this.btnCargar.Location = new System.Drawing.Point(16, 360);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(108, 30);
            this.btnCargar.TabIndex = 17;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            // 
            // btnVaciar
            // 
            this.btnVaciar.BackColor = System.Drawing.Color.White;
            this.btnVaciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVaciar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(85)))), ((int)(((byte)(112)))));
            this.btnVaciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVaciar.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnVaciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(85)))), ((int)(((byte)(112)))));
            this.btnVaciar.Location = new System.Drawing.Point(132, 360);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(108, 30);
            this.btnVaciar.TabIndex = 19;
            this.btnVaciar.Text = "Vaciar";
            this.btnVaciar.UseVisualStyleBackColor = false;
            // 
            // divLote
            // 
            this.divLote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
            this.divLote.Location = new System.Drawing.Point(16, 404);
            this.divLote.Name = "divLote";
            this.divLote.Size = new System.Drawing.Size(224, 1);
            this.divLote.TabIndex = 20;
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.BackColor = System.Drawing.Color.Transparent;
            this.lblLote.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblLote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lblLote.Location = new System.Drawing.Point(19, 371);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(128, 19);
            this.lblLote.TabIndex = 21;
            this.lblLote.Text = "TAMAÑO DE LOTE";
            // 
            // txtTamañoLote
            // 
            this.txtTamañoLote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtTamañoLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTamañoLote.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTamañoLote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.txtTamañoLote.Location = new System.Drawing.Point(16, 401);
            this.txtTamañoLote.Multiline = true;
            this.txtTamañoLote.Name = "txtTamañoLote";
            this.txtTamañoLote.Size = new System.Drawing.Size(224, 40);
            this.txtTamañoLote.TabIndex = 18;
            // 
            // pnlCenter
            // 
            this.pnlCenter.BackColor = System.Drawing.Color.White;
            this.pnlCenter.Controls.Add(this.lblSeccionBusqueda);
            this.pnlCenter.Controls.Add(this.label5);
            this.pnlCenter.Controls.Add(this.txtBuscarId);
            this.pnlCenter.Controls.Add(this.btnBuscarSecuencial);
            this.pnlCenter.Controls.Add(this.btnBuscarIndexado);
            this.pnlCenter.Controls.Add(this.divRes);
            this.pnlCenter.Controls.Add(this.lblResultado);
            this.pnlCenter.Controls.Add(this.lblTimingTitle);
            this.pnlCenter.Controls.Add(this.lblTiempoSecuencial);
            this.pnlCenter.Controls.Add(this.lblTiempoIndexado);
            this.pnlCenter.Controls.Add(this.divOps);
            this.pnlCenter.Controls.Add(this.lblSeccionOps);
            this.pnlCenter.Controls.Add(this.btnMigrarSql);
            this.pnlCenter.Controls.Add(this.txtTamañoLote);
            this.pnlCenter.Controls.Add(this.lblLote);
            this.pnlCenter.Location = new System.Drawing.Point(282, 82);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(258, 500);
            this.pnlCenter.TabIndex = 3;
            // 
            // lblSeccionBusqueda
            // 
            this.lblSeccionBusqueda.AutoSize = true;
            this.lblSeccionBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.lblSeccionBusqueda.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblSeccionBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(85)))), ((int)(((byte)(112)))));
            this.lblSeccionBusqueda.Location = new System.Drawing.Point(16, 18);
            this.lblSeccionBusqueda.Name = "lblSeccionBusqueda";
            this.lblSeccionBusqueda.Size = new System.Drawing.Size(84, 19);
            this.lblSeccionBusqueda.TabIndex = 0;
            this.lblSeccionBusqueda.Text = "BÚSQUEDA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.label5.Location = new System.Drawing.Point(16, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID A BUSCAR";
            // 
            // txtBuscarId
            // 
            this.txtBuscarId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtBuscarId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBuscarId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.txtBuscarId.Location = new System.Drawing.Point(16, 62);
            this.txtBuscarId.Name = "txtBuscarId";
            this.txtBuscarId.Size = new System.Drawing.Size(224, 30);
            this.txtBuscarId.TabIndex = 5;
            // 
            // btnBuscarSecuencial
            // 
            this.btnBuscarSecuencial.BackColor = System.Drawing.Color.White;
            this.btnBuscarSecuencial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarSecuencial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(120)))), ((int)(((byte)(155)))));
            this.btnBuscarSecuencial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarSecuencial.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnBuscarSecuencial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(120)))), ((int)(((byte)(155)))));
            this.btnBuscarSecuencial.Location = new System.Drawing.Point(16, 104);
            this.btnBuscarSecuencial.Name = "btnBuscarSecuencial";
            this.btnBuscarSecuencial.Size = new System.Drawing.Size(224, 32);
            this.btnBuscarSecuencial.TabIndex = 6;
            this.btnBuscarSecuencial.Text = "Búsqueda Secuencial";
            this.btnBuscarSecuencial.UseVisualStyleBackColor = false;
            // 
            // btnBuscarIndexado
            // 
            this.btnBuscarIndexado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.btnBuscarIndexado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarIndexado.FlatAppearance.BorderSize = 0;
            this.btnBuscarIndexado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarIndexado.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnBuscarIndexado.ForeColor = System.Drawing.Color.White;
            this.btnBuscarIndexado.Location = new System.Drawing.Point(16, 146);
            this.btnBuscarIndexado.Name = "btnBuscarIndexado";
            this.btnBuscarIndexado.Size = new System.Drawing.Size(224, 32);
            this.btnBuscarIndexado.TabIndex = 7;
            this.btnBuscarIndexado.Text = "Búsqueda Indexada";
            this.btnBuscarIndexado.UseVisualStyleBackColor = false;
            // 
            // divRes
            // 
            this.divRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
            this.divRes.Location = new System.Drawing.Point(16, 194);
            this.divRes.Name = "divRes";
            this.divRes.Size = new System.Drawing.Size(224, 1);
            this.divRes.TabIndex = 8;
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(85)))), ((int)(((byte)(112)))));
            this.lblResultado.Location = new System.Drawing.Point(16, 200);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(224, 42);
            this.lblResultado.TabIndex = 10;
            this.lblResultado.Text = "Esperando búsqueda...";
            // 
            // lblTimingTitle
            // 
            this.lblTimingTitle.AutoSize = true;
            this.lblTimingTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTimingTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblTimingTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(85)))), ((int)(((byte)(112)))));
            this.lblTimingTitle.Location = new System.Drawing.Point(16, 252);
            this.lblTimingTitle.Name = "lblTimingTitle";
            this.lblTimingTitle.Size = new System.Drawing.Size(168, 19);
            this.lblTimingTitle.TabIndex = 11;
            this.lblTimingTitle.Text = "TIEMPOS DE EJECUCIÓN";
            // 
            // lblTiempoSecuencial
            // 
            this.lblTiempoSecuencial.AutoSize = true;
            this.lblTiempoSecuencial.BackColor = System.Drawing.Color.Transparent;
            this.lblTiempoSecuencial.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTiempoSecuencial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lblTiempoSecuencial.Location = new System.Drawing.Point(16, 274);
            this.lblTiempoSecuencial.Name = "lblTiempoSecuencial";
            this.lblTiempoSecuencial.Size = new System.Drawing.Size(131, 20);
            this.lblTiempoSecuencial.TabIndex = 8;
            this.lblTiempoSecuencial.Text = "Secuencial:  0 ticks";
            // 
            // lblTiempoIndexado
            // 
            this.lblTiempoIndexado.AutoSize = true;
            this.lblTiempoIndexado.BackColor = System.Drawing.Color.Transparent;
            this.lblTiempoIndexado.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTiempoIndexado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.lblTiempoIndexado.Location = new System.Drawing.Point(16, 296);
            this.lblTiempoIndexado.Name = "lblTiempoIndexado";
            this.lblTiempoIndexado.Size = new System.Drawing.Size(130, 20);
            this.lblTiempoIndexado.TabIndex = 9;
            this.lblTiempoIndexado.Text = "Indexada:    0 ticks";
            // 
            // divOps
            // 
            this.divOps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
            this.divOps.Location = new System.Drawing.Point(16, 328);
            this.divOps.Name = "divOps";
            this.divOps.Size = new System.Drawing.Size(224, 1);
            this.divOps.TabIndex = 12;
            // 
            // lblSeccionOps
            // 
            this.lblSeccionOps.AutoSize = true;
            this.lblSeccionOps.BackColor = System.Drawing.Color.Transparent;
            this.lblSeccionOps.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblSeccionOps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(85)))), ((int)(((byte)(112)))));
            this.lblSeccionOps.Location = new System.Drawing.Point(16, 340);
            this.lblSeccionOps.Name = "lblSeccionOps";
            this.lblSeccionOps.Size = new System.Drawing.Size(105, 19);
            this.lblSeccionOps.TabIndex = 13;
            this.lblSeccionOps.Text = "OPERACIONES";
            // 
            // btnMigrarSql
            // 
            this.btnMigrarSql.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(110)))), ((int)(((byte)(140)))));
            this.btnMigrarSql.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMigrarSql.FlatAppearance.BorderSize = 0;
            this.btnMigrarSql.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMigrarSql.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnMigrarSql.ForeColor = System.Drawing.Color.White;
            this.btnMigrarSql.Location = new System.Drawing.Point(16, 449);
            this.btnMigrarSql.Name = "btnMigrarSql";
            this.btnMigrarSql.Size = new System.Drawing.Size(224, 32);
            this.btnMigrarSql.TabIndex = 11;
            this.btnMigrarSql.Text = "Migrar a SQL Server";
            this.btnMigrarSql.UseVisualStyleBackColor = false;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Controls.Add(this.label6);
            this.pnlRight.Controls.Add(this.btnMostrarDatos);
            this.pnlRight.Controls.Add(this.dgvCiudadanos);
            this.pnlRight.Location = new System.Drawing.Point(552, 82);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(706, 500);
            this.pnlRight.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(85)))), ((int)(((byte)(112)))));
            this.label6.Location = new System.Drawing.Point(16, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "DATOS DE CIUDADANOS";
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(100)))), ((int)(((byte)(130)))));
            this.btnMostrarDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarDatos.FlatAppearance.BorderSize = 0;
            this.btnMostrarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarDatos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMostrarDatos.ForeColor = System.Drawing.Color.White;
            this.btnMostrarDatos.Location = new System.Drawing.Point(558, 12);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(130, 32);
            this.btnMostrarDatos.TabIndex = 14;
            this.btnMostrarDatos.Text = "Mostrar Datos";
            this.btnMostrarDatos.UseVisualStyleBackColor = false;
            // 
            // dgvCiudadanos
            // 
            this.dgvCiudadanos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCiudadanos.Location = new System.Drawing.Point(16, 52);
            this.dgvCiudadanos.Name = "dgvCiudadanos";
            this.dgvCiudadanos.RowHeadersWidth = 51;
            this.dgvCiudadanos.Size = new System.Drawing.Size(672, 436);
            this.dgvCiudadanos.TabIndex = 12;
            // 
            // sepLC
            // 
            this.sepLC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.sepLC.Location = new System.Drawing.Point(270, 82);
            this.sepLC.Name = "sepLC";
            this.sepLC.Size = new System.Drawing.Size(12, 500);
            this.sepLC.TabIndex = 2;
            // 
            // sepCR
            // 
            this.sepCR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.sepCR.Location = new System.Drawing.Point(540, 82);
            this.sepCR.Name = "sepCR";
            this.sepCR.Size = new System.Drawing.Size(12, 500);
            this.sepCR.TabIndex = 4;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1270, 594);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.sepLC);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.sepCR);
            this.Controls.Add(this.pnlRight);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "Form1";
            this.Text = "El Arquitecto de Datos";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenter.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudadanos)).EndInit();
            this.ResumeLayout(false);

        }

        // ══════════════════════════════════════════════════════════════
        //  TABLA  —  ConfigurarDisenoTabla (llamado desde Form1.cs)
        // ══════════════════════════════════════════════════════════════
        private void ConfigurarDisenoTabla()
        {
            dgvCiudadanos.AutoGenerateColumns = false;
            dgvCiudadanos.Columns.Clear();

            dgvCiudadanos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "IdProp",
                HeaderText = "ID",
                Width = 65,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });
            dgvCiudadanos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreProp",
                HeaderText = "Nombre Completo",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvCiudadanos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EdadProp",
                HeaderText = "Edad",
                Width = 80,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            dgvCiudadanos.AllowUserToAddRows = false;
            dgvCiudadanos.ReadOnly = true;
            dgvCiudadanos.RowHeadersVisible = false;
            dgvCiudadanos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCiudadanos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCiudadanos.BackgroundColor = Color.White;
            dgvCiudadanos.GridColor = Color.FromArgb(228, 210, 220);

            dgvCiudadanos.DefaultCellStyle.BackColor = Color.White;
            dgvCiudadanos.DefaultCellStyle.ForeColor = Color.FromArgb(60, 45, 55);
            dgvCiudadanos.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgvCiudadanos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(188, 100, 130);
            dgvCiudadanos.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvCiudadanos.EnableHeadersVisualStyles = false;
            dgvCiudadanos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(80, 50, 70);
            dgvCiudadanos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCiudadanos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvCiudadanos.ColumnHeadersHeight = 36;

            dgvCiudadanos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(253, 247, 250);
            dgvCiudadanos.RowTemplate.Height = 30;
        }

        // ── Campos privados ──────────────────────────────────────────
        private Panel pnlHeader;
        private Panel pnlLeft;
        private Panel pnlCenter;
        private Panel pnlRight;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblSeccionRegistro;
        private Label lblSeccionBusqueda;
        private Label lblSeccionOps;
        private Label lblLote;

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtPosicion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtBuscarId;
        private System.Windows.Forms.Button btnBuscarSecuencial;
        private System.Windows.Forms.Button btnBuscarIndexado;
        private System.Windows.Forms.Label lblTiempoSecuencial;
        private System.Windows.Forms.Label lblTiempoIndexado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnMigrarSql;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DataGridView dgvCiudadanos;
        private Label label6;
        private Button btnMostrarDatos;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnCargar;
        private TextBox txtTamañoLote;
        private Button btnVaciar;
        private Panel pnlAccent;
        private Panel divReg;
        private Panel divLote;
        private Panel divRes;
        private Label lblTimingTitle;
        private Panel divOps;
        private Panel sepLC;
        private Panel sepCR;
    }
}