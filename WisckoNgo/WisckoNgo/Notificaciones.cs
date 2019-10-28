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
using System.Configuration;

namespace WisckoNgo
{
    public partial class Notificaciones : UserControl
    {
        Panel panelTemp;
        Label labelTemp;

        public Notificaciones()
        {
            InitializeComponent();
          
         
        }

        public void acomodarNotificaciones(string respuestaString)
        {
            //ConfigurationUserLevel.None.WriteLine("Me ejecuto"+respuestaString);
            flowLayoutPanel1.Controls.Clear();
            var respuestaJSON = JsonConvert.DeserializeObject<List<Notificacion>>(respuestaString);
            if (Properties.Settings.Default["configuracionoffline"].ToString() != "")
            {
                var leerlocal = JsonConvert.DeserializeObject<DatosOffline>(Properties.Settings.Default["configuracionoffline"].ToString());

                leerlocal.notificaciones = respuestaJSON;
                Properties.Settings.Default["configuracionoffline"] = JsonConvert.SerializeObject(leerlocal);

                Properties.Settings.Default.Save();

            }
            else
            {
                DatosOffline temp = new DatosOffline();
                temp.notificaciones = respuestaJSON;

                Properties.Settings.Default["configuracionoffline"] = JsonConvert.SerializeObject(temp);
                Properties.Settings.Default.Save();

            }

            for (int i = 0; i < respuestaJSON.Count;i++ )
            {
                iniciarComponentes(respuestaJSON[i].Contenido);

            }

        }
        public void iniciarComponentes(string contenido){
           
            labelTemp = new Label();
            panelTemp = new Panel();

            labelTemp.AutoSize = true;
            labelTemp.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelTemp.ForeColor = System.Drawing.Color.White;
            labelTemp.Size = new System.Drawing.Size(434, 19);
            labelTemp.Dock = DockStyle.Bottom;
            panelTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            panelTemp.Size = new System.Drawing.Size(700, 46);
            panelTemp.TabIndex = 0;


           labelTemp.Text ="+ "+contenido;
           panelTemp.Controls.Add(labelTemp);
           flowLayoutPanel1.Controls.Add(panelTemp);
        }

    }
}
