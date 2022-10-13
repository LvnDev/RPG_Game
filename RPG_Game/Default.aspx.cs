using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RPG_Game
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int damage;

            Character hero = new Character();
            hero.Name = "Hero";
            hero.DamageMaximum = 10;
            hero.AttackBonus = false;
            hero.Health = 100;
            Character monster = new Character();
            monster.Name = "Monster";
            monster.DamageMaximum = 5;
            monster.AttackBonus = false;
            monster.Health = 100;

            while (hero.Health > 0 && monster.Health > 0 ) 
            {
                damage = hero.Attack();
                monster.Defend(damage);

                damage = monster.Attack();
                hero.Defend(damage);

                printStats(hero);
                printStats(monster);

             
            }
            if(hero.Health > 0)
            {
                endLabel.Text = "Monster Win";
                
            }
            else if (monster.Health > 0)
            {
                endLabel.Text = "Hero Win";
            }
            

        }
        private void printStats(Character characeter)
        {
            Label1.Text += String.Format("<p> Name: {0} - Health: {1} - Damage Maximum: {3} - Attack Bonus: {2} ",
                characeter.Name,
                characeter.Health,
                characeter.AttackBonus.ToString(),
                characeter.DamageMaximum.ToString()); ;


        }
    }
}