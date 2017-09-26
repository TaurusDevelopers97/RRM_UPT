using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace RRM_UPT.Modelo
{
    public abstract class MUsuario:IPlantilla<MUsuario>
    {
        public bool roll { get; set; }
        public string nombre { get; set; }
        public string usuario { get; set; }
        public string pass { get; set; }
        public int idArea { get; set; }
        public string idUsuario { get; set; }
        public string correo { get; set; }

        string query;

        public int Alta(MUsuario obj)
        {
            query = "";
            return new Manager_BD().ExecuteRow(query);
        }

        public int Baja(MUsuario obj)
        {
            query = "";
            return new Manager_BD().ExecuteRow(query);
        }

        public int Modificacion(MUsuario obj)
        {
            query = "";
            return new Manager_BD().ExecuteRow(query);
        }
        public DataTable Consulta(MUsuario obj)
        {
            query = "";
            return new Manager_BD().ExecuteTbl(query);
        }
    }
}