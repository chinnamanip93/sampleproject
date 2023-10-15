using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practise_ConsoleApp
{
   public  class UkDataTagger_Output__Issue
    {
        public void HtmlOutPutElement()
        {
            string html = @"<html xmlns='http://www.w3.org/1999/xhtml' xmlns:ct-comp='http://www.hmrc.gov.uk/schemas/ct/comp/2021-01-01' 
                            xmlns:dpl='http://www.hmrc.gov.uk/schemas/ct/dpl/2021-01-01'  ="" xmlns:accrep='http://xbrl.frc.org.uk/reports/2021-01-01/accrep' 
                            xmlns:aurep='http://xbrl.frc.org.uk/reports/2021-01-01/aurep' xmlns:bus='http://xbrl.frc.org.uk/cd/2021-01-01/business'
                            xmlns:common='http://xbrl.frc.org.uk/general/2021-01-01/common' xmlns:core='http://xbrl.frc.org.uk/fr/2021-01-01/core'
                            xmlns:countries='http://xbrl.frc.org.uk/cd/2021-01-01/countries' xmlns:curr='http://xbrl.frc.org.uk/cd/2021-01-01/currencies'
                            xmlns:direp='http://xbrl.frc.org.uk/reports/2021-01-01/direp' xmlns:ix='http://www.xbrl.org/2008/inlineXBRL' 
                            xmlns:ixt='http://www.xbrl.org/inlineXBRL/transformation/2011-07-31' xmlns:xbrldt='http://xbrl.org/2005/xbrldt'
                            xmlns:xbrli='http://www.xbrl.org/2003/instance' xmlns:xl='http://www.xbrl.org/2003/XLink' xmlns:link='http://www.xbrl.org/2003/linkbase'
                            xmlns:xlink='http://www.w3.org/1999/xlink' xmlns:xsd='http://www.w3.org/2001/XMLSchema' xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' 
                            xmlns:xbrldi='http://xbrl.org/2006/xbrldi' xmlns:iso4217='http://www.xbrl.org/2003/iso4217'>";

            string spattern = @"  =" + "\"";
            MatchCollection matches = Regex.Matches(html.ToString(), spattern);
            if (matches.Count == 1)
            {
                html = Regex.Replace(html, spattern, string.Empty);
            }
            Console.WriteLine("Matches found: {0}", matches.Count);
            Console.WriteLine(html);
            Console.Read();

        }
    }
}
