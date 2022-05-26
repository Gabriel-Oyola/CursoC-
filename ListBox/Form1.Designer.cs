namespace ListBox
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
            this.listPedido = new System.Windows.Forms.ListBox();
            this.cbComida = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbExtra = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbGaseosa = new System.Windows.Forms.ComboBox();
            this.txtComida = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtExtra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGaseosa = new System.Windows.Forms.TextBox();
            this.btCARGAR = new System.Windows.Forms.Button();
            this.listNumPedido = new System.Windows.Forms.ListBox();
            this.listEstadoPedido = new System.Windows.Forms.ListBox();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btCambiarEstado = new System.Windows.Forms.Button();
            this.btVer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listPedido
            // 
            this.listPedido.FormattingEnabled = true;
            this.listPedido.Location = new System.Drawing.Point(386, 97);
            this.listPedido.Name = "listPedido";
            this.listPedido.Size = new System.Drawing.Size(180, 368);
            this.listPedido.TabIndex = 0;
            // 
            // cbComida
            // 
            this.cbComida.FormattingEnabled = true;
            this.cbComida.Location = new System.Drawing.Point(21, 65);
            this.cbComida.Name = "cbComida";
            this.cbComida.Size = new System.Drawing.Size(121, 21);
            this.cbComida.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Comida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Extra";
            // 
            // cbExtra
            // 
            this.cbExtra.FormattingEnabled = true;
            this.cbExtra.Location = new System.Drawing.Point(164, 65);
            this.cbExtra.Name = "cbExtra";
            this.cbExtra.Size = new System.Drawing.Size(121, 21);
            this.cbExtra.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(299, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gaseosa";
            // 
            // cbGaseosa
            // 
            this.cbGaseosa.FormattingEnabled = true;
            this.cbGaseosa.Location = new System.Drawing.Point(303, 65);
            this.cbGaseosa.Name = "cbGaseosa";
            this.cbGaseosa.Size = new System.Drawing.Size(121, 21);
            this.cbGaseosa.TabIndex = 5;
            // 
            // txtComida
            // 
            this.txtComida.Location = new System.Drawing.Point(21, 120);
            this.txtComida.Name = "txtComida";
            this.txtComida.Size = new System.Drawing.Size(72, 20);
            this.txtComida.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(160, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cantidad";
            // 
            // txtExtra
            // 
            this.txtExtra.Location = new System.Drawing.Point(164, 120);
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.Size = new System.Drawing.Size(72, 20);
            this.txtExtra.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(299, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cantidad";
            // 
            // txtGaseosa
            // 
            this.txtGaseosa.Location = new System.Drawing.Point(303, 120);
            this.txtGaseosa.Name = "txtGaseosa";
            this.txtGaseosa.Size = new System.Drawing.Size(72, 20);
            this.txtGaseosa.TabIndex = 11;
            // 
            // btCARGAR
            // 
            this.btCARGAR.Location = new System.Drawing.Point(21, 146);
            this.btCARGAR.Name = "btCARGAR";
            this.btCARGAR.Size = new System.Drawing.Size(171, 23);
            this.btCARGAR.TabIndex = 13;
            this.btCARGAR.Text = "Cargar";
            this.btCARGAR.UseVisualStyleBackColor = true;
            this.btCARGAR.Click += new System.EventHandler(this.btCARGAR_Click);
            // 
            // listNumPedido
            // 
            this.listNumPedido.FormattingEnabled = true;
            this.listNumPedido.Location = new System.Drawing.Point(21, 180);
            this.listNumPedido.Name = "listNumPedido";
            this.listNumPedido.Size = new System.Drawing.Size(171, 225);
            this.listNumPedido.TabIndex = 14;
            // 
            // listEstadoPedido
            // 
            this.listEstadoPedido.FormattingEnabled = true;
            this.listEstadoPedido.Location = new System.Drawing.Point(204, 180);
            this.listEstadoPedido.Name = "listEstadoPedido";
            this.listEstadoPedido.Size = new System.Drawing.Size(171, 225);
            this.listEstadoPedido.TabIndex = 15;
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(204, 442);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(171, 23);
            this.btEliminar.TabIndex = 16;
            this.btEliminar.Text = "Anular";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btCambiarEstado
            // 
            this.btCambiarEstado.Location = new System.Drawing.Point(204, 411);
            this.btCambiarEstado.Name = "btCambiarEstado";
            this.btCambiarEstado.Size = new System.Drawing.Size(171, 23);
            this.btCambiarEstado.TabIndex = 19;
            this.btCambiarEstado.Text = "Listo";
            this.btCambiarEstado.UseVisualStyleBackColor = true;
            this.btCambiarEstado.Click += new System.EventHandler(this.btCambiarEstado_Click);
            // 
            // btVer
            // 
            this.btVer.Location = new System.Drawing.Point(21, 411);
            this.btVer.Name = "btVer";
            this.btVer.Size = new System.Drawing.Size(171, 23);
            this.btVer.TabIndex = 20;
            this.btVer.Text = "Ver";
            this.btVer.UseVisualStyleBackColor = true;
            this.btVer.Click += new System.EventHandler(this.btVer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(578, 513);
            this.Controls.Add(this.btVer);
            this.Controls.Add(this.btCambiarEstado);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.listEstadoPedido);
            this.Controls.Add(this.listNumPedido);
            this.Controls.Add(this.btCARGAR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGaseosa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtExtra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtComida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbGaseosa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbExtra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbComida);
            this.Controls.Add(this.listPedido);
            this.Name = "Form1";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listPedido;
        private System.Windows.Forms.ComboBox cbComida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbExtra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbGaseosa;
        private System.Windows.Forms.TextBox txtComida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtExtra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGaseosa;
        private System.Windows.Forms.Button btCARGAR;
        private System.Windows.Forms.ListBox listNumPedido;
        private System.Windows.Forms.ListBox listEstadoPedido;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btCambiarEstado;
        private System.Windows.Forms.Button btVer;
    }
}

