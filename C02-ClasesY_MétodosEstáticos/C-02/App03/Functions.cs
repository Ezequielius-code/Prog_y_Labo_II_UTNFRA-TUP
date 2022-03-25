using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App03
{
    internal static class Functions
    {
        /// <summary>
        /// This method returns the name of the university. 
        /// </summary>
        /// <returns></returns>
        public static string AppName()
        {
            return "UNIVERSIDAD TECNOLÓGICA NACIONAL";
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="division"></param>
        /// <returns></returns>
        public static int StudentsQuantity(string division)
        {
            switch (division)
            {
                case "A":
                    return 10;
                case "B":
                    return 20;
                default:
                    return 100;
            }
        }
    }
}
