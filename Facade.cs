using System;
using System.Collections.Generic;

namespace Facade_Demo
{
    public class Facade : subsys1
    {
        subsys1 sys1 = new subsys1();
        public string GetData1()
        {
           return sys1.Data1;
        }
        public string GetData2()
        {
            return sys1.Data2;
        }
        public string GetAllData()
        {
            return sys1.Data1 + " " + sys1.Data2;
        }
        
    }
    public class subsys1
    {
        private string data1 = "Hej hej";
        public string Data1 { get; set; }
        private string data2 = "Hejsan svejsan!";
        public string Data2 {get; set;}
        public subsys1()
        {
            Data1 = data1;
            Data2 = data2;
        }
    }
}