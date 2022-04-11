using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Channels;
//using System.Threading.Tasks;

namespace SafetyChainCodingTest
{
    public class SCCTDataProcessor
    {
        private readonly ISCCTReader _SCCTReader;
        private readonly ISCCTWriter _SCCTWriter;
        //Channel<IEnumerable<SCCTFileData>> channel = Channel.CreateBounded<IEnumerable<SCCTFileData>>(5);

        public SCCTDataProcessor(ISCCTReader reader, ISCCTWriter writer)
        {
            _SCCTReader = reader;
            _SCCTWriter = writer;
        }

        public void ProcessDirectory(string directory)
        {
            Console.WriteLine("Begin processing.");

            var outputDirectory = directory + "\\Output\\";
            Directory.CreateDirectory(outputDirectory);


            foreach (var file in Directory.GetFiles(directory))
            {
                var data = _SCCTReader.Read(file);

                _SCCTWriter.Write(Path.Combine(outputDirectory, "output.csv"), data);
            }

            /*
             Task readFile = Task.Factory.StartNew(() =>
            {
                foreach (var file in Directory.GetFiles(directory))
                {
                    channel.Writer.TryWrite(_SCCTReader.Read(file));
                }
                channel.Writer.Complete();
            });

            var numFiles = Directory.GetFiles(directory).Length;
            IEnumerable<SCCTFileData> data;

            Task[] writeFile = new Task[numFiles / 4];
            for (int i = 0; i < writeFile.Length; i++)
            {
                writeFile[i] = Task.Factory.StartNew(async () =>
                {
                    while (await channel.Reader.WaitToReadAsync())
                    {
                        if (channel.Reader.TryRead(out data))
                        {
                            _SCCTWriter.Write(Path.Combine(outputDirectory, "output.csv"), data);
                        }
                    }
                });
            }

            readFile.Wait();
            Task.WaitAll(writeFile);
            */

            Console.WriteLine("End processing.");
        }
    }
}
