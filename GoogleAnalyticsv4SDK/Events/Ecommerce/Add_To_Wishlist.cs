using GoogleAnalyticsv4SDK.Models;

using System.Collections.Generic;

namespace GoogleAnalyticsv4SDK.Events.Ecommerce
{
    public class Add_To_Wishlist
    {
        private string currency; //required
        private decimal value; //required
        private List<Item> items; //required
    }
}
