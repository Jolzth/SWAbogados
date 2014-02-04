using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dall
{



    public class DALL_NOTARIO
    {
        public bool Guardar(notariado pnotario)
        {
            bool bGuardado = false;
            notariado Onotario = new notariado();

            int iAdmin = 0;

            try
            {
                using (var context = new expedientes_jbjEntities())
                {



                    iAdmin = (from p in context.notariadoes where p.id_notariado.Equals(pnotario.id_notariado) select p.id_notariado).Count();
                    if (iAdmin == 0)
                    {
                        Onotario.id_notariado= 0;
                        Onotario.id_gestion = pnotario.id_gestion;
                        Onotario.no_escritura = pnotario.no_escritura;
                       // Onotario.Fecha = pnotario.Fecha;
                        Onotario.Tipo_notariado = pnotario.Tipo_notariado;
                        Onotario.Objeto = pnotario.Objeto;
                       
                        Onotario.Folio = pnotario.Folio;
                        context.AddTonotariadoes(Onotario);
                    }
                    else
                    {
                        Onotario = context.notariadoes.Where(p => p.id_notariado.Equals(pnotario.id_notariado)).FirstOrDefault();
                        if (Onotario != null)
                        {
                            Onotario.id_gestion = pnotario.id_gestion;
                            Onotario.no_escritura = pnotario.no_escritura;
                           // Onotario.Fecha = pnotario.Fecha;
                            Onotario.Tipo_notariado = pnotario.Tipo_notariado;
                            Onotario.Objeto = pnotario.Objeto;

                            Onotario.Folio = pnotario.Folio;

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


        public bool Guardarsujeto(sujeto pnotario)
        {
            bool bGuardado = false;
            sujeto Onotario = new sujeto();

            int iAdmin = 0;

            try
            {
                using (var context = new expedientes_jbjEntities())
                {



                    iAdmin = (from p in context.sujetos where p.id_sujeto.Equals(pnotario.id_sujeto) select p.id_sujeto).Count();
                    if (iAdmin == 0)
                    {
                        Onotario.id_notariado = pnotario.id_notariado;
                        Onotario.id_sujeto= 0;
                        Onotario.Nombre_completo = pnotario.Nombre_completo;
                        Onotario.Tipo_sujeto = pnotario.Tipo_sujeto;
                        
                        context.AddTosujetos(Onotario);
                    }
                    else
                    {
                        //Onotario = context.notariadoes.Where(p => p.id_notariado.Equals(pnotario.id_notariado)).FirstOrDefault();
                        //if (Onotario != null)
                        //{
                        //    Onotario.id_gestion = pnotario.id_gestion;
                        //    Onotario.no_escritura = pnotario.no_escritura;
                        //    Onotario.Fecha = pnotario.Fecha;
                        //    Onotario.Tipo_notariado = pnotario.Tipo_notariado;
                        //    Onotario.Objeto = pnotario.Objeto;

                        //    Onotario.Folio = pnotario.Folio;

                        //}
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