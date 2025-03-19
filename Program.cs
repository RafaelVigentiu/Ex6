using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ex6 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Câte numere doriti sa introduceti? ");
            int totalOfNumbers = int.Parse(Console.ReadLine());
            bool[] exist = new bool[1000];

            for (int i = 0; i < totalOfNumbers; i++) {
                int x = int.Parse(Console.ReadLine());
                if (IsThreeDigitNumber(x)) {
                    exist[x] = IsThreeDigitNumber(x);
                }
            }

            (int missing1, int missing2) = FindTwoLargestMissingNumbers(exist);

            if (missing1 != -1 && missing2 != -1) {
                Console.WriteLine($"{missing1} {missing2}");
            } else {
                Console.WriteLine("NU EXISTA");
            }

        }

        private static bool IsThreeDigitNumber(int number) {
            return number >= 100 && number <= 999;

        }

        private static (int, int) FindTwoLargestMissingNumbers(bool[] check) {
            int missing1 = -1;
            int missing2 = -1;

            for (int i = 999; i >= 100; i--) {
                if (!check[i]) {
                    if (missing1 == -1) {
                        missing1 = i;
                    } else {
                        missing2 = i;
                        break;
                    }
                }
            }
            return (missing1, missing2);
        }
    }
}
