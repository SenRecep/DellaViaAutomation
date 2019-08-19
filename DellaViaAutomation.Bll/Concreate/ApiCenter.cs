using DellaViaAutomation.Entities.ComplexType;
using DellaViaAutomation.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace DellaViaAutomation.Bll.Concreate
{
    public static class ApiCenter<T> where T : class
    {
        static ApiCenter()
        {
            client.BaseAddress = new Uri("https://localhost:44396/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public static HttpClient client = new HttpClient();
        public static async Task<Uri> CreateAsync(T T,string controller)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                controller, T);
            response.EnsureSuccessStatusCode();

            return response.Headers.Location;
        }

        public static async Task<T> GetAsync(string controller)
        {
            HttpResponseMessage response = await client.GetAsync(controller);
            if (response.IsSuccessStatusCode)
            {
               return await response.Content.ReadAsAsync<T>();
            }
            return null;
        }

        public static async Task<User> AdminLogin(string email,string pass)
        {
            HttpResponseMessage response = await client.GetAsync($"AdminLoginValidate/{email}/{pass}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<User>();
            }
            return null;
        }

        public static async Task<T> UpdateAsync(T T, string controller)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync(
                $"{controller}/{(T as EntityBase).id}", T);
            response.EnsureSuccessStatusCode();

            T = await response.Content.ReadAsAsync<T>();
            return T;
        }

        public static async Task<HttpStatusCode> DeleteAsync(string id,string controller)
        {
            HttpResponseMessage response = await client.DeleteAsync(
                $"{controller}/{id}");
            return response.StatusCode;
        }
    }
}
