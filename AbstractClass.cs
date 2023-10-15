using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_ConsoleApp
{
   public class StringReplacement
    {
        public string Name = "Revrese";
        public string Reverse = "Revrese";
        public  string GetName()
        {
            return Name + Reverse;
        }
}
   public abstract class AbstractClass : StringReplacement
    {
        public  int Id = 1;
        public  string str1 = "chinna";
        public string str2 = "mani";
        public new  virtual string GetName()
        {
            return str1 + str2;
        }

        public abstract int Name(int i);
        

    }
    public class Drived: AbstractClass
    {
        public override  int Name(int i)
        {
            return i = base.Id;
        }
        public override string GetName()
        {
            return base.GetName();
        }

    }

}
