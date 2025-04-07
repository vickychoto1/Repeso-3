using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeso_3
{
    internal class PropietarioArchivo
    {
        public void Guardar(string archivo, List<Propietario> propietarios)
        {
            string json = JsonConvert.SerializeObject(propietarios);
            System.IO.File.WriteAllText(archivo, json);

        }
        public List<Propietario> Leer(string archivo)
        {
            List<Propietario> lista = new List<Propietario>();
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            lista = JsonConvert.DeserializeObject<List<Propietario>>(json);
            return lista;
        }
    }
}
