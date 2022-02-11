using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TraceProgram
{
    class SaveToTXT
    {
        string st; // путь к текушей папке  
        StreamWriter sw; // запись к файлу
        static int count;
        public SaveToTXT(bool overwriting)
        {
            count = 0;
            st = Directory.GetCurrentDirectory();
            if (Path.HasExtension(st))
            {
                sw = new StreamWriter(Path.Combine(st,"Trace.txt"), overwriting, Encoding.UTF8);
            }  
        }
        public void SaveText(string text,ConsoleColor consoleColor = ConsoleColor.White) 
        {
            try
            {
                sw.WriteLine(count.ToString()+" "+text);
                ConsoleWrite(count.ToString() + " " + text, consoleColor);
                count++;
            }
            catch (Exception ex) 
            {
                Console.WriteLine(count.ToString() +" "+"Ошибка работы с файлом" + ex.Message);
                sw.Close();
            }
        }
        public void StreamClose() 
        {
            sw.Close();
        }
        public void ConsoleWrite(string text, ConsoleColor cc = ConsoleColor.White) 
        {
            ConsoleColor consoleColor = Console.ForegroundColor;
            Console.ForegroundColor = cc;
            Console.WriteLine(text);
            Console.ForegroundColor = consoleColor;
        }
    }
}
