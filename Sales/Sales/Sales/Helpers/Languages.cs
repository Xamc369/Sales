

namespace Sales.Helpers
{
    using Xamarin.Forms;
    using Interfaces;
    using Resources;
    

    public static class Languages
    {
        static Languages()
        {
            var ci = DependencyService.Get<ILocalize>().GetCultureInfo();
            Resource.Culture = ci;
            DependencyService.Get<ILocalize>().SetLocale(ci);
        }

        public static string Accept
        {
            get { return Resource.Accept; }
        }

        public static string Error
        {
            get { return Resource.Error; }
        }

        public static string Nointernet
        {
            get { return Resource.Nointernet; }
        }

        public static string TurnOnInternet
        {
            get { return Resource.TurnOnInternet; }
        }

        public static string Productos
        {
            get { return Resource.Productos; }
        }
    }
}
