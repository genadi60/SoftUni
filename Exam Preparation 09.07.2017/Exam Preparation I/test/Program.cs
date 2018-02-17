using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var singerByAwards = new Dictionary<string, List<string>>();
            var participants = Regex.Split(Console.ReadLine(), @"\s*,\s*");
            var songs = Regex.Split(Console.ReadLine(), @"\s*,\s*");




            var result = singerByAwards
                .Select(x => new
                {
                    singer = x.Key,
                    awards = x.Value.Distinct().OrderBy(aw => aw),
                    awardscount = x.Value.Distinct().Count()
                })
                .OrderByDescending(awC => awC.awardscount)
                .ThenBy(s => s.singer)
                .ToArray();
        }
    }
}
