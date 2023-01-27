using System.Media;
using System.Security.Cryptography;
using System.Xml.Linq;
using System.Text.Json;

namespace Smoki
{
    public partial class Form1 : Form
    {
        int greward;
        int xpreward;
        string message = "", exhaustmessage = "";
        int wyprawalength;
        public Smok player = new Smok("~", "~");
        Enemy enemy = new Enemy("Dzik", 1);
        public Form1()
        {
            InitializeComponent();
            wyprawa0.Text = wyprawa0.Items[0].ToString();
            clock.Text = DateTime.Now.ToString("HH:mm:ss");
            DateTime dzisiaj = DateTime.Today;
            DateTime czasgry = DateTime.Now;
            string path = @"save.txt";//@ przed nazw¹ œcie¿ki aby zapobiec odczytu \ jako metody (np. \n)

            if (File.Exists(path))
            {
                Zapisywanie.Load(ref player.name, ref player.type, ref player.stats, ref player.statsxp, ref player.food, ref player.hunger, ref player.gold, ref player.wyprawa, ref player.wyprawainprogress, ref player.difficulty, ref player.duration, ref player.exhaustion);
                Updatestats();
                mainmenu();
                player.Skills(ref player.skill, ref player.skilldes, ref player.type);
                button1.Visible = false;
                smokname.Text = player.name;
                smoktype.Text = player.type;
                //player.Skills(ref player.skill, ref player.skilldes, ref player.type);
            }//wczytuje zapis
            clock.Enabled = true;

        }//rozpoczyna program, wczytuje zapis z pliku .txt jeœli istnieje

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            smoknameinput.Visible = true;
            smoktypeinput.Visible = true;
            button2.Visible = true;
        }//przycisk widoczny jedynie gdy nie ma pliku zapisu save.txt s³u¿y do pokazania panelu tworzenia smoka

        
        private void timer1_Tick(object sender, EventArgs e)
        {

            clock.Text = DateTime.Now.ToString("HH:mm:ss");
            gold.Text = player.gold.ToString();
            Zapisywanie.Save(player.name, player.type, player.stats, player.statsxp, player.food, player.hunger, player.gold, player.wyprawa, player.wyprawainprogress, player.difficulty, player.duration, player.exhaustion);
            //string jsonString = JsonSerializer.Serialize(player);
            //File.WriteAllText(fileName, jsonString);
            Updatestats();
            opis.Clear();

            if (player.hunger == 4) { opis.AppendText(player.name + " jest najedzony"); }
            if (player.hunger == 3) { opis.AppendText(player.name + " zjad³by coœ"); }
            if (player.hunger == 2) { opis.AppendText(player.name + " jest g³odny"); }
            if (player.hunger == 1) { opis.AppendText(player.name + " jest bardzo g³odny"); }
            if (player.hunger <= 0) { opis.AppendText(player.name + " umiera z g³odu."); }
            if (player.wyprawainprogress == true)
            {
                if (DateTime.Now > player.wyprawa)
                {
                    reward(ref player.difficulty, ref player.duration);
                    message = "\n" + player.name + " wróci³ z wyprawy." + "\n" + player.name + " znalaz³ w trakcie wyprawy : " + greward + "\nOraz otrzyma³ : " + xpreward + " rozdzielone pomiêdzy wszystkie statystyki";


                    player.wyprawainprogress = false;
                }
                //timer1.Stop(); }
                else
                {
                    message = "\n" + player.name + " wyruszy³ na wyprawê.\r\nPowróci o " + player.wyprawa.ToString("HH:mm:ss");
                }

            }
            opis.AppendText(message);
            //opis.AppendText(misctext); //zrobiæ tablice czynnoœci smoka, potem z tej tablicy losowaæ to co robi³ ostatnio.
            if (player.wyprawainprogress == false)
            {
                if (player.exhaustion < 12) { exhaustmessage = "\n" + "coœ sie popsu³o :/"; }
                if (player.exhaustion == 12) { exhaustmessage = "\n" + player.name + " jest w pe³ni wypoczêty i gotowy do akcji"; }
                if (player.exhaustion < 12 && player.exhaustion >= 6) { exhaustmessage = "\n" + player.name + " jest gotowy na wyprawê"; }
                if (player.exhaustion < 6 && player.exhaustion >= 2) { exhaustmessage = "\n" + player.name + " jest zmêczony i potrzebuje odpoczynku"; }
                if (player.exhaustion < 2 && player.exhaustion >= 0) { exhaustmessage = "\n" + player.name + " jest wykoñczony"; }
                opis.AppendText(exhaustmessage);
            }
        }//timer aktualizuj¹cy na bie¿¹co czas i wszystkie statystyki co sekunde i zapisuje do pliku .txt
        private void timer2_Tick(object sender, EventArgs e)
        {

        }//pusty timer jeszcze nie wykorzystany
        public void smoknameinput_TextChanged(object sender, EventArgs e)
        {
            smokname.Visible = true;
            smokname.Text = smoknameinput.Text;
            player.name = smoknameinput.Text;
            if (smokname.Text.Length > 16)
            {
                MessageBox.Show("Imiê nie mo¿e mieæ wiêcej ni¿ 16 znaków!", "B³¹d!");
                smoknameinput.Text = "";
                smokname.Text = "";
            }

        }//zapisanie nazwy smoka
        private void smoktypeinput_SelectedIndexChanged(object sender, EventArgs e)
        {
            smoktype.Visible = true;
            smoktype.Text = smoktypeinput.Text;
        }//zapisanie typu smoka

        private void button2_Click(object sender, EventArgs e)
        {
            int check = 0;
            if (smoknameinput.Text == "Imiê Smoka") { MessageBox.Show("Nie wybrano imienia smoka!", "B³¹d!"); }
            else
            {
                check++;
            }

            if (smoktypeinput.Text == "Typ Smoka") { MessageBox.Show("Nie wybrano typu smoka!", "B³¹d!"); }
            else
            {
                check++;
            }
            if (check >= 2)
            {
                smoknameinput.Visible = false;
                smoktypeinput.Visible = false;
                button2.Visible = false;
                player.name = smokname.Text;
                player.type = smoktype.Text;
                player.food = DateTime.Today;
                player.type = smoktype.Text;
                player.Skills(ref player.skill, ref player.skilldes, ref player.type);
                Updatestats();
                mainmenu();

            }
        }//tworzy obiekt smoka ze wszystkimi wymaganymi informacjami
        private void button3_Click(object sender, EventArgs e)
        {
            player.statsxp[0] += 60000;
            player.statsxp[1] += 15000;
            player.statsxp[2] += 30000;
            player.statsxp[3] += 30000;
            player.statsxp[4] += 15000;
            Updatestats();
        }//TEST XP -> DO USUNIÊCIA

        private void button4_Click(object sender, EventArgs e)
        {

            //if (player.hunger < 4) { player.hunger++; }
            if (strfood.Visible == true)
            {
                strfood.Visible = false;
                chafood.Visible = false;
                agifood.Visible = false;
                witfood.Visible = false;

            }
            else
            {
                strfood.Visible = true;
                chafood.Visible = true;
                agifood.Visible = true;
                witfood.Visible = true;
            }
        }//pokazuje menu karmienia
        private void button9_Click(object sender, EventArgs e)
        {
            if (strup.Visible == true)
            {
                strup.Visible = false;
                chaup.Visible = false;
                agiup.Visible = false;
                witup.Visible = false;
                strcost.Visible = false;
                chacost.Visible = false;
                agicost.Visible = false;
                witcost.Visible = false;
            }
            else
            {
                strup.Visible = true;
                chaup.Visible = true;
                agiup.Visible = true;
                witup.Visible = true;
                strcost.Visible = true;
                chacost.Visible = true;
                agicost.Visible = true;
                witcost.Visible = true;
            }
            strcost.Text = (player.stats[1] * player.stats[1]).ToString();
            chacost.Text = (player.stats[2] * player.stats[2]).ToString();
            agicost.Text = (player.stats[3] * player.stats[4]).ToString();
            witcost.Text = (player.stats[3] * player.stats[4]).ToString();
        }//menu treningu

        private void strup_Click(object sender, EventArgs e)
        {
            Train(1);
        }//trenowanie si³y
        private void chaup_Click(object sender, EventArgs e)
        {
            Train(2);
        }//trenowanie charyzmy
        private void agiup_Click(object sender, EventArgs e)
        {
            Train(3);
        }//trenowanie zwinnoœci
        private void witup_Click(object sender, EventArgs e)
        {
            Train(4);
        }//trenowanie witalnoœci

        private void strfood_Click(object sender, EventArgs e)
        {
            Feed(1);

        }//karmienie str
        private void chafood_Click(object sender, EventArgs e)
        {
            Feed(2);
        }//karmienie cha
        private void agifood_Click(object sender, EventArgs e)
        {
            Feed(3);
        }//karmienie agi
        private void witfood_Click(object sender, EventArgs e)
        {
            Feed(4);
        }//karmienie wit

        private void menuwypraw_Click_1(object sender, EventArgs e)
        {
            if (smokname.Visible == true)
            {
                hidemainmenu();
                wyprawamenu();

            }
            else { hidewyprawamenu(); mainmenu(); }
        }//menu wypraw
        private void wyprawa0_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (wyprawa0.Text == wyprawa0.Items[0].ToString()) { wyprawalength = 15; }
            if (wyprawa0.Text == wyprawa0.Items[1].ToString()) { wyprawalength = 30; }
            if (wyprawa0.Text == wyprawa0.Items[2].ToString()) { wyprawalength = 60; }
            if (wyprawa0.Text == wyprawa0.Items[3].ToString()) { wyprawalength = 120; }
        }//przypisuje d³ugoœæ w minutach wyprawy
        private void wyprawa1_Click(object sender, EventArgs e)
        {
            wyprawa(1);
        }//wypuszcza smoka na wyprawê na polany
        private void wyprawa2_Click(object sender, EventArgs e)
        {
            wyprawa(2);
        }//wypuszcza smoka na wyprawê na wzgórza
        private void wyprawa3_Click(object sender, EventArgs e)
        {
            wyprawa(3);
        }//wypuszcza smoka na wyprawê w góry

        private void button4_Click_1(object sender, EventArgs e)
        {
            hideeverything();
            fightmenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
            hidefightmenu();
            mainmenu();
        }

        private void Fight_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            int level;
            level = 15;//rng.Next(1, 6);
           
            enemy = new Enemy("Dzik",level);
            //opis.AppendText("\n"+enemy.name+"\n"+enemy.type+"\nPoziom " + enemy.stats[0]+"\nSi³a " + enemy.stats[1] + "\nCharyzma " + enemy.stats[2] + "\nZrêcznoœæ " + enemy.stats[3] + "\nWitalnoœæ " + enemy.stats[4]);
            //if(timer1.Enabled == true) { timer1.Enabled = false; }
            //else{ timer1.Enabled = true; }
            Walka();
        }

    }
}