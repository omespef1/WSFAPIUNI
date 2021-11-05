using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Web;
using System.Xml.Serialization;

namespace WSFAPIUNI.TO
{
    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    // [System.ServiceModel.MessageContractAttribute(WrapperName = "sincronizarMatMovResponse", IsWrapped = false)]
    //[WebService(Namespace = "")]

    public class sincronizarMatMovResponse
    {

        [DataMember]
        public int codigoRegistro { get; set; }
        [DataMember]
        public int codigoRespuesta { get; set; }
        [DataMember]
        public string mensajeRespuesta { get; set; }
    }
}