using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dall;
namespace BLL_ABOGADOS
{
    public class BLL_GESTION
    {
        public bool Guardar(gestion oUsuario)
        {
            bool bguardado = false;
            DALL_GESTION dall = new DALL_GESTION();
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