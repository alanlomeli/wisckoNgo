using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Configuration;
using System.Reflection;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Threading;
 namespace WisckoNgo
{

     public partial class MainForm : Form
     {
         ConexionApi api;
         bool online;
         bool sesionIniciada;
         DatosOffline datosOffline;
         Thread threadCambiarIndicador;
         public MainForm()
         {
             api = new ConexionApi();
   
             online = false;
             sesionIniciada = false;
             InitializeComponent();
             threadCambiarIndicador = new Thread(new ThreadStart(cambiarIndicador));
             threadCambiarIndicador.Start();
         }

         private async void MainForm_Load(object sender, EventArgs e)
         {

             this.controlLogin.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
             esconderComponentes();
             if (Properties.Settings.Default["registro"].ToString() == "")
             {

                 controlLogin.Visible = true;

             }
             else
             {
                 sideBar.Show();
                 var respuestaString = await api.iniciarSesion(Encrypt.Decrypt(Properties.Settings.Default["registro"].ToString()), Encrypt.Decrypt(Properties.Settings.Default["notpasswd"].ToString()));
                 if (respuestaString != null)
                 {
                     online = true;
                     var respuestaJSON = JsonConvert.DeserializeObject<RespuestaInicioSesion>(respuestaString);

                     if (respuestaJSON.success)
                     {
                         sesionIniciada = true;
                         controlAsistencia.acomodarComboBox(await api.obtenerClases());  
                         controlCuenta.acomodarCuenta(await api.obtenerDatosCuenta());
                         controlNotificaciones.acomodarNotificaciones(await api.obtenerNotificaciones());
                         controlHorario.acomodarHorario(await api.obtenerHorario());
                       
                         controlLogin.Hide();
                         mostrarComponentes();
                    
                     }
                     else
                     {
                         MessageBox.Show("Tu sesion ha cambiado", "Las credenciales que has usado anteriormente han cambiado", MessageBoxButtons.OK);
                         cerrarSesion();
                     }

                     

                 }
                 else
                 {
                     var datosoffline = JsonConvert.DeserializeObject<DatosOffline>(Properties.Settings.Default["configuracionoffline"].ToString());
                  //   Console.WriteLine(JsonConvert.SerializeObject(datosoffline));
                     if (datosoffline.clase != null)
                     {
                         controlAsistencia.acomodarComboBox(JsonConvert.SerializeObject(datosoffline.clase));
                     }
                     if (datosoffline.horario!=null)
                     {
                         controlHorario.acomodarHorario(JsonConvert.SerializeObject(datosoffline.horario));
                     }
                     if (datosoffline.cuenta != null)
                     {
                         controlCuenta.acomodarCuenta(JsonConvert.SerializeObject(datosoffline.cuenta));
                     }
                     if (datosoffline.notificaciones != null)
                     {
                         controlNotificaciones.acomodarNotificaciones(JsonConvert.SerializeObject(datosoffline.notificaciones));
                     }
                     controlLogin.Hide();
                     mostrarComponentes();
                     online = false;
  
                 }

             }


              
             indicadorSidebar.Height = btnAsistencia.Height;
             controlAsistencia.BringToFront();
            
         }

         private async void btnAsistencia_Click(object sender, EventArgs e)
         {
             indicadorSidebar.Top = btnAsistencia.Top;
             controlAsistencia.BringToFront();
             var asistencia = await api.obtenerClases();
             if (asistencia != null)
             {
                // Console.WriteLine("asistencia:"+asistencia);
                 if (sesionIniciada)
                 {
                     controlAsistencia.acomodarComboBox(asistencia);
                 }
                 else {
                    
                 }
                 online = true;
             }
             else
             {
                 var datosoffline = JsonConvert.DeserializeObject<DatosOffline>(Properties.Settings.Default["configuracionoffline"].ToString());
             
                 if (datosoffline.clase != null)
                 {
                     controlAsistencia.acomodarComboBox(JsonConvert.SerializeObject(datosoffline.clase));
                 }
                 online = false;
             }
              
         }

         private async void btnHorario_Click(object sender, EventArgs e)
         {

             indicadorSidebar.Top = btnHorario.Top;
             controlHorario.BringToFront();
             var horario = await api.obtenerHorario();
             if (horario != null)
             {
                 online = true;
                 if (sesionIniciada)
                 {
                     controlHorario.acomodarHorario(horario);
                 }
                
             }
             else
             {
                 online = false;
             }
              
         }

         private async void btnNotificaciones_Click(object sender, EventArgs e)
         {
             indicadorSidebar.Top = btnNotificaciones.Top;

             controlNotificaciones.BringToFront();
             var notificaciones = await api.obtenerNotificaciones();
             if (notificaciones != null)
             {
                 online = true;
                 if (sesionIniciada)
                 {
                     controlNotificaciones.acomodarNotificaciones(notificaciones);
                 }
                
             }
             else
             {
                 online = false;


             }

              
         }


         private async void btnCuenta_Click(object sender, EventArgs e)
         {
             indicadorSidebar.Top = btnCuenta.Top;
             controlCuenta.BringToFront();
             var cuenta = await api.obtenerDatosCuenta();
             if (cuenta != null)
             {
                 online = true;
                 if (sesionIniciada)
                 {
                     controlCuenta.acomodarCuenta(cuenta);
                 }
                
             }
             else
             {
                 online = false;
             }
              
         }

         private void login2_Load(object sender, EventArgs e)
         {

         }

         private void cuenta3_Load(object sender, EventArgs e)
         {

         }

         private void controlCuenta_Load(object sender, EventArgs e)
         {

         }

         private async void btnIniciarSesion_Click(object sender, EventArgs e)
         {
             if (!(controlLogin.textBoxRegistro.Text.All(char.IsDigit)) || controlLogin.textBoxRegistro.Text == "" || controlLogin.textBoxPassword.Text=="")
             {
                 MessageBox.Show("Solo se aceptan números y letras");
             }else{
             var respuestaString = await api.iniciarSesion(controlLogin.textBoxRegistro.Text, controlLogin.textBoxPassword.Text);
           
             if (respuestaString != null)
             {
                 var respuestaJSON = JsonConvert.DeserializeObject<RespuestaInicioSesion>(respuestaString);

                 online = true;
                 if (respuestaJSON.success)
                 {
                     if (controlLogin.checkRecordarme.Checked == true)
                     {
                         //Si marco la casilla de guardar sesion
                         //  Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                         Properties.Settings.Default["registro"] = Encrypt.EncryptMe(controlLogin.textBoxRegistro.Text);
                         Properties.Settings.Default["notpasswd"] = Encrypt.EncryptMe(controlLogin.textBoxPassword.Text);
                         Properties.Settings.Default.Save();

                         // Console.WriteLine(ConfigurationManager.AppSettings["registro"]);

                     }

                     sesionIniciada = true;
                     controlAsistencia.acomodarComboBox(await api.obtenerClases());
                     controlCuenta.acomodarCuenta(await api.obtenerDatosCuenta());
                     controlNotificaciones.acomodarNotificaciones(await api.obtenerNotificaciones());
                     controlHorario.acomodarHorario(await api.obtenerHorario());


                     controlLogin.Hide();
                     mostrarComponentes();
                      
                 }
                 else {
                     MessageBox.Show("Credenciales incorrectas.");

                 }

             }
             else {
                 MessageBox.Show("Parece que no estas conectado a internet.");
                 online = false;
             }
             }
         }


         private void esconderComponentes()
         {
             controlCuenta.Visible = false;
             controlNotificaciones.Visible = false;
             controlHorario.Visible = false;
             controlAsistencia.Visible = false;
             controlLogin.Visible = false;
             indicadorSidebar.Visible = false;
             sideBar.Visible = false;
         }
         private void mostrarComponentes()
         {
             controlCuenta.Visible = true;
             controlNotificaciones.Visible = true;
             controlHorario.Visible = true;
             controlAsistencia.Visible = true;
             controlLogin.Visible = true;
             indicadorSidebar.Visible = true;
             sideBar.Visible = true;

         }

         private async void btnCerrarSesion_Click(object sender, EventArgs e)
         {
              cerrarSesion();
         }

         public void cambiarIndicador()
         {
             while (true)
             {
               
                 if (!online)
                 {
                    

                     sesionIniciada = false;
                     labelOnline.BeginInvoke(
    (Action)(() =>
    {
        this.labelOnline.Text = "Offline";
        this.indicadorOnline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(85)))));

    }));

                     
                 }
                 else
                 {
                    
                     labelOnline.BeginInvoke(
          (Action)(() =>
          {
              labelOnline.Text = "Online";
              this.indicadorOnline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(216)))), ((int)(((byte)(100)))));

          }));
                     if (!sesionIniciada)
                     {
                         iniciarSesion();
                     }
                 }
                 Thread.Sleep(100);
             }

         }
         public async void cerrarSesion()
         {
             Properties.Settings.Default["registro"] ="";
             Properties.Settings.Default["notpasswd"] = "";
             Properties.Settings.Default.Save();
             var respuestaString = await api.cerrarSesion();
             esconderComponentes();

             this.controlLogin.Show();
        
         }

         public async void iniciarSesion()
         {
             var respuestaString = await api.iniciarSesion(Encrypt.Decrypt(Properties.Settings.Default["registro"].ToString()), Encrypt.Decrypt(Properties.Settings.Default["notpasswd"].ToString()));

             if (respuestaString != null)
             {
               
                 online = true;
                 var respuestaJSON = JsonConvert.DeserializeObject<RespuestaInicioSesion>(respuestaString);

                 if (respuestaJSON.success)
                 {
                    
                     sesionIniciada = true;
                      
                 }
             }
            

         }
         public void cerrarMainForm(Object sender, FormClosingEventArgs e)
         {
             threadCambiarIndicador.Abort();
         }
     }
}
