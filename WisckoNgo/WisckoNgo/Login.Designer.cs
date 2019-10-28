namespace WisckoNgo
{
    partial class Login
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




        public System.Windows.Forms.Label labelWiscko;
        public System.Windows.Forms.TextBox textBoxRegistro;
        public System.Windows.Forms.TextBox textBoxPassword;
        public System.Windows.Forms.CheckBox checkRecordarme;
        public System.Windows.Forms.Button btnIniciarSesion;
    }
}
