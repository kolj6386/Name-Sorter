using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name_Sorter.SortingMethods
{
    public class UnsortedNames
    {
        // Found this code on google to use as my base method and tweaked it from there. 
        // names.Sort((n1, n2) => n1.Split(" ")[1].CompareTo(n2.Split(" ")[1]));
        public string SortNames(List<string> names)
        {
            names.Sort((n1, n2) =>
            {
                var name1 = n1.ToLower().Split(" ");
                var name1Length = name1.Length;

                var name2 = n2.ToLower().Split(" ");
                var name2Length = name2.Length;

                var result = name1[name1Length - 1].CompareTo(name2[name2Length - 1]);
                // Looked up the sort method and learnt it returns a number so incase the last names are the same they will sort by first name
                if (result == 0)
                    result = name1[0].CompareTo(name2[0]);
                return result;
            });
            return names[0];
        }
    }
}
