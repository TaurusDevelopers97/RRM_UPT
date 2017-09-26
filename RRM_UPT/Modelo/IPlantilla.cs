using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RRM_UPT.Modelo
{
    interface IPlantilla <T>
    {
        int Alta(T obj);
        int Baja(T obj);
        int Modificacion(T obj);
        DataTable Consulta(T obj);
    }
}
