using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCreateContourSPEC
{
    public interface IData
    {
        string SizeName { get; set; }
        string DieNo { get; set; }
        string UpdatedTime { get; set; }
    }
}
