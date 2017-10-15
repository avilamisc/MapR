using System.IO;
using System.Net;
using MapR.Model;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;

namespace MapR.Services
{
    public class ServiceBranchs
    {
        string branchUrl = "https://mbgu2q4kj1.execute-api.us-east-1.amazonaws.com/dev/Portal/getAllBranch";
        public async Task<BranchModel[]> GetAllBranchAsync()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await client.GetAsync(branchUrl);
            if(response.StatusCode == HttpStatusCode.OK)
            {
                var json = await response.Content.ReadAsStringAsync();
                return DeserializeBranches(json);
            }
            return null;
        }

        private BranchModel[] DeserializeBranches(string json)
        {
            BranchModel[] branches;
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(BranchModel[]));
            branches = js.ReadObject(ms) as BranchModel[];

            return branches;
        }
    }
}
