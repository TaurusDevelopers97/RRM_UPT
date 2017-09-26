using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace RRM_UPT.Modelo
{
    public class MHistorial:IPlantilla<MHistorial>
    {
        public int idHistorial { get; set; }
        public string idUsuario { get; set; }
        public int idArticulo { get; set; }
        public string fechaResguardo { get; set; }
        public string statusResguardo { get; set; }

        string query;

        public int Alta(MHistorial obj)
        {
            query = "";
            return new Manager_BD().ExecuteRow(query);
        }

        public int Baja(MHistorial obj)
        {
            query = "";
            return new Manager_BD().ExecuteRow(query);
        }

        public int Modificacion(MHistorial obj)
        {
            query = "";
            return new Manager_BD().ExecuteRow(query);
        }

        public DataTable Consulta(MHistorial obj)
        {
            query = "";
            return new Manager_BD().ExecuteTbl(query);
        }
    }
}