using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafetyChainCodingTest
{
    public class SCCTCSVFileWriter : ISCCTWriter
    {
        public void Write(string fileName, IEnumerable<SCCTFileData> data)
        {
            using (StreamWriter output = new StreamWriter(fileName, new FileStreamOptions {Access = FileAccess.Write, Mode = FileMode.Append, Share = FileShare.Write}))
            {
                output.WriteLine("Id,Name,CreatedBy,CreatedOn");
                foreach (var dataItem in data)
                {
                    output.WriteLine(dataItem.Id + "," + dataItem.Name + "," + dataItem.CreatedBy + "," + dataItem.CreatedOn);
                }
            }
        }
    }
}
