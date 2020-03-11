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