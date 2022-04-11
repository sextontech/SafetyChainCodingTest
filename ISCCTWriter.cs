using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafetyChainCodingTest
{
    public interface ISCCTWriter
    {
        public void Write(string fileName, IEnumerable<SCCTFileData> data);
    }
}
