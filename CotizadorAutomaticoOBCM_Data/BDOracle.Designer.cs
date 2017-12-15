﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace CotizadorAutomaticoOBCM_Data
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class Entidades : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new Entidades object using the connection string found in the 'Entidades' section of the application configuration file.
        /// </summary>
        public Entidades() : base("name=Entidades", "Entidades")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new Entidades object.
        /// </summary>
        public Entidades(string connectionString) : base(connectionString, "Entidades")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new Entidades object.
        /// </summary>
        public Entidades(EntityConnection connection) : base(connection, "Entidades")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<MONEDA> MONEDA
        {
            get
            {
                if ((_MONEDA == null))
                {
                    _MONEDA = base.CreateObjectSet<MONEDA>("MONEDA");
                }
                return _MONEDA;
            }
        }
        private ObjectSet<MONEDA> _MONEDA;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the MONEDA EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToMONEDA(MONEDA mONEDA)
        {
            base.AddObject("MONEDA", mONEDA);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Modelo", Name="MONEDA")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class MONEDA : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new MONEDA object.
        /// </summary>
        /// <param name="iDMONEDA">Initial value of the IDMONEDA property.</param>
        /// <param name="dESCRIPCION">Initial value of the DESCRIPCION property.</param>
        /// <param name="sIGNO">Initial value of the SIGNO property.</param>
        public static MONEDA CreateMONEDA(global::System.Decimal iDMONEDA, global::System.String dESCRIPCION, global::System.String sIGNO)
        {
            MONEDA mONEDA = new MONEDA();
            mONEDA.IDMONEDA = iDMONEDA;
            mONEDA.DESCRIPCION = dESCRIPCION;
            mONEDA.SIGNO = sIGNO;
            return mONEDA;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal IDMONEDA
        {
            get
            {
                return _IDMONEDA;
            }
            set
            {
                if (_IDMONEDA != value)
                {
                    OnIDMONEDAChanging(value);
                    ReportPropertyChanging("IDMONEDA");
                    _IDMONEDA = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("IDMONEDA");
                    OnIDMONEDAChanged();
                }
            }
        }
        private global::System.Decimal _IDMONEDA;
        partial void OnIDMONEDAChanging(global::System.Decimal value);
        partial void OnIDMONEDAChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String DESCRIPCION
        {
            get
            {
                return _DESCRIPCION;
            }
            set
            {
                OnDESCRIPCIONChanging(value);
                ReportPropertyChanging("DESCRIPCION");
                _DESCRIPCION = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("DESCRIPCION");
                OnDESCRIPCIONChanged();
            }
        }
        private global::System.String _DESCRIPCION;
        partial void OnDESCRIPCIONChanging(global::System.String value);
        partial void OnDESCRIPCIONChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String SIGNO
        {
            get
            {
                return _SIGNO;
            }
            set
            {
                OnSIGNOChanging(value);
                ReportPropertyChanging("SIGNO");
                _SIGNO = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("SIGNO");
                OnSIGNOChanged();
            }
        }
        private global::System.String _SIGNO;
        partial void OnSIGNOChanging(global::System.String value);
        partial void OnSIGNOChanged();

        #endregion

    
    }

    #endregion

    
}