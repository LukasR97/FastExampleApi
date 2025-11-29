using Newtonsoft.Json;

namespace TestForEgoPaulus
{
    public class OrganRepository
    {
        public Organ GetOrgan()
        {
            using (StreamReader writetext = new StreamReader("Organs.txt"))
            {
                string organJsonString = writetext.ReadToEnd();

                return JsonConvert.DeserializeObject<Organ>(organJsonString);
            }

            throw new Exception("No organ data found.");
        }

        public Organ Save(OrganDTO organDTO)
        {
            string organDTOJsonString = JsonConvert.SerializeObject(organDTO);

            using (StreamWriter writetext = new StreamWriter("Organs.txt"))
            {
                writetext.WriteLine(organDTOJsonString);
            }

            Organ organ = JsonConvert.DeserializeObject<Organ>(organDTOJsonString);

            if (organ == null)
            {
                throw new Exception("Deserialization resulted in null Organ object.");
            }

            return organ;
        }

        public string Delete()
        {
            string organResult;

            using (StreamReader writetext = new StreamReader("Organs.txt"))
            {
                string organJsonString = writetext.ReadToEnd();
                organResult = organJsonString;
            }
            using (StreamWriter writetext = new StreamWriter("Organs.txt"))
            {
                writetext.WriteLine("");
            }

            return $"REMOVED FROM TEXT FILE THIS Organ: {organResult}";
        }

        public Organ Update()
        {
            throw new NotImplementedException();
        }
    }
}
