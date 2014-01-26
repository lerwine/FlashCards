using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Erwine.Leonard.Thomas.Flash_Cards.Data
{
    public class DropDownItem<EnumeratedValueType> : IComparable<DropDownItem<EnumeratedValueType>>, IComparable<EnumeratedValueType>, 
        IEquatable<DropDownItem<EnumeratedValueType>>, IEquatable<EnumeratedValueType>
    {
        public bool operator ==(DropDownItem<EnumeratedValueType> value1, DropDownItem<EnumeratedValueType> value2)
        {
            return (value1.Value.Equals(value2.Value));
        }

        public bool operator !=(DropDownItem<EnumeratedValueType> value1, DropDownItem<EnumeratedValueType> value2)
        {
            return (value1.Value.Equals(value2.Value));
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (obj is EnumeratedValueType)
                return this.Value.Equals((EnumeratedValueType)obj);

            if (obj is DropDownItem<EnumeratedValueType>)
                return this.Value.Equals(((DropDownItem<EnumeratedValueType>)obj).Value);

            return false;
        }

        public override int GetHashCode()
        {
            return this.Value.GetHashCode();
        }

        private static EnumeratedValueType GetEnumValue(string value)
        {
            if (value == null)
                throw new ArgumentNullException("value");

            if (value == null)
                throw new ArgumentException("Value cannot be empty", "value");

            return ((EnumeratedValueType)(Enum.Parse(typeof(EnumeratedValueType), value, true)));
        }

        private EnumeratedValueType _value;
        
        private string _display, _toolTip;

        public EnumeratedValueType Value
        {
            get
            {
                return this._value;
            }
        }

        public string Display
        {
            get
            {
                return this._display;
            }
        }

        public string ToolTip
        {
            get
            {
                return this._toolTip;
            }
        }

        public DropDownItem(string value, string display, string toolTip)
            : this(DropDownItem<EnumeratedValueType>.GetEnumValue(value), display, toolTip)
        {
        }

        public DropDownItem(EnumeratedValueType value, string display, string toolTip)
        {
            if (!typeof(EnumeratedValueType).IsEnum)
                throw new ArgumentException("Only enumerated types are supported");

            this._value = value;
            if (String.IsNullOrEmpty(display))
                this._display = Enum.GetName(typeof(EnumeratedValueType), value);
            else
                this._display = display;

            if (String.IsNullOrEmpty(toolTip))
                this._toolTip = this._display;
            else
                this._toolTip = toolTip;
        }

        public DropDownItem(XmlElement enumerationElement)
        {
            XmlNamespaceManager nsmgr;
            XmlElement listItemElement;

            if (enumerationElement == null)
                throw new ArgumentNullException();

            if (enumerationElement.NamespaceURI != Properties.Settings.Default.XMLSchemaNamespace)
                throw new ArgumentException("Invalid namespace");

            if (enumerationElement.LocalName != "enumeration")
                throw new ArgumentException("Invalid element name");

            if (enumerationElement.Attributes["value"] == null)
                throw new ArgumentException("Invalid element");

            nsmgr = new XmlNamespaceManager(enumerationElement.OwnerDocument.NameTable);
            nsmgr.AddNamespace("xs", Properties.Settings.Default.XMLSchemaNamespace);
            nsmgr.AddNamespace("ddi", Properties.Settings.Default.DropDownInfoNamespace);

            this._value = DropDownItem<EnumeratedValueType>.GetEnumValue(enumerationElement.Attributes["value"].InnerText);

            if ((listItemElement = enumerationElement.SelectSingleNode("xs:annotation/xs:appinfo/ddi:ListItem", nsmgr)) == null ||
                listItemElement.Attributes["Display"] == null || String.IsNullOrEmpty(listItemElement.Attributes["Display"].InnerText))
                this._display = Enum.GetName(typeof(EnumeratedValueType), value);
            else
                this._display = listItemElement.Attributes["Display"].InnerText;

            if (listItemElement == null || listItemElement.IsEmpty || String.IsNullOrEmpty(listItemElement.InnerText))
                this._toolTip = this._display;
            else
                this._toolTip = listItemElement.InnerText;
        }

        public override string ToString()
        {
            return this._display;
        }

        #region IComparable<DropDownItem<EnumeratedValueType>> Members

        public int CompareTo(DropDownItem<EnumeratedValueType> other)
        {
            return (((int)(this.Value)).CompareTo((int)(other.Value)));
        }

        #endregion

        #region IComparable<EnumeratedValueType> Members

        public int CompareTo(EnumeratedValueType other)
        {
            return (((int)(this.Value)).CompareTo((int)other));
        }

        #endregion

        #region IEquatable<DropDownItem<EnumeratedValueType>> Members

        public bool Equals(DropDownItem<EnumeratedValueType> other)
        {
            return this.Value.Equals(other.Value);
        }

        #endregion

        #region IEquatable<EnumeratedValueType> Members

        public bool Equals(EnumeratedValueType other)
        {
            return this.Value.Equals(other);
        }

        #endregion
    }
}
