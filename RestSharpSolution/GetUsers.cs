using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using Newtonsoft.Json;
using System.Linq;

namespace ApiAutotestPage130
{
    public class ApiUsers
    {
        public List <ListOfUsers> GetUsers()
        {
            var restClient = new RestClient("https://jsonplaceholder.typicode.com/users");
            var restRequest = new RestRequest(Method.GET);
            restClient.AddDefaultHeader("Accepts", "application/json");
            restRequest.RequestFormat = DataFormat.Json;

            IRestResponse response = restClient.Execute(restRequest);
            var content = response.Content;

            var users = JsonConvert.DeserializeObject<List<ListOfUsers>>(content).ToList();
            return users;

        }
    }
}
