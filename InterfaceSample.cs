using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_ConsoleApp
{
    public interface InterfaceSample
    {
         string GetSweetDetails();
    }
    public class SampleClass : InterfaceSample
    {
        string[] strArray = new string[]{
            "Jaggery",
            "cake",
            "Sweetponda",
            "Mysurepack",
            "honey cake",
            "Maida flour", 
            "yogurt",
            "oil", 
            "sugar",
            "Gram flour"
        };
        public string GetSweetDetails()
        {
            //var  strcount =  strArray.Count();
            string str = string.Empty;
            if (strArray.Length >= 0)
            {
                foreach(var s in strArray)
                {
                    str = str+"--" + s;
                }
            }
            return str;
        }
    }
}
