using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WisckoNgo
{

    class RespuestaInicioSesion {
        public bool success { get; set; }
        public string cuenta { get; set; }
        public string sesion { get; set; }
    }
    class Respuesta {
        public bool success { get; set; }
    }

    class DatosCuenta {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Foto { get; set; }
        public string Division { get; set; }
        public int Nomina { get; set; }
        public DatosCuenta(string Nombre,string Apellido, string Foto, string Division,int Nomina) {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Foto = Foto;
            this.Division = Division;
            this.Nomina=Nomina;
        }
    }
    class DatosHorario {
        public string dia { get; set; }
        public List<DatosHorarioClase> clase { get; set; }
    }
    class DatosHorarioClase
    {
        public string hora { get; set; }
        public string grupo { get; set; }
        public string materia { get; set; }
        public string salon { get; set; }
    }
    class Notificacion {
        public string Contenido { get; set; }
    }
    class Clases {
        public int ID { get; set; }
        public int dia { get; set; }
        public string materia { get; set; }    
    }
    class DatosOffline {
        public List<Notificacion> notificaciones { get; set; }
        public DatosCuenta cuenta { get; set; }
        public List<DatosHorario> horario { get; set; }
        public List<Clases> clase { get; set; }

    }
 
    class TomaAsistencia {
        public TomaAsistencia(int clase) {
            this.clase = clase;
            this.alumnos= new List<int>();
        }
        public int clase { get; set; }
        public List<int> alumnos { get; set; }
    }
    class RespuestaModuloAircko {
        public string id { get; set; }
        public Boolean air { get; set; }
    }

}
