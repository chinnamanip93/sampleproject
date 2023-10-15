using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//using Microsoft.Office.Interop.word
using Microsoft.Office.Interop.Word;

namespace Practise_ConsoleApp
{
    class FilewordDocumentRead
    {

        public void GetPdfDocumentRead()
        {
            FileStream file = new FileStream(@"C:\CHINNAMANI\Resume\net Mvc Junior programmer.docx", FileMode.Open, FileAccess.Read);

            using (StreamReader pdfdocument = new StreamReader(file))
            {
                string result = pdfdocument.ReadToEnd();
                Console.WriteLine(result);
                Console.ReadLine();
                pdfdocument.Close();
                file.Close();
            }
        }
        public void WordreadFile()
        {
            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document doc = new Microsoft.Office.Interop.Word.Document();
            object fileName = @"C:\CHINNAMANI\Resume\net Mvc Junior programmer.docx";
            // Define an object to pass to the API for missing parameters
            object missing = System.Type.Missing;
            doc = word.Documents.Open(ref fileName,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing);
            string ReadValue = string.Empty;
            // Activate the document
            doc.Activate();
            foreach (Microsoft.Office.Interop.Word.Range tmpRange in doc.StoryRanges)
            {
                ReadValue += tmpRange.Text;
            }
            Console.WriteLine(ReadValue);
        }
    }
}
