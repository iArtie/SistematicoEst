
namespace Sistematico
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtbEstudiantes = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnUpt = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.ndMate = new System.Windows.Forms.NumericUpDown();
            this.nuCont = new System.Windows.Forms.NumericUpDown();
            this.nuProg = new System.Windows.Forms.NumericUpDown();
            this.nuEst = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dtbEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndMate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuCont)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuProg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuEst)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Carnet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Direccion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Correo:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(106, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(196, 23);
            this.txtName.TabIndex = 6;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(106, 107);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(196, 23);
            this.txtLastname.TabIndex = 7;
            // 
            // txtCarnet
            // 
            this.txtCarnet.Location = new System.Drawing.Point(106, 149);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(196, 23);
            this.txtCarnet.TabIndex = 8;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(106, 191);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(196, 23);
            this.txtPhone.TabIndex = 9;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(106, 234);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(196, 23);
            this.txtAdress.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(106, 273);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(196, 23);
            this.txtEmail.TabIndex = 11;
            // 
            // dtbEstudiantes
            // 
            this.dtbEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtbEstudiantes.Location = new System.Drawing.Point(354, 12);
            this.dtbEstudiantes.Name = "dtbEstudiantes";
            this.dtbEstudiantes.RowTemplate.Height = 25;
            this.dtbEstudiantes.Size = new System.Drawing.Size(746, 582);
            this.dtbEstudiantes.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Matematica:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Contabilidad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 427);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Programacion:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 465);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Estadistica:";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(21, 546);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 21;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnUpt
            // 
            this.btnUpt.Location = new System.Drawing.Point(129, 546);
            this.btnUpt.Name = "btnUpt";
            this.btnUpt.Size = new System.Drawing.Size(75, 23);
            this.btnUpt.TabIndex = 22;
            this.btnUpt.Text = "Modificar";
            this.btnUpt.UseVisualStyleBackColor = true;
            this.btnUpt.Click += new System.EventHandler(this.btnUpt_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(227, 546);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 23;
            this.btnDel.Text = "Eliminar";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // ndMate
            // 
            this.ndMate.Location = new System.Drawing.Point(129, 347);
            this.ndMate.Name = "ndMate";
            this.ndMate.Size = new System.Drawing.Size(120, 23);
            this.ndMate.TabIndex = 24;
            // 
            // nuCont
            // 
            this.nuCont.Location = new System.Drawing.Point(129, 386);
            this.nuCont.Name = "nuCont";
            this.nuCont.Size = new System.Drawing.Size(120, 23);
            this.nuCont.TabIndex = 25;
            // 
            // nuProg
            // 
            this.nuProg.Location = new System.Drawing.Point(129, 425);
            this.nuProg.Name = "nuProg";
            this.nuProg.Size = new System.Drawing.Size(120, 23);
            this.nuProg.TabIndex = 26;
            // 
            // nuEst
            // 
            this.nuEst.Location = new System.Drawing.Point(129, 463);
            this.nuEst.Name = "nuEst";
            this.nuEst.Size = new System.Drawing.Size(120, 23);
            this.nuEst.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 606);
            this.Controls.Add(this.nuEst);
            this.Controls.Add(this.nuProg);
            this.Controls.Add(this.nuCont);
            this.Controls.Add(this.ndMate);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUpt);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtbEstudiantes);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtCarnet);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtbEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndMate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuCont)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuProg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuEst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DataGridView dtbEstudiantes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnUpt;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.NumericUpDown ndMate;
        private System.Windows.Forms.NumericUpDown nuCont;
        private System.Windows.Forms.NumericUpDown nuProg;
        private System.Windows.Forms.NumericUpDown nuEst;
    }
}

