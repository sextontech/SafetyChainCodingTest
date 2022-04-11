using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafetyChainCodingTest
{
    public interface ISCCTReader
    {
        public IEnumerable<SCCTFileData> Read(string fileName);
    }
}
