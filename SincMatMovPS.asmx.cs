using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WSFAPIUNI.BO;
using WSFAPIUNI.TO;
using WSFAPIUNI.ServiceReference1;
using System.Threading.Tasks;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

namespace WSFAPIUNI
{


    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]

    //[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    //[System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.example.org/SincMatMovPS/", ConfigurationName = "WSFAPIUNI.SincMatMovPS")]
      [WebService(Namespace = "http://www.ocu.es/xsd/SincronizarMatMov")]
   

    public class SincMatMovPS 
    {
        [WebMethod]       
        [SoapDocumentMethod(Action = "http://www.example.org/SincMatMovPS/SincMatMov", ResponseElementName = "sincronizarMatMovResponse",ParameterStyle =SoapParameterStyle.Bare,Use =System.Web.Services.Description.SoapBindingUse.Literal)]
        [return: XmlElement("sincronizarMatMovResponse")]
        public sincronizarMatMovResponse sincronizarMatMovRequest(sincronizarMatMov sincronizarMatMovRequest)
        {
            BO.BOsincronizarMatMovRequest BO = new BOsincronizarMatMovRequest();
              return BO.sincronizarMatMovRequest(sincronizarMatMovRequest.tipoMatricula);
        }



      
    }

    public class sincronizarMatMov
    {
        public ServiceReference1.T_TIPO_MATRICULA tipoMatricula { get; set; }
    }
}
