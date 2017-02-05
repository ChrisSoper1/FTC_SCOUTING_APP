using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FTC_Scouting_App
{
    class SaveLoad
    {
        public static void load()
        {

            String MyDocumentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            String SaveFileFolder = Path.Combine(MyDocumentsFolder, "FTC_Scorecard");
            if (!Directory.Exists(SaveFileFolder))
            {
                Directory.CreateDirectory(SaveFileFolder);
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<Competition>));
            //TODO reuse variables better

            FileStream reader = new FileStream(Path.Combine(SaveFileFolder, "save.xml"), FileMode.Open);
            Program.compList =  (List<Competition>)serializer.Deserialize(reader);
            reader.Close();

        }
        public static void save()
        {
            String MyDocumentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            String SaveFileFolder = Path.Combine(MyDocumentsFolder, "FTC_Scorecard");
            if (!Directory.Exists(SaveFileFolder))
            {
                Directory.CreateDirectory(SaveFileFolder);
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<Competition>));
            //TODO reuse variables better



            FileStream writer = new FileStream(Path.Combine(SaveFileFolder, "save.xml"), FileMode.Create);
            serializer.Serialize(writer, Program.compList);
            writer.Close();
        }
    }
}
