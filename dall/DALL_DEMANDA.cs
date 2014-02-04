using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dall
{
    public class DALL_DEMANDA
    {
        public bool Guardar(demanda pdemanda)
        {
            bool bGuardado = false;
            demanda Odemanda = new demanda();

            int iAdmin = 0;

            try
            {
                using (var context = new expedientes_jbjEntities())
                {



                    iAdmin = (from p in context.demandas where p.id_demanda.Equals(pdemanda.id_demanda) select p.id_demanda).Count();
                    if (iAdmin == 0)
                    {
                        Odemanda.id_demanda= 0;
                        Odemanda.id_gestion = pdemanda.id_gestion;
                        Odemanda.id_contraparte = pdemanda.id_contraparte;
                        Odemanda.tipo_demanda = pdemanda.tipo_demanda;
                        Odemanda.Sentencia = pdemanda.Sentencia;
                        Odemanda.Relacion_hechos = pdemanda.Relacion_hechos;
                        Odemanda.Fecha_fin = pdemanda.Fecha_fin;
                       // Odemanda.Fecha_ini = pdemanda.Fecha_ini;
                        Odemanda.Peticion = pdemanda.Peticion;
                        Odemanda.Firma = pdemanda.Firma;
                        Odemanda.no_acusacion = pdemanda.no_acusacion;
                        Odemanda.no_expfiscal = pdemanda.no_expfiscal;
                        Odemanda.no_expjudicial = pdemanda.no_expjudicial;
                        Odemanda.no_exppolicial = pdemanda.no_exppolicial;
                        Odemanda.juzgado = pdemanda.juzgado;
                        Odemanda.Fiscal = pdemanda.Fiscal;
                        Odemanda.Acusador = pdemanda.Acusador;
                        Odemanda.Mediacion = pdemanda.Mediacion;
                        context.AddTodemandas(Odemanda);
                    }
                    else
                    {
                        Odemanda = context.demandas.Where(p => p.id_demanda.Equals(pdemanda.id_demanda)).FirstOrDefault();
                        if (Odemanda != null)
                        {

                           
                            
                            Odemanda.tipo_demanda = pdemanda.tipo_demanda;
                            Odemanda.Sentencia = pdemanda.Sentencia;
                            Odemanda.Relacion_hechos = pdemanda.Relacion_hechos;
                            Odemanda.Fecha_fin = pdemanda.Fecha_fin;
                         //   Odemanda.Fecha_ini = pdemanda.Fecha_ini;
                            Odemanda.Peticion = pdemanda.Peticion;
                            Odemanda.Firma = pdemanda.Firma;
                            Odemanda.no_acusacion = pdemanda.no_acusacion;
                            Odemanda.no_expfiscal = pdemanda.no_expfiscal;
                            Odemanda.no_expjudicial = pdemanda.no_expjudicial;
                            Odemanda.no_exppolicial = pdemanda.no_exppolicial;
                            Odemanda.juzgado = pdemanda.juzgado;
                            Odemanda.Fiscal = pdemanda.Fiscal;
                            Odemanda.Acusador = pdemanda.Acusador;
                            Odemanda.Mediacion = pdemanda.Mediacion;


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