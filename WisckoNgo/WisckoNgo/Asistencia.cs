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
    public partial class Asistencia : UserControl
    {
       public ConexionApi api;
       DateTime fecha;
        public Asistencia()
        {
             fecha = DateTime.Today;

            fecha = new DateTime();  //Dscomentar si deseas hacer pruebas para que el sistema piense que es lunes
            api = new ConexionApi();
            InitializeComponent();
         
        }

        private void Asistencia_Load(object sender, EventArgs e)
        {

        }

        public void acomodarComboBox(string respuestaString)
        {
           
            string[] portNames = System.IO.Ports.SerialPort.GetPortNames();
            comboBox2.Items.Clear();
            if(portNames.Length!=0){
            foreach (string PortAvailable in portNames)
            {
               
                comboBox2.Items.Add(PortAvailable);
            }
            comboBox2.SelectedIndex = 0;
            }
            actualizarAsistenciasGuardadas();
            var respuestaJSON = JsonConvert.DeserializeObject<List<Clases>>(respuestaString);
            if (Properties.Settings.Default["configuracionoffline"].ToString() != "")
            {
                var leerlocal = JsonConvert.DeserializeObject<DatosOffline>(Properties.Settings.Default["configuracionoffline"].ToString());
              
                leerlocal.clase = respuestaJSON;
                Properties.Settings.Default["configuracionoffline"]=JsonConvert.SerializeObject(leerlocal);
           
                Properties.Settings.Default.Save();
              
            }
            else
            {
                DatosOffline temp = new DatosOffline();
                temp.clase = respuestaJSON;
             
               Properties.Settings.Default["configuracionoffline"]=JsonConvert.SerializeObject(temp);
               Properties.Settings.Default.Save();
             
            }

           
            var tempJSON = JsonConvert.DeserializeObject<List<Clases>>(JsonConvert.SerializeObject(respuestaJSON));
            tempJSON.Clear();
            
                for (int i = 0; i < respuestaJSON.Count; i++)
            {
              
                if (respuestaJSON[i].dia==(int)fecha.DayOfWeek)
                {
                tempJSON.Add(respuestaJSON[i]);
               
                }
            }

            this.comboBox1.DataSource = tempJSON;
            this.comboBox1.DisplayMember = "materia";
            this.comboBox1.ValueMember = "ID";
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            if (comboBox1.Text != "" && comboBox2.Text!="")
                {
                    if (Properties.Settings.Default["tomarasistencia"].ToString() == "")
                    {
                        abrirVentana();
                    }else{
                        DialogResult result1 = MessageBox.Show("Parece que hay asistencias pendientes. Si continua, no se actualizarán. ¿Deseas continuar?",
        "Se han encontrado asistencias en cola",
        MessageBoxButtons.YesNo);
                        if (result1 == DialogResult.Yes)
                        {
                            abrirVentana();
                        }

                    }
                }
                else
                {
                    if (comboBox1.Text == "") { MessageBox.Show("Elige la clase a tomar asistencia."); }
                    if (comboBox2.Text == "") { MessageBox.Show("Elige el puerto Aircko."); 
                    
                            string[] portNames = System.IO.Ports.SerialPort.GetPortNames();
                            comboBox2.Items.Clear();
                            if (portNames.Length != 0)
                            {
                                foreach (string PortAvailable in portNames)
                                {
                                    
                                    comboBox2.Items.Add(PortAvailable);
                                }
                                comboBox2.SelectedIndex = 0;
                            }

                    }
                }
            }


        void abrirVentana() {
            EscanearCredenciales escanear;
            if (!checkBox1.Checked)
            {
                escanear = new EscanearCredenciales(Int32.Parse(comboBox1.SelectedValue.ToString()), comboBox1.Text, comboBox2.Text);

            }
            else {
                escanear = new EscanearCredenciales(0, "ASISTENCIA DE TODO EL DIA", comboBox2.Text);

            } try
             {

                escanear.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.cerrarForm);

                escanear.Show();
            }
            catch (System.ObjectDisposedException ex)
            {

            }
        }
        private void cerrarForm(Object sender, FormClosingEventArgs e)
        {
            actualizarAsistenciasGuardadas();
        }

        private async void actualizarAsistenciasGuardadas() {
            

            if (Properties.Settings.Default["tomarasistencia"].ToString()!="")
            {
               
            var respuesta = await api.cambiarAsistenciaClase(Properties.Settings.Default["tomarasistencia"].ToString());
            if (respuesta != null)
            {
           
                var respuestaJSON = JsonConvert.DeserializeObject<Respuesta>(respuesta);
                if (respuestaJSON.success)
                {
                    MessageBox. Show("La asistencia en cola se ha actualizado.");
                    Properties.Settings.Default["tomarasistencia"] = "";
                    Properties.Settings.Default.Save();
                }
            }
            }
        }
    
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (comboBox1.Items.Count == 0)
                {
                    checkBox1.Checked = false;
                    MessageBox.Show("No tienes ninguna clase el día de hoy");
                }
                else
                {
                    this.comboBox1.Enabled = false;
                }
            }
            else {
                this.comboBox1.Enabled = true;
            }

        }
    }
}
