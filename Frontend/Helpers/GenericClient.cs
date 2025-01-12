
// BU YAPI BÜTÜN PROJELER İÇİN SABİT OLARAK KULANILABİLİR.


using System.Net.Http.Headers;

namespace Frontend.Helpers
{
    public  static class GenericClient
    {
        public static HttpClient Client { get; private set; }

        public static void InitializeClientBaseAddres(this IServiceCollection services , IConfiguration configuration) 
        {
           // var clientBaseUrl = configuration.GetSection("ClientBaseUrl").Value;
            var apiBaseUrl = configuration.GetSection("ApiBaseUrl").Value;
            Client = new HttpClient();
            Client.BaseAddress = new Uri(apiBaseUrl);
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }

    }
}
