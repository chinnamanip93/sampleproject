using System;
using System.Text.RegularExpressions; 

namespace Practise_ConsoleApp
{
    class Program 
    {
        static void Main(string[] args)
        {



             string[] str = { "subbu", "mani", "arun", "chinna" };
            int strLength = str.Length-1;
            for (int i = 0; i < strLength; i++)
            {
                for (int j = strLength; j > i; j--)
                {
                    //if(ICloneable)
                    if (str[j-1].CompareTo(str[j])> 0)
                    {
                        var temp = str[j - 1];
                        str[j - 1] = str[j];
                        str[j] = temp;
                    }
                }
            }
            var d = str;

            //Triangular_Kavi kavi = new Triangular_Kavi();

            //kavi.Triangular_Kavi_output();
            TwoListFilterSingleList fl = new TwoListFilterSingleList();
            fl.FilterList();

            Triagular Triagr = new Triagular();
            Triagr.TriangularDisplay();

            XML Xmltag = new XML();
            Xmltag.XMLProcess();


            jsonDataModelbinding obiject = new jsonDataModelbinding();
            obiject.JsonbindFetchModel();
            Console.ReadKey();

            //------------   Regualar using Replace to html header------------------------
            //UkDataTagger_Output__Issue HtmlOutput = new UkDataTagger_Output__Issue();
            //HtmlOutput.HtmlOutPutElement();
            //-------------- Abstract class Called----------------------------------------
            //Drived AbstractObjClass = new Drived();
            //Console.WriteLine(AbstractObjClass.Name(3));
            //Console.WriteLine(AbstractObjClass.GetName());
            //----------interface called--------------------------------------------------
            //InterfaceSample objinterface = new SampleClass();
            //Console.WriteLine(objinterface.GetSweetDetails());
            //----------day of week property checking---
            //DayOfWeek day1 = new DayOfWeek();
            //Console.WriteLine(DateTime.Today.DayOfWeek.Equals(day1));
            //---------------------  file reader ---------------------------------
            //FilewordDocumentRead pdffilereader = new FilewordDocumentRead();
            //pdffilereader.WordreadFile();
            //Console.Read();

        }
    }
}