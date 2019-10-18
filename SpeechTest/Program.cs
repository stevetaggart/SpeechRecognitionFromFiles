//
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE.md file in the project root for full license information.
//

using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CognitiveServices.Speech;
using SpeechTest;

namespace MicrosoftSpeechSDKSamples
{


    class Program
    {
        private static string[] GetFiles(string directory)
        {
            string[] files = Directory.GetFiles(directory);
            return files;
        }

        private static void SaveOutput(string filename, string content)
        {
            StreamWriter writer = new StreamWriter(filename);
            writer.Write(content);
            writer.Close();
        }

        static void Main(string[] args)
        {
            var finalResponse = new StringBuilder();
            string[] files = GetFiles(args[0]);
            foreach (var file in files)
            {
                var fileResult = SpeechRecognitionFromFile.ContinuousRecognitionWithFileAsync(file).Result;
                finalResponse.Append(fileResult);
                Console.WriteLine("File {0} processed", file);
            }

            SaveOutput("output.txt", finalResponse.ToString());
        }
    }
}