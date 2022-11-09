using IdentityModel.Client;
using Movies.Client.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Movies.Client.ApiServices
{
    public class MovieApiService : IMovieApiService
    {
        public async Task<Movie> CreateMovie(Movie movie)
        {
            throw new System.NotImplementedException();
        }

        public async Task DeleteMovie(string id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Movie> GetMovie(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Movie>> GetMovies()
        {
            var apiClientCredentials = new ClientCredentialsTokenRequest
            {
                Address = "https://localhost:5005/connect/token",
                ClientId = "movieClient",
                ClientSecret = "secret",
                Scope = "movieAPI"
            };

            var client = new HttpClient();

            var disco = await client.GetDiscoveryDocumentAsync("https://localhost:5005");
            if (disco.IsError)
            {
                return null;
            }

            var tokenResponse = await client.RequestClientCredentialsTokenAsync(apiClientCredentials);
            if (tokenResponse.IsError)
            {
                return null;
            }

            var apiClient = new HttpClient();
            apiClient.SetBearerToken(tokenResponse.AccessToken);

            var response = await apiClient.GetAsync("https://localhost:5001/api/movies");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();

            List<Movie> movieList = JsonConvert.DeserializeObject<List<Movie>>(content);

            return movieList;
        }

        public async Task<Movie> UpdateMovie(Movie movie)
        {
            throw new System.NotImplementedException();
        }
    }
}
