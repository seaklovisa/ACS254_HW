using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    /// <summary>
    /// 自定義appconfig StudentDiscounts區段
    /// </summary>
    public partial class StudentDiscountConfig : ConfigurationSection
    {
        [ConfigurationProperty("StudentDiscounts")]
        public DiscountCollection DiscountItems
        {
            get { return (base["StudentDiscounts"] as DiscountCollection); }
        }
    }

    [ConfigurationCollection(typeof(DiscountElement))]
    public partial class DiscountCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new DiscountElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return (element as DiscountElement).Name;
        }

        public DiscountElement this[int index]
        {
            get { return base.BaseGet(index) as DiscountElement; }
        }
    }

    public partial class DiscountElement : ConfigurationElement
    {
        [ConfigurationProperty("Name", DefaultValue = "", IsKey = true, IsRequired = true)]
        public string Name { get { return (string)base["Name"]; } set { base["Name"] = value; } }

        [ConfigurationProperty("Action", DefaultValue = "", IsKey = false, IsRequired = true)]
        public string Action { get { return (string)base["Action"]; } set { base["Action"] = value; } }
    }
}