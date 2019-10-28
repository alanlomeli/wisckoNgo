namespace WisckoNgo
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sideBar = new System.Windows.Forms.Panel();
            this.labelOnline = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.indicadorSidebar = new System.Windows.Forms.Panel();
            this.btnCuenta = new System.Windows.Forms.Button();
            this.btnNotificaciones = new System.Windows.Forms.Button();
            this.btnHorario = new System.Windows.Forms.Button();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.indicadorOnline = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.controlCuenta = new WisckoNgo.Cuenta();
            this.controlLogin = new WisckoNgo.Login();
            this.controlAsistencia = new WisckoNgo.Asistencia();
            this.controlNotificaciones = new WisckoNgo.Notificaciones();
            this.controlHorario = new WisckoNgo.Horario();
            this.sideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.sideBar.Controls.Add(this.labelOnline);
            this.sideBar.Controls.Add(this.btnCerrarSesion);
            this.sideBar.Controls.Add(this.indicadorSidebar);
            this.sideBar.Controls.Add(this.btnCuenta);
            this.sideBar.Controls.Add(this.btnNotificaciones);
            this.sideBar.Controls.Add(this.btnHorario);
            this.sideBar.Controls.Add(this.btnAsistencia);
            this.sideBar.Controls.Add(this.shapeContainer2);
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(186, 574);
            this.sideBar.TabIndex = 0;
            this.sideBar.Visible = false;
            // 
            // labelOnline
            // 
            this.labelOnline.AutoSize = true;
            this.labelOnline.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOnline.ForeColor = System.Drawing.Color.White;
            this.labelOnline.Location = new System.Drawing.Point(43, 491);
            this.labelOnline.Name = "labelOnline";
            this.labelOnline.Size = new System.Drawing.Size(52, 18);
            this.labelOnline.TabIndex = 2;
            this.labelOnline.Text = "Online";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 519);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(182, 52);
            this.btnCerrarSesion.TabIndex = 5;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // indicadorSidebar
            // 
            this.indicadorSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(216)))), ((int)(((byte)(100)))));
            this.indicadorSidebar.Location = new System.Drawing.Point(0, 30);
            this.indicadorSidebar.Name = "indicadorSidebar";
            this.indicadorSidebar.Size = new System.Drawing.Size(14, 52);
            this.indicadorSidebar.TabIndex = 1;
            // 
            // btnCuenta
            // 
            this.btnCuenta.FlatAppearance.BorderSize = 0;
            this.btnCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuenta.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuenta.ForeColor = System.Drawing.Color.White;
            this.btnCuenta.Image = ((System.Drawing.Image)(resources.GetObject("btnCuenta.Image")));
            this.btnCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCuenta.Location = new System.Drawing.Point(12, 204);
            this.btnCuenta.Name = "btnCuenta";
            this.btnCuenta.Size = new System.Drawing.Size(174, 52);
            this.btnCuenta.TabIndex = 4;
            this.btnCuenta.Text = "Cuenta";
            this.btnCuenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCuenta.UseVisualStyleBackColor = true;
            this.btnCuenta.Click += new System.EventHandler(this.btnCuenta_Click);
            // 
            // btnNotificaciones
            // 
            this.btnNotificaciones.FlatAppearance.BorderSize = 0;
            this.btnNotificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotificaciones.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotificaciones.ForeColor = System.Drawing.Color.White;
            this.btnNotificaciones.Image = ((System.Drawing.Image)(resources.GetObject("btnNotificaciones.Image")));
            this.btnNotificaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotificaciones.Location = new System.Drawing.Point(12, 146);
            this.btnNotificaciones.Name = "btnNotificaciones";
            this.btnNotificaciones.Size = new System.Drawing.Size(174, 52);
            this.btnNotificaciones.TabIndex = 3;
            this.btnNotificaciones.Text = "Notificaciones";
            this.btnNotificaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotificaciones.UseVisualStyleBackColor = true;
            this.btnNotificaciones.Click += new System.EventHandler(this.btnNotificaciones_Click);
            // 
            // btnHorario
            // 
            this.btnHorario.FlatAppearance.BorderSize = 0;
            this.btnHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHorario.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorario.ForeColor = System.Drawing.Color.White;
            this.btnHorario.Image = ((System.Drawing.Image)(resources.GetObject("btnHorario.Image")));
            this.btnHorario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHorario.Location = new System.Drawing.Point(12, 89);
            this.btnHorario.Name = "btnHorario";
            this.btnHorario.Size = new System.Drawing.Size(174, 52);
            this.btnHorario.TabIndex = 2;
            this.btnHorario.Text = "Horario";
            this.btnHorario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHorario.UseVisualStyleBackColor = true;
            this.btnHorario.Click += new System.EventHandler(this.btnHorario_Click);
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAsistencia.FlatAppearance.BorderSize = 0;
            this.btnAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistencia.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistencia.ForeColor = System.Drawing.Color.White;
            this.btnAsistencia.Image = ((System.Drawing.Image)(resources.GetObject("btnAsistencia.Image")));
            this.btnAsistencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsistencia.Location = new System.Drawing.Point(12, 30);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(174, 52);
            this.btnAsistencia.TabIndex = 1;
            this.btnAsistencia.Text = "Asistencia";
            this.btnAsistencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAsistencia.UseVisualStyleBackColor = true;
            this.btnAsistencia.Click += new System.EventHandler(this.btnAsistencia_Click);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.indicadorOnline});
            this.shapeContainer2.Size = new System.Drawing.Size(186, 574);
            this.shapeContainer2.TabIndex = 6;
            this.shapeContainer2.TabStop = false;
            // 
            // indicadorOnline
            // 
            this.indicadorOnline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(216)))), ((int)(((byte)(100)))));
            this.indicadorOnline.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.indicadorOnline.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.indicadorOnline.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(216)))), ((int)(((byte)(100)))));
            this.indicadorOnline.Location = new System.Drawing.Point(119, 495);
            this.indicadorOnline.Name = "indicadorOnline";
            this.indicadorOnline.Size = new System.Drawing.Size(7, 7);
            // 
            // controlCuenta
            // 
            this.controlCuenta.Location = new System.Drawing.Point(192, 30);
            this.controlCuenta.Name = "controlCuenta";
            this.controlCuenta.Size = new System.Drawing.Size(840, 532);
            this.controlCuenta.TabIndex = 4;
            this.controlCuenta.Load += new System.EventHandler(this.controlCuenta_Load);
            // 
            // controlLogin
            // 
            this.controlLogin.Location = new System.Drawing.Point(192, 30);
            this.controlLogin.Name = "controlLogin";
            this.controlLogin.Size = new System.Drawing.Size(840, 532);
            this.controlLogin.TabIndex = 2;
            // 
            // controlAsistencia
            // 
            this.controlAsistencia.Location = new System.Drawing.Point(192, 30);
            this.controlAsistencia.Name = "controlAsistencia";
            this.controlAsistencia.Size = new System.Drawing.Size(840, 532);
            this.controlAsistencia.TabIndex = 1;
            // 
            // controlNotificaciones
            // 
            this.controlNotificaciones.Location = new System.Drawing.Point(192, 30);
            this.controlNotificaciones.Name = "controlNotificaciones";
            this.controlNotificaciones.Size = new System.Drawing.Size(840, 532);
            this.controlNotificaciones.TabIndex = 7;
            // 
            // controlHorario
            // 
            this.controlHorario.Location = new System.Drawing.Point(192, 22);
            this.controlHorario.Name = "controlHorario";
            this.controlHorario.Size = new System.Drawing.Size(840, 540);
            this.controlHorario.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1055, 572);
            this.Controls.Add(this.controlCuenta);
            this.Controls.Add(this.controlLogin);
            this.Controls.Add(this.controlAsistencia);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.controlNotificaciones);
            this.Controls.Add(this.controlHorario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WisckoNgo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.cerrarMainForm);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.sideBar.ResumeLayout(false);
            this.sideBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideBar;
        private System.Windows.Forms.Button btnCuenta;
        private System.Windows.Forms.Button btnNotificaciones;
        private System.Windows.Forms.Button btnHorario;
        private System.Windows.Forms.Button btnAsistencia;
        private System.Windows.Forms.Label labelOnline;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel indicadorSidebar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.OvalShape indicadorOnline;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Asistencia controlAsistencia;
        private Notificaciones controlNotificaciones;
        private Login controlLogin;
        private Cuenta controlCuenta;
        private Horario controlHorario;
    }
}

