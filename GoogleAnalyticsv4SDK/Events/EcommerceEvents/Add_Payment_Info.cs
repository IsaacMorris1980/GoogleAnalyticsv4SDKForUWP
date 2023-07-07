using System.Collections.Generic;

namespace GoogleAnalyticsv4SDK.Models
{

    public class Add_Payment_Info
    {
        private string currency; //required
        private decimal value; // required
        private string coupon;
        private string payment_type;
        private List<Item> items; //required

    }
}
