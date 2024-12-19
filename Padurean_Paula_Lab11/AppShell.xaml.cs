using Padurean_Paula_Lab11.Data;
using Padurean_Paula_Lab11.Models;

namespace Padurean_Paula_Lab11
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }

        public App()
        {
            Database = new ShoppingListDatabase(new RestService());
            MainPage = new NavigationPage(new ListEntryPage());
        }

        public class ShoppingListDatabase
        {
            public ShoppingListDatabase(RestService restService)
            {
                RestService = restService;
            }

            public RestService RestService { get; }

            internal async Task DeleteShopListAsync(ShopList slist)
            {
                throw new NotImplementedException();
            }

            internal async Task SaveShopListAsync(ShopList slist)
            {
                throw new NotImplementedException();
            }
        }
    }

    internal class ListEntryPage : Page
    {
    }
}