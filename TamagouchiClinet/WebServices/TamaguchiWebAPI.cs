using TamagouchiClinet.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace TamagouchiClinet.WebServices
{
    class TamaguchiWebAPI
    {
        private HttpClient client;
        private string baseUri;

        public TamaguchiWebAPI(string baseUri)  
        {
            //Set client handler to support cookies!!
            HttpClientHandler handler = new HttpClientHandler();
            handler.CookieContainer = new System.Net.CookieContainer();

            //Create client with the handler!
            this.client = new HttpClient(handler, true);
            this.baseUri = baseUri;
        }
        public async Task<PlayerDTO> LoginAsync(string email, string pass)
        {
            try
            {
                HttpResponseMessage response = await this.client.GetAsync($"{this.baseUri}/Login?email={email}&pass={pass}");
                if (response.IsSuccessStatusCode)
                {
                    JsonSerializerOptions options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    string content = await response.Content.ReadAsStringAsync();
                    PlayerDTO p = JsonSerializer.Deserialize<PlayerDTO>(content, options);
                    return p;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                
                return null;
            }
        }
        public async Task<PlayerDTO> SignUpAsync(string firstName, string lastName,  string email, string userName, string password, string gender, DateTime bdate)
        {
            string url = $"{baseUri}/SignUp";
            PlayerDTO p = new PlayerDTO
            {
                PfirstName = firstName,
                PbirthDay = bdate,
                PlastName = lastName,
                PlayerGender = gender,
                PlayerPassword = password,
                Email = email,
                UserName = userName
            };
            try
            {
                string json = JsonSerializer.Serialize(p);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await this.client.PostAsync(url,content);
                if (response.IsSuccessStatusCode)
                {
                    JsonSerializerOptions options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                        
                    };
                    string content2 = await response.Content.ReadAsStringAsync();
                    PlayerDTO player = JsonSerializer.Deserialize<PlayerDTO>(content2,options);
                    return player;
                }
                else
                {
                    return null;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);      
                return null;      
            }
        }

        public async Task<AnimalDTO> GetPlayerAnimalsAsync()
        {
            try
            {
                HttpResponseMessage response = await this.client.GetAsync($"{this.baseUri}/GetAnimals");
                if (response.IsSuccessStatusCode)
                {
                    JsonSerializerOptions options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    string content = await response.Content.ReadAsStringAsync();
                    AnimalDTO animal = JsonSerializer.Deserialize<AnimalDTO>(content, options);
                    return animal ;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                
                return null;
            }
        }


        public async Task<AnimalDTO> AddPetAsync(string animalName)
        {
            try
            {
                HttpResponseMessage response = await this.client.GetAsync($"{this.baseUri}/AddPet?animalName={animalName}");
                if (response.IsSuccessStatusCode)
                {
                    JsonSerializerOptions options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    string content = await response.Content.ReadAsStringAsync();
                    AnimalDTO p = JsonSerializer.Deserialize<AnimalDTO>(content, options);
                    return p;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                
                return null;
            }

        }
        public async Task<AnimalDTO> ChangesAsync()
        {
            try
            {
                HttpResponseMessage response = await this.client.GetAsync($"{this.baseUri}/Changes");
                if (response.IsSuccessStatusCode)
                {
                    JsonSerializerOptions options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    string content = await response.Content.ReadAsStringAsync();
                    AnimalDTO p = JsonSerializer.Deserialize<AnimalDTO>(content, options);
                    return p;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {

                return null;
            }
        }
    
        public async Task<AnimalDTO> DoAction(int i)
        {
            try
            {
                HttpResponseMessage response = await this.client.GetAsync($"{this.baseUri}/DoAction?i={i}");
                if (response.IsSuccessStatusCode)
                {
                    JsonSerializerOptions options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    string content = await response.Content.ReadAsStringAsync();
                    AnimalDTO p = JsonSerializer.Deserialize<AnimalDTO>(content, options);
                    return p;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
            return null;
            }
        }
        public async Task<List<FunctionDTO>> GetFunctions()
        {
            try
            {
                HttpResponseMessage response = await this.client.GetAsync($"{this.baseUri}/GetAction");
                if (response.IsSuccessStatusCode)
                {
                    JsonSerializerOptions options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    string content = await response.Content.ReadAsStringAsync();
                    List<FunctionDTO> p = JsonSerializer.Deserialize<List<FunctionDTO>>(content, options);
                    return p;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                return null;
            }

        }
    }
}
