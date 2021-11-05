using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WSFAPIUNI.TO;

namespace WSFAPIUNI.TO
{
    public class SincMatMovRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.ocu.es/xsd/SincronizarMatMov", Order = 0)]
        public T_TIPO_MATRICULA tipoMatricula;

        public SincMatMovRequest()
        {
        }

        public SincMatMovRequest(T_TIPO_MATRICULA tipoMatricula)
        {
            this.tipoMatricula = tipoMatricula;
        }
    }
}