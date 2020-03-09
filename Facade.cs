using System;
using System.Collections.Generic;

namespace Facade_Demo
{
    //Facad objekt som hantera komunikation med subsystemen 
    public class Facade
    {
        private subsys1 sys1 = new subsys1();
        private subsys2 sys2 = new subsys2();
        public string GetData1()//hämtar första index data ur subsystem 1 och 2 
        {

            return sys1.Data1 + " " + sys2.Info1;
        }
        public string GetData2() //hämtar andra index data ur subsystem 1 och 2
        {
            return sys1.Data2 + " " + sys2.Info2;
        }
        public List<string> GetAllData() //returnerar samtlig data
        {
            List<string> DataList = new List<string>();
            DataList.Add(GetData1());
            DataList.Add(GetData2());
            return DataList;
        }

    }
    public class subsys1 //subsystem med data
    {
        public subsys1()//konstruktor som förhindrar att man ändrar på dom faktiska värden i systemet. 
        {
            Data1 = data1;
            Data2 = data2;
        }
        public string Data1 { get; set; }
        private string data1 = "Hej hej";
        public string Data2 { get; set; }
        private string data2 = "Hejsan svejsan!";

    }
    public class subsys2  //subsystem med data
    {
        public subsys2()
        {
            Info1 = information1;
            Info2 = information2;
        }
        //kan finnas flera subsystem nestlade eller kontakter med API som blir krångligt att hantera direkt i Main
        public string Info1 { get; set; }
        public string Info2 { get; set; }
        private string information1 = "Abra kadabra";
        private string information2 = "Hokus pokus!";
    }
}