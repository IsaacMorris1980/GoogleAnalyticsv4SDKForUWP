using GoogleAnalyticsv4SDK.Models;

using System.Collections.Generic;
namespace GoogleAnalyticsv4SDK.EcommerceEvents
{
    public class Begin_Checkout
    {
        private string currency; //required
        private decimal value; //required
        private string coupon;
        private List<Item> items; //required
    }
}
