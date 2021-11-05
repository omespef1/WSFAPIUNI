using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSFAPIUNI.TO
{
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2556.0")]
    //[System.SerializableAttribute()]
    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.ComponentModel.DesignerCategoryAttribute("code")]
    //[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ocu.es/xsd/SincronizarMatMov")]
    //public class tiposDesglose : object, System.ComponentModel.INotifyPropertyChanged
    //{
    //    public string tipoConcepto { get; set; }
    //    public string codigoConcepto { get; set; }
    //    public string nombreConcepto { get; set; }
    //    public double importeConcepto { get; set; }
    //    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
    //}

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2556.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ocu.es/xsd/SincronizarMatMov")]
    public partial class T_TIPO_DESGLOSE : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string tipoConceptoField;

        private int codigoConceptoField;

        private string nombreConceptoField;

        private decimal importeConceptoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string tipoConcepto
        {
            get
            {
                return this.tipoConceptoField;
            }
            set
            {
                this.tipoConceptoField = value;
                this.RaisePropertyChanged("tipoConcepto");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public int codigoConcepto
        {
            get
            {
                return this.codigoConceptoField;
            }
            set
            {
                this.codigoConceptoField = value;
                this.RaisePropertyChanged("codigoConcepto");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string nombreConcepto
        {
            get
            {
                return this.nombreConceptoField;
            }
            set
            {
                this.nombreConceptoField = value;
                this.RaisePropertyChanged("nombreConcepto");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public decimal importeConcepto
        {
            get
            {
                return this.importeConceptoField;
            }
            set
            {
                this.importeConceptoField = value;
                this.RaisePropertyChanged("importeConcepto");
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

}