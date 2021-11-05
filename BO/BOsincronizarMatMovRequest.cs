
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using WSFAPIUNI.TO;
using WSFAPIUNI.DAO;
using System.Configuration;
using WSFAPIUNI.WsFaFactu;
using Ophelia.Comun;
using System.Xml;
using WSFAPIUNI.ServiceReference1;
using DigitalWare.Apps.Utilities.Gn.DAO;
using Digitalware.Apps.Utilities.Fa.TO;
using Digitalware.Apps.Utilities.Fa.DAO;
using Digitalware.Apps.Utilities.In.DAO;
using SevenFramework.DataBase;

namespace WSFAPIUNI.BO
{
    public class BOsincronizarMatMovRequest
    {
        int emp_codi = int.Parse(ConfigurationManager.AppSettings["emp_codi"].ToString());
        DAOFaClien daoFaclien = new DAOFaClien();
        DAOFaPiuni daoFapiuni = new DAOFaPiuni();
        DAO.DAOGnArbol DAOGnArbol = new DAO.DAOGnArbol();
        DAOAfActiv DAOActiv = new DAOAfActiv();
        DAOTipdo daoTipdo = new DAOTipdo();
        DAOFaFactu DAOFactu = new DAOFaFactu();
        WiewSsec.TOFaClien newFaclien = new WiewSsec.TOFaClien();
        DAOFaPcfiu DAOFaPcfiu = new DAOFaPcfiu();
        DAOInProdu DAOProdu = new DAOInProdu();
        DAOFaPcniu DAOPcniu = new DAOFaPcniu();
        DAOGnParam DAOParam = new DAOGnParam();
        DAOFaCpiun DAOPiun = new DAOFaCpiun();
        WsFaFactu.SFAFACTU ws = new WsFaFactu.SFAFACTU();
        DAOCaCxcob DAOCxCob = new DAOCaCxcob();



        public sincronizarMatMovResponse sincronizarMatMovRequest(ServiceReference1.T_TIPO_MATRICULA TipoMatricula)
        {
            sincronizarMatMovResponse er = new sincronizarMatMovResponse();

            try
            {
                if (string.IsNullOrEmpty(TipoMatricula.codigoEstudio))
                    TipoMatricula.codigoEstudio = "0";               
                //if (ManejaSfapiuoi.dig_valo == "S")
                //{
                    //Se crea cliente o actualiza
                    ProcessClientOpc(TipoMatricula);
                    //Se crean las facturas
                    CreateFaFactuOpc(TipoMatricula);
                //}
                //else
                //{
                //    //Se crea cliente o actualiza
                //    ProcessClient(TipoMatricula);
                //    //Se crean las facturas
                //    CreateFaFactu(TipoMatricula);
                //}





                er.mensajeRespuesta = "Matrícula registrada correctamente";
                er.codigoRegistro = TipoMatricula.codigoRegistro;
                return er;
                //}
                //throw new Exception("Documento yan existe");
            }
            catch (Exception ex)
            {
                er.codigoRegistro = TipoMatricula.codigoRegistro;
                er.codigoRespuesta = 1;
                er.mensajeRespuesta = ex.Message;
                return er;
            }





        }

        public void initTransaction()
        {

        }
        public void ProcessClient(ServiceReference1.T_TIPO_MATRICULA TipoMatricula)
        {
            WiewSsec.SIEWSSEC wsClien = new WiewSsec.SIEWSSEC();
            var faclien = daoFaclien.getFaClien(emp_codi, TipoMatricula.numDocumento);
            var tipdo = daoTipdo.GetGnTipdo(TipoMatricula.tipoDocumento);
            if (tipdo == null)
                throw new Exception("Tipo de documento no existe");
            var Fapiuni = daoFapiuni.getFaPiuni(emp_codi);
            if (Fapiuni == null)
                throw new Exception("STSFAPIUNI no se encuentra parametrizado");
            if (faclien == null)
            {
                newFaclien.emp_codi = emp_codi;
                newFaclien.tip_codi = int.Parse(tipdo.tip_codi.ToString());
                newFaclien.ter_coda = TipoMatricula.numDocumento;
                newFaclien.cli_dive = 0;
                newFaclien.cli_nomb = TipoMatricula.nombrePersona;
                newFaclien.cli_apel = TipoMatricula.apellidosPersona;
                newFaclien.cli_noco = string.Format("{0} {1}", TipoMatricula.nombrePersona, TipoMatricula.apellidosPersona);
                newFaclien.mod_codi = 3;
                newFaclien.cli_esta = "A";
                newFaclien.cli_audp = "S";
                newFaclien.cli_coda = TipoMatricula.numDocumento;
                newFaclien.tcl_codi = Fapiuni.tcl_codi;
                newFaclien.cal_codi = Fapiuni.cal_codi;
                newFaclien.coc_codi = Fapiuni.coc_codi;
                newFaclien.cim_codi = Fapiuni.cim_codi;
                newFaclien.arb_csuc = DAOGnArbol.GetArbCodi(emp_codi, 2, Fapiuni.arb_sucu);
                newFaclien.dcl_dire = TipoMatricula.direccionDom;
                newFaclien.dcl_ntel = TipoMatricula.telefonoFijoDom == null ? TipoMatricula.telefonoMovil : TipoMatricula.telefonoFijoDom;
                newFaclien.dcl_mail = TipoMatricula.email;
                newFaclien.dcl_nfax = "";
                newFaclien.arb_clte = "";
                newFaclien.cli_inna = "S";
                newFaclien.ven_codi = Fapiuni.ven_codi;
                newFaclien.arb_ccec = DAOGnArbol.GetArbCodiAnt(emp_codi, 3, TipoMatricula.codigoEstudio);
                if (newFaclien.arb_ccec == null)
                    throw new Exception("Código plan de estudios no pertenece a un centro de costos válido");
                newFaclien.lis_codi = Fapiuni.lis_codi;
                newFaclien.ven_codi = Fapiuni.ven_codi;
                newFaclien.lis_codi = Fapiuni.lis_codi;
                newFaclien.dcl_obse = ".";
                newFaclien.dcl_apar = "";
                newFaclien.dcl_cloc = "";
                newFaclien.cli_anex = "";
                newFaclien.cli_hpra = "";
                newFaclien.cli_fecm = 0;
                newFaclien.cli_feca = 0;
                newFaclien.cli_audp = "S";
                newFaclien.arb_cpro = DAOGnArbol.GetArbCodi(emp_codi, 4, Fapiuni.arb_proy);
                newFaclien.arb_care = DAOGnArbol.GetArbCodi(emp_codi, 1, Fapiuni.arb_area);
                newFaclien.act_codi = DAOActiv.GetActCodi(emp_codi, Fapiuni.act_cont);
                newFaclien.cli_esta = "A";
                newFaclien.pai_codi = Fapiuni.pai_codi;
                newFaclien.dep_codi = Fapiuni.dep_codi;
                newFaclien.mun_codi = Fapiuni.mun_codi;
                newFaclien.arb_clte = DAOGnArbol.GetArbCodi(emp_codi, 6, Fapiuni.arb_conc);
                newFaclien.ase_codi = Fapiuni.ase_codi;
                newFaclien.cob_cont = Fapiuni.cob_cont;


                //newFaclien.ase_codi = 
                //falta plan de estudios
                WiewSsec.TSalida salida = new WiewSsec.TSalida();



                string siewssecReturn = wsClien.SyncFaClien(newFaclien.emp_codi, newFaclien.tip_codi, newFaclien.ter_coda, newFaclien.cli_dive, newFaclien.cli_nomb, newFaclien.cli_apel, newFaclien.cli_noco,
                    newFaclien.mod_codi, newFaclien.pai_codi, newFaclien.dep_codi, newFaclien.mun_codi, newFaclien.cli_coda, newFaclien.tcl_codi, newFaclien.cal_codi,
                    newFaclien.coc_codi, newFaclien.cim_codi, newFaclien.arb_csuc, newFaclien.dcl_dire, newFaclien.dcl_ntel, newFaclien.dcl_mail,
                    newFaclien.dcl_nfax, newFaclien.arb_clte, newFaclien.cli_inna, newFaclien.ven_codi, newFaclien.arb_ccec, newFaclien.lis_codi, newFaclien.dcl_obse,
                    newFaclien.dcl_apar, newFaclien.dcl_cloc, newFaclien.cli_anex, newFaclien.cli_hpra, newFaclien.cli_fecm, newFaclien.cli_feca, newFaclien.cli_audp);

                //if(salida.Retorno>0)
                //    throw new Exception(salida.TxtError);  

                salida = GetValueFromSiewSsec(siewssecReturn);
                if (salida.Retorno > 0)
                    throw new Exception(salida.TxtError);
                //Se actualiza ter_code, ya que el COM no lo incluye, por tanto no es visible en Seven
                daoFaclien.updateFaclien(emp_codi, salida.CliCodi);
            }


        }
        public void ProcessClientOpc(ServiceReference1.T_TIPO_MATRICULA TipoMatricula)
        {
            WiewSsec.SIEWSSEC wsClien = new WiewSsec.SIEWSSEC();
            var faclien = daoFaclien.getFaClien(emp_codi, TipoMatricula.numDocumento);
            List<SQLParams> sQLParams = new List<SQLParams>()
            {
                new SQLParams("DIG_CODI", "SIE000003")
            };
            var SIE000003 = DAO_Gn_Digfl.GetGnFlag(sQLParams);
            sQLParams = new List<SQLParams>()
            {
                new SQLParams("DIG_CODI", "SFA000016")
            };
            var SFA000016 = DAO_Gn_Digfl.GetGnFlag(sQLParams);
            if (SIE000003.dig_valo == "S" && SFA000016.dig_valo == "S")
            {
                throw new Exception("SIE000003  y  SFA000016 no pueden estar activos simultáneamente");
            }

            var tipdo = daoTipdo.GetGnTipdo(TipoMatricula.tipoDocumento);
            if (tipdo == null)
                throw new Exception("Tipo de documento no existe");
            var Fapiuni = daoFapiuni.getFaPiuni(emp_codi);
            if (Fapiuni == null)
                throw new Exception("STSFAPIUNI no se encuentra parametrizado");
            var arbolCodigoEstudios = new DAO_Gn_Arbol().GetGnArbolByArbCoan(emp_codi, 3, TipoMatricula.codigoEstudio);
            if (arbolCodigoEstudios == null)
                throw new Exception(string.Format("No se encontró Código de estudio ", TipoMatricula.periodoAcademico.Substring(0, 4), TipoMatricula.codigoEstudio));
            var sfapiuoi = new DAO_Fa_Piuoi().GetFaPiuoi(emp_codi, arbolCodigoEstudios.arb_cont, int.Parse(TipoMatricula.periodoAcademico.Substring(0, 4)));
            if (sfapiuoi == null)
                throw new Exception(string.Format("Programa SFAPIUOI no parametrizado para año {0} y Código de estudio {1}", TipoMatricula.periodoAcademico.Substring(0, 4), TipoMatricula.codigoEstudio));


            //if (TipoMatricula.codigoSubtipoEstudio != sfapiuoi.tcl_codi.ToString())
            //    throw new Exception(string.Format("No se encontró coincidencia para el subtipo de estudio {0}", TipoMatricula.codigoSubtipoEstudio));
            newFaclien.emp_codi = emp_codi;
            newFaclien.tip_codi = int.Parse(tipdo.tip_codi.ToString());
            newFaclien.ter_coda = TipoMatricula.numDocumento;
            newFaclien.cli_dive = 0;
            newFaclien.cli_nomb = TipoMatricula.nombrePersona;
            newFaclien.cli_apel = TipoMatricula.apellidosPersona;
            newFaclien.cli_noco = string.Format("{0} {1}", TipoMatricula.nombrePersona, TipoMatricula.apellidosPersona);
            newFaclien.mod_codi = new DAO_Gn_Param().GetGnParam(emp_codi).mon_codi;
            newFaclien.cli_esta = "A";
            newFaclien.cli_audp = "S";
            newFaclien.cli_coda = TipoMatricula.numDocumento;
            newFaclien.tcl_codi = sfapiuoi.tcl_codi;
            newFaclien.cal_codi = Fapiuni.cal_codi;
            newFaclien.coc_codi = Fapiuni.coc_codi;
            newFaclien.cim_codi = Fapiuni.cim_codi;
            newFaclien.arb_csuc = DAOGnArbol.GetArbCodi(emp_codi, 2, Fapiuni.arb_sucu);
            if (newFaclien.arb_csuc == "")
                throw new Exception("Sucursal configurada en sfapiuni no válida.");
            newFaclien.dcl_dire = TipoMatricula.direccionDom;
            newFaclien.dcl_ntel = TipoMatricula.telefonoFijoDom == null ? TipoMatricula.telefonoMovil : TipoMatricula.telefonoFijoDom;
            newFaclien.dcl_mail = TipoMatricula.email;
            newFaclien.dcl_nfax = TipoMatricula.telefonoFijoDom == null ? TipoMatricula.telefonoMovil : TipoMatricula.telefonoFijoDom;
            newFaclien.arb_clte = "";
            newFaclien.cli_inna = "S";
            newFaclien.ven_codi = Fapiuni.ven_codi;
            newFaclien.arb_ccec = DAOGnArbol.GetArbCodiAnt(emp_codi, 3, TipoMatricula.codigoEstudio);
            if (newFaclien.arb_ccec == null)
                throw new Exception("Código plan de estudios no pertenece a un centro de costos válido");
            newFaclien.lis_codi = Fapiuni.lis_codi;
            newFaclien.ven_codi = Fapiuni.ven_codi;
            newFaclien.lis_codi = Fapiuni.lis_codi;
            newFaclien.dcl_obse = TipoMatricula.codigoPersona.ToString();
            newFaclien.dcl_apar = "0";
            newFaclien.dcl_cloc = "0";
            newFaclien.cli_anex = ".";
            newFaclien.cli_hpra = "0";
            newFaclien.cli_fecm = 0;
            newFaclien.cli_feca = 0;
            newFaclien.cli_audp = "N";
           
         

             sQLParams = new List<SQLParams>()
                {
                    new SQLParams("DIG_CODI","SFA000024")
                };
            var ManejaSfapiuoi = DAO_Gn_Digfl.GetGnFlag(sQLParams);
            if (ManejaSfapiuoi.dig_valo == "S")
            {
                var codigoModalidad = new DAO_Gn_Arbol().GetGnArbolByArbCoan(emp_codi, 1, TipoMatricula.codigoModalidadPlan);
                if (codigoModalidad == null)
                    throw new Exception(string.Format("Código de modalidad {0} no parametrizado en seven-erp", TipoMatricula.codigoModalidadPlan));
                newFaclien.arb_care = codigoModalidad.arb_codi;
                var proyecto = new DAO_Gn_Arbol().GetGnArbolByArbCoan(emp_codi, 4, TipoMatricula.periodoAcademico);
                if (proyecto == null)
                    throw new Exception(string.Format("No se encontró periodo académico", TipoMatricula.periodoAcademico));
                newFaclien.arb_cpro = proyecto.arb_codi;
            }
            else
            {
                newFaclien.arb_care= DAOGnArbol.GetArbCodi(emp_codi, 1, Fapiuni.arb_area);
                newFaclien.arb_cpro = DAOGnArbol.GetArbCodi(emp_codi, 4, Fapiuni.arb_proy);
            }
           

          
            newFaclien.act_codi = DAOActiv.GetActCodi(emp_codi, Fapiuni.act_cont);
            newFaclien.cli_esta = "A";
            newFaclien.pai_codi = Fapiuni.pai_codi;
            newFaclien.dep_codi = Fapiuni.dep_codi;
            newFaclien.mun_codi = Fapiuni.mun_codi;
            newFaclien.arb_clte = DAOGnArbol.GetArbCodi(emp_codi, 6, Fapiuni.arb_conc);
            newFaclien.ase_codi = Fapiuni.ase_codi;
            newFaclien.cob_cont = Fapiuni.cob_cont;
            //newFaclien.ase_codi = 
            //falta plan de estudios
            WiewSsec.TSalida salida = new WiewSsec.TSalida();



            salida = wsClien.SyncFaClienComplex(newFaclien);

            //if(salida.Retorno>0)
            //    throw new Exception(salida.TxtError);  

            //salida = GetValueFromSiewSsec(siewssecReturn.);
            if (salida.Retorno > 0)
            {
                if (salida.TxtError == null)
                    throw new Exception("Error consumiendo el método SyncFaClienComplex, el error devuelto es desconocido");
                throw new Exception(salida.TxtError);
            }

            //Se actualiza ter_code, ya que el COM no lo incluye, por tanto no es visible en Seven
            daoFaclien.updateFaclien(emp_codi, salida.CliCodi);



        }

        public List<TOOutFaFactu> CreateFaFactu(ServiceReference1.T_TIPO_MATRICULA TipoMatricula)
        {
            List<TOOutFaFactu> facturas = new List<TOOutFaFactu>();
            try
            {
                //Obtengo la llave única 
                string fac_ndoc = GetKeyFaFactu(TipoMatricula);
                var facturasAnular = DAOFactu.GetDocFaFactu(emp_codi, fac_ndoc);
                bool horasAdicionales = false;
                //Si trae más de un recibo es porque se van a pagar horas adicionales, no debe anularse la matrícula
                if (TipoMatricula.desglosesMatMov.Where(f => f.tipoConcepto == "A").ToList().Count > 1)
                {
                    horasAdicionales = true;
                    if (TipoMatricula.desglosesMatMov.Where(f => f.tipoConcepto == "A").ToList().Count > TipoMatricula.recibosMatMov.Count)
                        throw new Exception("Se debe definir un segundo tipo de recibo si se van a pagar horas adicionales");

                }

                if (facturasAnular.Count > 0 && !horasAdicionales)
                {


                    //Buscamos la factura que esté aplicada para anularla , así como anualar las otras facturas generadas
                    TOFaFactu facturaMatricula = facturasAnular.Where(f => f.fac_tipo == "F" && f.fac_esta == "A").FirstOrDefault();
                    if (facturaMatricula != null)
                    {
                        CA_CXCOB infoPago = DAOCxCob.GetCaCxCobPago(emp_codi, facturaMatricula.fac_cont);
                        if (infoPago.cxc_sald == 0)
                        {
                            string respuesta = ws.AnularFacturaConCruce(emp_codi, facturaMatricula.fac_cont);
                            TOOutFaFactu anulaRespuesta = GetValueFromXmlNode(respuesta);
                            if (anulaRespuesta.retorno != 0)
                                throw new Exception(anulaRespuesta.txtError);
                        }

                    }
                    //List<TOFaCpiun> FacturasParaAnular = DAOPiun.GetFaCpiun(emp_codi,fac)
                }

                //Se genera factura de maatrícula ordinaria
                facturas.Add(ProcessFaFactu(TipoMatricula, "Ord", "", null, null, horasAdicionales));
                if (TipoMatricula.recibosMatMov.Count > 0)
                {
                    //Se genera factura de matrícula extraordinaria
                    if (TipoMatricula.recibosMatMov[0].importePago1 > 0)
                    {
                        facturas.Add(ProcessFaFactu(TipoMatricula, "Ext", "", null, null, horasAdicionales));
                    }
                    //Se genera matrícula de pago extémporaneo
                    if (TipoMatricula.recibosMatMov[0].importePago2 > 0)
                    {
                        facturas.Add(ProcessFaFactu(TipoMatricula, "Exe", "", null, null, horasAdicionales));
                    }
                }
                if (TipoMatricula.desglosesMatMov.Count > 0)
                {
                    List<ServiceReference1.T_TIPO_DESGLOSE> notasCredito = TipoMatricula.desglosesMatMov.Where(d => d.tipoConcepto == "T").ToList();
                    //Por cada concepto T se genera una nota crédito con cruce a la factura de la matricula ordinaria
                    foreach (ServiceReference1.T_TIPO_DESGLOSE desglose in notasCredito)
                    {
                        facturas.Add(ProcessFaFactu(TipoMatricula, "", "Note", desglose, facturas[0], horasAdicionales));
                    }
                }

            }
            catch (Exception ex)
            {
                if (facturas.Count > 0)
                {
                    string respuesta = ws.AnularFacturaConCruce(emp_codi, facturas[0].fac_cont);
                    TOOutFaFactu anulaRespuesta = GetValueFromXmlNode(respuesta);
                    if (anulaRespuesta.retorno != 0)
                        throw new Exception(anulaRespuesta.txtError);
                }
                throw new Exception(ex.Message);
            }

            return facturas;
        }

        public List<TOOutFaFactu> CreateFaFactuOpc(ServiceReference1.T_TIPO_MATRICULA TipoMatricula)
        {



            List<TOOutFaFactu> facturas = new List<TOOutFaFactu>();


            ////Obtengo la llave única 
            string fac_ndoc = GetKeyFaFactu(TipoMatricula);
            var facturasAnular = DAOFactu.GetDocFaFactu(emp_codi, fac_ndoc);
            
            bool horasAdicionales = false;
            //Si trae más de un recibo es porque se van a pagar horas adicionales, no debe anularse la matrícula
            if (TipoMatricula.desglosesMatMov.Where(f => f.tipoConcepto == "A").ToList().Count > 1)
            {
                horasAdicionales = true;
                if (TipoMatricula.desglosesMatMov.Where(f => f.tipoConcepto == "A").ToList().Count > TipoMatricula.recibosMatMov.Count && !isUdca())
                    throw new Exception("Se debe definir un segundo tipo de recibo si se van a pagar horas adicionales");

            }

            // Si hay facturas para anular
            if (facturasAnular.Count > 0 && !horasAdicionales)
            {

                //Buscamos la factura que esté aplicada para anularla , así como anualar las otras facturas generadas
                TOFaFactu facturaMatricula = facturasAnular.Where(f => f.fac_tipo == "F" && f.fac_esta == "A").FirstOrDefault();
                if (facturaMatricula != null)
                {
                    CA_CXCOB infoPago = DAOCxCob.GetCaCxCobPagoOPC(emp_codi, facturaMatricula.fac_cont);
                    var cuentasxCobrarExistentesReferencia = DAOCxCob.GetCaCxcob(emp_codi, facturaMatricula.fac_cont, TipoMatricula.recibosMatMov.FirstOrDefault().referenciaRecibo);
                    if (infoPago.cxc_sald >0)
                    {
                        string respuesta = ws.AnularFacturaConCruce(emp_codi, facturaMatricula.fac_cont);
                        TOOutFaFactu anulaRespuesta = GetValueFromXmlNode(respuesta);
                        if (anulaRespuesta.retorno != 0)
                            throw new Exception(anulaRespuesta.txtError);
                    }
                    //else
                    //{
                    //    //Si no tiene cruces verifica si ya existe la referencia y anula su factura
                    //    if (cuentasxCobrarExistentesReferencia != null && cuentasxCobrarExistentesReferencia.Count > 0)
                    //    {
                    //        string respuesta = ws.AnularFacturaConCruce(emp_codi, facturaMatricula.fac_cont);
                    //        TOOutFaFactu anulaRespuesta = GetValueFromXmlNode(respuesta);
                    //        if (anulaRespuesta.retorno != 0)
                    //            throw new Exception(anulaRespuesta.txtError);
                    //    }
                    //}

                    //Segunda escenario
                    //Verifricar si la referencia  de referencia recibo ya existe en ca_cxcob con ese cxc_cref y ese fac_ndoc y anularla si existe



                }

            }

            try
            {
               // Obtiene el arbolCodigoEstudios
                var arbolCodigoEstudios = new DAO_Gn_Arbol().GetGnArbolByArbCoan(emp_codi, 3, TipoMatricula.codigoEstudio);
                 // Si tiene algún tipoConcepto A o son horas adicionales empieza a crear las diferentes facturas, si no , crea pecuniarios o certificados únicamente
                if (TipoMatricula.desglosesMatMov.Where(d => d.tipoConcepto == "A").ToList().Count == 1 || horasAdicionales)
                {
                    //Anulación Parcial si el primer recibo es cobrado = S y ImportePagoOportuno es negativo
                    if (TipoMatricula.recibosMatMov.FirstOrDefault().esCobrado == "S" && TipoMatricula.recibosMatMov.LastOrDefault().ImportePagoOportuno < 0)
                    {
                        //Crea nota crédito sin cruce
                        facturas.Add(ProcessFaFactuOpc(TipoMatricula, "Note", 0, 1, arbolCodigoEstudios.arb_cont,null));
                    }
                    // Si no , inicia creación de las diferentes facturas
                    else
                    {
                        //decimal descuento = 0;
                        //Boolean aplicaDescuento = false;
                        //if (TipoMatricula.desglosesMatMov.Where(m => m.tipoConcepto == "T").ToList().Count > 0)
                        //{
                        //    aplicaDescuento = true;
                        //    descuento = TipoMatricula.desglosesMatMov[1].importeConcepto;
                        //}
                        //Crea la matrícula ordinaria

                        if (isUdca())
                        {


                            if (TipoMatricula.desglosesMatMov.Where(d => d.tipoConcepto == "A").Count() == 2 && TipoMatricula.recibosMatMov.FirstOrDefault(r => r.esCobrado == "N") != null)
                            {

                                // Crear Factura de matrícula
                                facturas.Add(ProcessFaFactuOpc(TipoMatricula, "Ord", 0, 0, arbolCodigoEstudios.arb_cont, null, false));
                                 // Crea la factura de horas adicionales
                                facturas.Add(ProcessFaFactuOpc(TipoMatricula, "Ord", 1, 0, arbolCodigoEstudios.arb_cont, null, false));

                                // si tiene importePago1 entonces debe agregar una factura extraordinaria
                               if(TipoMatricula.recibosMatMov.FirstOrDefault().importePago1!= null && TipoMatricula.recibosMatMov.FirstOrDefault().importePago1 > 0)
                                {
                                    facturas.Add(ProcessFaFactuOpc(TipoMatricula, "Extr", 0, 0, arbolCodigoEstudios.arb_cont, null, false));

                                }
                              // si tiene importepago3 crea una factura por pronto pago
                               if(TipoMatricula.recibosMatMov.FirstOrDefault().importePago3 != null && TipoMatricula.recibosMatMov.FirstOrDefault().importePago3 > 0 )
                                {
                                    facturas.Add(ProcessFaFactuOpc(TipoMatricula, "Exe", 0, 0, arbolCodigoEstudios.arb_cont, null, false));
                                }
                              


                            }
                        }

                        else
                        {


                            facturas.Add(ProcessFaFactuOpc(TipoMatricula, "Ord", 0, 0, arbolCodigoEstudios.arb_cont, null, horasAdicionales));
                            /**/
                            if (TipoMatricula.recibosMatMov[0].fechaPago1Hasta != null)
                            {
                                //Crea la matrícula extrardinaria
                                facturas.Add(ProcessFaFactuOpc(TipoMatricula, "Extr", 0, 0, arbolCodigoEstudios.arb_cont, null, horasAdicionales));
                            }

                            /**/
                            //Crea la matrícula extemporánea
                            if ((TipoMatricula.recibosMatMov[0].importePago3 != null && TipoMatricula.recibosMatMov[0].importePago3 > 0) || (TipoMatricula.recibosMatMov[0].fechaPago2Hasta != null))
                            {
                                facturas.Add(ProcessFaFactuOpc(TipoMatricula, "Exe", 0, 0, arbolCodigoEstudios.arb_cont, null, horasAdicionales));
                            }


                        }

                        //Crea la nota con cruce a la factura
                        IEnumerable<ServiceReference1.T_TIPO_DESGLOSE> notas = TipoMatricula.desglosesMatMov.Where(t => t.tipoConcepto == "T");
                        if (notas.Count() > 0)
                        {
                            foreach (ServiceReference1.T_TIPO_DESGLOSE desglose in notas.ToList())
                            {
                                facturas.Add(ProcessFaFactuOpc(TipoMatricula, "Note", Array.IndexOf(TipoMatricula.desglosesMatMov.ToList().ToArray(), desglose), 0, arbolCodigoEstudios.arb_cont, facturas[0]));
                            }

                        }


                    }
                }
                //Corresponde a anulación total
                if (TipoMatricula.codigoAnulacion != null && TipoMatricula.codigoAnulacion > 0)
                {
                    var recibos = TipoMatricula.recibosMatMov.Where(r => r.esCobrado == "S");
                    if (recibos != null && recibos.Any())
                        facturas.Add(ProcessFaFactuOpc(TipoMatricula, "Note", 0, 1, arbolCodigoEstudios.arb_cont));
                }

                // pecuniarios, certificados...
                if (TipoMatricula.desglosesMatMov.Where(d => d.tipoConcepto == "D").ToList().Count == 1)
                {

                    facturas.Add(ProcessFaFactuOpc(TipoMatricula, "Ord", 0, 0, arbolCodigoEstudios.arb_cont));

                }


            }
            catch (Exception ex)
            {
                if (facturas.Count > 0)
                {
                    string respuesta = ws.AnularFacturaConCruce(emp_codi, facturas[0].fac_cont);
                    TOOutFaFactu anulaRespuesta = GetValueFromXmlNode(respuesta);
                    if (anulaRespuesta.retorno != 0)
                        throw new Exception(anulaRespuesta.txtError);
                }
                throw new Exception(ex.Message);
            }

            return facturas;
        }

      



        public TOOutFaFactu ProcessFaFactu(ServiceReference1.T_TIPO_MATRICULA TipoMatricula, string regist, string type = "", ServiceReference1.T_TIPO_DESGLOSE tipodesglose = null, TOOutFaFactu MatriculaOrd = null, bool horasAdicionales = false)
        {
            //Obtengo la llave única
            string fac_ndoc = GetKeyFaFactu(TipoMatricula);
            TOOutFaFactu fac = new TOOutFaFactu();
            //Contador para hayar la posición del  tipo de recibo con el que se deben contabilizar los valores
            int count = 0;
            int IndexDesglose = 0;
            //Contador para hayar la posición del desglose con el que se van a contabilizar los valores
            if (horasAdicionales)
            {
                //Obtengo la posición de desglose y de tipo de recibo para facturar las horas extras
                var pagoOportuno = TipoMatricula.desglosesMatMov.Where(c => c.tipoConcepto == "A").LastOrDefault().importeConcepto;
                IndexDesglose = TipoMatricula.desglosesMatMov.FindIndex(c => c.importeConcepto == pagoOportuno);
                count = TipoMatricula.recibosMatMov.FindIndex(r => r.ImportePagoOportuno == pagoOportuno);
            }


            //Se consultan parametros de empresa
            TOGnParam param = DAOParam.GetGnParam(emp_codi);
            //Encabezado    
            //Consulta parámetros de facturas            
            TOFaPcfiu FaPcfiu = DAOFaPcfiu.GetFaCfpiu(emp_codi, TipoMatricula.actividadEconomica.ToString(), TipoMatricula.codigoEstudio);

            List<TSFaDdisp> distribucionAut = new List<TSFaDdisp>();
            if (FaPcfiu == null)
                throw new Exception(string.Format("Programa SFAPCFIU no parametrizado para la actividad económica {0} y codigo de estudio {1}", TipoMatricula.actividadEconomica, TipoMatricula.codigoEstudio));
            WsFaFactu.TSFaFactu pfactura = new WsFaFactu.TSFaFactu();
            //crea encabezados y algunas propiedades del detalle que comparten todas las facturas

            IN_PRODU produ = new IN_PRODU();
            List<TSFaDfact> detalles = new List<TSFaDfact>();
            WsFaFactu.TSFaDfact detalle = new WsFaFactu.TSFaDfact();
            WsFaFactu.TSFaDdisp distA = new WsFaFactu.TSFaDdisp();
            pfactura.Emp_codi = int.Parse(ConfigurationManager.AppSettings["emp_codi"].ToString());
            pfactura.Fac_tdis = "A";
            pfactura.Cli_coda = TipoMatricula.numDocumento;
            pfactura.Dcl_codd = 1;
            pfactura.Fac_esta = "A";
            pfactura.Mon_codi = param.mon_codi;
            pfactura.Fac_fech = DateTime.Now;
            pfactura.Fac_feta = DateTime.Now;
            pfactura.Fac_tido = "M";
            pfactura.Fac_peri = TipoMatricula.periodoAcademico;
            string academyPeriod = TipoMatricula.periodoAcademico.Split('-')[1];
            //Cuando se debe crear una nota crédito
            if (type == "Note")
            {
                //Consulta parámetros de notas crédito.
                TOFaPcniu FaPcniu = DAOPcniu.GetFaPcniu(emp_codi, tipodesglose.codigoConcepto.ToString());
                if (FaPcniu == null)
                    throw new Exception("Programa SFAPCNIU no parametrizado");
                List<TSFaCruau> cruces = new List<TSFaCruau>();
                pfactura.Top_codi = FaPcniu.top_code;
                pfactura.Fac_desc = FaPcniu.pcn_obse + " " + TipoMatricula.periodoAcademico;
                pfactura.Arb_csuc = DAOGnArbol.GetArbCodi(emp_codi, 2, FaPcniu.arb_sucu);
                pfactura.Fac_tipo = "C";
                pfactura.Fac_fepo = TipoMatricula.recibosMatMov[count].fechaPagoOportunoHasta.AsDateTime();
                pfactura.Fac_cref = TipoMatricula.recibosMatMov[count].referenciaRecibo;


                if (academyPeriod.ToUpper() == "1S")
                {
                    produ = DAOProdu.ConsultarInProdu(short.Parse(emp_codi.ToString()), FaPcniu.pro_cdep);
                    detalle.Dfa_dest = FaPcniu.dsp_cdep;
                }
                if (academyPeriod.ToUpper() == "2S")
                {
                    produ = DAOProdu.ConsultarInProdu(short.Parse(emp_codi.ToString()), FaPcniu.pro_cdes);
                    detalle.Dfa_dest = FaPcniu.dsp_cdes;
                }
                CA_CXCOB cuentaXcobrar = DAOCxCob.GetCaCxcob(emp_codi, MatriculaOrd.fac_cont).Where(c => c.cxc_sald > 0 && c.cxc_esta == "A").FirstOrDefault();
                detalle.Dfa_valo = Math.Abs(double.Parse(tipodesglose.importeConcepto.ToString()));
                if (detalle.Dfa_valo > cuentaXcobrar.cxc_sald)
                    throw new Exception(string.Format("Saldo de cuenta por cobrar ({0}) es menor al valor del cruce aplicado"));
                detalle.Bod_codi = int.Parse(FaPcniu.bod_codi);
                //Cruce automático a la factura creada en orden de matrícula                    
                TSFaCruau cruce = new TSFaCruau();
                cruce.Cru_valo = detalle.Dfa_valo;
                cruce.Fac_numc = MatriculaOrd.fac_nume;
                cruce.Fac_fecc = MatriculaOrd.fac_fech;
                cruce.Arb_succ = MatriculaOrd.arb_csuc;
                cruce.Top_codc = MatriculaOrd.top_codi;
                cruce.Cxc_cont = cuentaXcobrar.cxc_cont;
                cruces.Add(cruce);
                pfactura.vCruce = cruces.ToArray();
                // pendiente cruce.Fac_fecc 
                //Area                   
                distA.Tar_codi = 1;
                distA.Arb_codi = DAOGnArbol.GetArbCodi(emp_codi, 1, FaPcniu.arb_area);
                distA.Ddi_porc = 100;
                distA.Ddi_tipo = "P";
                distribucionAut.Add(distA);
                //Proyecto
                WsFaFactu.TSFaDdisp distP = new WsFaFactu.TSFaDdisp();
                distP.Tar_codi = 4;
                distP.Arb_codi = DAOGnArbol.GetArbCodi(emp_codi, 4, FaPcniu.arb_proy);
                distP.Ddi_porc = 100;
                distP.Ddi_tipo = "P";
                distribucionAut.Add(distP);
                //Sucursal
                WsFaFactu.TSFaDdisp distS = new WsFaFactu.TSFaDdisp();
                distS.Tar_codi = 2;
                distS.Arb_codi = DAOGnArbol.GetArbCodi(emp_codi, 2, FaPcniu.arb_sucu);
                distS.Ddi_porc = 100;
                distS.Ddi_tipo = "P";
                distribucionAut.Add(distS);
            }
            else
            {
                //Para crear facturas normales
                pfactura.Fac_desc = FaPcfiu.pcf_obse + " " + TipoMatricula.periodoAcademico;
                pfactura.Arb_csuc = DAOGnArbol.GetArbCodi(emp_codi, 2, FaPcfiu.arb_sucu);
                pfactura.Fac_tipo = "F";
                pfactura.Fac_cref = TipoMatricula.recibosMatMov[count].referenciaRecibo;
                detalle.Bod_codi = FaPcfiu.bod_codi;
                switch (FaPcfiu.pcf_tiac)
                {
                    case "M":
                        //Ordinaria
                        if (regist == "Ord")
                        {
                            pfactura.Top_codi = FaPcfiu.top_como;
                            pfactura.Fac_fepo = Convert.ToDateTime(TipoMatricula.recibosMatMov[count].fechaPagoOportunoHasta);
                            if (academyPeriod.ToUpper() == "1S")
                            {
                                produ = DAOProdu.ConsultarInProdu(short.Parse(emp_codi.ToString()), FaPcfiu.pro_cmop);
                                detalle.Dfa_dest = FaPcfiu.dsp_cmop;
                            }
                            if (academyPeriod.ToUpper() == "2S")
                            {
                                produ = DAOProdu.ConsultarInProdu(short.Parse(emp_codi.ToString()), FaPcfiu.pro_cmos);
                                detalle.Dfa_dest = FaPcfiu.dsp_cmos;
                            }
                            if (TipoMatricula.desglosesMatMov[0].tipoConcepto == "A" || TipoMatricula.desglosesMatMov[0].tipoConcepto == "D")
                                detalle.Dfa_valo = double.Parse(TipoMatricula.desglosesMatMov[IndexDesglose].importeConcepto.ToString());
                        }
                        //Extraordinaria
                        if (regist == "Ext")
                        {
                            pfactura.Top_codi = FaPcfiu.top_come;
                            pfactura.Fac_fepo = Convert.ToDateTime(TipoMatricula.recibosMatMov[count].fechaPago1Hasta);
                            if (academyPeriod.ToUpper() == "1S")
                            {
                                produ = DAOProdu.ConsultarInProdu(short.Parse(emp_codi.ToString()), FaPcfiu.pro_cmep);
                                detalle.Dfa_dest = FaPcfiu.dsp_cmep;
                            }
                            if (academyPeriod.ToUpper() == "2S")
                            {
                                produ = DAOProdu.ConsultarInProdu(short.Parse(emp_codi.ToString()), FaPcfiu.pro_cmes);
                                detalle.Dfa_dest = FaPcfiu.dsp_cmes;
                            }
                            if (TipoMatricula.desglosesMatMov[0].tipoConcepto == "A" || TipoMatricula.desglosesMatMov[0].tipoConcepto == "D")
                                detalle.Dfa_valo = double.Parse((TipoMatricula.recibosMatMov[count].importePago1 - TipoMatricula.recibosMatMov[count].ImportePagoOportuno).ToString());
                        }
                        //Extemporánea
                        if (regist == "Exe")
                        {
                            pfactura.Top_codi = FaPcfiu.top_comt;
                            pfactura.Fac_fepo = Convert.ToDateTime(TipoMatricula.recibosMatMov[count].fechaPago2Hasta);
                            if (academyPeriod.ToUpper() == "1S")
                            {
                                produ = DAOProdu.ConsultarInProdu(short.Parse(emp_codi.ToString()), FaPcfiu.pro_cmtp);
                                detalle.Dfa_dest = FaPcfiu.dsp_cmtp;
                            }
                            if (academyPeriod.ToUpper() == "2S")
                            {
                                produ = DAOProdu.ConsultarInProdu(short.Parse(emp_codi.ToString()), FaPcfiu.pro_cmts);
                                detalle.Dfa_dest = FaPcfiu.dsp_cmts;
                            }
                            detalle.Dfa_valo = double.Parse(TipoMatricula.recibosMatMov[0].importePago2.ToString());
                        }
                        break;
                    //Intersemestral
                    case "I":
                        if (academyPeriod.ToUpper() == "1I")
                        {
                            produ = DAOProdu.ConsultarInProdu(short.Parse(emp_codi.ToString()), FaPcfiu.pro_cisp);
                            detalle.Dfa_dest = FaPcfiu.dsp_cisp;
                        }
                        if (academyPeriod.ToUpper() == "2I")
                        {
                            produ = DAOProdu.ConsultarInProdu(short.Parse(emp_codi.ToString()), FaPcfiu.pro_ciss);
                            detalle.Dfa_dest = FaPcfiu.dsp_ciss;
                        }
                        detalle.Dfa_valo = double.Parse(TipoMatricula.desglosesMatMov[IndexDesglose].importeConcepto.ToString());
                        break;
                    //Otros servicios
                    case "O":
                        pfactura.Top_codi = FaPcfiu.top_cose;
                        if (academyPeriod.ToUpper() == "1S")
                        {
                            produ = DAOProdu.ConsultarInProdu(short.Parse(emp_codi.ToString()), FaPcfiu.pro_csep);
                            detalle.Dfa_dest = FaPcfiu.dsp_csep;
                        }
                        if (academyPeriod.ToUpper() == "2S")
                        {
                            produ = DAOProdu.ConsultarInProdu(short.Parse(emp_codi.ToString()), FaPcfiu.pro_cses);
                            detalle.Dfa_dest = FaPcfiu.dsp_cses;
                        }
                        detalle.Dfa_valo = double.Parse(TipoMatricula.desglosesMatMov[IndexDesglose].importeConcepto.ToString());
                        break;
                }
                //Crea la distribución automática
                //Area                    
                distA.Tar_codi = 1;
                distA.Arb_codi = DAOGnArbol.GetArbCodi(emp_codi, 1, FaPcfiu.arb_area);
                distA.Ddi_porc = 100;
                distA.Ddi_tipo = "P";
                distribucionAut.Add(distA);
                //Proyecto
                WsFaFactu.TSFaDdisp distP = new WsFaFactu.TSFaDdisp();
                distP.Tar_codi = 4;
                distP.Arb_codi = DAOGnArbol.GetArbCodi(emp_codi, 4, FaPcfiu.arb_proy);
                distP.Ddi_porc = 100;
                distP.Ddi_tipo = "P";
                distribucionAut.Add(distP);
                //Sucursal
                WsFaFactu.TSFaDdisp distS = new WsFaFactu.TSFaDdisp();
                distS.Tar_codi = 2;
                distS.Arb_codi = DAOGnArbol.GetArbCodi(emp_codi, 2, FaPcfiu.arb_sucu);
                distS.Ddi_porc = 100;
                distS.Ddi_tipo = "P";
                distribucionAut.Add(distS);

            }
            //Propiedades de detalle que comparten notas y facturas
            pfactura.Fac_fepe = pfactura.Fac_fepo;
            pfactura.Fac_fext = pfactura.Fac_fepo;
            pfactura.Fac_feci = pfactura.Fac_fepo;
            pfactura.Fac_fecf = pfactura.Fac_fepo;
            detalle.Pro_codi = produ.pro_codi;
            detalle.Uni_codi = produ.uni_codi;
            detalle.Dfa_cant = 1;
            detalle.Dfa_tide = "P";
            detalle.Dfa_desc = pfactura.Fac_desc;
            detalle.Cli_coda = pfactura.Cli_coda;
            detalle.Dcl_codd = 1;
            //Distribución automática
            //Centro de costos
            WsFaFactu.TSFaDdisp distCC = new WsFaFactu.TSFaDdisp();
            distCC.Tar_codi = 3;
            distCC.Arb_codi = DAOGnArbol.GetArbCodiAnt(emp_codi, 3, TipoMatricula.codigoEstudio);
            distCC.Ddi_porc = 100;
            distCC.Ddi_tipo = "P";
            distribucionAut.Add(distCC);
            detalle.vDistribA = distribucionAut.ToArray();
            detalles.Add(detalle);
            pfactura.vDetalle = detalles.ToArray();
            var x = ws.InsertarFactura(pfactura);
            fac = GetValueFromXmlNode(x);
            if (fac.retorno != 0)
                throw new Exception(fac.txtError);
            fac.arb_csuc = pfactura.Arb_csuc;
            fac.top_codi = pfactura.Top_codi;
            fac.fac_fech = pfactura.Fac_fech;
            DAOFactu.updateFaFactu(emp_codi, fac.fac_cont, fac_ndoc);
            return fac;
        }
        /// <summary>
        /// Función para crear las facturas con la nueva configuración que utiliza SFAPIUOI Y SFADPIUO
        /// </summary>
        /// <param name="TipoMatricula"></param>
        /// <param name="regist">Tipo de factura (Ordinaria,Extraordinaria,extemporanea, Nota</param>
        /// <param name="posicionDesglose">Definde la posición del desglose autilizar</param>
        /// <param name="posicionRecibo">Define la posición del recibo a utilizar</param>
        /// <param name="arb_cont">arb_cont del codigo de estudios</param>
        /// <param name="MatriculaOrd">Factura original, esta se debe enviar cuando se va crear una nota crédito. La misma define la factura a la cual se realizará el cruce</param>
        /// <returns></returns>
        public TOOutFaFactu ProcessFaFactuOpc(ServiceReference1.T_TIPO_MATRICULA TipoMatricula, string regist, int posicionDesglose, int posicionRecibo, int arb_cont = 0, TOOutFaFactu MatriculaOrd = null, bool horasAdicionales = false)
        {
            ////Obtengo la llave única            
            string fac_ndoc = GetKeyFaFactu(TipoMatricula);



            bool EstudianteNuevo = false;
            TOOutFaFactu fac = new TOOutFaFactu();
            if (TipoMatricula.recibosMatMov[0].importePago3 != null && TipoMatricula.recibosMatMov[0].importePago3 > 0)
            {
                if(!isUdca())
                 EstudianteNuevo = true;
                if (regist == "Exe")
                    regist = "Pop";
            }
            //Si es consumo de horas adicionales, busca el indice del desglose y del recibo que coincida con el pago oportuno
            if (horasAdicionales && !isUdca())
            {
                //Obtengo la posición de desglose y de tipo de recibo para facturar las horas extras
                var pagoOportuno = TipoMatricula.desglosesMatMov.Where(c => c.tipoConcepto == "A").LastOrDefault().importeConcepto;
                posicionDesglose = TipoMatricula.desglosesMatMov.FindIndex(c => c.importeConcepto == pagoOportuno);
                posicionRecibo = TipoMatricula.recibosMatMov.FindIndex(r => r.ImportePagoOportuno == pagoOportuno);
                if (posicionDesglose < 0)
                    throw new Exception(string.Format(" No se encontró desglose con importeConcepto = {0}", pagoOportuno));
                if (posicionRecibo < 0)
                    throw new Exception(string.Format(" No se encontró recibo con ImportePagoOportuno = {0}", pagoOportuno));
            }

            string tipoPago = "";
            //var gnArbolperiodoAcademico = new DAO_Gn_Arbol().GetGnArbolByArbCoan(emp_codi, 4, TipoMatricula.periodoAcademico);
            // Consulta la parametrización de sfapiuoi basado en la sucrusal, y los primeros 4 dígitos del periodo académico
            var sfapiuoi = new DAO_Fa_Piuoi().GetFaPiuoi(emp_codi, arb_cont, int.Parse(TipoMatricula.periodoAcademico.Substring(0, 4)));
            // Consulta el código de actividad basado en la actividad económica del la matrícula
            var filtergnItemsActividadEconimica = DAO_Gn_Items.GetGnItems(0, 465, TipoMatricula.actividadEconomica.ToString());
            if (filtergnItemsActividadEconimica == null)
                throw new Exception(String.Format("Código {0} no creado como item de código de actividad", TipoMatricula.actividadEconomica.ToString()));
            var gnItemsActividadEconimica = filtergnItemsActividadEconimica.FirstOrDefault();
            int conceptoImputable = 0;

           // Según si es factura ordinaria, extemporánea , extraordinaria , pop o nota, confogura el tipoPago y el concepto imputable
            switch (regist)
            {
                case "Ord":
                    tipoPago = "O";
                    conceptoImputable = TipoMatricula.desglosesMatMov[posicionDesglose].codigoConcepto;
                    //index = TipoMatricula.desglosesMatMov.FindIndex(d => d.tipoConcepto == "A");
                    break;
                case "Extr":
                    tipoPago = "E";
                    conceptoImputable = TipoMatricula.desglosesMatMov[posicionDesglose].codigoConcepto;
                    //index = TipoMatricula.desglosesMatMov.FindIndex(d => d.tipoConcepto == "A");
                    break;
                case "Exe":
                    tipoPago = "X";
                    conceptoImputable = TipoMatricula.desglosesMatMov[posicionDesglose].codigoConcepto;
                    //index = TipoMatricula.desglosesMatMov.FindIndex(d => d.tipoConcepto == "A");
                    break;
                case "Pop":
                    tipoPago = "P";
                    conceptoImputable = TipoMatricula.desglosesMatMov[posicionDesglose].codigoConcepto;
                    //index = TipoMatricula.desglosesMatMov.FindIndex(d => d.tipoConcepto == "A");
                    break;
                case "Note":
                    tipoPago = "O";
                    // Si es nota y trae código de anulación, el concepto imputable es el código de anulación de la matrícuka
                    if (TipoMatricula.codigoAnulacion > 0)
                        conceptoImputable = (int)TipoMatricula.codigoAnulacion;
                    else
                    {
                        // Si el primer recibo esCObrado == S y el importePagoOportuno es negativo, el concepto imputable es el codigoFormaPago
                        if (TipoMatricula.recibosMatMov.FirstOrDefault().esCobrado == "S" && TipoMatricula.recibosMatMov.LastOrDefault().ImportePagoOportuno < 0)
                        {
                            conceptoImputable = TipoMatricula.recibosMatMov.LastOrDefault().codigoFormaPago;
                        }
                        else
                        {// Si no , el concepto Impitable es el codigo concepto del desglose especificado en el parámetro de esta función
                            conceptoImputable = TipoMatricula.desglosesMatMov[posicionDesglose].codigoConcepto;
                        }
                    }
                    //index = TipoMatricula.desglosesMatMov.FindIndex(d => d.tipoConcepto == "T");
                    break;

            }
            //int arb_cpac = new DAO_Gn_Arbol().GetGnArbolByArbCoan(emp_codi, 4, TipoMatricula.periodoAcademico.Substring(5)).arb_cont;
            // Consulta del detalle de parametrización de sfadpiuoi basado en empresa, año, sucursal, concepto imputable, periodo académico , tipo de pago, y actividad económica
            var sfadpiuo = new DAO_Fa_Dpiuo().GetFaDpiuo(emp_codi, sfapiuoi.piu_anop, arb_cont, conceptoImputable, TipoMatricula.periodoAcademico, tipoPago, gnItemsActividadEconimica.ite_cont);


            //Se consultan parametros de empresa
            TOGnParam param = DAOParam.GetGnParam(emp_codi);
            //Encabezado    

            if (sfadpiuo == null)
                throw new Exception("No se encontraron detalles en el programa de configuración SFADPIUO con los parámetros enviados");
            List<TSFaDdisp> distribucionAut = new List<TSFaDdisp>();
            int conversion = 0;
            WsFaFactu.TSFaFactu pfactura = new WsFaFactu.TSFaFactu();
            //crea encabezados y algunas propiedades del detalle que comparten todas las facturas
            if (!int.TryParse(TipoMatricula.recibosMatMov[posicionRecibo].referenciaRecibo.Substring(5), out conversion))
                throw new Exception("Campo referencia recibo debe ser numérico y su tamaño debe ser mayor a 5");

            List<TSFaDfact> detalles = new List<TSFaDfact>();
            WsFaFactu.TSFaDfact detalle = new WsFaFactu.TSFaDfact();
            WsFaFactu.TSFaDdisp distA = new WsFaFactu.TSFaDdisp();
            pfactura.Emp_codi = int.Parse(ConfigurationManager.AppSettings["emp_codi"].ToString());
            pfactura.Fac_tdis = "A";
            pfactura.Fac_nume = int.Parse(TipoMatricula.recibosMatMov[posicionRecibo].referenciaRecibo.Substring(5));
            pfactura.Cli_coda = TipoMatricula.numDocumento;
            pfactura.Dcl_codd = 1;
            pfactura.Fac_esta = "A";            
            pfactura.Mon_codi = param.mon_codi;
            pfactura.Fac_fech = DateTime.Parse(TipoMatricula.recibosMatMov[posicionRecibo].fechaEmision);
            pfactura.Fac_feta = DateTime.Parse(TipoMatricula.recibosMatMov[posicionRecibo].fechaEmision);
            pfactura.Fac_tido = "M";
            pfactura.Fac_peri = TipoMatricula.periodoAcademico;
            string academyPeriod = TipoMatricula.periodoAcademico.Split('-')[1];



            //Para crear facturas normales
            pfactura.Fac_desc = sfadpiuo.dpi_desc;
            pfactura.Arb_csuc = DAOGnArbol.GetArbCodi(emp_codi, 2, sfadpiuo.arb_sucu);
            pfactura.Fac_cref = TipoMatricula.recibosMatMov[posicionRecibo].referenciaRecibo;
            var produ = DAO_In_Produ.GetInProdu(short.Parse(emp_codi.ToString()), "", sfadpiuo.pro_cont).FirstOrDefault();

             // Si es ordinaria, configura fac_tipo, fechas de pago ordinario, extemporaneo, extraordinario, valor, tipo de desuento y valor de descuento
            if (regist == "Ord")
            {
                pfactura.Fac_pepe = 0;
                pfactura.Fac_pext = 0;
                pfactura.Fac_tipo = "F";
                if (EstudianteNuevo)
                {
                    // Si es estudiante nuevo los valores los toma de la fechaPago 3 y el valor del descuento es la resta de el importepagoOportuno - importepaGO3 del recibo enviado como parámetro
                    //if(TipoMatricula.recibosMatMov[posicionRecibo].fechaPago3Hasta != null)
                    //    throw new Exception("No se encuentra definida parametrización para el tipo de pago Ordinario y código etiqueta <fechaPago3Hasta>.");
                    pfactura.Fac_fepo = TipoMatricula.recibosMatMov[posicionRecibo].fechaPago3Hasta.AsDateTime();
                    pfactura.Fac_fepe = TipoMatricula.recibosMatMov[posicionRecibo].fechaPago3Hasta.AsDateTime();
                    pfactura.Fac_fext = TipoMatricula.recibosMatMov[posicionRecibo].fechaPago3Hasta.AsDateTime();
                    detalle.Dfa_valo = (double)TipoMatricula.desglosesMatMov[posicionDesglose].importeConcepto;
                    //if (TipoMatricula.desglosesMatMov.Where(m => m.tipoConcepto == "T").ToList().Count > 0)
                    //    detalle.Dfa_valo = double.Parse(TipoMatricula.recibosMatMov[posicionRecibo].ImportePagoOportuno.ToString()) + Math.Abs(double.Parse(descuento.ToString()));
                    //else
                    //    detalle.Dfa_valo = double.Parse(TipoMatricula.recibosMatMov[posicionRecibo].ImportePagoOportuno.ToString());
                    detalle.Dfa_tide = "V";
                    detalle.Dfa_pvde = double.Parse(TipoMatricula.recibosMatMov[posicionRecibo].ImportePagoOportuno.ToString()) - double.Parse(TipoMatricula.recibosMatMov[posicionRecibo].importePago3.ToString());
                }

                if (!EstudianteNuevo)
                {
                     // Si es estudiante antiguo el valor de la matrícula es el importe concepto de la posición enviada en el desglose
                    //if (TipoMatricula.recibosMatMov[posicionRecibo].fechaPagoOportunoHasta != null)
                    //    throw new Exception("No se encuentra definida parametrización para el tipo de pago Ordinario y código etiqueta <fechaPagoOportunoHasta>.");
                    pfactura.Fac_fepo = TipoMatricula.recibosMatMov[posicionRecibo].fechaPagoOportunoHasta.AsDateTime();
                    pfactura.Fac_fepe = TipoMatricula.recibosMatMov[posicionRecibo].fechaPagoOportunoHasta.AsDateTime();
                    pfactura.Fac_fext = TipoMatricula.recibosMatMov[posicionRecibo].fechaPagoOportunoHasta.AsDateTime();
                    detalle.Dfa_valo = (double)TipoMatricula.desglosesMatMov[posicionDesglose].importeConcepto;
                }
            }
             // Si es pop , las fechas las toma del campo fechaPagoOportunpoHasta de la posición de recibo enviado como parámetro y el valor lo toma de restar el importePagoOportuno - el importePago3 de la posición de recibo enviado como parámetro
            if (regist == "Pop")
            {
                pfactura.Fac_pepe = 0;
                pfactura.Fac_pext = 0;
                pfactura.Fac_tipo = "F";
                if (EstudianteNuevo)
                {
                    //if (TipoMatricula.recibosMatMov[posicionRecibo].fechaPagoOportunoHasta != null)
                    //    throw new Exception("No se encuentra definida parametrización para el tipo de pago Oportuno y código etiqueta <fechaPagoOportunoHasta>.");


                    pfactura.Fac_fepo = TipoMatricula.recibosMatMov[posicionRecibo].fechaPagoOportunoHasta.AsDateTime();
                    pfactura.Fac_fepe = TipoMatricula.recibosMatMov[posicionRecibo].fechaPagoOportunoHasta.AsDateTime();
                    pfactura.Fac_fext = TipoMatricula.recibosMatMov[posicionRecibo].fechaPagoOportunoHasta.AsDateTime();
                    detalle.Dfa_valo = double.Parse(TipoMatricula.recibosMatMov[posicionRecibo].ImportePagoOportuno.ToString()) - double.Parse(TipoMatricula.recibosMatMov[posicionRecibo].importePago3.ToString());
                    detalle.Dfa_tide = "V";
                    detalle.Dfa_pvde = 0;

                }
                else
                {

                    pfactura.Fac_fepo = TipoMatricula.recibosMatMov[posicionRecibo].fechaPago3Hasta.AsDateTime();
                    pfactura.Fac_fepe = TipoMatricula.recibosMatMov[posicionRecibo].fechaPago3Hasta.AsDateTime();
                    pfactura.Fac_fext = TipoMatricula.recibosMatMov[posicionRecibo].fechaPago3Hasta.AsDateTime();
                    detalle.Dfa_valo = double.Parse(TipoMatricula.recibosMatMov[posicionRecibo].ImportePagoOportuno.ToString()) - double.Parse(TipoMatricula.recibosMatMov[posicionRecibo].importePago3.ToString());
                    detalle.Dfa_tide = "V";
                    detalle.Dfa_pvde = 0;

                }
            }


            // Si la factura es extraordinaria 
            if (regist == "Extr")
            {

                pfactura.Fac_pepe = 0;
                pfactura.Fac_pext = 0;

                 // Si es estudiante antiguo  toma las fechas del campo fechaPago1Hasta de la posición  de recibo enviado como parámetro en la función 
                  // el valor de la factura en este caso es el campo importtepago1 - importePagoOportuno del recibo enviado como parámetro
                if (!EstudianteNuevo)
                {
                    //if (TipoMatricula.recibosMatMov[posicionRecibo].fechaPago1Hasta != null)
                    //    throw new Exception("No se encuentra definida parametrización para el tipo de pago Extraordinario y código etiqueta <fechaPago1Hasta>.");
                    pfactura.Fac_fepo = TipoMatricula.recibosMatMov[posicionRecibo].fechaPago1Hasta.AsDateTime();
                    pfactura.Fac_fepe = TipoMatricula.recibosMatMov[posicionRecibo].fechaPago1Hasta.AsDateTime();
                    pfactura.Fac_fext = TipoMatricula.recibosMatMov[posicionRecibo].fechaPago1Hasta.AsDateTime();
                    //CASO 571329
                    if (double.Parse(TipoMatricula.recibosMatMov[posicionRecibo].ImportePagoOportuno.ToString())==0)
                        return new TOOutFaFactu();                    
                    detalle.Dfa_valo = double.Parse(TipoMatricula.recibosMatMov[posicionRecibo].importePago1.ToString()) - double.Parse(TipoMatricula.recibosMatMov[posicionRecibo].ImportePagoOportuno.ToString());

                }
                // Si es estudiante nuevo tomas las fechas de fechaPago1Hasta y el valor  de la resta entre importePago1  - ImportePagoOportuno de la posición del recibo enviado como parámetro
                if (EstudianteNuevo)
                {
                    //if (TipoMatricula.recibosMatMov[posicionRecibo].fechaPago1Hasta != null)
                    //    throw new Exception("No se encuentra definida parametrización para el tipo de pago Extraordinario y código etiqueta <fechaPago1Hasta>.");
                    pfactura.Fac_fepo = TipoMatricula.recibosMatMov[posicionRecibo].fechaPago1Hasta.AsDateTime();
                    pfactura.Fac_fepe = TipoMatricula.recibosMatMov[posicionRecibo].fechaPago1Hasta.AsDateTime();
                    pfactura.Fac_fext = TipoMatricula.recibosMatMov[posicionRecibo].fechaPago1Hasta.AsDateTime();
                    //CASO 571329
                    if (double.Parse(TipoMatricula.recibosMatMov[posicionRecibo].ImportePagoOportuno.ToString()) == 0)
                        return new TOOutFaFactu();
                    detalle.Dfa_valo = double.Parse(TipoMatricula.recibosMatMov[posicionRecibo].importePago1.ToString()) - double.Parse(TipoMatricula.recibosMatMov[posicionRecibo].ImportePagoOportuno.ToString());
                    detalle.Dfa_tide = "V";
                    detalle.Dfa_pvde = 0;

                }

                pfactura.Fac_tipo = "F";
            }
            // Si es factura extemporánea
            if (regist == "Exe")
            {
                pfactura.Fac_pepe = 0;
                pfactura.Fac_pext = 0;
                // Si es estudiante antiguo, toma las fechas de  fechaPago2Hasta y el valor de la matrícula es importePago2 - importePago1 de la primera posición de los recibos
                if (!EstudianteNuevo)
                {
                    //if (TipoMatricula.recibosMatMov[posicionRecibo].fechaPago2Hasta != null)
                    //    throw new Exception("No se encuentra definida parametrización para el tipo de pago Extemporaneo y código etiqueta <fechaPago2Hasta>.");
                    pfactura.Fac_fepo = TipoMatricula.recibosMatMov[posicionRecibo].fechaPago2Hasta.AsDateTime();
                    pfactura.Fac_fepe = TipoMatricula.recibosMatMov[posicionRecibo].fechaPago2Hasta.AsDateTime();
                    pfactura.Fac_fext = TipoMatricula.recibosMatMov[posicionRecibo].fechaPago2Hasta.AsDateTime();
                    detalle.Dfa_valo = double.Parse(TipoMatricula.recibosMatMov[0].importePago2.ToString()) - double.Parse(TipoMatricula.recibosMatMov[0].importePago1.ToString());
                }
                // Si es estudiante nuevo, toma las fechas de  fechaPago1Hasta y el valor de la matrícula es importePago1 - ImportePagoOportuno de la primera posición de los recibos

                if (EstudianteNuevo)
                {
                    //if (TipoMatricula.recibosMatMov[posicionRecibo].fechaPago1Hasta != null)
                    //    throw new Exception("No se encuentra definida parametrización para el tipo de pago Extemporaneo y código etiqueta <fechaPago1Hasta>.");
                    pfactura.Fac_fepo = TipoMatricula.recibosMatMov[posicionRecibo].fechaPago1Hasta.AsDateTime();
                    pfactura.Fac_fepe = TipoMatricula.recibosMatMov[posicionRecibo].fechaPago1Hasta.AsDateTime();
                    pfactura.Fac_fext = TipoMatricula.recibosMatMov[posicionRecibo].fechaPago1Hasta.AsDateTime();
                    detalle.Dfa_valo = double.Parse(TipoMatricula.recibosMatMov[0].importePago1.ToString()) - double.Parse(TipoMatricula.recibosMatMov[0].ImportePagoOportuno.ToString());
                }

                pfactura.Fac_tipo = "F";
            }

            // Si es nota , toma las fechas del campo fechaPagoOportunoHasta
            if (regist == "Note")
            {
                //if (TipoMatricula.recibosMatMov[posicionRecibo].fechaPagoOportunoHasta != null)
                //    throw new Exception("No se encuentra definida parametrización para Nota y código etiqueta <fechaPagoOportunoHasta>.");
                pfactura.Fac_fepo = TipoMatricula.recibosMatMov[posicionRecibo].fechaPagoOportunoHasta.AsDateTime();
                pfactura.Fac_fepe = TipoMatricula.recibosMatMov[posicionRecibo].fechaPagoOportunoHasta.AsDateTime();
                pfactura.Fac_fext = TipoMatricula.recibosMatMov[posicionRecibo].fechaPagoOportunoHasta.AsDateTime();
                pfactura.Fac_pepe = 0;
                pfactura.Fac_pext = 0;
                // valor Notas para anulación parcial o total,  si viene código de anulacíón y el ImportePagoOportuno es negativo, el valor de la matrícula es ImportePagoOportuno del recibo que viene como parámetro
                if (TipoMatricula.codigoAnulacion > 0 || TipoMatricula.recibosMatMov.LastOrDefault().ImportePagoOportuno < 0)
                    detalle.Dfa_valo = Math.Abs(double.Parse(TipoMatricula.recibosMatMov[posicionRecibo].ImportePagoOportuno.ToString()));
                else
                {
                    //Valor notas para creación de nota con cruce
                    // Si no, crea una nota con cruce a la factura                      
                    detalle.Dfa_valo = Math.Abs(double.Parse(TipoMatricula.desglosesMatMov[posicionDesglose].importeConcepto.ToString()));
                    List<TSFaCruau> cruces = new List<TSFaCruau>();
                    CA_CXCOB cuentaXcobrar = DAOCxCob.GetCaCxcob(emp_codi, MatriculaOrd.fac_cont).Where(c => c.cxc_sald > 0 && c.cxc_esta == "A").FirstOrDefault();
                    TSFaCruau cruce = new TSFaCruau();
                    cruce.Cru_valo = detalle.Dfa_valo;
                    cruce.Fac_numc = MatriculaOrd.fac_nume;
                    cruce.Fac_fecc = MatriculaOrd.fac_fech;
                    cruce.Arb_succ = MatriculaOrd.arb_csuc;
                    cruce.Top_codc = MatriculaOrd.top_codi;
                    cruce.Cxc_cont = cuentaXcobrar.cxc_cont;
                    cruces.Add(cruce);
                    pfactura.vCruce = cruces.ToArray();
                }

                pfactura.Fac_tipo = "C";
            }

            pfactura.Top_codi = sfadpiuo.top_codi;
            detalle.Bod_codi = sfadpiuo.bod_codi;
            detalle.Pro_codi = produ.pro_codi;
            pfactura.Fac_feci = DateTime.Parse(TipoMatricula.recibosMatMov[posicionRecibo].fechaEmision);
            pfactura.Fac_fecf = DateTime.Parse(TipoMatricula.recibosMatMov[posicionRecibo].fechaEmision);
            detalle.Uni_codi = produ.uni_codi;
            detalle.Dfa_cant = 1;
            detalle.Dfa_tide = "V";
            detalle.Dfa_desc = pfactura.Fac_desc;
            detalle.Cli_coda = pfactura.Cli_coda;
            detalle.Dcl_codd = 1;
            detalle.Dfa_dest = sfadpiuo.dsp_codi;

            //Distribución automática

            //Crea la distribución automática
            //Area                    
            distA.Tar_codi = 1;
            distA.Arb_codi = DAOGnArbol.GetArbCodi(emp_codi, 1, sfadpiuo.arb_area);
            distA.Ddi_porc = 100;
            distA.Ddi_tipo = "P";
            distA.Ddi_valo = 0;
            distribucionAut.Add(distA);
            //Proyecto
            WsFaFactu.TSFaDdisp distP = new WsFaFactu.TSFaDdisp();
            distP.Tar_codi = 4;
            distP.Arb_codi = DAOGnArbol.GetArbCodi(emp_codi, 4, sfadpiuo.arb_cpac);
            distP.Ddi_porc = 100;
            distP.Ddi_tipo = "P";
            distP.Ddi_valo = 0;
            distribucionAut.Add(distP);
            //Sucursal
            WsFaFactu.TSFaDdisp distS = new WsFaFactu.TSFaDdisp();
            distS.Tar_codi = 2;
            distS.Arb_codi = DAOGnArbol.GetArbCodi(emp_codi, 2, sfadpiuo.arb_sucu);
            distS.Ddi_porc = 100;
            distS.Ddi_tipo = "P";
            distS.Ddi_valo = 0;
            distribucionAut.Add(distS);
            //Centro de costos
            WsFaFactu.TSFaDdisp distCC = new WsFaFactu.TSFaDdisp();
            distCC.Tar_codi = 3;
            distCC.Arb_codi = DAOGnArbol.GetArbCodi(emp_codi, 3, sfapiuoi.arb_cest);
            distCC.Ddi_porc = 100;
            distCC.Ddi_tipo = "P";
            distCC.Ddi_valo = 0;

            distribucionAut.Add(distCC);
            detalle.vDistribA = distribucionAut.ToArray();
            detalles.Add(detalle);
            pfactura.vDetalle = detalles.ToArray();
            var x = ws.InsertarFactura(pfactura);
            fac = GetValueFromXmlNode(x);
            if (fac.retorno != 0)
                throw new Exception(fac.txtError);
            fac.arb_csuc = pfactura.Arb_csuc;
            fac.top_codi = pfactura.Top_codi;
            fac.fac_fech = pfactura.Fac_fech;
            DAOFactu.updateFaFactu(emp_codi, fac.fac_cont, fac_ndoc);
            return fac;


        }
        public TOOutFaFactu GetValueFromXmlNode(string xmlRoute)
        {
            TOOutFaFactu salida = new TOOutFaFactu();
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(xmlRoute);
            foreach (XmlNode node in xml.DocumentElement.ChildNodes)
            {
                salida.retorno = int.Parse(node.FirstChild.InnerText);
                salida.fac_nume = int.Parse(node.LastChild.InnerText);
                salida.txtError = node.ChildNodes[1].InnerText;
                salida.fac_cont = int.Parse(node.ChildNodes[2].InnerText);
            }
            return salida;
        }

        public WiewSsec.TSalida GetValueFromSiewSsec(string xmlRoute)
        {
            WiewSsec.TSalida salida = new WiewSsec.TSalida();
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(xmlRoute);
            foreach (XmlNode node in xml.DocumentElement.ChildNodes)
            {

                salida.Retorno = short.Parse(node.FirstChild.InnerText);
                salida.TxtError = node.ChildNodes[1].InnerText;
                salida.CliCodi = int.Parse(node.ChildNodes[2].InnerText);
                salida.DclCodd = short.Parse(node.LastChild.InnerText);

            }
            return salida;

        }
        public string GetKeyFaFactu(ServiceReference1.T_TIPO_MATRICULA TipoMatricula)
        {
            string actividadEconomica = convertTOxCaracteres(TipoMatricula.actividadEconomica.ToString(), 3, '0');
            string numeroOrdenExpendiente = convertTOxCaracteres((TipoMatricula.numeroOrdenExpediente == null ? 0 : TipoMatricula.numeroOrdenExpediente).ToString(), 7, '0');
            string codigoPlanEstudios = convertTOxCaracteres(TipoMatricula.codigoPlanEstudios, 4, '0');
            string codigoEstudio = convertTOxCaracteres(TipoMatricula.codigoEstudio, 4, '0');
            string periodoAcademico = TipoMatricula.periodoAcademico;
            string codigoMovimiento = convertTOxCaracteres((TipoMatricula.codigoMovimiento == null ? 0 : TipoMatricula.codigoMovimiento).ToString(), 7, '0');
            string periodoActividad = convertTOxCaracteres(TipoMatricula.periodoActividad.ToString(), 2, '0');
            string key = actividadEconomica + numeroOrdenExpendiente + codigoPlanEstudios + codigoEstudio + periodoAcademico + codigoMovimiento + periodoActividad;
            return key;
        }
        public string convertTOxCaracteres(string key, int x, char chracter)
        {
            string cadena = "";
            int caracteresFaltantes = x - key.Length;
            for (int i = 1; i <= caracteresFaltantes; i++)
            {
                cadena += chracter;
            }
            return cadena + key;
        }


        public bool isUdca()
        {

            try
            {

                if (ConfigurationManager.AppSettings["udca"] == "true")
                    return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }


    }

}