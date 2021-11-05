using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Serialization;
using System.Xml.Schema;



namespace WSFAPIUNI.TO
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2556.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ocu.es/xsd/SincronizarMatMov")]
    public partial class T_TIPO_MATRICULA : object, System.ComponentModel.INotifyPropertyChanged
    {

        private int codigoRegistroField;

        private int codigoPersonaField;

        private string tipoDocumentoField;

        private string numDocumentoField;

        private string nombrePersonaField;

        private string apellidosPersonaField;

        private int codigoProvinciaDomField;

        private bool codigoProvinciaDomFieldSpecified;

        private string nombreProvinciaDomField;

        private int codigoMunicipioDomField;

        private bool codigoMunicipioDomFieldSpecified;

        private string nombreMunicipioDomField;

        private string direccionDomField;

        private string telefonoFijoDomField;

        private string telefonoMovilField;

        private string emailField;

        private string codigoPaisNacimientoField;

        private string periodoAcademicoField;

        private int actividadEconomicaField;

        private int periodoActividadField;

        private string codigoPlanEstudiosField;

        private System.Nullable<int> numeroOrdenExpedienteField;

        private bool numeroOrdenExpedienteFieldSpecified;

        private System.Nullable<int> codigoMovimientoField;

        private bool codigoMovimientoFieldSpecified;

        private string codigoEstudioField;

        private string fechaUltimaModificacionField;

        private string tipoPagoField;

        private System.Nullable<int> codigoSistemaFinanciacionField;

        private bool codigoSistemaFinanciacionFieldSpecified;

        private System.Nullable<decimal> importeMatMovField;

        private bool importeMatMovFieldSpecified;

        private System.Nullable<decimal> importeSistemaFinanciacionField;

        private bool importeSistemaFinanciacionFieldSpecified;

        private System.Nullable<decimal> importeRecargosField;

        private bool importeRecargosFieldSpecified;

        private System.Nullable<int> codigoAnulacionField;

        private bool codigoAnulacionFieldSpecified;

        private string fechaAnulacionField;

        private string fechaDesanulacionField;

        private string centroCosteField;

        private string ordenCUCField;

        private string tipoCursoField;

        private string fechaInicioImparticionField;

        private string fechaFinImparticionField;

        private List< T_TIPO_DESGLOSE> desglosesMatMovField;

        private List< T_TIPO_RECIBO> recibosMatMovField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public int codigoRegistro
        {
            get
            {
                return this.codigoRegistroField;
            }
            set
            {
                this.codigoRegistroField = value;
                this.RaisePropertyChanged("codigoRegistro");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public int codigoPersona
        {
            get
            {
                return this.codigoPersonaField;
            }
            set
            {
                this.codigoPersonaField = value;
                this.RaisePropertyChanged("codigoPersona");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string tipoDocumento
        {
            get
            {
                return this.tipoDocumentoField;
            }
            set
            {
                this.tipoDocumentoField = value;
                this.RaisePropertyChanged("tipoDocumento");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string numDocumento
        {
            get
            {
                return this.numDocumentoField;
            }
            set
            {
                this.numDocumentoField = value;
                this.RaisePropertyChanged("numDocumento");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string nombrePersona
        {
            get
            {
                return this.nombrePersonaField;
            }
            set
            {
                this.nombrePersonaField = value;
                this.RaisePropertyChanged("nombrePersona");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string apellidosPersona
        {
            get
            {
                return this.apellidosPersonaField;
            }
            set
            {
                this.apellidosPersonaField = value;
                this.RaisePropertyChanged("apellidosPersona");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public int codigoProvinciaDom
        {
            get
            {
                return this.codigoProvinciaDomField;
            }
            set
            {
                this.codigoProvinciaDomField = value;
                this.RaisePropertyChanged("codigoProvinciaDom");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool codigoProvinciaDomSpecified
        {
            get
            {
                return this.codigoProvinciaDomFieldSpecified;
            }
            set
            {
                this.codigoProvinciaDomFieldSpecified = value;
                this.RaisePropertyChanged("codigoProvinciaDomSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string nombreProvinciaDom
        {
            get
            {
                return this.nombreProvinciaDomField;
            }
            set
            {
                this.nombreProvinciaDomField = value;
                this.RaisePropertyChanged("nombreProvinciaDom");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public int codigoMunicipioDom
        {
            get
            {
                return this.codigoMunicipioDomField;
            }
            set
            {
                this.codigoMunicipioDomField = value;
                this.RaisePropertyChanged("codigoMunicipioDom");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool codigoMunicipioDomSpecified
        {
            get
            {
                return this.codigoMunicipioDomFieldSpecified;
            }
            set
            {
                this.codigoMunicipioDomFieldSpecified = value;
                this.RaisePropertyChanged("codigoMunicipioDomSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string nombreMunicipioDom
        {
            get
            {
                return this.nombreMunicipioDomField;
            }
            set
            {
                this.nombreMunicipioDomField = value;
                this.RaisePropertyChanged("nombreMunicipioDom");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string direccionDom
        {
            get
            {
                return this.direccionDomField;
            }
            set
            {
                this.direccionDomField = value;
                this.RaisePropertyChanged("direccionDom");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string telefonoFijoDom
        {
            get
            {
                return this.telefonoFijoDomField;
            }
            set
            {
                this.telefonoFijoDomField = value;
                this.RaisePropertyChanged("telefonoFijoDom");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string telefonoMovil
        {
            get
            {
                return this.telefonoMovilField;
            }
            set
            {
                this.telefonoMovilField = value;
                this.RaisePropertyChanged("telefonoMovil");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
                this.RaisePropertyChanged("email");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public string codigoPaisNacimiento
        {
            get
            {
                return this.codigoPaisNacimientoField;
            }
            set
            {
                this.codigoPaisNacimientoField = value;
                this.RaisePropertyChanged("codigoPaisNacimiento");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public string periodoAcademico
        {
            get
            {
                return this.periodoAcademicoField;
            }
            set
            {
                this.periodoAcademicoField = value;
                this.RaisePropertyChanged("periodoAcademico");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
        public int actividadEconomica
        {
            get
            {
                return this.actividadEconomicaField;
            }
            set
            {
                this.actividadEconomicaField = value;
                this.RaisePropertyChanged("actividadEconomica");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
        public int periodoActividad
        {
            get
            {
                return this.periodoActividadField;
            }
            set
            {
                this.periodoActividadField = value;
                this.RaisePropertyChanged("periodoActividad");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 18)]
        public string codigoPlanEstudios
        {
            get
            {
                return this.codigoPlanEstudiosField;
            }
            set
            {
                this.codigoPlanEstudiosField = value;
                this.RaisePropertyChanged("codigoPlanEstudios");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 19)]
        public System.Nullable<int> numeroOrdenExpediente
        {
            get
            {
                return this.numeroOrdenExpedienteField;
            }
            set
            {
                this.numeroOrdenExpedienteField = value;
                this.RaisePropertyChanged("numeroOrdenExpediente");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numeroOrdenExpedienteSpecified
        {
            get
            {
                return this.numeroOrdenExpedienteFieldSpecified;
            }
            set
            {
                this.numeroOrdenExpedienteFieldSpecified = value;
                this.RaisePropertyChanged("numeroOrdenExpedienteSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 20)]
        public System.Nullable<int> codigoMovimiento
        {
            get
            {
                return this.codigoMovimientoField;
            }
            set
            {
                this.codigoMovimientoField = value;
                this.RaisePropertyChanged("codigoMovimiento");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool codigoMovimientoSpecified
        {
            get
            {
                return this.codigoMovimientoFieldSpecified;
            }
            set
            {
                this.codigoMovimientoFieldSpecified = value;
                this.RaisePropertyChanged("codigoMovimientoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 21)]
        public string codigoEstudio
        {
            get
            {
                return this.codigoEstudioField;
            }
            set
            {
                this.codigoEstudioField = value;
                this.RaisePropertyChanged("codigoEstudio");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 22)]
        public string fechaUltimaModificacion
        {
            get
            {
                return this.fechaUltimaModificacionField;
            }
            set
            {
                this.fechaUltimaModificacionField = value;
                this.RaisePropertyChanged("fechaUltimaModificacion");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 23)]
        public string tipoPago
        {
            get
            {
                return this.tipoPagoField;
            }
            set
            {
                this.tipoPagoField = value;
                this.RaisePropertyChanged("tipoPago");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 24)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 25)]
        public System.Nullable<decimal> importeMatMov
        {
            get
            {
                return this.importeMatMovField;
            }
            set
            {
                this.importeMatMovField = value;
                this.RaisePropertyChanged("importeMatMov");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool importeMatMovSpecified
        {
            get
            {
                return this.importeMatMovFieldSpecified;
            }
            set
            {
                this.importeMatMovFieldSpecified = value;
                this.RaisePropertyChanged("importeMatMovSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 26)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 27)]
        public System.Nullable<decimal> importeRecargos
        {
            get
            {
                return this.importeRecargosField;
            }
            set
            {
                this.importeRecargosField = value;
                this.RaisePropertyChanged("importeRecargos");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool importeRecargosSpecified
        {
            get
            {
                return this.importeRecargosFieldSpecified;
            }
            set
            {
                this.importeRecargosFieldSpecified = value;
                this.RaisePropertyChanged("importeRecargosSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 28)]
        public System.Nullable<int> codigoAnulacion
        {
            get
            {
                return this.codigoAnulacionField;
            }
            set
            {
                this.codigoAnulacionField = value;
                this.RaisePropertyChanged("codigoAnulacion");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool codigoAnulacionSpecified
        {
            get
            {
                return this.codigoAnulacionFieldSpecified;
            }
            set
            {
                this.codigoAnulacionFieldSpecified = value;
                this.RaisePropertyChanged("codigoAnulacionSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 29)]
        public string fechaAnulacion
        {
            get
            {
                return this.fechaAnulacionField;
            }
            set
            {
                this.fechaAnulacionField = value;
                this.RaisePropertyChanged("fechaAnulacion");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 30)]
        public string fechaDesanulacion
        {
            get
            {
                return this.fechaDesanulacionField;
            }
            set
            {
                this.fechaDesanulacionField = value;
                this.RaisePropertyChanged("fechaDesanulacion");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 31)]
        public string centroCoste
        {
            get
            {
                return this.centroCosteField;
            }
            set
            {
                this.centroCosteField = value;
                this.RaisePropertyChanged("centroCoste");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 32)]
        public string ordenCUC
        {
            get
            {
                return this.ordenCUCField;
            }
            set
            {
                this.ordenCUCField = value;
                this.RaisePropertyChanged("ordenCUC");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 33)]
        public string tipoCurso
        {
            get
            {
                return this.tipoCursoField;
            }
            set
            {
                this.tipoCursoField = value;
                this.RaisePropertyChanged("tipoCurso");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 34)]
        public string fechaInicioImparticion
        {
            get
            {
                return this.fechaInicioImparticionField;
            }
            set
            {
                this.fechaInicioImparticionField = value;
                this.RaisePropertyChanged("fechaInicioImparticion");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 35)]
        public string fechaFinImparticion
        {
            get
            {
                return this.fechaFinImparticionField;
            }
            set
            {
                this.fechaFinImparticionField = value;
                this.RaisePropertyChanged("fechaFinImparticion");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 36)]
        [System.Xml.Serialization.XmlArrayItemAttribute("tiposDesglose", typeof(T_TIPO_DESGLOSE), IsNullable = false)]
        public List<T_TIPO_DESGLOSE> desglosesMatMov
        {
            get
            {
                return this.desglosesMatMovField;
            }
            set
            {
                this.desglosesMatMovField = value;
                this.RaisePropertyChanged("desglosesMatMov");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 37)]
        [System.Xml.Serialization.XmlArrayItemAttribute("tiposRecibo", typeof(T_TIPO_RECIBO), IsNullable = false)]
        public List<T_TIPO_RECIBO> recibosMatMov
        {
            get
            {
                return this.recibosMatMovField;
            }
            set
            {
                this.recibosMatMovField = value;
                this.RaisePropertyChanged("recibosMatMov");
            }
        }

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
    //public partial class T_TIPO_MATRICULA : object, System.ComponentModel.INotifyPropertyChanged
    //{

    //    private int codigoRegistroField;

    //    private int codigoPersonaField;

    //    private string tipoDocumentoField;

    //    private string numDocumentoField;

    //    private string nombrePersonaField;

    //    private string apellidosPersonaField;

    //    private int codigoProvinciaDomField;

    //    private bool codigoProvinciaDomFieldSpecified;

    //    private string nombreProvinciaDomField;

    //    private int codigoMunicipioDomField;

    //    private bool codigoMunicipioDomFieldSpecified;

    //    private string nombreMunicipioDomField;

    //    private string direccionDomField;

    //    private string telefonoFijoDomField;

    //    private string telefonoMovilField;

    //    private string emailField;

    //    private string codigoPaisNacimientoField;

    //    private string periodoAcademicoField;

    //    private int actividadEconomicaField;

    //    private int periodoActividadField;

    //    private string codigoPlanEstudiosField;

    //    private System.Nullable<int> numeroOrdenExpedienteField;

    //    private bool numeroOrdenExpedienteFieldSpecified;

    //    private System.Nullable<int> codigoMovimientoField;

    //    private bool codigoMovimientoFieldSpecified;

    //    private string codigoEstudioField;

    //    private string fechaUltimaModificacionField;

    //    private string tipoPagoField;

    //    private System.Nullable<int> codigoSistemaFinanciacionField;

    //    private bool codigoSistemaFinanciacionFieldSpecified;

    //    private System.Nullable<decimal> importeMatMovField;

    //    private bool importeMatMovFieldSpecified;

    //    private System.Nullable<decimal> importeSistemaFinanciacionField;

    //    private bool importeSistemaFinanciacionFieldSpecified;

    //    private System.Nullable<decimal> importeRecargosField;

    //    private bool importeRecargosFieldSpecified;

    //    private System.Nullable<int> codigoAnulacionField;

    //    private bool codigoAnulacionFieldSpecified;

    //    private string fechaAnulacionField;

    //    private string fechaDesanulacionField;

    //    private string centroCosteField;

    //    private string ordenCUCField;

    //    private string tipoCursoField;

    //    private string fechaInicioImparticionField;

    //    private string fechaFinImparticionField;

    //    private T_TIPO_DESGLOSE[][] desglosesMatMovField;

    //    private T_TIPO_RECIBO[][] recibosMatMovField;

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    //    public int codigoRegistro
    //    {
    //        get
    //        {
    //            return this.codigoRegistroField;
    //        }
    //        set
    //        {
    //            this.codigoRegistroField = value;
    //            this.RaisePropertyChanged("codigoRegistro");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    //    public int codigoPersona
    //    {
    //        get
    //        {
    //            return this.codigoPersonaField;
    //        }
    //        set
    //        {
    //            this.codigoPersonaField = value;
    //            this.RaisePropertyChanged("codigoPersona");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
    //    public string tipoDocumento
    //    {
    //        get
    //        {
    //            return this.tipoDocumentoField;
    //        }
    //        set
    //        {
    //            this.tipoDocumentoField = value;
    //            this.RaisePropertyChanged("tipoDocumento");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
    //    public string numDocumento
    //    {
    //        get
    //        {
    //            return this.numDocumentoField;
    //        }
    //        set
    //        {
    //            this.numDocumentoField = value;
    //            this.RaisePropertyChanged("numDocumento");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
    //    public string nombrePersona
    //    {
    //        get
    //        {
    //            return this.nombrePersonaField;
    //        }
    //        set
    //        {
    //            this.nombrePersonaField = value;
    //            this.RaisePropertyChanged("nombrePersona");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
    //    public string apellidosPersona
    //    {
    //        get
    //        {
    //            return this.apellidosPersonaField;
    //        }
    //        set
    //        {
    //            this.apellidosPersonaField = value;
    //            this.RaisePropertyChanged("apellidosPersona");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
    //    public int codigoProvinciaDom
    //    {
    //        get
    //        {
    //            return this.codigoProvinciaDomField;
    //        }
    //        set
    //        {
    //            this.codigoProvinciaDomField = value;
    //            this.RaisePropertyChanged("codigoProvinciaDom");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlIgnoreAttribute()]
    //    public bool codigoProvinciaDomSpecified
    //    {
    //        get
    //        {
    //            return this.codigoProvinciaDomFieldSpecified;
    //        }
    //        set
    //        {
    //            this.codigoProvinciaDomFieldSpecified = value;
    //            this.RaisePropertyChanged("codigoProvinciaDomSpecified");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
    //    public string nombreProvinciaDom
    //    {
    //        get
    //        {
    //            return this.nombreProvinciaDomField;
    //        }
    //        set
    //        {
    //            this.nombreProvinciaDomField = value;
    //            this.RaisePropertyChanged("nombreProvinciaDom");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
    //    public int codigoMunicipioDom
    //    {
    //        get
    //        {
    //            return this.codigoMunicipioDomField;
    //        }
    //        set
    //        {
    //            this.codigoMunicipioDomField = value;
    //            this.RaisePropertyChanged("codigoMunicipioDom");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlIgnoreAttribute()]
    //    public bool codigoMunicipioDomSpecified
    //    {
    //        get
    //        {
    //            return this.codigoMunicipioDomFieldSpecified;
    //        }
    //        set
    //        {
    //            this.codigoMunicipioDomFieldSpecified = value;
    //            this.RaisePropertyChanged("codigoMunicipioDomSpecified");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
    //    public string nombreMunicipioDom
    //    {
    //        get
    //        {
    //            return this.nombreMunicipioDomField;
    //        }
    //        set
    //        {
    //            this.nombreMunicipioDomField = value;
    //            this.RaisePropertyChanged("nombreMunicipioDom");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
    //    public string direccionDom
    //    {
    //        get
    //        {
    //            return this.direccionDomField;
    //        }
    //        set
    //        {
    //            this.direccionDomField = value;
    //            this.RaisePropertyChanged("direccionDom");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
    //    public string telefonoFijoDom
    //    {
    //        get
    //        {
    //            return this.telefonoFijoDomField;
    //        }
    //        set
    //        {
    //            this.telefonoFijoDomField = value;
    //            this.RaisePropertyChanged("telefonoFijoDom");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
    //    public string telefonoMovil
    //    {
    //        get
    //        {
    //            return this.telefonoMovilField;
    //        }
    //        set
    //        {
    //            this.telefonoMovilField = value;
    //            this.RaisePropertyChanged("telefonoMovil");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
    //    public string email
    //    {
    //        get
    //        {
    //            return this.emailField;
    //        }
    //        set
    //        {
    //            this.emailField = value;
    //            this.RaisePropertyChanged("email");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
    //    public string codigoPaisNacimiento
    //    {
    //        get
    //        {
    //            return this.codigoPaisNacimientoField;
    //        }
    //        set
    //        {
    //            this.codigoPaisNacimientoField = value;
    //            this.RaisePropertyChanged("codigoPaisNacimiento");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
    //    public string periodoAcademico
    //    {
    //        get
    //        {
    //            return this.periodoAcademicoField;
    //        }
    //        set
    //        {
    //            this.periodoAcademicoField = value;
    //            this.RaisePropertyChanged("periodoAcademico");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
    //    public int actividadEconomica
    //    {
    //        get
    //        {
    //            return this.actividadEconomicaField;
    //        }
    //        set
    //        {
    //            this.actividadEconomicaField = value;
    //            this.RaisePropertyChanged("actividadEconomica");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
    //    public int periodoActividad
    //    {
    //        get
    //        {
    //            return this.periodoActividadField;
    //        }
    //        set
    //        {
    //            this.periodoActividadField = value;
    //            this.RaisePropertyChanged("periodoActividad");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(Order = 18)]
    //    public string codigoPlanEstudios
    //    {
    //        get
    //        {
    //            return this.codigoPlanEstudiosField;
    //        }
    //        set
    //        {
    //            this.codigoPlanEstudiosField = value;
    //            this.RaisePropertyChanged("codigoPlanEstudios");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 19)]
    //    public System.Nullable<int> numeroOrdenExpediente
    //    {
    //        get
    //        {
    //            return this.numeroOrdenExpedienteField;
    //        }
    //        set
    //        {
    //            this.numeroOrdenExpedienteField = value;
    //            this.RaisePropertyChanged("numeroOrdenExpediente");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlIgnoreAttribute()]
    //    public bool numeroOrdenExpedienteSpecified
    //    {
    //        get
    //        {
    //            return this.numeroOrdenExpedienteFieldSpecified;
    //        }
    //        set
    //        {
    //            this.numeroOrdenExpedienteFieldSpecified = value;
    //            this.RaisePropertyChanged("numeroOrdenExpedienteSpecified");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 20)]
    //    public System.Nullable<int> codigoMovimiento
    //    {
    //        get
    //        {
    //            return this.codigoMovimientoField;
    //        }
    //        set
    //        {
    //            this.codigoMovimientoField = value;
    //            this.RaisePropertyChanged("codigoMovimiento");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlIgnoreAttribute()]
    //    public bool codigoMovimientoSpecified
    //    {
    //        get
    //        {
    //            return this.codigoMovimientoFieldSpecified;
    //        }
    //        set
    //        {
    //            this.codigoMovimientoFieldSpecified = value;
    //            this.RaisePropertyChanged("codigoMovimientoSpecified");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(Order = 21)]
    //    public string codigoEstudio
    //    {
    //        get
    //        {
    //            return this.codigoEstudioField;
    //        }
    //        set
    //        {
    //            this.codigoEstudioField = value;
    //            this.RaisePropertyChanged("codigoEstudio");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(Order = 22)]
    //    public string fechaUltimaModificacion
    //    {
    //        get
    //        {
    //            return this.fechaUltimaModificacionField;
    //        }
    //        set
    //        {
    //            this.fechaUltimaModificacionField = value;
    //            this.RaisePropertyChanged("fechaUltimaModificacion");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(Order = 23)]
    //    public string tipoPago
    //    {
    //        get
    //        {
    //            return this.tipoPagoField;
    //        }
    //        set
    //        {
    //            this.tipoPagoField = value;
    //            this.RaisePropertyChanged("tipoPago");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 24)]
    //    public System.Nullable<int> codigoSistemaFinanciacion
    //    {
    //        get
    //        {
    //            return this.codigoSistemaFinanciacionField;
    //        }
    //        set
    //        {
    //            this.codigoSistemaFinanciacionField = value;
    //            this.RaisePropertyChanged("codigoSistemaFinanciacion");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlIgnoreAttribute()]
    //    public bool codigoSistemaFinanciacionSpecified
    //    {
    //        get
    //        {
    //            return this.codigoSistemaFinanciacionFieldSpecified;
    //        }
    //        set
    //        {
    //            this.codigoSistemaFinanciacionFieldSpecified = value;
    //            this.RaisePropertyChanged("codigoSistemaFinanciacionSpecified");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 25)]
    //    public System.Nullable<decimal> importeMatMov
    //    {
    //        get
    //        {
    //            return this.importeMatMovField;
    //        }
    //        set
    //        {
    //            this.importeMatMovField = value;
    //            this.RaisePropertyChanged("importeMatMov");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlIgnoreAttribute()]
    //    public bool importeMatMovSpecified
    //    {
    //        get
    //        {
    //            return this.importeMatMovFieldSpecified;
    //        }
    //        set
    //        {
    //            this.importeMatMovFieldSpecified = value;
    //            this.RaisePropertyChanged("importeMatMovSpecified");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 26)]
    //    public System.Nullable<decimal> importeSistemaFinanciacion
    //    {
    //        get
    //        {
    //            return this.importeSistemaFinanciacionField;
    //        }
    //        set
    //        {
    //            this.importeSistemaFinanciacionField = value;
    //            this.RaisePropertyChanged("importeSistemaFinanciacion");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlIgnoreAttribute()]
    //    public bool importeSistemaFinanciacionSpecified
    //    {
    //        get
    //        {
    //            return this.importeSistemaFinanciacionFieldSpecified;
    //        }
    //        set
    //        {
    //            this.importeSistemaFinanciacionFieldSpecified = value;
    //            this.RaisePropertyChanged("importeSistemaFinanciacionSpecified");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 27)]
    //    public System.Nullable<decimal> importeRecargos
    //    {
    //        get
    //        {
    //            return this.importeRecargosField;
    //        }
    //        set
    //        {
    //            this.importeRecargosField = value;
    //            this.RaisePropertyChanged("importeRecargos");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlIgnoreAttribute()]
    //    public bool importeRecargosSpecified
    //    {
    //        get
    //        {
    //            return this.importeRecargosFieldSpecified;
    //        }
    //        set
    //        {
    //            this.importeRecargosFieldSpecified = value;
    //            this.RaisePropertyChanged("importeRecargosSpecified");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 28)]
    //    public System.Nullable<int> codigoAnulacion
    //    {
    //        get
    //        {
    //            return this.codigoAnulacionField;
    //        }
    //        set
    //        {
    //            this.codigoAnulacionField = value;
    //            this.RaisePropertyChanged("codigoAnulacion");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlIgnoreAttribute()]
    //    public bool codigoAnulacionSpecified
    //    {
    //        get
    //        {
    //            return this.codigoAnulacionFieldSpecified;
    //        }
    //        set
    //        {
    //            this.codigoAnulacionFieldSpecified = value;
    //            this.RaisePropertyChanged("codigoAnulacionSpecified");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(Order = 29)]
    //    public string fechaAnulacion
    //    {
    //        get
    //        {
    //            return this.fechaAnulacionField;
    //        }
    //        set
    //        {
    //            this.fechaAnulacionField = value;
    //            this.RaisePropertyChanged("fechaAnulacion");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(Order = 30)]
    //    public string fechaDesanulacion
    //    {
    //        get
    //        {
    //            return this.fechaDesanulacionField;
    //        }
    //        set
    //        {
    //            this.fechaDesanulacionField = value;
    //            this.RaisePropertyChanged("fechaDesanulacion");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(Order = 31)]
    //    public string centroCoste
    //    {
    //        get
    //        {
    //            return this.centroCosteField;
    //        }
    //        set
    //        {
    //            this.centroCosteField = value;
    //            this.RaisePropertyChanged("centroCoste");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(Order = 32)]
    //    public string ordenCUC
    //    {
    //        get
    //        {
    //            return this.ordenCUCField;
    //        }
    //        set
    //        {
    //            this.ordenCUCField = value;
    //            this.RaisePropertyChanged("ordenCUC");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(Order = 33)]
    //    public string tipoCurso
    //    {
    //        get
    //        {
    //            return this.tipoCursoField;
    //        }
    //        set
    //        {
    //            this.tipoCursoField = value;
    //            this.RaisePropertyChanged("tipoCurso");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(Order = 34)]
    //    public string fechaInicioImparticion
    //    {
    //        get
    //        {
    //            return this.fechaInicioImparticionField;
    //        }
    //        set
    //        {
    //            this.fechaInicioImparticionField = value;
    //            this.RaisePropertyChanged("fechaInicioImparticion");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(Order = 35)]
    //    public string fechaFinImparticion
    //    {
    //        get
    //        {
    //            return this.fechaFinImparticionField;
    //        }
    //        set
    //        {
    //            this.fechaFinImparticionField = value;
    //            this.RaisePropertyChanged("fechaFinImparticion");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlArrayAttribute(Order = 36)]
    //    [System.Xml.Serialization.XmlArrayItemAttribute("tiposDesglose", typeof(T_TIPO_DESGLOSE), IsNullable = false)]
    //    public T_TIPO_DESGLOSE[][] desglosesMatMov
    //    {
    //        get
    //        {
    //            return this.desglosesMatMovField;
    //        }
    //        set
    //        {
    //            this.desglosesMatMovField = value;
    //            this.RaisePropertyChanged("desglosesMatMov");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlArrayAttribute(Order = 37)]
    //    [System.Xml.Serialization.XmlArrayItemAttribute("tiposRecibo", typeof(T_TIPO_RECIBO), IsNullable = false)]
    //    public T_TIPO_RECIBO[][] recibosMatMov
    //    {
    //        get
    //        {
    //            return this.recibosMatMovField;
    //        }
    //        set
    //        {
    //            this.recibosMatMovField = value;
    //            this.RaisePropertyChanged("recibosMatMov");
    //        }
    //    }

    //    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

    //    protected void RaisePropertyChanged(string propertyName)
    //    {
    //        System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
    //        if ((propertyChanged != null))
    //        {
    //            propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
    //        }
    //    }
    //}

    ////[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2556.0")]
    ////[System.SerializableAttribute()]
    ////[System.Diagnostics.DebuggerStepThroughAttribute()]
    ////[System.ComponentModel.DesignerCategoryAttribute("code")]
    ////[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ocu.es/xsd/SincronizarMatMov")]
    ////public class T_TIPO_MATRICULA:object, System.ComponentModel.INotifyPropertyChanged
    ////{


    ////    public string codigoRegistro { get; set; }
    ////    public string codigoPersona { get; set; }
    ////    public string tipoDocumento { get; set; }
    ////    public string numDocumento { get; set; }
    ////    public string nombrePersona { get; set; }
    ////    public string apellidosPersona { get; set; }
    ////    public string codigoProvinciaDom { get; set; }
    ////    public string codigoMunicipioDom { get; set; }
    ////    public string direccionDom { get; set; }
    ////    public string telefonoMovil { get; set; }
    ////    public string telefonoFijoDom { get; set; }
    ////    public string email { get; set; }
    ////    public string codigoPaisNacimiento { get; set; }
    ////    public string periodoAcademico { get; set; }
    ////    public string actividadEconomica { get; set; }
    ////    public string periodoActividad { get; set; }
    ////    public string codigoPlanEstudios { get; set; }
    ////    public string numeroOrdenExpediente { get; set; }
    ////    public int codigoMovimiento { get; set; }
    ////    public string codigoEstudio { get; set; }
    ////    public string fechaUltimaModificacion { get; set; }
    ////    public string tipoPago { get; set; }
    ////    public int codigoSistemaFinanciacion { get; set; }
    ////    public double importeMatMov { get; set; }
    ////    public double importeSistemaFinanciacion { get; set; }
    ////    public double importeRecargos { get; set; }
    ////    public int codigoAnulacion { get; set; }
    ////    public string fechaAnulacion { get; set; }
    ////    public string fechaDesanulacion { get; set; }
    ////    public string centroCoste { get; set; }
    ////    public string ordenCUC { get; set; }
    ////    public string tipoCurso { get; set; }
    ////    public string fechaInicioImparticion { get; set; }
    ////    public string fechaFinImparticion { get; set; }
    ////    public List<tiposDesglose> desglosesMatMov { get; set; }
    ////    public List<tiposRecibo> recibosMatMov { get; set; }

    ////    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
    ////}
}