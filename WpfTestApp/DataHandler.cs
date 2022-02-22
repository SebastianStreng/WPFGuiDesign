using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTestApp
{
    internal class DataHandler
    {
        private void Filter(List<string> list1, Dictionary<string, string> dict)
        {
            var selection = dict.Select(x => x.Value).Where(x => x.)
        }

        private Dictionary<string, string> CombineTwoListsToDict(List<string> list1, List<string> list2)
        {
            Dictionary<string, string> filters = new Dictionary<string, string>();

            for (int i = 0; i < list1.Count; i++)
            {
                filters.Add(list1[i], list2[i]);
            }
            return filters;
        }
    }
}