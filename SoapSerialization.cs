using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Soap;
using static BankAccountCreation.SoapSerializationEx;

namespace BankAccountCreation
{
    internal class SoapSerializationEx
    {
        public class Data
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public DateTime DateOfIssue { get; set; }
        }

        
        class SoapSerializationDemo 
        {
            
            public Data GetData()
            {
                SoapFormatter soapFormatter = new SoapFormatter();
                Stream objread = new FileStream("file.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
                Data retrieveddata = (Data) soapFormatter.Deserialize(objread);
                return  retrieveddata;
            }

           public void SaveData(Data _data)
            {
                
               
                SoapFormatter soapFormatter = new SoapFormatter();
                Stream stream=new FileStream("file.xml",FileMode.Create);
                soapFormatter.Serialize(stream,this._data);
                stream.Close();

            }
            
        }
        static void Main(string[] args)
        {
            SoapSerializationDemo demo = new SoapSerializationDemo();

            Data _data = new Data();
            _data.Name = "abc";
            _data.Id = 1;
            _data.DateOfIssue = DateTime.Now;
            _data.Description = "abc";
            demo.SaveData(_data );
            demo.GetData();
        }
    }
}
