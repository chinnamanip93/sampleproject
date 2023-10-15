using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_ConsoleApp
{
    public class TwoListFilterSingleList
    {

        List<CustomerInformation> dbList = new List<CustomerInformation>
        {
                new CustomerInformation{Id=1, FirstName="Raju",   LastName="Ahmed"},
                new CustomerInformation{Id=2, FirstName="Tahira", LastName="Biswas"},
               new CustomerInformation{Id=2, FirstName="Tahira", LastName="Biswas"},
               new CustomerInformation{Id=2, FirstName="Tahira", LastName="Biswas"},
            new CustomerInformation{Id=3, FirstName="Shohag", LastName="Mia"},
            new CustomerInformation{Id=4, FirstName="Saiful", LastName="Islam"}
        };

        List<CustomerInformation> csutomerList = new List<CustomerInformation>
        {
             new CustomerInformation{Id=1, FirstName="Raju",   LastName="Ahmed"},
            new CustomerInformation{Id=2, FirstName="Tahira", LastName="Biswas"},
            new CustomerInformation{Id=4, FirstName="Saiful", LastName="Islam"},
            new CustomerInformation{Id=5, FirstName="Anny", LastName="Bishwas"},
            new CustomerInformation{Id=6, FirstName="Kabita", LastName="Roy"},
            new CustomerInformation{Id=7, FirstName="Zahidul", LastName="Emon"}
        };
        public void FilterList()
        {
            var newList = csutomerList.Where(cusItem => !dbList.Any(dbItem => cusItem.Id == dbItem.Id
            && cusItem.FirstName == dbItem.FirstName &&
           cusItem.LastName == dbItem.LastName));
            var newlist1 = csutomerList.Select(x => dbList.Any(y => y.FirstName == x.FirstName)).ToList();
            var newlist2 = csutomerList.Select(x => dbList.All(y => y.FirstName == x.FirstName));

        }

    }

    public class CustomerInformation
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
