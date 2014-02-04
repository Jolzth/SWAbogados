using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dall
{
    public class DALL_GESTION
    {
        //SITEMAP
        public bool Guardar(gestion pGESTION)
        {
            bool bGuardado = false;
            gestion Ogestion = new gestion();

            int iAdmin = 0;

            try
            {
                using (var context = new expedientes_jbjEntities())
                {



                    iAdmin = (from p in context.gestions where p.id_gestion.Equals(pGESTION.id_gestion) select p.id_gestion).Count();
                    if (iAdmin == 0)
                    {
                        Ogestion.id_gestion= 0;
                        Ogestion.id_honorario = pGESTION.id_honorario;
                        Ogestion.FECHA = DateTime.Now;
                        Ogestion.ACTIVO = pGESTION.ACTIVO;

                        context.AddTogestions(Ogestion);
                    }
                    else
                    {
                        Ogestion = context.gestions.Where(p => p.id_gestion.Equals(pGESTION.id_gestion)).FirstOrDefault();
                        if (Ogestion != null)
                        {
                            Ogestion.id_honorario = pGESTION.id_honorario;

                        }
                    }
                    context.SaveChanges();
                    bGuardado = true;
                }

                return bGuardado;

            }






            catch (Exception)
            {

                throw;
            }





        }
        

    }
}