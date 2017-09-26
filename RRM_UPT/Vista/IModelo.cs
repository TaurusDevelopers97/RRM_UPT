using RRM_UPT.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRM_UPT.Vista
{
    public interface IModelo
    {
        MUsuario usuario { get; set; }
        MResguardo resguardo { get; set; }
        MInventario inventario { get; set; }
        MHistorial historial { get; set; }
    }
}
