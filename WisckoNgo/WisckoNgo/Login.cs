using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WisckoNgo
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
      

        }

        private void InitializeComponent()
        {
            this.labelWiscko = new System.Windows.Forms.Label();
            this.textBoxRegistro = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.checkRecordarme = new System.Windows.Forms.CheckBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWiscko
            // 
            this.labelWiscko.AutoSize = true;
            this.labelWiscko.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWiscko.ForeColor = System.Drawing.Color.White;
            this.labelWiscko.Location = new System.Drawing.Point(289, 128);
            this.labelWiscko.Name = "labelWiscko";
            this.labelWiscko.Size = new System.Drawing.Size(104, 33);
            this.labelWiscko.TabIndex = 1;
            this.labelWiscko.Text = "Wiscko";
            // 
            // textBoxRegistro
            // 
            this.textBoxRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.textBoxRegistro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.textBoxRegistro.Location = new System.Drawing.Point(251, 188);
            this.textBoxRegistro.Name = "textBoxRegistro";
            this.textBoxRegistro.Size = new System.Drawing.Size(182, 15);
            this.textBoxRegistro.TabIndex = 2;
            this.textBoxRegistro.Text = "Nomina";
            this.textBoxRegistro.Click += new System.EventHandler(this.textBoxRegistro_Click);
            this.textBoxRegistro.TextChanged += new System.EventHandler(this.textBoxRegistro_TextChanged);
            this.textBoxRegistro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRegistro_KeyPress);
            this.textBoxRegistro.Leave += new System.EventHandler(this.textBoxRegistro_Leave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.textBoxPassword.Location = new System.Drawing.Point(251, 214);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(182, 15);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.Text = "Contraseña";
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.Click += new System.EventHandler(this.textBoxPassword_Click);
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // checkRecordarme
            // 
            this.checkRecordarme.AutoSize = true;
            this.checkRecordarme.Checked = true;
            this.checkRecordarme.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkRecordarme.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkRecordarme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.checkRecordarme.Location = new System.Drawing.Point(251, 240);
            this.checkRecordarme.Name = "checkRecordarme";
            this.checkRecordarme.Size = new System.Drawing.Size(84, 17);
            this.checkRecordarme.TabIndex = 4;
            this.checkRecordarme.Text = "Recordarme";
            this.checkRecordarme.UseVisualStyleBackColor = true;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(216)))), ((int)(((byte)(100)))));
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Location = new System.Drawing.Point(295, 263);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(116, 23);
            this.btnIniciarSesion.TabIndex = 5;
            this.btnIniciarSesion.Text = "INICIAR SESIÓN";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // Login
            // 
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.checkRecordarme);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxRegistro);
            this.Controls.Add(this.labelWiscko);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(654, 532);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBoxRegistro_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxRegistro_Click(object sender, EventArgs e)
        {
            textBoxRegistro.Text = textBoxRegistro.Text == "Nomina" ? "" : textBoxRegistro.Text;
        }

        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            textBoxPassword.Text = textBoxPassword.Text == "Contraseña" ? "" : textBoxPassword.Text;
        }

        private void textBoxRegistro_Leave(object sender, EventArgs e)
        {
            textBoxRegistro.Text = textBoxRegistro.Text == "" ? "Nomina" : textBoxRegistro.Text;
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            textBoxPassword.Text = textBoxPassword.Text == "" ? "Contraseña" : textBoxPassword.Text;
        }

        private void Login_Load(object sender, EventArgs e)
        {
 
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
        }

        private void textBoxRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }

       
        }
    }
}
