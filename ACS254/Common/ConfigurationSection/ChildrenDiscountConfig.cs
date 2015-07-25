using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    /// <summary>
    /// 自定義 ChildrenDiscounts區段
    /// </summary>
    public partial class ChildrenDiscountConfig : ConfigurationSection
    {
        [ConfigurationProperty("ChildrenDiscounts")]
        public DiscountCollection DiscountItems
        {
            get { return (base["ChildrenDiscounts"] as DiscountCollection); }
        }
    }
}