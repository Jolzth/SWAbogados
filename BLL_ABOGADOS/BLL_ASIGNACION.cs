using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dall;
namespace BLL_ABOGADOS
{
    public class BLL_ASIGNACION
    {
        public bool Guardar(asignacion oUsuario)
        {
            bool bguardado = false;
            DALL_ASIGNACION dall = new DALL_ASIGNACION();
            try
            {
                bguardado = dall.Guardar(oUsuario);

                return bguardado;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}