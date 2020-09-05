using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CryptaRSA.Clasess
{
    public class SettingsUser
    {
        public static SettingsUser GetSettingsUser()
        {
            SettingsUser settings = null;
            string fileName = GlobalPath.SettingFile;


            if (File.Exists(fileName))
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Open))
                {
                    XmlSerializer xser = new XmlSerializer(typeof(SettingsUser));
                    settings = (SettingsUser)xser.Deserialize(fs);
                    fs.Close();
                }
            }
            else settings = new SettingsUser();

            return settings;



        }


        internal string GetPassWord()
        {
            string res;
            try
            {
                res = Crypro.Decript(passWord);
            }
            catch (Exception e)
            {
                res = passWord;
            }

            return res;
        }

        internal void SetPassWord(string p)
        {
          passWord =  Crypro.Encript(p);
        }

        public void Save()
        {
            string fileName = GlobalPath.SettingFile;
            if (File.Exists(fileName)) File.Delete(fileName);

            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {

                XmlSerializer xser = new XmlSerializer(typeof(SettingsUser));

                xser.Serialize(fs, this);
                fs.Close();

            }
           
           
            
        }

        public string Login { get; set; }
        public string passWord { get; set; }
    }
}
