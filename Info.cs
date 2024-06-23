using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Kiosk
{
    internal class Info
    {
        static Info instance;

        public static Info Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Info();
                }
                return instance;
            }
        }
        public string Name { get; set; }
        public string IdNumber { get; set; }
        public string CallNumber {  get; set; }
        public string Adress { get; set; }
        public string RichBox { get; set; }        
        public string Doctor { get; set; }
        
    }
}
