using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace GxchainCsharpSdk
{
    public class GxChainRsp
    {
        public int id { get; set; }
        public string jsonrpc { get; set; }
        public object result { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }


    public class Abi
    {
        public string version { get; set; }
        public List<object> types { get; set; }
        public List<object> structs { get; set; }
        public List<object> actions { get; set; }
        public List<object> tables { get; set; }
        public List<object> error_messages { get; set; }
        public List<object> abi_extensions { get; set; }
    }

    public class Owner
    {
        public int weight_threshold { get; set; }
        public List<object> account_auths { get; set; }
        public List<List<object>> key_auths { get; set; }
        public List<object> address_auths { get; set; }
    }

    public class Active
    {
        public int weight_threshold { get; set; }
        public List<object> account_auths { get; set; }
        public List<List<object>> key_auths { get; set; }
        public List<object> address_auths { get; set; }
    }

    public class Options
    {
        public string memo_key { get; set; }
        public string voting_account { get; set; }
        public int num_witness { get; set; }
        public int num_committee { get; set; }
        public List<object> votes { get; set; }
        public List<object> extensions { get; set; }
    }

    public class Account
    {
        public string id { get; set; }
        public DateTime membership_expiration_date { get; set; }
        public DateTime merchant_expiration_date { get; set; }
        public DateTime datasource_expiration_date { get; set; }
        public DateTime data_transaction_member_expiration_date { get; set; }
        public string registrar { get; set; }
        public string referrer { get; set; }
        public string lifetime_referrer { get; set; }
        public string merchant_auth_referrer { get; set; }
        public string datasource_auth_referrer { get; set; }
        public int network_fee_percentage { get; set; }
        public int lifetime_referrer_fee_percentage { get; set; }
        public int referrer_rewards_percentage { get; set; }
        public string name { get; set; }
        public string vm_type { get; set; }
        public string vm_version { get; set; }
        public string code { get; set; }
        public string code_version { get; set; }
        public Abi abi { get; set; }
        public Owner owner { get; set; }
        public Active active { get; set; }
        public Options options { get; set; }
        public string statistics { get; set; }
        public List<object> whitelisting_accounts { get; set; }
        public List<object> blacklisting_accounts { get; set; }
        public List<object> whitelisted_accounts { get; set; }
        public List<object> blacklisted_accounts { get; set; }
        public string cashback_vb { get; set; }
        public List<object> owner_special_authority { get; set; }
        public List<object> active_special_authority { get; set; }
        public int top_n_control_flags { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }


    public class WitnessAccount
    {
        public string id { get; set; }
        public string witness_account { get; set; }
        public int last_aslot { get; set; }
        public string signing_key { get; set; }
        public string vote_id { get; set; }
        public string total_votes { get; set; }
        public string url { get; set; }
        public int total_missed { get; set; }
        public int last_confirmed_block_num { get; set; }
        public bool is_valid { get; set; }
    }

}
