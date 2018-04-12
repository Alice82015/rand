using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rand
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.將所有號碼都放入list中
            List<int> numbers = new List<int>();
            for(int i = 1; i <=42; i++)
            {
                numbers.Add(i);
            }

            // 產生亂數物件
            Random rand = new Random();

            // 重複動作
            for (int i = 0; i < 6; i++)
            {
                // 隨機挑選其中一個出來
                int r = rand.Next(1, numbers.Count);
                Console.Write(numbers[r] + " ");

                // 從list中刪除
                numbers.RemoveAt(r);
            }

            // 暫停螢幕
            Console.ReadLine();
            

            

        }
    }
}
