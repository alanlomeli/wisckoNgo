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
    public partial class Horario : UserControl
    {
        string[] horario;
        string[] dias;
      public Horario()
        {
            InitializeComponent();
            horario = new string[9] { "07:00-07:50", "07:50-08:40", "08:40-09:30", "09:30-10:20", "10:20-11:10", "11:10-12:00", "12:00-12:50", "12:50-01:40", "01:40-02:30" };        
            dias = new string[5] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes" };
        }
        public void acomodarHorario(string respuestaString)
        {
          //  Console.WriteLine("Se ejecuta horario"+respuestaString);
            this.tableLayoutPanel1.Visible = false;
            this.tableLayoutPanel1.Controls.Clear();
            this.tableLayoutPanel1.Controls.Add(this.panel16, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.panel15, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.panel14, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.panel13, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel11, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.panel10, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel12, 0, 4);
              

                var respuestaJSON = JsonConvert.DeserializeObject<List<DatosHorario>>(respuestaString);

                if (Properties.Settings.Default["configuracionoffline"].ToString() != "")
                {
                    var leerlocal = JsonConvert.DeserializeObject<DatosOffline>(Properties.Settings.Default["configuracionoffline"].ToString());

                    leerlocal.horario = respuestaJSON;
                    Properties.Settings.Default["configuracionoffline"] = JsonConvert.SerializeObject(leerlocal);

                    Properties.Settings.Default.Save();

                }
                else
                {
                    DatosOffline temp = new DatosOffline();
                    temp.horario = respuestaJSON;

                    Properties.Settings.Default["configuracionoffline"] = JsonConvert.SerializeObject(temp);
                    Properties.Settings.Default.Save();

                }
            for (int i = 0; i < respuestaJSON.Count; i++)
                {

                    for (int k = 0; k < respuestaJSON[i].clase.Count; k++)
                    {

                        tableLayoutPanel1.Controls.Add(new Label { 
                            Text = respuestaJSON[i].clase[k].materia + "\n" + respuestaJSON[i].clase[k].grupo + " " + respuestaJSON[i].clase[k].salon,
                            Anchor = AnchorStyles.None,
                            AutoSize = true,
                            ForeColor = System.Drawing.Color.White,
                            Font = new System.Drawing.Font("Lato",8F,
                            System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)))},
                            i + 1, obtenerPosTabla(respuestaJSON[i].clase[k].hora));


                    
                }
            }
          //  Console.WriteLine("debug:" + ConfigurationManager.AppSettings["configuracionoffline"]);
                this.tableLayoutPanel1.Visible = true;


        }
        public int obtenerPosTabla(string hora)
        {
            for (int i = 0; i < horario.Length; i++)
            {
                if (hora == horario[i])
                {
                    return i+1;
                }
            }
            return 1;
        }
    }
}
