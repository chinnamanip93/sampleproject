using Newtonsoft.Json;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_ConsoleApp
{
    public class jsonDataModelbinding
    {

        public void JsonbindFetchModel()
        {
            string fileName = @"C:\CHINNAMANI\Project\Practise_ConsoleApp\jsonData.json";
            string jsontext = File.ReadAllText(fileName);
            var data = JsonConvert.DeserializeObject<List<Jsondatamodel>>(jsontext);

            // var Count = data.Count;           
            List<Jsondatamodel> listdatamodel = new List<Jsondatamodel>();
            foreach(var i in data)
            {
                var n = i;
                 Jsondatamodel jsonmodel = new Jsondatamodel();
                 jsonmodel.id = i.id;
            }               
        }
    }
}
