using Microsoft.AspNetCore.Mvc;
using Mobile.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.API
{
    public class ApiService
    {
        public const string _URL = "https://goiabinha-intelitrader-api.conveyor.cloud/v1/users/";

        public static async Task<List<User>> GetUsers()
        {
            try
            {
                HttpClient _CLIENT = new HttpClient();
                string      json    = await _CLIENT.GetStringAsync(_URL);
                List<User>  users   = JsonConvert.DeserializeObject<List<User>>(json);
                
                return users;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public static async Task AddNewUser(User user)
        {
            try
            {
                HttpClient _CLIENT = new HttpClient();

                var new_user = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");

                var response = await _CLIENT.PostAsync(_URL, new_user);

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Error to add new user");

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
