using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dall;
namespace BLL_ABOGADOS
{
    public class BLL_DETCONTACTO
    {
        public bool GuardarMensaje(detalle_consulta oUsuario)
        {
            bool bguardado = false;
            DALL_DETCONTACTO dall = new DALL_DETCONTACTO();
            try
            {
                bguardado = dall.GuardarMensaje(oUsuario);

                return bguardado;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}