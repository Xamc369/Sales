

namespace Sales.Interfaces
{
    using System.Globalization;
    public interface ILocalize
    {
        CultureInfo GetCultureInfo();

        void SetLocale(CultureInfo ci);
    }
}
