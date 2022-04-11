using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SafetyChainCodingTest
{
    public class SCCTFileData
    {
        [JsonProperty]
        public string Id { get; set; }

        [JsonProperty]
        public string Name { get; set; }

        [JsonProperty]
        public string CreatedOn { get; set; }

        [JsonProperty]
        public string CreatedBy { get; set; }
    }
}
