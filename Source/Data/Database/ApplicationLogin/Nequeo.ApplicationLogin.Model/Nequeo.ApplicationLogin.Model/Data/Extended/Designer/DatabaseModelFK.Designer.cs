//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nequeo.DataAccess.ApplicationLogin.Data.Extended
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Data;
    using System.Threading;
    using System.Diagnostics;
    using System.Data.SqlClient;
    using System.Data.OleDb;
    using System.Data.Odbc;
    using System.Collections;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Xml.Serialization;
    using System.Runtime.Serialization;
    using System.ComponentModel;
    using Nequeo.Data.DataType;
    using Nequeo.Data;
    using Nequeo.Data.Linq;
    using Nequeo.Data.Control;
    using Nequeo.Data.Custom;
    using Nequeo.Data.LinqToSql;
    using Nequeo.Data.DataSet;
    using Nequeo.Data.Edm;
    using Nequeo.ComponentModel;
    
    
    #region TableEntityForeignKey Data Type
    /// <summary>
    /// The tableentityforeignkey data object class.
    /// </summary>
    [DataContractAttribute(Name = "TableEntityForeignKey", IsReference = true)]
    [SerializableAttribute()]
    [KnownTypeAttribute(typeof(DataBase))]
    public partial class TableEntityForeignKey : DataBase
    {
        
        private string _Name;
        
        private string _ColumnName;
        
        private string _ColumnType;
        
        private long _Length;
        
        private bool _IsNullable;
        
        #region Extensibility Method Definitions
        /// <summary>
        /// On create data entity.
        /// </summary>
		partial void OnCreated();

        /// <summary>
        /// On load data entity.
        /// </summary>
		partial void OnLoaded();

		#endregion
        
        /// <summary>
        /// Default constructor.
        /// </summary>
        public TableEntityForeignKey()
        {
            OnCreated();
        }
        
        /// <summary>
        /// Gets sets, the name property for the object.
        /// </summary>
        [CategoryAttribute("Column")]
        [DescriptionAttribute("Gets sets, the name property for the object.")]
        [DataMemberAttribute(Name = "Name")]
        [XmlElementAttribute(ElementName = "Name", IsNullable = false)]
        [SoapElementAttribute(IsNullable = false)]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                if ((this._Name != value))
                {
                    this._Name = value;
                }
            }
        }
        
        /// <summary>
        /// Gets sets, the columnname property for the object.
        /// </summary>
        [CategoryAttribute("Column")]
        [DescriptionAttribute("Gets sets, the columnname property for the object.")]
        [DataMemberAttribute(Name = "ColumnName")]
        [XmlElementAttribute(ElementName = "ColumnName", IsNullable = false)]
        [SoapElementAttribute(IsNullable = false)]
        public string ColumnName
        {
            get
            {
                return this._ColumnName;
            }
            set
            {
                if ((this._ColumnName != value))
                {
                    this._ColumnName = value;
                }
            }
        }
        
        /// <summary>
        /// Gets sets, the columntype property for the object.
        /// </summary>
        [CategoryAttribute("Column")]
        [DescriptionAttribute("Gets sets, the columntype property for the object.")]
        [DataMemberAttribute(Name = "ColumnType")]
        [XmlElementAttribute(ElementName = "ColumnType", IsNullable = false)]
        [SoapElementAttribute(IsNullable = false)]
        public string ColumnType
        {
            get
            {
                return this._ColumnType;
            }
            set
            {
                if ((this._ColumnType != value))
                {
                    this._ColumnType = value;
                }
            }
        }
        
        /// <summary>
        /// Gets sets, the length property for the object.
        /// </summary>
        [CategoryAttribute("Column")]
        [DescriptionAttribute("Gets sets, the length property for the object.")]
        [DataMemberAttribute(Name = "Length")]
        [XmlElementAttribute(ElementName = "Length", IsNullable = false)]
        [SoapElementAttribute(IsNullable = false)]
        public long Length
        {
            get
            {
                return this._Length;
            }
            set
            {
                if ((this._Length != value))
                {
                    this._Length = value;
                }
            }
        }
        
        /// <summary>
        /// Gets sets, the isnullable property for the object.
        /// </summary>
        [CategoryAttribute("Column")]
        [DescriptionAttribute("Gets sets, the isnullable property for the object.")]
        [DataMemberAttribute(Name = "IsNullable")]
        [XmlElementAttribute(ElementName = "IsNullable", IsNullable = false)]
        [SoapElementAttribute(IsNullable = false)]
        public bool IsNullable
        {
            get
            {
                return this._IsNullable;
            }
            set
            {
                if ((this._IsNullable != value))
                {
                    this._IsNullable = value;
                }
            }
        }
        
        /// <summary>
        /// Create a new tableentityforeignkey data entity.
        /// </summary>
        /// <param name="name">Initial value of Name.</param>
        /// <param name="columnName">Initial value of ColumnName.</param>
        /// <param name="columnType">Initial value of ColumnType.</param>
        /// <param name="length">Initial value of Length.</param>
        /// <param name="isNullable">Initial value of IsNullable.</param>
        /// <returns>The Data.Extended.TableEntityForeignKey entity.</returns>
        public static Data.Extended.TableEntityForeignKey CreateTableEntityForeignKey(string name, string columnName, string columnType, long length, bool isNullable)
        {
            Data.Extended.TableEntityForeignKey tableEntityForeignKey = new Data.Extended.TableEntityForeignKey();
            tableEntityForeignKey.Name = name;
            tableEntityForeignKey.ColumnName = columnName;
            tableEntityForeignKey.ColumnType = columnType;
            tableEntityForeignKey.Length = length;
            tableEntityForeignKey.IsNullable = isNullable;
            return tableEntityForeignKey;
        }
    }
    #endregion
}