using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dall;
namespace BLL_ABOGADOS
{
    public class BLL_CONTRAPARTE
    {
        public bool Guardar(contraparte oUsuario)
        {
            bool bguardado = false;
            DALL_CONTRAPARTE dall = new DALL_CONTRAPARTE();
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