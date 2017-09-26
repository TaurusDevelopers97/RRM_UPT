using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace RRM_UPT.Modelo
{
    public class MInventario:IPlantilla<MInventario>
    {
        public int idArticulo { get; set; }
        public string nombre { get; set; }
        public string noSerie { get; set; }
        public string descripcion { get; set; }
        public string statusArt { get; set; }
        public string factura { get; set; }
        public float costo { get; set; }

        string query;

        public int Alta(MInventario obj)
        {
            query = "";
            return new Manager_BD().ExecuteRow(query);
        }

        public int Baja(MInventario obj)
        {
            query = "";
            return new Manager_BD().ExecuteRow(query);
        }

        public int Modificacion(MInventario obj)
        {
            query = "";
            return new Manager_BD().ExecuteRow(query);
        }

        public DataTable Consulta(MInventario obj)
        {
            query = "";
            return new Manager_BD().ExecuteTbl(query);
        }
    }
}