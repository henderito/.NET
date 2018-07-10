using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TP1_Henderson
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPersona = new System.Windows.Forms.TabPage();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rdbMasc = new System.Windows.Forms.RadioButton();
            this.rdbFem = new System.Windows.Forms.RadioButton();
            this.chkPop = new System.Windows.Forms.CheckBox();
            this.chkIndie = new System.Windows.Forms.CheckBox();
            this.chkMetal = new System.Windows.Forms.CheckBox();
            this.chkTrance = new System.Windows.Forms.CheckBox();
            this.chkReggea = new System.Windows.Forms.CheckBox();
            this.chkRock = new System.Windows.Forms.CheckBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.tabObjetos = new System.Windows.Forms.TabPage();
            this.listDerecha = new System.Windows.Forms.ListBox();
            this.btnDeleteItemRight = new System.Windows.Forms.Button();
            this.btnAllToRight = new System.Windows.Forms.Button();
            this.btnToRight = new System.Windows.Forms.Button();
            this.btnToLeft = new System.Windows.Forms.Button();
            this.listIzquierda = new System.Windows.Forms.ListBox();
            this.btnCarga = new System.Windows.Forms.Button();
            this.txtCarga = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPersona.SuspendLayout();
            this.gbSexo.SuspendLayout();
            this.tabObjetos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPersona);
            this.tabControl1.Controls.Add(this.tabObjetos);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(467, 341);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPersona
            // 
            this.tabPersona.Controls.Add(this.gbSexo);
            this.tabPersona.Controls.Add(this.chkPop);
            this.tabPersona.Controls.Add(this.chkIndie);
            this.tabPersona.Controls.Add(this.chkMetal);
            this.tabPersona.Controls.Add(this.chkTrance);
            this.tabPersona.Controls.Add(this.chkReggea);
            this.tabPersona.Controls.Add(this.chkRock);
            this.tabPersona.Controls.Add(this.dtpFechaNac);
            this.tabPersona.Controls.Add(this.btnAceptar);
            this.tabPersona.Controls.Add(this.label7);
            this.tabPersona.Controls.Add(this.label6);
            this.tabPersona.Controls.Add(this.cmbColor);
            this.tabPersona.Controls.Add(this.label5);
            this.tabPersona.Controls.Add(this.lblEdad);
            this.tabPersona.Controls.Add(this.label3);
            this.tabPersona.Controls.Add(this.label2);
            this.tabPersona.Controls.Add(this.txtApellido);
            this.tabPersona.Controls.Add(this.label1);
            this.tabPersona.Controls.Add(this.txtNombre);
            this.tabPersona.Location = new System.Drawing.Point(4, 22);
            this.tabPersona.Name = "tabPersona";
            this.tabPersona.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersona.Size = new System.Drawing.Size(459, 315);
            this.tabPersona.TabIndex = 0;
            this.tabPersona.Text = "Carga de Personas";
            this.tabPersona.UseVisualStyleBackColor = true;
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rdbMasc);
            this.gbSexo.Controls.Add(this.rdbFem);
            this.gbSexo.Location = new System.Drawing.Point(95, 91);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(99, 58);
            this.gbSexo.TabIndex = 23;
            this.gbSexo.TabStop = false;
            // 
            // rdbMasc
            // 
            this.rdbMasc.AutoSize = true;
            this.rdbMasc.Checked = true;
            this.rdbMasc.Location = new System.Drawing.Point(6, 9);
            this.rdbMasc.Name = "rdbMasc";
            this.rdbMasc.Size = new System.Drawing.Size(73, 17);
            this.rdbMasc.TabIndex = 8;
            this.rdbMasc.TabStop = true;
            this.rdbMasc.Text = "Masculino";
            this.rdbMasc.UseVisualStyleBackColor = true;
            // 
            // rdbFem
            // 
            this.rdbFem.AutoSize = true;
            this.rdbFem.Location = new System.Drawing.Point(6, 32);
            this.rdbFem.Name = "rdbFem";
            this.rdbFem.Size = new System.Drawing.Size(71, 17);
            this.rdbFem.TabIndex = 9;
            this.rdbFem.TabStop = true;
            this.rdbFem.Text = "Femenino";
            this.rdbFem.UseVisualStyleBackColor = true;
            // 
            // chkPop
            // 
            this.chkPop.AutoSize = true;
            this.chkPop.Location = new System.Drawing.Point(182, 175);
            this.chkPop.Name = "chkPop";
            this.chkPop.Size = new System.Drawing.Size(45, 17);
            this.chkPop.TabIndex = 22;
            this.chkPop.Text = "Pop";
            this.chkPop.UseVisualStyleBackColor = true;
            // 
            // chkIndie
            // 
            this.chkIndie.AutoSize = true;
            this.chkIndie.Location = new System.Drawing.Point(182, 155);
            this.chkIndie.Name = "chkIndie";
            this.chkIndie.Size = new System.Drawing.Size(49, 17);
            this.chkIndie.TabIndex = 21;
            this.chkIndie.Text = "Indie";
            this.chkIndie.UseVisualStyleBackColor = true;
            // 
            // chkMetal
            // 
            this.chkMetal.AutoSize = true;
            this.chkMetal.Location = new System.Drawing.Point(96, 224);
            this.chkMetal.Name = "chkMetal";
            this.chkMetal.Size = new System.Drawing.Size(52, 17);
            this.chkMetal.TabIndex = 20;
            this.chkMetal.Text = "Metal";
            this.chkMetal.UseVisualStyleBackColor = true;
            // 
            // chkTrance
            // 
            this.chkTrance.AutoSize = true;
            this.chkTrance.Location = new System.Drawing.Point(96, 201);
            this.chkTrance.Name = "chkTrance";
            this.chkTrance.Size = new System.Drawing.Size(60, 17);
            this.chkTrance.TabIndex = 19;
            this.chkTrance.Text = "Trance";
            this.chkTrance.UseVisualStyleBackColor = true;
            // 
            // chkReggea
            // 
            this.chkReggea.AutoSize = true;
            this.chkReggea.Location = new System.Drawing.Point(96, 178);
            this.chkReggea.Name = "chkReggea";
            this.chkReggea.Size = new System.Drawing.Size(64, 17);
            this.chkReggea.TabIndex = 18;
            this.chkReggea.Text = "Reggea";
            this.chkReggea.UseVisualStyleBackColor = true;
            // 
            // chkRock
            // 
            this.chkRock.AutoSize = true;
            this.chkRock.Location = new System.Drawing.Point(96, 155);
            this.chkRock.Name = "chkRock";
            this.chkRock.Size = new System.Drawing.Size(52, 17);
            this.chkRock.TabIndex = 17;
            this.chkRock.Text = "Rock";
            this.chkRock.UseVisualStyleBackColor = true;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNac.Location = new System.Drawing.Point(95, 65);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaNac.TabIndex = 16;
            this.dtpFechaNac.ValueChanged += new System.EventHandler(this.calcularEdad);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(296, 169);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnClickAceptar);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Color Favorito:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Estilo Musical:";
            // 
            // cmbColor
            // 
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(95, 253);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(121, 21);
            this.cmbColor.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sexo:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(216, 68);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(38, 13);
            this.lblEdad.TabIndex = 7;
            this.lblEdad.Text = "Edad: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de Nac:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(95, 37);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(95, 11);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // tabObjetos
            // 
            this.tabObjetos.Controls.Add(this.listDerecha);
            this.tabObjetos.Controls.Add(this.btnDeleteItemRight);
            this.tabObjetos.Controls.Add(this.btnAllToRight);
            this.tabObjetos.Controls.Add(this.btnToRight);
            this.tabObjetos.Controls.Add(this.btnToLeft);
            this.tabObjetos.Controls.Add(this.listIzquierda);
            this.tabObjetos.Controls.Add(this.btnCarga);
            this.tabObjetos.Controls.Add(this.txtCarga);
            this.tabObjetos.Location = new System.Drawing.Point(4, 22);
            this.tabObjetos.Name = "tabObjetos";
            this.tabObjetos.Padding = new System.Windows.Forms.Padding(3);
            this.tabObjetos.Size = new System.Drawing.Size(459, 315);
            this.tabObjetos.TabIndex = 1;
            this.tabObjetos.Text = "Listado de Objetos";
            this.tabObjetos.UseVisualStyleBackColor = true;
            // 
            // listDerecha
            // 
            this.listDerecha.FormattingEnabled = true;
            this.listDerecha.Location = new System.Drawing.Point(255, 50);
            this.listDerecha.Name = "listDerecha";
            this.listDerecha.Size = new System.Drawing.Size(171, 238);
            this.listDerecha.TabIndex = 7;
            // 
            // btnDeleteItemRight
            // 
            this.btnDeleteItemRight.Location = new System.Drawing.Point(196, 194);
            this.btnDeleteItemRight.Name = "btnDeleteItemRight";
            this.btnDeleteItemRight.Size = new System.Drawing.Size(34, 23);
            this.btnDeleteItemRight.TabIndex = 6;
            this.btnDeleteItemRight.Text = "...";
            this.btnDeleteItemRight.UseVisualStyleBackColor = true;
            this.btnDeleteItemRight.Click += new System.EventHandler(this.btnEliminarItemDerecha);
            // 
            // btnAllToRight
            // 
            this.btnAllToRight.Location = new System.Drawing.Point(196, 165);
            this.btnAllToRight.Name = "btnAllToRight";
            this.btnAllToRight.Size = new System.Drawing.Size(34, 23);
            this.btnAllToRight.TabIndex = 5;
            this.btnAllToRight.Text = ">>";
            this.btnAllToRight.UseVisualStyleBackColor = true;
            this.btnAllToRight.Click += new System.EventHandler(this.btnPasarDeIzquierdaMuchos);
            // 
            // btnToRight
            // 
            this.btnToRight.Location = new System.Drawing.Point(196, 136);
            this.btnToRight.Name = "btnToRight";
            this.btnToRight.Size = new System.Drawing.Size(34, 23);
            this.btnToRight.TabIndex = 4;
            this.btnToRight.Text = ">";
            this.btnToRight.UseVisualStyleBackColor = true;
            this.btnToRight.Click += new System.EventHandler(this.btnPasarDeIzquierdaUno);
            // 
            // btnToLeft
            // 
            this.btnToLeft.Location = new System.Drawing.Point(196, 107);
            this.btnToLeft.Name = "btnToLeft";
            this.btnToLeft.Size = new System.Drawing.Size(34, 23);
            this.btnToLeft.TabIndex = 3;
            this.btnToLeft.Text = "<";
            this.btnToLeft.UseVisualStyleBackColor = true;
            this.btnToLeft.Click += new System.EventHandler(this.btnPasarDeDerechaUno);
            // 
            // listIzquierda
            // 
            this.listIzquierda.FormattingEnabled = true;
            this.listIzquierda.Location = new System.Drawing.Point(6, 50);
            this.listIzquierda.Name = "listIzquierda";
            this.listIzquierda.Size = new System.Drawing.Size(171, 238);
            this.listIzquierda.TabIndex = 2;
            // 
            // btnCarga
            // 
            this.btnCarga.Location = new System.Drawing.Point(126, 3);
            this.btnCarga.Name = "btnCarga";
            this.btnCarga.Size = new System.Drawing.Size(104, 23);
            this.btnCarga.TabIndex = 1;
            this.btnCarga.Text = "Cargar Objeto";
            this.btnCarga.UseVisualStyleBackColor = true;
            this.btnCarga.Click += new System.EventHandler(this.btnClickAgregarObjeto);
            // 
            // txtCarga
            // 
            this.txtCarga.Location = new System.Drawing.Point(9, 7);
            this.txtCarga.Name = "txtCarga";
            this.txtCarga.Size = new System.Drawing.Size(100, 20);
            this.txtCarga.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 347);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPersona.ResumeLayout(false);
            this.tabPersona.PerformLayout();
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.tabObjetos.ResumeLayout(false);
            this.tabObjetos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPersona;
        private System.Windows.Forms.TabPage tabObjetos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ListBox listDerecha;
        private System.Windows.Forms.Button btnDeleteItemRight;
        private System.Windows.Forms.Button btnAllToRight;
        private System.Windows.Forms.Button btnToRight;
        private System.Windows.Forms.Button btnToLeft;
        private System.Windows.Forms.ListBox listIzquierda;
        private System.Windows.Forms.Button btnCarga;
        private System.Windows.Forms.TextBox txtCarga;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton rdbFem;
        private System.Windows.Forms.RadioButton rdbMasc;
        private System.Windows.Forms.CheckBox chkPop;
        private System.Windows.Forms.CheckBox chkIndie;
        private System.Windows.Forms.CheckBox chkMetal;
        private System.Windows.Forms.CheckBox chkTrance;
        private System.Windows.Forms.CheckBox chkReggea;
        private System.Windows.Forms.CheckBox chkRock;
        private System.Windows.Forms.GroupBox gbSexo;
    }
}

