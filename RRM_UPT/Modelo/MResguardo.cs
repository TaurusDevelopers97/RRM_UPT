using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace RRM_UPT.Modelo
{
    public class MResguardo: IPlantilla<MResguardo>
    {
        public int idResguardo { get; set; }
        public string idUsuario { get; set; }
        public int idArticulo { get; set; }
        public string fechaResguardo { get; set; }

        string query;

        public int Alta(MResguardo obj)
        {
            query = "";
            return new Manager_BD().ExecuteRow(query);
        }

        public int Baja(MResguardo obj)
        {
            query = "";
            return new Manager_BD().ExecuteRow(query);
        }

        public int Modificacion(MResguardo obj)
        {
            query = "";
            return new Manager_BD().ExecuteRow(query);
        }

        public DataTable Consulta(MResguardo obj)
        {
            query = "";
            return new Manager_BD().ExecuteTbl(query);
        }
    }
}