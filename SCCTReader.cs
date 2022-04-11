using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SafetyChainCodingTest
{
    public class SCCTFileReader : ISCCTReader
    {
        public IEnumerable<SCCTFileData> Read(string fileName)
        {
            // Open file and parse JSON
            var fileData = File.ReadAllText(fileName);
            return !fileData.Contains("[") ? new List<SCCTFileData> { JsonConvert.DeserializeObject<SCCTFileData>(fileData) } : JsonConvert.DeserializeObject<List<SCCTFileData>>(fileData);
        }
    }
}
