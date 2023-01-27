using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Smoki
{
    public partial class Form1
    {
        public void wyprawa(int difficulty)
        {
            if (player.wyprawainprogress == true) { MessageBox.Show(player.name + " jest już na wyprawie!", "Uwaga!"); }
            else
            {
                player.difficulty = difficulty;
                durcheck(ref player.duration);
                if (exhaustcheck(player.duration, player.exhaustion) == 0)
                {
                    player.wyprawa = DateTime.Now;
                    player.wyprawa = player.wyprawa.AddMinutes(wyprawalength);
                    player.wyprawainprogress = true;
                }
            }

        }
        public void hideeverything()
        {
            if (opis.Visible == true)
            {
                hidewyprawamenu();
                hidemainmenu();
                wyprawy.Visible = false;
                opis.Visible = false;
            }
            else
            {
                opis.Visible=true;
                wyprawy.Visible = true;
                mainmenu();
                wyprawamenu();
            }
        }

        public void hidewyprawamenu()
        {
            wyprawa0.Visible = false;
            wopis0.Visible = false;
            wyprawa1.Visible = false;
            wopis1.Visible = false;
            wyprawa2.Visible = false;
            wopis2.Visible = false;
            wyprawa3.Visible = false;
            wopis3.Visible = false;
        }//chowa menu wypraw
        public void wyprawamenu()
        {
            wyprawa0.Visible = true;
            wopis0.Visible = true;
            wyprawa1.Visible = true;
            wopis1.Visible = true;
            wyprawa2.Visible = true;
            wopis2.Visible = true;
            wyprawa3.Visible = true;
            wopis3.Visible = true;
        }//pokazuje menu wypraw
        public void hidemainmenu()
        {
            strup.Visible = false;
            chaup.Visible = false;
            agiup.Visible = false;
            witup.Visible = false;
            strcost.Visible = false;
            chacost.Visible = false;
            agicost.Visible = false;
            witcost.Visible = false;
            strfood.Visible = false;
            chafood.Visible = false;
            agifood.Visible = false;
            witfood.Visible = false;
            gold.Visible = false;
            label1.Visible = false;
            smokname.Visible = false;
            smoktype.Visible = false;
            growth.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            skilldesc.Visible = false;
            label12.Visible = false;
            skill.Visible = false;
            damage.Visible = false;
            speed.Visible = false;
            special.Visible = false;
            hitpoints.Visible = false;
            level.Visible = false;
            strength.Visible = false;
            charisma.Visible = false;
            agility.Visible = false;
            vitality.Visible = false;
            progressBar1.Visible = false;
            progressBar2.Visible = false;
            progressBar3.Visible = false;
            progressBar4.Visible = false;
            progressBar5.Visible = false;
            feed.Visible = false;
            train.Visible = false;
            fight.Visible = false;
            //wyprawy.Visible = false;
            //opis.Visible = false;
        }//chowa menu główne
        public void mainmenu()
        {

            //player.StartingStats(ref player.type);
            gold.Visible = true;
            label1.Visible = true;
            smokname.Visible = true;
            smoktype.Visible = true;
            growth.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            skilldesc.Visible = true;
            damage.Visible = true;
            speed.Visible = true;
            special.Visible = true;
            hitpoints.Visible = true;
            level.Visible = true;
            strength.Visible = true;
            charisma.Visible = true;
            agility.Visible = true;
            vitality.Visible = true;
            skill.Visible = true;
            skilldesc.Visible=true;
            label12.Visible = true;
            progressBar1.Visible = true;
            progressBar2.Visible = true;
            progressBar3.Visible = true;
            progressBar4.Visible = true;
            progressBar5.Visible = true;
            feed.Visible = true;
            train.Visible = true;
            opis.Visible = true;
            fight.Visible = true;
            //wyprawy.Visible = true;

            Hunger(ref player.hunger, ref player.food);
            Updatestats();
        }//pokazuje menu główne
        public void fightmenu() 
        {
            starcie.Visible = true;
            smokname.Visible = true;
            growth.Visible = true;
            smoktype.Visible= true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label12.Visible = true;
            level.Visible= true;
            strength.Visible= true;
            charisma.Visible= true;
            agility.Visible= true;
            vitality.Visible= true;
            damage.Visible= true;
            special.Visible= true;
            speed.Visible= true;
            hitpoints.Visible= true;
            skill.Visible= true;
            skilldesc.Visible= true;
            enemyname.Visible= true;
            enemyspecies.Visible= true;
            enemytype.Visible= true;
            estat0.Visible= true;
            estat1.Visible= true;
            estat2.Visible= true;
            estat3.Visible= true;
            estat4.Visible= true;
            estat5.Visible= true;
            estat6.Visible= true;
            estat7.Visible= true;
            estat8.Visible= true;
            estat9.Visible= true;
            elvl.Visible= true;
            estr.Visible= true;
            echa.Visible= true;
            eagi.Visible= true;
            evit.Visible= true;
            edmg.Visible= true;
            eskill.Visible= true;
            edoublehit.Visible= true;
            ehitpoints.Visible= true;
            especial.Visible= true;
            eskilldesc.Visible= true;
        }//pokazuje menu walki
        public void hidefightmenu()
        {
            starcie.Visible = false;
            smokname.Visible = false;
            growth.Visible = false;
            smoktype.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label12.Visible = false;
            level.Visible = false;
            strength.Visible = false;
            charisma.Visible = false;
            agility.Visible = false;
            vitality.Visible = false;
            damage.Visible = false;
            special.Visible = false;
            speed.Visible = false;
            hitpoints.Visible = false;
            skill.Visible = false;
            skilldesc.Visible = false;
            enemyname.Visible = false;
            enemyspecies.Visible = false;
            enemytype.Visible = false;
            estat0.Visible = false;
            estat1.Visible = false;
            estat2.Visible = false;
            estat3.Visible = false;
            estat4.Visible = false;
            estat5.Visible = false;
            estat6.Visible = false;
            estat7.Visible = false;
            estat8.Visible = false;
            estat9.Visible = false;
            elvl.Visible = false;
            estr.Visible = false;
            echa.Visible = false;
            eagi.Visible = false;
            evit.Visible = false;
            edmg.Visible = false;
            eskill.Visible = false;
            edoublehit.Visible = false;
            ehitpoints.Visible = false;
            especial.Visible = false;
            eskilldesc.Visible = false;
        }//chowa menu walki
        public void hidestats() 
        {
            
        }//jeszcze puste
        public void Updatestats()
        {
            Levelup(player.stats, player.statsxp);
            if (player.stats[0] >= 5) { wyprawa2.Enabled = true; }
            if (player.stats[0] >= 10) { wyprawa3.Enabled = true; }
            progressBar1.Maximum = 100 * (player.stats[0] * player.stats[0]);
            progressBar1.Value = player.statsxp[0];
            level.Text = player.stats[0].ToString();
            progressBar2.Maximum = 10 * (player.stats[1] * player.stats[1]);
            progressBar2.Value = player.statsxp[1];
            strength.Text = player.stats[1].ToString();
            progressBar3.Maximum = 10 * (player.stats[2] * player.stats[2]);
            progressBar3.Value = player.statsxp[2];
            charisma.Text = player.stats[2].ToString();
            progressBar4.Maximum = 10 * (player.stats[3] * player.stats[3]);
            progressBar4.Value = player.statsxp[3];
            agility.Text = player.stats[3].ToString();
            progressBar5.Maximum = 10 * (player.stats[4] * player.stats[4]);
            progressBar5.Value = player.statsxp[4];
            vitality.Text = player.stats[4].ToString();
            skilldesc.Text = player.skilldes;
            skill.Text = player.skill;
            player.mindmg = 0.75 * (player.stats[1] * (0.5 * player.stats[0]));
            player.maxdmg = 1.25 * (player.stats[1] * (0.5 * player.stats[0]));
            damage.Text = ((int)player.mindmg).ToString() + " - " + ((int)player.maxdmg).ToString();
            player.skillchance = 10 + (player.stats[2] - player.stats[0]);
            if (player.skillchance < 0) { player.skillchance = 0; }
            special.Text = ((int)player.skillchance).ToString() + "%";
            player.speed = 10 + player.stats[3] - player.stats[0];
            if (player.speed < 0) { player.speed = 0; }
            speed.Text = ((int)player.speed).ToString() + "%";

            player.hp = 100 + ((10 * player.stats[0]) * (player.stats[4] / 2));
            hitpoints.Text = player.hp.ToString();
        }//aktualizuje statystyki wyświetlane w menu głównym
        public void Levelup(int[] stats, int[] statsxp)
        {
            if (statsxp[0] >= 100 * (stats[0] * stats[0]))
            {
                for (; statsxp[0] >= (100 * (stats[0] * stats[0]));)
                {
                    statsxp[0] -= 100 * (stats[0] * stats[0]);
                    stats[0]++;

                }
                level.Text = stats[0].ToString(); progressBar1.Maximum = 100 * (stats[0] * stats[0]); progressBar1.Value = statsxp[0];
            }
            for (int i = 1; i < stats.Length; i++)
            {
                if (statsxp[i] >= 10 * (stats[i] * stats[i]))
                {
                    for (; statsxp[i] >= (10 * (stats[i] * stats[i]));)
                    {
                        statsxp[i] -= 10 * (stats[i] * stats[i]);
                        stats[i]++;
                    }
                    if (i == 1) { strength.Text = stats[1].ToString(); progressBar2.Maximum = 10 * (stats[i] * stats[1]); progressBar2.Value = statsxp[1]; }
                    if (i == 2) { charisma.Text = stats[2].ToString(); progressBar3.Maximum = 10 * (stats[i] * stats[2]); progressBar3.Value = statsxp[2]; }
                    if (i == 3) { agility.Text = stats[3].ToString(); progressBar4.Maximum = 10 * (stats[i] * stats[3]); progressBar4.Value = statsxp[3]; }
                    if (i == 4) { vitality.Text = stats[4].ToString(); progressBar5.Maximum = 10 * (stats[i] * stats[4]); progressBar5.Value = statsxp[4]; }

                }
            }

            if (player.stats[0] >= 10) { growth.Text = "Młody smok"; }
            if (player.stats[0] >= 25) { growth.Text = "Dorosły smok"; }
        }//zwiększa poziomy i aktualizuje wielkość progressbarów
        public static void Hunger(ref int hunger, ref DateTime food)
        {
            DateTime today = DateTime.Today;
            if (food < today)
            {
                for (; food < today;)
                {
                    if (food == today) { return; }
                    hunger--;
                    food = food.AddDays(1);
                }

            }
            if (hunger < 0) { hunger = 0; }
        }//sprawdza kiedy ostatnio smok był karmiony
        public void reward(ref int difficulty, ref int duration)
        {

            Random rng = new Random();
            if (difficulty == 1)
            {
                greward = (duration * rng.Next(5, 10));
                xpreward = (duration * 2);
                player.gold += greward;
                player.statsxp[0] += xpreward * 4;
                for (int i = 1; i < 5; i++)
                {
                    player.statsxp[i] += xpreward;
                }
            }
        }//system nagradzania wypraw
        
        public void durcheck(ref int duration)
        {

            if (wyprawa0.Text == wyprawa0.Items[0].ToString()) { duration = 1; }
            if (wyprawa0.Text == wyprawa0.Items[1].ToString()) { duration = 2; }
            if (wyprawa0.Text == wyprawa0.Items[2].ToString()) { duration = 4; }
            if (wyprawa0.Text == wyprawa0.Items[3].ToString()) { duration = 6; }
        }//przypisuje koszt długości wyprawy
        public int exhaustcheck(int duration, int exhaustion)
        {
            if (duration > exhaustion)
            {
                MessageBox.Show(player.name + " jest zbyt zmęczony na tą wyprawę.\nBy odnowić punkty zmęczenia musisz go nakarmić.", "Błąd!");
                return 1;
            }
            else
            {
                player.exhaustion -= player.duration;
                return 0;
            }
        }//sprawdza czy smok nie jest zbyt zmęczony na wyprawę
        
        public void Feed(int foodtype)
        {
            if (player.hunger >= 4)
            {
                MessageBox.Show(player.name + " jest już najedzony!", "");
                return;
            }
            player.exhaustion = 12;
            player.hunger++;
            player.statsxp[foodtype] += 2 * (player.stats[0] * player.stats[0]);
            player.statsxp[0] += 2 * (player.stats[0] * player.stats[0]);
        }//mechanika karmienia
        public void Train(int type)
        {
            strcost.Text = (player.stats[1] * player.stats[1]).ToString();
            chacost.Text = (player.stats[2] * player.stats[2]).ToString();
            agicost.Text = (player.stats[3] * player.stats[4]).ToString();
            witcost.Text = (player.stats[3] * player.stats[4]).ToString();
            if (player.gold < ((player.stats[type] * player.stats[type])))
            {
                MessageBox.Show("Nie wystarczająco złota.");
                return;
            }
            else
            {
                player.gold -= (player.stats[type] * player.stats[type]);
                player.statsxp[type] += (player.stats[type] * player.stats[type]);
                player.statsxp[0] += (player.stats[type] * player.stats[type]);
                Updatestats();
                
            }
        }//mechanika trenowania
        public void Walka()
        {
            elvl.Text = enemy.stats[0].ToString();
            estr.Text = enemy.stats[1].ToString();
            echa.Text = enemy.stats[2].ToString();
            eagi.Text = enemy.stats[3].ToString();
            evit.Text = enemy.stats[4].ToString();
            enemyname.Text = enemy.name;
            enemyspecies.Text = "";
            enemytype.Text = enemy.type;
            edmg.Text =enemy.mindmg.ToString() + " - " + enemy.maxdmg.ToString();
            especial.Text = enemy.skillchance.ToString()+"%";
            edoublehit.Text = enemy.speed.ToString()+"%";
            ehitpoints.Text = enemy.hp.ToString();
            //eskill.Text=enemy.skill.ToString();
            //eskilldesc.Text = enemy.skilldes.ToString();

            hideeverything();
            fightmenu();
            Random rng = new Random();
            int damage, edamage,skillroll,eskillroll,doublehitroll,edoublehitroll,hp,ehp;
            hp = player.hp; ehp = enemy.hp;
            for (;hp>0&&ehp>0;)
            {

                
                edamage = rng.Next((int)enemy.mindmg, (int)enemy.maxdmg);
                 eskillroll = rng.Next(1, 101);
                doublehitroll = rng.Next(1, 101); edoublehitroll = rng.Next(1, 101);
                for (int i=1;i>0 ;i-- )
                {
                    
                    damage = rng.Next((int)player.mindmg, (int)player.maxdmg);
                    skillroll = rng.Next(1, 101);
                    if (skillroll < player.skillchance) 
                    {
                        //do wstawienia
                    }
                    doublehitroll = rng.Next(1, 101);
                    if (doublehitroll < player.speed) { i++; }
                    ehp -= damage;
                    starcie.AppendText("\nZadałeś " + damage + " obrażeń.\nPrzeciwnikowi zostało "+ehp+" zdrowia.");
                }
                for (int i=1;i>0;i--)
                {
                    edamage = rng.Next((int)enemy.mindmg, (int)enemy.maxdmg);
                    eskillroll = rng.Next(1, 101);
                    if (eskillroll < enemy.skillchance)
                    {
                        //do wstawienia
                    }
                    edoublehitroll = rng.Next(1, 101);
                    if (edoublehitroll < enemy.speed) { i++; }
                    hp -= edamage;
                    starcie.AppendText("\nOtrzymałeś " + edamage + " obrażeń.\nZostało ci " + hp+" zdrowia");
                }
                starcie.AppendText("\n\n-----------------\n");
                //Thread.Sleep(1000);
            }
            if (hp > 0) { starcie.AppendText("Wygrałeś walkę!"); }
            else { starcie.AppendText("Przegrałeś walkę!"); }
            button6.Visible = true;
            //timer1.Start();
        }
    }
}
