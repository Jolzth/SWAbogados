using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dall;
namespace BLL_ABOGADOS
{
    public class BLL_NOTARIO
    {
        public bool Guardar(notariado oUsuario)
        {
            bool bguardado = false;
            DALL_NOTARIO dall = new DALL_NOTARIO();
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
        public bool Guardarsujeto(sujeto oUsuario)
        {
            bool bguardado = false;
            DALL_NOTARIO dall = new DALL_NOTARIO();
            try
            {
                bguardado = dall.Guardarsujeto(oUsuario);

                return bguardado;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}