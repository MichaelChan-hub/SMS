using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Models.UIModels
{
    public class PageModel<T>
    {
        public int TotalCount { get; set; }
        public List<T> ReList { get; set; }

    }
}
