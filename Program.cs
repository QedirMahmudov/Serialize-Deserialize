using Newtonsoft.Json;

namespace Serialize_DeserializeTask
{

    internal class Program
    {
        public static List<string> names = new List<string>();
        public static string reader;


        static void Main(string[] args)
        {
            Add("Oqoshhjhhhhhj");
            Add("Mototmoto");

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
            reader = StreamReaderMethod();
            var deserialize = JsonConvert.DeserializeObject<List<string>>(reader);
            names.Add(name);
            StreamWriterMethod(JsonConvert.SerializeObject(names));
        }


        public static bool Search(string name)
        {
            reader = StreamReaderMethod();
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
            string reader = StreamReaderMethod();
            var deserialize = JsonConvert.DeserializeObject<List<string>>(reader);
            deserialize.Remove(name);
            StreamWriterMethod(JsonConvert.SerializeObject(deserialize));

        }














        public static void StreamWriterMethod(string serialize)
        {
            using (StreamWriter sw = new StreamWriter(@"C:\Users\ASUS\Desktop\Folders\CodeAcademyTasks\Serialize&DeserializeTask\JsonFIle\Names.json"))
            {
                sw.WriteLine(serialize);
            }
        }


        public static string StreamReaderMethod()
        {
            string result;
            using (StreamReader sr = new StreamReader(@"C:\Users\ASUS\Desktop\Folders\CodeAcademyTasks\Serialize&DeserializeTask\JsonFIle\Names.json"))
            {
                return result = sr.ReadToEnd();
            }
        }

    }
}
