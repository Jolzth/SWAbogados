using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dall
{
    public class DALL_CONTRAPARTE
    {
        public bool Guardar(contraparte pcontraparte)
        {
            bool bGuardado = false;
            contraparte Ocontraparte = new contraparte();

            int iAdmin = 0;

            try
            {
                using (var context = new expedientes_jbjEntities())
                {



                    iAdmin = (from p in context.contrapartes where p.id_contraparte.Equals(pcontraparte.id_contraparte) select p.id_contraparte).Count();
                    if (iAdmin == 0)
                    {
                        Ocontraparte.id_contraparte = pcontraparte.id_contraparte;
                        Ocontraparte.no_ced = pcontraparte.no_ced;
                        Ocontraparte.Nombres = pcontraparte.Nombres;
                        Ocontraparte.Oficio = pcontraparte.Oficio;
                        Ocontraparte.Apellidos = pcontraparte.Apellidos;
                        Ocontraparte.Edo_civil = pcontraparte.Edo_civil;
                        Ocontraparte.Domicilio = pcontraparte.Domicilio;
                        Ocontraparte.Edad = pcontraparte.Edad;
                        context.AddTocontrapartes(Ocontraparte);
                    }
                    else
                    {
                        Ocontraparte= context.contrapartes.Where(p => p.id_contraparte.Equals(pcontraparte.id_contraparte)).FirstOrDefault();
                        if (Ocontraparte != null)
                        {

                            Ocontraparte.no_ced = pcontraparte.no_ced;
                            Ocontraparte.Nombres = pcontraparte.Nombres;
                            Ocontraparte.Oficio = pcontraparte.Oficio;
                            Ocontraparte.Apellidos = pcontraparte.Apellidos;
                            Ocontraparte.Edo_civil = pcontraparte.Edo_civil;
                            Ocontraparte.Domicilio = pcontraparte.Domicilio;
                            Ocontraparte.Edad = pcontraparte.Edad;
                            

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