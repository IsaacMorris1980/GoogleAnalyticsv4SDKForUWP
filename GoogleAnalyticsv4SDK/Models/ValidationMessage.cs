namespace GoogleAnalyticsv4SDK.Models
{

    public class Rootobject
    {
        public Validationmessage[] validationMessages { get; set; }
    }

    public class Validationmessage
    {
        public string fieldPath { get; set; }
        public string description { get; set; }
        public string validationCode { get; set; }
    }

}
