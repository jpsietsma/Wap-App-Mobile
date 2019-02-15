using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WacApp.Libs
{
    public class ApiProcessor
    {
        public async Task LoadAllFarms()
        {
            List<string> allFarms = new List<string>();
            string url = "http://localhost:61729/api/farms/GetAllFarms";

            using (HttpResponseMessage response = await wacApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    allFarms = await response.Content.ReadAsAsync<List<string>>();
                }
            }
        } 
    }
}
