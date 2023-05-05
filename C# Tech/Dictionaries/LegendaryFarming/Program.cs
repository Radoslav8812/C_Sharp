using System;
using System.Linq;
using System.Collections.Generic;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower().Split();
            var coreDict = new Dictionary<string, int>();
            var secondaryDict = new Dictionary<string, int>();

            for (int i = 0; i < input.Length; i++)
            {
                var quantity = int.Parse(input[i]);
                var material = input[i + 1];
                i++;

                if (material == "motes")
                {
                    if (!coreDict.ContainsKey("motes"))
                    {
                        coreDict.Add(material, quantity);
                    }
                    else
                    {
                        coreDict["motes"] += quantity;
                    }

                    if (coreDict["motes"] >= 250)
                    {
                        Console.WriteLine("Dragonwrath obtained!");
                        coreDict["motes"] -= 250;
                        break;
                    }
                }
                else if (material == "fragments")
                {
                    if (!coreDict.ContainsKey("fragments"))
                    {
                        coreDict.Add(material, quantity);
                    }
                    else
                    {
                        coreDict["fragments"] += quantity;
                    }

                    if (coreDict["fragments"] >= 250)
                    {
                        Console.WriteLine("Shadowmourne obtained!");
                        coreDict["fragments"] -= 250;
                        break;
                    }
                }
                else if (material == "shards")
                {
                    if (!coreDict.ContainsKey("shards"))
                    {
                        coreDict.Add(material, quantity);
                    }
                    else
                    {
                        coreDict["shards"] += quantity;
                    }

                    if (coreDict["shards"] >= 250)
                    {
                        Console.WriteLine("Valanyr obtained!");
                        coreDict["shards"] -= 250;
                        break;
                    }
                }
                else
                {
                    if (!secondaryDict.ContainsKey(material))
                    {
                        secondaryDict.Add(material, quantity);
                    }
                    else
                    {
                        secondaryDict[material] += quantity;
                    }
                }
            }

            
            foreach (var item in coreDict.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in secondaryDict.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");

            }
        }
    }
}

