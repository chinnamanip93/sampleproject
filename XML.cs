using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Practise_ConsoleApp
{
    public class XML
    {
        public void XMLProcess()
        {
            Context ctx = new Context();
            ctx.Persons.Add(new Human("john", 100));
            ctx.Persons.Add(new Human("jane", 200));

            var writer = new StringWriter();
            new XmlSerializer(typeof(Context)).Serialize(writer, ctx);

            Console.WriteLine(writer.ToString());
            Console.ReadKey();

            VpClass ctx1 = new VpClass();
            ctx1.TrasansactionList.Add(new Transaction() 
            { name = "chiunna",
                amount = "200"
            }) ;
            ctx1.TrasansactionList.Add(new Transaction()
            {
                name = "SriRam",
                amount = "200"
            });
            ctx1.TrasansactionList.Add(new Transaction()
            {
                name = "SriRam",
                amount = "200"
            });

            var writer1 = new StringWriter();
            new XmlSerializer(typeof(Context)).Serialize(writer1, ctx1);

            Console.WriteLine(writer1.ToString());
            Console.ReadKey();

        }

    }


    [XmlRoot("TransactionResult")]
    public class Context
    {
        public Context()
        {
            this.Persons = new Persons();
        }

        [XmlArray("TransactionList")]
        [XmlArrayItem("Transaction")]
        public Persons Persons { get; set; }
    }

    public class Persons : List<Human>
    {

    }

    public class Human
    {
        public Human() { }
        public Human(string name, int amount)
        {
            Name = name;
            Amount = amount;
        }
        public string Name { get; set; }
        public int Amount { get; set; }
    }


    [XmlRoot("TransactionResult")]
    public class VpClass{

           public List<Transaction> TrasansactionList; 
    }

   
    public class XmlContex
    {
        [XmlArray("TransactionList")]
        [XmlArrayItem("Transaction")]

        public Transaction Trans { get; set; }
    }
    public class Transaction
    {

        public string amount { get; set; }
        public string name { get; set; }
    }
}
