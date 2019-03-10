using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace GxchainCsharpSdk
{
    public class GxChainReq
    {
        public string jsonrpc { get; set; }
        public string method { get; set; }
        public List<object> @params { get; set; }
        public int id { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}

