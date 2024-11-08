using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace PetAsService.Api
{
    internal class PetAsService
    {
        public PetModels GetCaracteristicasPorID(string Id)
        {
            var client = new RestClient("https://api.thecatapi.com/v1/breeds/search?");
            var request = new RestRequest();
            request.Method = Method.Get;
            client.AddDefaultParameter("q", Id);
            RestResponse response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                List<PetModels> resultados = JsonConvert.DeserializeObject<List<PetModels>>(response.Content.ToString());
                if (resultados != null && resultados.Count > 0) 
                {
                    return resultados[0];
                }
                else
                {
                    return null;
                }
            }
            else
                return null;
        }

        public List<String> GetPetsFavoritos()
        {
            var client = new RestClient("https://api.thecatapi.com/v1/favourites?limit=20&sub_id=PetAsServiceUser&order=DESC");
            var request = new RestRequest();
            request.Method = Method.Get;
            request.AddHeader("x-api-key", "live_fAVYjDD1ToNyUu5FkklXbFUKF41KLoMKSw5wtgvGU2Y02bAysRdM8UomGjcuyd2B");

            RestResponse response = client.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                List<FavoritePet> resultados = JsonConvert.DeserializeObject<List<FavoritePet>>(response.Content.ToString());
                List<String> petFavoritos = new List<String>();
                foreach (var pet in resultados)
                {
                    PetModels nomePet = GetCaracteristicasPorID(pet.image_id);
                    if (nomePet != null)
                    {
                        petFavoritos.Add(nomePet.name);
                    }
                }
                return petFavoritos;
            }
            else
            {
                return null;
            }
        }

        public bool PostFavoritarRaca(string Id)
        {
            var client = new RestClient("https://api.thecatapi.com/v1/favourites");
            var request = new RestRequest();
            request.Method = Method.Post;

            request.AddHeader("x-api-key", "live_fAVYjDD1ToNyUu5FkklXbFUKF41KLoMKSw5wtgvGU2Y02bAysRdM8UomGjcuyd2B");
            var jsonBody = new
            {
                image_id = Id,
                sub_id = "PetAsServiceUser"
            };
            request.AddJsonBody(jsonBody);
            RestResponse response = client.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }
            return false;


        }

        public bool DeleteFavoritoRaca(string name)
        {
            int? Id = PegarIdFavorito(name);

            var client = new RestClient($"https://api.thecatapi.com/v1/favourites/{Id}");
            var request = new RestRequest();
            request.Method = Method.Delete;
            request.AddHeader("x-api-key", "live_fAVYjDD1ToNyUu5FkklXbFUKF41KLoMKSw5wtgvGU2Y02bAysRdM8UomGjcuyd2B");
            RestResponse response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }
            return false;
        }

        private int? PegarIdFavorito(string name)
        {
            
            var client = new RestClient("https://api.thecatapi.com/v1/favourites?limit=20&sub_id=PetAsServiceUser&order=DESC");
            var request = new RestRequest();
            request.Method = Method.Get;
            request.AddHeader("x-api-key", "live_fAVYjDD1ToNyUu5FkklXbFUKF41KLoMKSw5wtgvGU2Y02bAysRdM8UomGjcuyd2B");

            try
            {
                
                RestResponse response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    List<FavoritePet> resultados = JsonConvert.DeserializeObject<List<FavoritePet>>(response.Content);
                    int? petFavoritos = null;
                    foreach (var pet in resultados)
                    {
                        PetModels nomePet = GetCaracteristicasPorID(pet.image_id);
                        if (nomePet != null)
                        {
                            if (nomePet.name.ToString() == name)
                            {
                                petFavoritos = pet.id;
                                break;
                            }
                        }
                        
                        
                    }

                    return petFavoritos;
                }
                else
                {
                    MessageBox.Show($"Erro na requisição: {response.StatusCode} - {response.Content}");
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exceção ocorrida: {ex.Message}");
                return null;
            }
        }

    }
}
