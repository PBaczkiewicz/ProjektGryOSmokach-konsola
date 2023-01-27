using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Smoki
{

    public class Smok
    {

        public static void CreateDragon(string name, string type)
        {

        }//kreator smoka jeszcze nie wykorzystywany
        public void Skills(ref string skill, ref string skilldes, ref string type)
        {
            if (type == "~") { Console.WriteLine("Błąd! Nie wykryto typu."); }
            if (type == "Ogień") { skill = "Zionięcie"; skilldes = "Smok zionie ogniem w przeciwnika zadając 150% obrażeń."; }
            if (type == "Woda") { skill = "Spowolnienie"; skilldes = "Smok spowalnia przeciwnika redukując jego szybkość o połowę"; }
            if (type == "Powietrze") { skill = "Szybkość"; skilldes = "Smok wykorzystuje pomyślne wiatry zwiększając szybkość o połowę"; ; }
            if (type == "Ziemia") { skill = "Blok"; skilldes = "Smok blokuje następny cios przeciwnika"; }

        }//przypisuje umiejętności do typu smoka
        public string name = "~";
        public string type = "~";
        public string skill = "~";
        public string skilldes = "~";
        public double mindmg = 0;
        public double maxdmg = 0;
        public double skillchance = 0;
        public double speed = 0;
        public int hp;
        public int gold;
        public int hunger = 4;
        public int exhaustion = 12;
        public DateTime food;
        public DateTime wyprawa;
        public bool wyprawainprogress;
        public int difficulty;
        public int duration;

        public int[] stats = new int[] { 1, 1, 1, 1, 1 }; //0lvl,1siła,2charyzma,3zręczność,4witalność
        public int[] statsxp = new int[] { 0, 0, 0, 0, 0, 0, 0 };
        public Smok(string names = "~", string types = "~")
        {
            string name = names;
            string type = types;

            DateTime food = DateTime.Today;
            stats = new int[] { 1, 1, 1, 1, 1 };
            statsxp = new int[] { 0, 0, 0, 0, 0, 0, 0 };
        }



    }
    public class Enemy
    {
        public void Etype(int typ) 
        {
            string[] typy;
            if (typ == 0) {typy = new string[] { "Brak" }; }
            else {typy = new string[] { "Ogień", "Woda", "Powietrze", "Ziemia" }; }
            Random rng = new Random();
            int i = rng.Next(typy.Length);
            type = typy[i];
        }
        public void Estats(int level)
        {
            Random rng = new Random();
            stats[0]=level;
            for (int i = 1; i < stats.Length; i++)
            {
                stats[i] += rng.Next(stats[0], (int)(1.5*stats[0]));

            }
            mindmg = (int)(0.75 * (stats[1] * (0.5 * stats[0])));
            maxdmg = (int)(1.25 * (stats[1] * (0.5 * stats[0])));
            skillchance = 10 + (stats[2] - stats[0]);
            if (skillchance < 0) { skillchance = 0; }
            speed = 10 + stats[3] - stats[0];
            if (speed < 0) { speed = 0; }
            hp = 100 + ((10 * stats[0]) * (stats[4] / 2));
        }
        public string name;
        public string type;
        public string skill;
        public string skilldes;
        public int hp;
        public double mindmg = 0;
        public double maxdmg = 0;
        public double skillchance = 0;
        public double speed = 0;
        public int[] stats = new int[] { 1, 1, 1, 1, 1 };
        public Enemy(string names = "~", int level=1)
        {
            Etype(0);
            name = names;
            stats = new int[] { level, 1,1,1,1};
            Estats(level);
            
        }
    }
}
