﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

namespace Nequeo.VoIP.Sip.Data
{
    // 
    // This source code was auto-generated by xsd, Version=4.6.81.0.
    // 


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class contacts
    {

        private contactsContact[] contactField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("contact")]
        public contactsContact[] contact
        {
            get
            {
                return this.contactField;
            }
            set
            {
                this.contactField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class contactsContact
    {

        private string nameField;

        private string sipAccountField;

        private bool presenceStateField;

        private string groupField;

        private string pictureField;

        private string[] numbersField;

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string sipAccount
        {
            get
            {
                return this.sipAccountField;
            }
            set
            {
                this.sipAccountField = value;
            }
        }

        /// <remarks/>
        public bool presenceState
        {
            get
            {
                return this.presenceStateField;
            }
            set
            {
                this.presenceStateField = value;
            }
        }

        /// <remarks/>
        public string group
        {
            get
            {
                return this.groupField;
            }
            set
            {
                this.groupField = value;
            }
        }

        /// <remarks/>
        public string picture
        {
            get
            {
                return this.pictureField;
            }
            set
            {
                this.pictureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("number", IsNullable = false)]
        public string[] numbers
        {
            get
            {
                return this.numbersField;
            }
            set
            {
                this.numbersField = value;
            }
        }
    }
}