using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace StreamsAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        private static void ZipAndExtract()
        {
            string sourceDirectory = @"C:\Users\Kris\Desktop\resources";
            string targetDirectory = @"C:\Users\Kris\Desktop\result.zip";
            string destinationDirectory = @"C:\Users\Kris\Desktop\result";

            ZipFile.CreateFromDirectory(sourceDirectory, targetDirectory);
            ZipFile.ExtractToDirectory(targetDirectory, destinationDirectory);
        }

        private static void DirectoryTraversal()
        {
            string[] allFiles = Directory.GetFiles("../../../", ".");

            Dictionary<string, Dictionary<string, double>> groupedFiles = new Dictionary<string, Dictionary<string, double>>();
            foreach (var file in allFiles)
            {
                FileInfo fileInfo = new FileInfo(file);

                if (!groupedFiles.ContainsKey(fileInfo.Extension))
                {
                    groupedFiles.Add(fileInfo.Extension, new Dictionary<string, double>());
                }

                double size = (double)fileInfo.Length / 1024;
                groupedFiles[fileInfo.Extension].Add(fileInfo.Name, size);
            }

            var sortedFiles = groupedFiles.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key);

            List<string> lines = new List<string>();

            foreach (var file in sortedFiles)
            {
                lines.Add(file.Key);

                foreach (var item in file.Value.OrderBy(x=>x.Value))
                {
                    lines.Add($"--{item.Key} - {item.Value:f3}kb");
                }
            }
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/report.txt";
            File.WriteAllLines(path, lines);
        }

        private static void CopyBinaryFile()
        {
            FileStream fileReader = new FileStream("copyMe.png", FileMode.Open);
            FileStream fileWrite = new FileStream("copyMeCopy.png", FileMode.Create);

            byte[] arrayOfBytes = new byte[256];

            while (true)
            {
                int currentBytes = fileReader.Read(arrayOfBytes, 0, arrayOfBytes.Length);

                if (currentBytes == 0)
                {
                    fileWrite.Flush();
                    break;
                }

                fileWrite.Write(arrayOfBytes, 0, arrayOfBytes.Length);
            }
        }

        private static void WordCount()
        {
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            string[] wordLines = File.ReadAllLines("words.txt");
            string[] textLines = File.ReadAllLines("text.txt");

            foreach (var item in wordLines)
            {
                if (!wordsCount.ContainsKey(item))
                {
                    wordsCount.Add(item, 0);
                }
            }

            foreach (var line in textLines)
            {
                foreach (var word in wordsCount)
                {
                    if (line.Contains(word.Key, StringComparison.OrdinalIgnoreCase))
                    {
                        wordsCount[word.Key]++;
                    }
                }
            }

            foreach (var item in wordsCount.OrderByDescending(x => x.Value))
            {
                string result = $"{item.Key} - {item.Value} \n";
                File.AppendAllText("actualResult.txt", result);
            }
        }

        private static void LineNumbers()
        {
            string[] lines = File.ReadAllLines("text.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                int letterCount = lines[i].Count(symbol => char.IsLetter(symbol));

                int punctuationCount = lines[i].Count(symbol => char.IsPunctuation(symbol));

                File.AppendAllText("../../../output.txt", $"Line {i + 1}: {lines[i]} ({letterCount})({punctuationCount}) \n");
            }
        }

        private static StreamReader EvenLines()
        {
            StreamReader streamReader = new StreamReader("text.txt");
            string[] specialSymbol = new[] { "-", ",", ".", "!", "?" };
            bool isEven = true;

            while (true)
            {
                string result = streamReader.ReadLine();

                if (result == null)
                {
                    break;
                }

                if (!isEven)
                {
                    isEven = true;
                    continue;
                }

                foreach (var symbol in specialSymbol)
                {
                    result = result.Replace(symbol, "@");
                }

                Console.WriteLine(string.Join(" ", result.Split().Reverse()));

                isEven = false;
            }

            return streamReader;
        }
    }
}
