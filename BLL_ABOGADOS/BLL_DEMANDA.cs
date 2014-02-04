using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dall;
namespace BLL_ABOGADOS
{
    public class BLL_DEMANDA
    {
        public bool Guardar(demanda oUsuario)
        {
            bool bguardado = false;
            DALL_DEMANDA dall = new DALL_DEMANDA();
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