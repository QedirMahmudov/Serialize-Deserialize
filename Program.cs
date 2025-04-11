using Newtonsoft.Json;

namespace Serialize_DeserializeTask
{

    internal class Program
    {
        public static List<string> names = new List<string>();
        public static string reader;
        public static string path = @"C:\Users\ASUS\Desktop\Folders\CodeAcademyTasks\Serialize&DeserializeTask\JsonFIle\Names.json";

        static void Main(string[] args)
        {
            //Add("Oqoshhjhhhhhj");
            //Add("Oqoshhjhhhhhj");
            //Add("Oqoshhjhhhhhj");
            //Add("Oqoshhjhhhhhj");
            //Add("Mototmoto");
            //Add("Mototmoto");

            Delete("Oqoshhjhhhhhj");

            //StreamWriterMethod(JsonConvert.SerializeObject(names));

            //StreamReaderMethod();

            //string serializeName = JsonConvert.SerializeObject(names);


            //using (StreamWriter sw = new StreamWriter(@"C:\Users\ASUS\Desktop\Folders\CodeAcademyTasks\Serialize&DeserializeTask\JsonFIle\Names.json"))
            //{
            //    sw.WriteLine(serializeName);
            //}



            //string result;
            //using (StreamReader sr = new StreamReader(@"C:\Users\ASUS\Desktop\Folders\CodeAcademyTasks\Serialize&DeserializeTask\JsonFIle\Names.json"))
            //{
            //    result = sr.ReadToEnd();
            //};

            //Console.WriteLine(result);


            //var deserializeName = JsonConvert.DeserializeObject<List<string>>(result);



        }





        public static void Add(string name)
        {
            reader = StreamReaderMethod(path);
            var deserialize = JsonConvert.DeserializeObject<List<string>>(reader);
            names.Add(name);
            StreamWriterMethod(JsonConvert.SerializeObject(names), path);
        }


        public static bool Search(string name)
        {
            reader = StreamReaderMethod(path);
            var deserialize = JsonConvert.DeserializeObject<List<string>>(reader);
            var result = names.Where(x => x.Contains(name));

            if (result.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Delete(string name)
        {
            string reader = StreamReaderMethod(path);
            var deserialize = JsonConvert.DeserializeObject<List<string>>(reader);
            deserialize.Remove(name);
            StreamWriterMethod(JsonConvert.SerializeObject(deserialize), path);

        }














        public static void StreamWriterMethod(string serialize, string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(serialize);
            }
        }


        public static string StreamReaderMethod(string path)
        {
            string result;
            using (StreamReader sr = new StreamReader(path))
            {
                return result = sr.ReadToEnd();
            }
        }

    }
}
