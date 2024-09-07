using System.Text;

namespace AdvancedTutorials
{
   
    internal partial class Program
    {
        static void Main(string[] args)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\NewPath.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
            }

            FileStream newStream = File.Open(path, FileMode.Append);
            Byte[] info = new UTF8Encoding(true).GetBytes("Saving texts for test.");
            newStream.Write(info, 0, info.Length);
            newStream.Close();

            StreamReader newReader = new StreamReader(path);
            var fileText = newReader.ReadToEnd;
            Console.WriteLine(fileText);

            
            
        }
    }
} 