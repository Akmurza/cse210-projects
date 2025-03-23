using System;
using System.ComponentModel;
using System.Security.Cryptography;
using Microsoft.Win32.SafeHandles;
namespace MyProj;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Project.");
        System.Console.WriteLine(Scripture.MakeScriptures());
        
        
        while(true){
            System.Console.WriteLine("hello tap Enter if you want to play or tap quit if you want to cancel");
            string usersEnter = Console.ReadLine();
            
            if(usersEnter=="")
            {
                System.Console.WriteLine("oi");
                //очистка консоли и отображение нового текста
                Console.Clear();
                Console.WriteLine(Word.NewWord());


                //вызов ВОРД функции скрытия случайных слов(генератор случайных индексов+замена в тексте побуквенно)

                

                //опять запрос ввода энтер или выход
                //снова замещение нескольких слов пробелами пока все не закроется
            

                //
                //

            }
            else{
                return;
            }
        }













        //программа должна заканчиваться либо выходом либо полным исчезновением букв
        //Содержать не менее 3 классов в дополнение к Programклассу: один для самого Священного Писания, один для ссылки (например, «Иоанна 3:16») и для представления слова в Священном Писании.
        //Предоставьте несколько конструкторов для ссылки на Священное Писание, чтобы обрабатывать случай одного стиха и диапазона стихов («Притчи 3:5» или «Притчи 3:5-6»).
        //В демонстрационном видео вы можете видеть, что когда пользователь нажимал клавишу ввода, слова на экране «исчезали» или заменялись подчеркиваниями. На самом деле, консоль очищалась, а затем писание снова распечатывалось, но на этот раз с подчеркиваниями вместо определенных слов.

//*Очистить консоль можно с помощью Console.Clear()метода.


// This will start by displaying "AAA" and waiting for the user to press the enter key
//Console.WriteLine("AAA");
//Console.ReadLine();

// This will clear the console
//Console.Clear();

// This will show "BBB" in the console where "AAA" used to be
//Console.WriteLine("BBB");
        //
        //



    }
}