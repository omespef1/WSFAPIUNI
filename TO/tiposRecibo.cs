using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSFAPIUNI.TO
{

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2556.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ocu.es/xsd/SincronizarMatMov")]
    public partial class T_TIPO_RECIBO : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string referenciaReciboField;

        private string fechaEmisionField;

        private decimal importePagoOportunoField;

        private string fechaPagoOportunoHastaField;

        private System.Nullable<decimal> importePago1Field;

        private bool importePago1FieldSpecified;

        private string fechaPago1HastaField;

        private System.Nullable<decimal> importePago2Field;

        private bool importePago2FieldSpecified;

        private string fechaPago2HastaField;

        private System.Nullable<decimal> importePago3Field;

        private bool importePago3FieldSpecified;

        private string fechaPago3HastaField;

        private System.Nullable<int> codigoSistemaFinanciacionField;

        private bool codigoSistemaFinanciacionFieldSpecified;

        private System.Nullable<decimal> importeSistemaFinanciacionField;

        private bool importeSistemaFinanciacionFieldSpecified;

        private int plazoPagoField;

        private int codigoFormaPagoField;

        private string esCobradoField;

        private string fechaCobroField;

        private System.Nullable<decimal> importeCobradoField;

        private bool importeCobradoFieldSpecified;

        private string modoCobroField;

        private string estadoSolicitudDevolucionField;

        private string codigoBancoIngresoField;

        private string entidadPagadoraField;

        private string esPagoOnLineField;

        private string idOperacionBancariaOnLineField;

       

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string referenciaRecibo
        {
            get
            {
                return this.referenciaReciboField;
            }
            set
            {
                this.referenciaReciboField = value;
                this.RaisePropertyChanged("referenciaRecibo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string fechaEmision
        {
            get
            {
                return this.fechaEmisionField;
            }
            set
            {
                this.fechaEmisionField = value;
                this.RaisePropertyChanged("fechaEmision");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public decimal ImportePagoOportuno
        {
            get
            {
                return this.importePagoOportunoField;
            }
            set
            {
                this.importePagoOportunoField = value;
                this.RaisePropertyChanged("ImportePagoOportuno");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string fechaPagoOportunoHasta
        {
            get
            {
                return this.fechaPagoOportunoHastaField;
            }
            set
            {
                this.fechaPagoOportunoHastaField = value;
                this.RaisePropertyChanged("fechaPagoOportunoHasta");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 4)]
        public System.Nullable<decimal> importePago1
        {
            get
            {
                return this.importePago1Field;
            }
            set
            {
                this.importePago1Field = value;
                this.RaisePropertyChanged("importePago1");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool importePago1Specified
        {
            get
            {
                return this.importePago1FieldSpecified;
            }
            set
            {
                this.importePago1FieldSpecified = value;
                this.RaisePropertyChanged("importePago1Specified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string fechaPago1Hasta
        {
            get
            {
                return this.fechaPago1HastaField;
            }
            set
            {
                this.fechaPago1HastaField = value;
                this.RaisePropertyChanged("fechaPago1Hasta");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 6)]
        public System.Nullable<decimal> importePago2
        {
            get
            {
                return this.importePago2Field;
            }
            set
            {
                this.importePago2Field = value;
                this.RaisePropertyChanged("importePago2");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool importePago2Specified
        {
            get
            {
                return this.importePago2FieldSpecified;
            }
            set
            {
                this.importePago2FieldSpecified = value;
                this.RaisePropertyChanged("importePago2Specified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string fechaPago2Hasta
        {
            get
            {
                return this.fechaPago2HastaField;
            }
            set
            {
                this.fechaPago2HastaField = value;
                this.RaisePropertyChanged("fechaPago2Hasta");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 8)]
        public System.Nullable<decimal> importePago3
        {
            get
            {
                return this.importePago3Field;
            }
            set
            {
                this.importePago3Field = value;
                this.RaisePropertyChanged("importePago3");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool importePago3Specified
        {
            get
            {
                return this.importePago3FieldSpecified;
            }
            set
            {
                this.importePago3FieldSpecified = value;
                this.RaisePropertyChanged("importePago3Specified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string fechaPago3Hasta
        {
            get
            {
                return this.fechaPago3HastaField;
            }
            set
            {
                this.fechaPago3HastaField = value;
                this.RaisePropertyChanged("fechaPago3Hasta");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 10)]
        public System.Nullable<int> codigoSistemaFinanciacion
        {
            get
            {
                return this.codigoSistemaFinanciacionField;
            }
            set
            {
                this.codigoSistemaFinanciacionField = value;
                this.RaisePropertyChanged("codigoSistemaFinanciacion");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool codigoSistemaFinanciacionSpecified
        {
            get
            {
                return this.codigoSistemaFinanciacionFieldSpecified;
            }
            set
            {
                this.codigoSistemaFinanciacionFieldSpecified = value;
                this.RaisePropertyChanged("codigoSistemaFinanciacionSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 11)]
        public System.Nullable<decimal> importeSistemaFinanciacion
        {
            get
            {
                return this.importeSistemaFinanciacionField;
            }
            set
            {
                this.importeSistemaFinanciacionField = value;
                this.RaisePropertyChanged("importeSistemaFinanciacion");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool importeSistemaFinanciacionSpecified
        {
            get
            {
                return this.importeSistemaFinanciacionFieldSpecified;
            }
            set
            {
                this.importeSistemaFinanciacionFieldSpecified = value;
                this.RaisePropertyChanged("importeSistemaFinanciacionSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public int plazoPago
        {
            get
            {
                return this.plazoPagoField;
            }
            set
            {
                this.plazoPagoField = value;
                this.RaisePropertyChanged("plazoPago");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public int codigoFormaPago
        {
            get
            {
                return this.codigoFormaPagoField;
            }
            set
            {
                this.codigoFormaPagoField = value;
                this.RaisePropertyChanged("codigoFormaPago");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public string esCobrado
        {
            get
            {
                return this.esCobradoField;
            }
            set
            {
                this.esCobradoField = value;
                this.RaisePropertyChanged("esCobrado");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public string fechaCobro
        {
            get
            {
                return this.fechaCobroField;
            }
            set
            {
                this.fechaCobroField = value;
                this.RaisePropertyChanged("fechaCobro");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 16)]
        public System.Nullable<decimal> importeCobrado
        {
            get
            {
                return this.importeCobradoField;
            }
            set
            {
                this.importeCobradoField = value;
                this.RaisePropertyChanged("importeCobrado");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool importeCobradoSpecified
        {
            get
            {
                return this.importeCobradoFieldSpecified;
            }
            set
            {
                this.importeCobradoFieldSpecified = value;
                this.RaisePropertyChanged("importeCobradoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
        public string modoCobro
        {
            get
            {
                return this.modoCobroField;
            }
            set
            {
                this.modoCobroField = value;
                this.RaisePropertyChanged("modoCobro");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 18)]
        public string estadoSolicitudDevolucion
        {
            get
            {
                return this.estadoSolicitudDevolucionField;
            }
            set
            {
                this.estadoSolicitudDevolucionField = value;
                this.RaisePropertyChanged("estadoSolicitudDevolucion");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 19)]
        public string codigoBancoIngreso
        {
            get
            {
                return this.codigoBancoIngresoField;
            }
            set
            {
                this.codigoBancoIngresoField = value;
                this.RaisePropertyChanged("codigoBancoIngreso");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 20)]
        public string entidadPagadora
        {
            get
            {
                return this.entidadPagadoraField;
            }
            set
            {
                this.entidadPagadoraField = value;
                this.RaisePropertyChanged("entidadPagadora");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 21)]
        public string esPagoOnLine
        {
            get
            {
                return this.esPagoOnLineField;
            }
            set
            {
                this.esPagoOnLineField = value;
                this.RaisePropertyChanged("esPagoOnLine");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 22)]
        public string IdOperacionBancariaOnLine
        {
            get
            {
                return this.idOperacionBancariaOnLineField;
            }
            set
            {
                this.idOperacionBancariaOnLineField = value;
                this.RaisePropertyChanged("IdOperacionBancariaOnLine");
            }
        }

        /// <remarks/>
       

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2556.0")]
    //[System.SerializableAttribute()]
    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.ComponentModel.DesignerCategoryAttribute("code")]
    //[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ocu.es/xsd/SincronizarMatMov")]
    //public class tiposRecibo : object, System.ComponentModel.INotifyPropertyChanged
    //{

    //    public string referenciaRecibo { get; set; }
    //    public string fechaEmision { get; set; }
    //    public double ImportePagoOportuno { get; set; }
    //    public string fechaPagoOportunoHasta { get; set; }
    //    public double importePago1 { get; set; }
    //    public string fechaPago1Hasta { get; set; }
    //    public double importePago2 { get; set; }
    //    public string fechaPago2Hasta { get; set; }
    //    public double importePago3 { get; set; }
    //    public string fechaPago3Hasta { get; set; }
    //    public int plazoPago { get; set; }
    //    public string codigoFormaPago { get; set; }
    //    public string esCobrado { get; set; }
    //    public string fechaCobro { get; set; }
    //    public double importeCobrado { get; set; }
    //    public string modoCobro { get; set; }
    //    public string esPagoOnLine { get; set; }

    //    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

    //}
}