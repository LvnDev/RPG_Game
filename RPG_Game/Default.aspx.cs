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
            hero.AttackBonus = true;
            hero.Health = 500;
            Character monster = new Character();
            monster.Name = "Monster";
            monster.DamageMaximum = 15;
            monster.AttackBonus = false;
            monster.Health = 600;

            while (hero.Health > 0 || monster.Health > 0) 
            {
                damage = hero.Attack();
                monster.Defend(damage);

                damage = monster.Attack();
                hero.Defend(damage);

                printStats(hero);
                printStats(monster);
            }

            

        }
        private void printStats(Character characeter)
        {
            Label1.Text += String.Format("<p>Name: {0} - Health: {1} - Damage Maximum: {2} - Attack Bonus: {3}",
                characeter.Name,
                characeter.Health,
                characeter.AttackBonus.ToString(),
                characeter.DamageMaximum.ToString()); ;


        }
    }
}