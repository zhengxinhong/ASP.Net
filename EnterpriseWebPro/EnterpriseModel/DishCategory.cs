using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseModel
{
    /// <summary>
    /// 菜品分类表
    /// </summary>
    [Serializable]
    public class DishCategory
    {

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

    }
}
