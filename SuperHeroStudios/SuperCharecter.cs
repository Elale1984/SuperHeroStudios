using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * This is the SuperCharecter class which contains the properties, a constructor, and an
 * overriden ToString method that displays the properties in an orginized fashion. There is 
 * also a couple of utility methods that are used to add the abilities and weeknesses of 
 * the charecter to a string concatonating the items in an orginized format.
 */
namespace SuperHeroStudios
{
    public class SuperCharecter
    {
        String alias;
        String secretIdentity;
        String archEnemy;
        String type;
        String humanBDay;
        String superBDay;
        String city;
        List<String> ability;
        List<String> weakness;
        String primaryWeapon;
        String secondaryWeapon1;
        String secWeap1Amt;
        String secondaryWeapon2;
        String secWeap2Amt;
        String suitColor;
        String accentColor;
        String powerRank;
        int power;
        int speed;
        int stamina;

        public SuperCharecter(string alias, string secretIdentity, string archEnemy, string type, String humanBDay, String superBDay,
            string city, List<string> ability, List<string> weakness, string primaryWeapon, string secondaryWeapon1, String secWeap1Amt,
            string secondaryWeapon2, String secWeap2Amt, string suitColor, string accentColor, String powerRank, int power,
            int speed, int stamina)
        {
            this.alias = alias;
            this.secretIdentity = secretIdentity;
            this.archEnemy = archEnemy;
            this.type = type;
            this.humanBDay = humanBDay;
            this.superBDay = superBDay;
            this.city = city;
            this.ability = ability;
            this.weakness = weakness;
            this.primaryWeapon = primaryWeapon;
            this.secondaryWeapon1 = secondaryWeapon1;
            this.secWeap1Amt = secWeap1Amt;
            this.secondaryWeapon2 = secondaryWeapon2;
            this.secWeap2Amt = secWeap2Amt;
            this.suitColor = suitColor;
            this.accentColor = accentColor;
            this.powerRank = powerRank;
            this.power = power;
            this.speed = speed;
            this.stamina = stamina;
        }

       // overriden ToString method 
        public override string ToString()
        {

            string details = "Alias: " + this.alias;
            details += "\r\nSecret Identity: " + secretIdentity;
            details += "\r\nArch Enemy: " + archEnemy;
            details += "\r\nType: " + type;
            details += "\r\nHuman B-Day " + humanBDay;
            details += "\r\nSuper B-Day: " + superBDay;
            details += "\r\nCity: " + city;
            details += "\r\nAbility: " + utilGetAbility();
            details += "\r\nWeakness: " + utilGetWeaknesses();
            details += "\r\nPrimary Weapon: " + primaryWeapon;
            details += "\r\nSecondary Weapon 1: " + secondaryWeapon1 + "= " + secWeap1Amt;
            details += "\r\nSecondary Weapon 2: " + secondaryWeapon2 + "= " + secWeap2Amt;
            details += "\r\nSuit Color: " + suitColor;
            details += "\r\nAccent Color: " + accentColor;
            details += "\r\nPower Rank: " + powerRank;
            details += "\r\nPower Level: " + power.ToString();
            details += "\r\nSpeed Level: " + speed.ToString();
            details += "\r\nStamina: " + stamina.ToString();

            return details;
        }

        // utility string method returns the string of all of the weaknesses that are located in the weaknesses list
        public string utilGetWeaknesses()
        {

            String weaknessString = "";
            if (weakness.Count >= 1)
            {

                foreach (var item in weakness)
                {
                    weaknessString += item + ", ";
                }
            }
            else
                weaknessString = "None";


            return weaknessString;
        }

        // utility string method returns the string of all of the Abilities that are located in the Abilities list
        public string utilGetAbility()
        {
            String abilityString = "";
            if (ability.Count >= 1)
            {

                foreach (var item in ability)
                {
                    abilityString += item + ", ";
                }
            }
            else
                abilityString = "None";
           

            return abilityString;
        }
    }
}
