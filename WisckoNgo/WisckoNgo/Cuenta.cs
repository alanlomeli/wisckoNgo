using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using System.Configuration;

namespace WisckoNgo
{
    public partial class Cuenta : UserControl
    {
        public Cuenta()
        {
            InitializeComponent();
        }
        public void acomodarCuenta(string respuestaString)
        {
           // Console.WriteLine(respuestaString);
            var respuestaJSON = JsonConvert.DeserializeObject<DatosCuenta>(respuestaString);

            if (Properties.Settings.Default["configuracionoffline"].ToString() != "")
            {
                var leerlocal = JsonConvert.DeserializeObject<DatosOffline>(Properties.Settings.Default["configuracionoffline"].ToString());

                leerlocal.cuenta = respuestaJSON;
                Properties.Settings.Default["configuracionoffline"] = JsonConvert.SerializeObject(leerlocal);

                Properties.Settings.Default.Save();

            }
            else
            {
                DatosOffline temp = new DatosOffline();
                temp.cuenta = respuestaJSON;

                Properties.Settings.Default["configuracionoffline"] = JsonConvert.SerializeObject(temp);
                Properties.Settings.Default.Save();

            }

            this.labelTextoNombre.Text = respuestaJSON.Nombre + " " + respuestaJSON.Apellido;
            this.labelTextoNomina.Text = respuestaJSON.Nomina + "";
            this.labelTextoDivision.Text = respuestaJSON.Division;
            if (respuestaJSON.Foto != "")
            {
                //Avatar
                try{
                var request = WebRequest.Create("https://storage.googleapis.com/wiscko-249904.appspot.com/avatares/" + respuestaJSON.Foto);

           using (var response = request.GetResponse())
           using (var stream = response.GetResponseStream())
           {
               this.picAvatar.Image = Bitmap.FromStream(stream);
           }
            }
            catch(Exception ex){
            
            }
            }
        }
        }
    
}
