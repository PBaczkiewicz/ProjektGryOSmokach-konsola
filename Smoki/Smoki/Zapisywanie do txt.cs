using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Smoki
{
    public class Zapisywanie
    {
        //zapisuje wszystkie statystyki smoka
        public static void Save(string name, string race, int[] stats, int[] statsxp, DateTime food, int hunger, int gold, DateTime wyprawa, bool wyprawainprogress, int difficulty, int duration, int exhaustion)
        {
            string path = @"save.txt";//@ przed nazwą ścieżki aby zapobiec odczytu \ jako metody (np. \n)
            StreamWriter file;
            if (!File.Exists(path))//sprawdza czy plik istnieje
            {
                file = File.CreateText(path);
            }
            else
            {
                file = new StreamWriter(path, false);// w nawiasie pierwszy argument oznacza ścieżke zapisu, drugi argument wybiera czy nadpisać tekst czy dodać do tekstu
                //Console.WriteLine("Plik zapisu otwarty!");
            }
            file.WriteLine(gold);
            file.WriteLine(food);
            file.WriteLine(wyprawa);
            file.WriteLine(difficulty);
            file.WriteLine(duration);
            file.WriteLine(wyprawainprogress);
            file.WriteLine(hunger);
            file.WriteLine(exhaustion);
            file.WriteLine(name);
            file.WriteLine(race);
            for (int i = 0; i < stats.Length; i++)
            {
                file.WriteLine(stats[i]);
                file.WriteLine(statsxp[i]);
            }
            file.Close();
        }
        //wczytuje wszystkie statystyki smoka
        public static void Load(ref string name, ref string race, ref int[] stats, ref int[] statsxp, ref DateTime food, ref int hunger, ref int gold,ref DateTime wyprawa, ref bool wyprawainprogress, ref int difficulty, ref int duration, ref int exhaustion)
        {
            string path = @"save.txt";
            StreamReader file;
            if (!File.Exists(path))
            {
                //Console.WriteLine("Plik nie istnieje!!!");
                return;
            }
            else
            {
                file = new StreamReader(path);
                //Console.WriteLine("Wczytuje zapis.");
            }
            gold = int.Parse(file.ReadLine());
            food = DateTime.Parse(file.ReadLine());
            wyprawa = DateTime.Parse(file.ReadLine());
            difficulty = int.Parse(file.ReadLine());
            duration = int.Parse(file.ReadLine());
            wyprawainprogress = bool.Parse(file.ReadLine());
            hunger = int.Parse(file.ReadLine());
            exhaustion = int.Parse(file.ReadLine());
            name = file.ReadLine();
            race = file.ReadLine();

            for (int i = 0; i < stats.Length; i++)//do przerobienia!!! chyba jest git
            {
                stats[i] = int.Parse(file.ReadLine());
                statsxp[i] = int.Parse(file.ReadLine());
            }
            //Console.ReadKey();
            file.Close();
            return;
        }
        
    }
}
