﻿using System;
using System.Threading;
using WarriorWars.Enum;
using WarriorWars.Equipment;
namespace WarriorWars
{
    class Warrior
    {
        private const int GOOD_GUY_STARTING_HEALTH = 100;
        private const int BAD_GUY_STARTING_HEALTH = 100;
        private readonly Faction Faction;

        private int health;
        private string name;
        private bool isAlive;
        public bool IsAlive {
            get
            {
                return isAlive;
            }
           }
        private Weapon weapon;
        private Armor armor;

        public Warrior(string name ,Faction faction)
        {
            this.name = name;
            Faction =faction;
            isAlive = true;

            switch(faction)
            {
                case Faction.GoodGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = GOOD_GUY_STARTING_HEALTH;
                    break;

                case Faction.BadGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = BAD_GUY_STARTING_HEALTH;
                    break;

                default:
                    break; 
            }
        }

        public void Attack(Warrior enemy)
        {
            int damage = weapon.Damgae / enemy.armor.ArmorPoints;

            enemy.health -= damage;

            AttackResult(enemy, damage);
        }
        private void AttackResult(Warrior enemy , int damage) { 
            if(enemy.health<=0)
            {
                enemy.isAlive = false;
                Tools.ColorfulWriteLine($"{enemy.name} is dead",ConsoleColor.Red);
                Tools.ColorfulWriteLine($"{ name} is victorious!",ConsoleColor.Green);


            }
            else
            {
                Console.WriteLine($"{name} attack {enemy.name}, {damage} damage was inflicted to {enemy.name}, remaining halth of {enemy.name} is {enemy.health}");
            }

            Thread.Sleep(200);
        }
    }
}
