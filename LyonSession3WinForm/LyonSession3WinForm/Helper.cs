using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LyonSession3WinForm
{
    public class Helper
    {
        private static HttpClient client = new HttpClient() { BaseAddress = new Uri("http://localhost:5078/api/") };

        public static async Task<T> Get<T>(string url)
        {
            try
            {
                var res = await client.GetStringAsync(url);
                return JsonSerializer.Deserialize<T>(res);
            }
            catch (Exception ex)
            {
                return default;
            }
        }

        public static async Task<int> PostReturnStatus(string url, object data)
        {
            try
            {
                var res = await client.PostAsJsonAsync(url, data);
                return (int)res.StatusCode;
            }
            catch (Exception ex)
            {
                return default;
            }
        }

        public static async Task<int> PutReturnStatus(string url, object data)
        {
            try
            {
                var res = await client.PutAsJsonAsync(url, data);
                return (int)res.StatusCode;
            }
            catch (Exception ex)
            {
                return default;
            }
        }

        public static async Task<int> DeleteReturnStatus(string url, object data)
        {
            try
            {
                var res = await client.DeleteAsync(url);
                return (int)res.StatusCode;
            }
            catch (Exception ex)
            {
                return default;
            }
        }
    }
}
