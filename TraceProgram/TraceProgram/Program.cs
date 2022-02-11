using System;

namespace TraceProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            SaveToTXT saveToFile = new SaveToTXT(false);
            int N = 0;                                    // значение N
            saveToFile.SaveText( "N = " + N);            
            int I = 0;                                    // значение I
            saveToFile.SaveText( "I = " + I.ToString());
            int P = 0;                                    // незнаю зачем она тут
            saveToFile.SaveText("P = " + P.ToString());
            while (I <= 10)
            {              
                saveToFile.SaveText(" Пока i<=10 ", ConsoleColor.Red);
                saveToFile.SaveText(" N + I",   ConsoleColor.Red);
                saveToFile.SaveText(" I + 1",   ConsoleColor.Red);
                saveToFile.SaveText(" N = " + N, ConsoleColor.Green);                
                saveToFile.SaveText(" I = " + I, ConsoleColor.Green);                
                N += I;
                I++;
            }
            saveToFile.SaveText(string.Format(" Конец N ={0}, I ={1}",N,I));
            saveToFile.StreamClose();
        }
    }
}
