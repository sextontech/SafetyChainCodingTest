
using System.Security.AccessControl;
using System.Text.Json;
using Newtonsoft.Json;
using SafetyChainCodingTest;

if(args.Length ==0)
    Console.WriteLine("No directory provided.");
else
{
    SCCTDataProcessor processor = new SCCTDataProcessor(new SCCTFileReader(), new SCCTCSVFileWriter());
    processor.ProcessDirectory(args[0]);
    Console.WriteLine("Press any key to close program.");
    Console.ReadKey();
}


