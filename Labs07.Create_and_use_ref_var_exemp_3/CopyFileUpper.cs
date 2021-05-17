using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Labs07.Create_and_use_ref_var
{
    class CopyFileUpper
    {
        public static void Main()
        {
            string sFrom;
            string sTo;
            StreamReader srFrom;
            StreamWriter swTo;

            Console.WriteLine("Введите имя файла: ");
            sFrom = Console.ReadLine();

            Console.WriteLine("Введите имя нового файла: ");
            sTo = Console.ReadLine();

            try
            {
                srFrom = new StreamReader(sFrom);
                swTo = new StreamWriter(sTo);

                while (srFrom.Peek() != -1)
                {
                    string sBuffer = srFrom.ReadLine();
                    sBuffer = sBuffer.ToUpper();
                    swTo.WriteLine(sBuffer);

                }
                swTo.Close();
                srFrom.Close();

            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("Входящий файл не найден!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected exception");
                Console.WriteLine(e.ToString());
            }
        
        }

    }
}
