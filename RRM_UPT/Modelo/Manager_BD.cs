using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace RRM_UPT.Modelo
{
    public class Manager_BD
    {
        public Manager_BD()
        {
            //establecer conexion
        }

        public int ExecuteRow(string query)
        {
            int row = 0;
            return row;
        }

        public DataTable ExecuteTbl(string query)
        {
            DataTable tbl = new DataTable();
            return tbl;
        }

    }
}