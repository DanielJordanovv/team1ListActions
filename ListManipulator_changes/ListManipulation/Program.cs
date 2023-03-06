using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string[] cmd = Console.ReadLine().Split().ToArray();
                string command = cmd[0];
                if (command.ToLower() == "finish")
                {
                    break;
                }
                switch (command)
                {
                    case "add":
                        nums.Add(int.Parse(cmd[1]));
                        Console.WriteLine(string.Join(" ", nums));
                        break;
                    case "delete":
                        nums.RemoveAt(int.Parse(cmd[1]));
                        break;
                    case "remove":
                        nums.Remove(int.Parse(cmd[1]));
                        break;
                    case "addmany":
                        int[] arr = cmd[1].Split().Select(int.Parse).ToArray();
                        nums.AddRange(arr);
                        break;
                    case "countodds":
                        int count = 0;
                        for (int i = 0; i < nums.Count; i++)
                        {
                            if (nums[i] % 2 == 1)
                            {
                                count++;
                            }
                        }
                        count++;
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", nums));
                        break;
                    case "printodds":
                        Console.WriteLine(string.Join(" ", nums.Where(x => x % 2 == 1)));
                        break;

                    default:
                        break;
                }
            }

        }
    }
}
