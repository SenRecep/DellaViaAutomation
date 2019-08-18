using DellaViaAutomation.Entities.ComplexType;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DellaViaAutomation.Bll.Concreate
{
    public static class ApiCenter<T> where T : EntityBase
    {

        static ApiCenter()
        {
            uri = $"https://localhost:44396/api/{typeof(T).Name}";
        }
        static string uri;

        public static async Task<dynamic> GetAsync()
        {

            using (HttpClient httpClient = new HttpClient())
            {
                return JsonConvert.DeserializeObject<dynamic>(
                await httpClient.GetStringAsync(uri)
                );
            }
        }

        public static async Task<dynamic> PostAsync(T Ts)
        {

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(uri);
                StringContent content = new StringContent(JsonConvert.SerializeObject(Ts), Encoding.UTF8, "application / json");
                HttpResponseMessage response = await httpClient.PostAsync("", content);

                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();
                    Ts = JsonConvert.DeserializeObject<T>(data);
                }
            }
            return Ts;
        }

        public static async Task<dynamic> PutAsync(string id, T Ts)
        {

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(uri);
                StringContent content = new StringContent(JsonConvert.SerializeObject(Ts), Encoding.UTF8, "application / json");
                HttpResponseMessage response = await httpClient.PutAsync($"{id}", content);

                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();
                    Ts = JsonConvert.DeserializeObject<T>(data);
                }
            }
            return Ts;
        }

        public static async Task<dynamic> DeleteAsycn(string id)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(uri);
                //StringContent content = new StringContent(JsonConvert.SerializeObject(Ts), Encoding.UTF8, "application/json");
                var response = await httpClient.DeleteAsync($"{id}");

                if (response.IsSuccessStatusCode)
                {

                }
            }

            return null;
        }



        //public void method()
        //{
        //    using (var client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri("http://localhost:3376/");
        //        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //        HttpResponseMessage response;
        //        response = client.GetAsync("api/OgrenciApi").Result;
        //        if (response.IsSuccessStatusCode)
        //        {
        //            var ogrenciler = response.Content.ReadAsAsync<IEnumerable<Ogrenci>>().Result;
        //            foreach (var ogrenci in ogrenciler)
        //            {
        //                Console.WriteLine("Ogrenci ID : {0} - Öğrencinin Adı: {1}- Soyadı : {2} - Bölümü : {3} - Fakültesi : {4}", ogrenci.Id, ogrenci.Adi, ogrenci.Soyadi, ogrenci.BolumAdi, ogrenci.FakulteAdi);
        //            }



        //        }
        //        Console.ReadKey();


        //    }
        //}

        //public async Task<ActionResult> pagename()
        //{

        //    //Veritabanındaki olan Car listesini çağırmak için;
        //    ViewResult v = View("index", await ApiCenter<User>.GetAsync());

        //    //Kaydetme Methodunu çağırmak için;

        //    User c = new User();
        //    c.FirstName = "tugsfba";
        //    c.IsAdmin = true;
        //    v = View("index", await ApiCenter<User>.PostAsync(c));

        //    //Update Methodunu çağırmak için;

        //    c.FirstName = "Adım değişti";
        //    c.IsAdmin = false;
        //    v = View("index", await ApiCenter<User>.PutAsync("id", c));


        //    //Silme Methodunu çağırmak için;

        //    v = View("index", await ApiCenter<User>.DeleteAsycn("id"));

        //    return v;
        //}
    }
}
