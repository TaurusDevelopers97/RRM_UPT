using RRM_UPT.Modelo;
using RRM_UPT.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace RRM_UPT.Presentador
{
    public class Presentador
    {
        IModelo modelo;
        DataTable tbl;

        public Presentador(IModelo modelo)
        {
            this.modelo = modelo;
        }

        public void Log_in()
        {

        }

        #region Altas
        public int A_Inventario()
        {
            return new MInventario().Alta(modelo.inventario);
        }
        public int A_Resguardo()
        {
            return new MResguardo().Alta(modelo.resguardo);
        }
        public int A_Historial()
        {
            return new MHistorial().Alta(modelo.historial);
        }
        public int A_Usuario()
        {
            return 0;
        }
        #endregion

        #region Bajas
        public int B_Inventario()
        {
            return new MInventario().Baja(modelo.inventario);
        }
        public int B_Resguardo()
        {
            return new MResguardo().Baja(modelo.resguardo);
        }
        public int B_Historial()
        {
            return new MHistorial().Baja(modelo.historial);
        }
        public int B_Usuario()
        {
            return 0;
        }
        #endregion

        #region Modificaciones
        public int M_Inventario()
        {
            return new MInventario().Modificacion(modelo.inventario);
        }
        public int M_Resguardo()
        {
            return new MResguardo().Modificacion(modelo.resguardo);
        }
        public int M_Historial()
        {
            return new MHistorial().Modificacion(modelo.historial);
        }
        public int M_Usuario()
        {
            return 0;
        }
        #endregion

        #region Consultas
        public DataTable C_Inventario()
        {
            tbl = new DataTable();
            return tbl = new MInventario().Consulta(modelo.inventario);
        }
        public DataTable C_Resguardo()
        {
            tbl = new DataTable();
            return tbl = new MResguardo().Consulta(modelo.resguardo);
        }
        public DataTable C_Historial()
        {
            tbl = new DataTable();
            return tbl = new MHistorial().Consulta(modelo.historial);
        }
        public DataTable C_Usuario()
        {
            tbl = new DataTable();
            return tbl;
        }
        #endregion
    }
}