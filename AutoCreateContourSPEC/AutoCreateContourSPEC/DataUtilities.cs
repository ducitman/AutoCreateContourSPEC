using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCreateContourSPEC
{
    public class DataUtilities
    {
        public static string STARTFORMAT = @"0
""""
""""
0
0";
        public static string MIDDLEFORMAT = @"0
0
0
0
0
0
0,#TRUE#,"""",0
0,0,0
0,0,0
0,0,0
0,0,0
0,0,0
0,0,0
0,0,0
0,0,0";
        public static string SIDEANDBFFORMAT = @"0
""
""
0
0
0
0
0
0
0
0
0
0
0
0
0
0,#TRUE#,"""",0
0,0,0
0,0,0
0,0,0
0,0,0
0,0,0
0,0,0
0,0,0
0,0,0";
        public static string DESTINATIONPATH = @"C:\Users\duc.phamhuynh\Desktop\Duc\Doc\TSSimulatorTransfer\";
        
    }
}
