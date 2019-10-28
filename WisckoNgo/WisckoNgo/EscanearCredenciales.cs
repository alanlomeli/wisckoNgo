using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using Newtonsoft.Json;

namespace WisckoNgo
{
    public partial class EscanearCredenciales : Form
    {
        static SerialPort _serialPort;

        Panel panelTemp;
        Label labelTemp;
        Thread t;
        TomaAsistencia tomarAsistencia;
        public EscanearCredenciales(int clase_id,string clase,string puerto)
        {
       

         
            tomarAsistencia = new TomaAsistencia(clase_id);
           
         
            InitializeComponent();
            this.Text = clase;
            t = new Thread(new ThreadStart(escanear));
            
            _serialPort = new SerialPort();
            _serialPort.PortName = puerto;//Set your board COM
            _serialPort.BaudRate = 9600;

            try
            {
                _serialPort.Open();
                   t.Start();
         
            }
            catch (System.IO.IOException ex)
            {
                t.Abort();

                MessageBox.Show("Asegúrese de tener su módulo Aircko conectado");
                this.Close();
            }
                
          
        }
    
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
           
            this.Close();
          
        }
        private void mostrarRegistro(string registro) {

            labelTemp = new Label();
            panelTemp = new Panel();

            labelTemp.AutoSize = true;
            labelTemp.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelTemp.ForeColor = System.Drawing.Color.White;
            labelTemp.Size = new System.Drawing.Size(200, 19);
            labelTemp.Dock = DockStyle.Bottom;
            panelTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            panelTemp.Size = new System.Drawing.Size(200, 46);
            panelTemp.TabIndex = 0;


            labelTemp.Text = registro;
            panelTemp.Controls.Add(labelTemp);

            flowLayoutPanel1.BeginInvoke(
     (Action)(() =>
     {
         flowLayoutPanel1.Controls.Add(panelTemp);
     }));
        }
       
        private void escanear()
        {         
            while(true){
            
            string a="";
            int registro;
            try
            {
                 a = _serialPort.ReadExisting();
            }
            catch (System.InvalidOperationException ex)
            {          
                MessageBox.Show("Se ha perdido la conexión con el módulo");

                this.Invoke((MethodInvoker)delegate
                {
                    this.Close();
                    this.t.Abort();
                });
            }
            if (a != "")
            {
                try
                {
                    var respuestaJSONTest = JsonConvert.DeserializeObject<RespuestaModuloAircko>(a);
                }
                catch (Newtonsoft.Json.JsonReaderException ex)
                {
                    MessageBox.Show("Ha ocurrido un problema con la conexión, asegurese de que tener el puerto correcto y que el módulo se encuentre conectado.");
                    this.Invoke((MethodInvoker)delegate
                    {
                        this.Close();
                        this.t.Abort();
                    });
                }

                var respuestaJSON = JsonConvert.DeserializeObject<RespuestaModuloAircko>(a);
                if (respuestaJSON.air)
                {
                    try
                    {
                        registro = Int32.Parse(respuestaJSON.id);

                        if (!tomarAsistencia.alumnos.Contains(registro))
                        {
                            tomarAsistencia.alumnos.Add(registro);

                            mostrarRegistro(registro + "");
                        }

                    }
                    catch (FormatException) { };
                }
            }
            Thread.Sleep(100);
        
        }
        }

        private void EscanearCredenciales_ParentChanged(object sender, EventArgs e)
        {

        }

        private void cerrarForm(Object sender, FormClosingEventArgs e)
        {
            if (tomarAsistencia.alumnos.Any())
            {
                Properties.Settings.Default["tomarasistencia"] = JsonConvert.SerializeObject(tomarAsistencia);
                Properties.Settings.Default.Save();
            }
            else {
                Properties.Settings.Default["tomarasistencia"] = "";
                Properties.Settings.Default.Save();

            }
           
            _serialPort.Close();
            t.Abort();
        }
    }
}
