using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WisckoNgo
{
    public class ConexionApi
    {
  
        HttpClient client;

        public ConexionApi() {
            client = new HttpClient();
            client.BaseAddress = new Uri("https://wiscko-249904.appspot.com/");

        }

      public  async  Task<string> iniciarSesion(string registro, string passwd) {
        {

            IEnumerable<KeyValuePair<string, string>> queries = new List<KeyValuePair<string, string>>(){
                new KeyValuePair<string,string>("registro",registro),
                 new KeyValuePair<string,string>("pass",passwd)
            };

            HttpContent parametros = new FormUrlEncodedContent(queries);


            try
            {
                using (HttpResponseMessage response = await client.PostAsync("wisckoNgoAuth.php", parametros))
                {

                    using (HttpContent content = response.Content)
                    {
              
                            string contenidoRespuesta = await content.ReadAsStringAsync();
                            HttpContentHeaders headers = content.Headers;
                            return contenidoRespuesta;
                        
                    }
                }
            }catch(Exception ex){
                return null;
            }
            }

        }

      public async Task<string> obtenerDatosCuenta()
      {
          {
              try{
                  using (HttpResponseMessage response = await client.GetAsync("wisckoNgoCuenta.php"))
                  {
                      using (HttpContent content = response.Content)
                      {
                          string contenidoRespuesta = await content.ReadAsStringAsync();
                          return contenidoRespuesta;

                      }
                  }
              }catch(Exception ex){
                  return null;
                  }
              }
          

      }
      public async Task<string> obtenerHorario()
      {
          {
              try
              {
                  using (HttpResponseMessage response = await client.GetAsync("wisckoNgoHorario.php"))
                  {
                      using (HttpContent content = response.Content)
                      {
                          string contenidoRespuesta = await content.ReadAsStringAsync();
                          return contenidoRespuesta;

                      }
                  }
              }catch(Exception ex){
                  return null;
              }
          }

      }
      public async Task<string> cerrarSesion()
      {
          {
              try
              {
                  using (HttpResponseMessage response = await client.GetAsync("wisckoNgoCerrarSesion.php"))
                  {
                      using (HttpContent content = response.Content)
                      {
                          string contenidoRespuesta = await content.ReadAsStringAsync();
                          return contenidoRespuesta;

                      }
                  }
              }catch(Exception ex){
                  return null; 
              }
          }

      }

      public async Task<string> obtenerNotificaciones()
      {
          {
              try
              {
                  using (HttpResponseMessage response = await client.GetAsync("wisckoNgoNotificaciones.php"))
                  {
                      using (HttpContent content = response.Content)
                      {
                          string contenidoRespuesta = await content.ReadAsStringAsync();
                          return contenidoRespuesta;

                      }
                  }
              }catch(Exception ex){
                  return null;
              }
          }

      }

      public async Task<string> obtenerClases()
      {
          {
              try
              {
                  using (HttpResponseMessage response = await client.GetAsync("wisckoNgoObtenerClases.php"))
                  {
                      using (HttpContent content = response.Content)
                      {
                          string contenidoRespuesta = await content.ReadAsStringAsync();
                          Console.WriteLine(contenidoRespuesta);
                          return contenidoRespuesta;

                      }
                  }
              }catch(Exception ex){
              return null;
}
          }

      }

      public async Task<string> cambiarAsistenciaClase(string asistencias)
      {
          {

              IEnumerable<KeyValuePair<string, string>> queries = new List<KeyValuePair<string, string>>(){
                new KeyValuePair<string,string>("asistencias",asistencias)
               
            };

              HttpContent parametros = new FormUrlEncodedContent(queries);


              try
              {
                  using (HttpResponseMessage response = await client.PostAsync("wisckoNgoCambiarAsistencia.php", parametros))
                  {

                      using (HttpContent content = response.Content)
                      {

                          string contenidoRespuesta = await content.ReadAsStringAsync();
                          HttpContentHeaders headers = content.Headers;
                          return contenidoRespuesta;

                      }
                  }
              }
              catch (Exception ex)
              {
                  return null;
              }
          }

      }

    }
}
