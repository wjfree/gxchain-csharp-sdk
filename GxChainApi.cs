using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace GxchainCsharpSdk
{
    public partial class GxChainApi
    {
        private RestClient client;

        public GxChainApi(string apiUrl)
        {
            client = new RestClient(apiUrl);
        }

        public int ReadTimeout { get; set; } = 10000;

        private async Task<string> doPostRequestAsync(List<object> listOfObjects)
        {

            GxChainReq req = new GxChainReq
            {
                jsonrpc = "2.0",
                method = "call",
                id = 1,
                @params = listOfObjects
            };

            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(req);

            var cts = new CancellationTokenSource(ReadTimeout);
            var response = await client.ExecuteTaskAsync(request, cts.Token);
            return JsonConvert.DeserializeObject<GxChainRsp>(response.Content).result.ToString();
        }
    
        public async Task<string> GetChainId()
        {
            var rsp = await doPostRequestAsync(new List<object> { 0, "get_chain_id", new List<object>() });
            return rsp;
        }

        public async Task<Account> GetAccountByName(string accountName)
        {
            var rsp = await doPostRequestAsync(new List<object> { 0, "get_account_by_name", new List<object> { accountName } });
            return JsonConvert.DeserializeObject<Account>(rsp);
        }

        public async Task<WitnessAccount> GetWitnessByAccount(string accountId)
        {
            var rsp = await doPostRequestAsync(new List<object> { 0, "get_witness_by_account", new List<object> { accountId } });
            return JsonConvert.DeserializeObject<WitnessAccount>(rsp);
        }
    }
}
