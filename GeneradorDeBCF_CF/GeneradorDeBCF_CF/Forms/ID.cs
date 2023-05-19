using Newtonsoft.Json;
using System.Collections.Generic;

namespace GeneradorDeBCF_CF.Forms
{
    public class Root
    {
        [JsonProperty("@odata.context")]
        public string odatacontext { get; set; }
        public List<Value> value { get; set; }
    }

    public class Value
    {
        [JsonProperty("@odata.etag")]
        public string odataetag { get; set; }
        public string incidentid { get; set; }
    }
}