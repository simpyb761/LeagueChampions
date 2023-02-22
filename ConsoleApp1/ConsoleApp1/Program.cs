using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using static System.Console;

namespace LeagueChampions
{
    class Program
    {
        static void Main(string[] args)
        {
               Mage firstMage= new Mage("Lux", "Mid Lane", "ILllumination","Light Binding", "Prismatic Barrier", "Lucent Singularity", "Final Spark", "Support Mage", "AOE" );
               firstMage.Display();
        }
    }
    interface Champions
    {
        string Name { get; set; }
        string Lane { get; set; }
        string Passive { get; set; }
        string AbilityOne { get; set; }
        string AbilityTwo { get; set; }
        string AbilityThree { get; set; }
        string AbilityFour { get; set; }

        public void Display();
    }

    class Mage : Champions
    {
        public string Name { get; set; }
        public string Lane { get; set; }
        public string Passive { get; set; }
        public string AbilityOne { get; set; }
        public string AbilityTwo { get; set; }
        public string AbilityThree { get; set; }
        public string AbilityFour { get; set; }
        public string MageType { get; set; }
        public string TargetType { get; set; }

        public Mage()
        {
            Name = string.Empty;
            Lane = string.Empty;
            Passive = string.Empty;
            AbilityOne = string.Empty;
            AbilityTwo = string.Empty;
            AbilityThree = string.Empty;
            AbilityFour = string.Empty;
            MageType = string.Empty;
            TargetType = string.Empty;
        }
        public Mage(string name, string lane, string passive, string abilityOne, string abilityTwo, string abilityThree, string abilityFour, string mageType, string targetType)
        {
            Name = name;
            Lane = lane;
            Passive = passive;
            AbilityOne = abilityOne;
            AbilityTwo = abilityTwo;
            AbilityThree = abilityThree;
            AbilityFour = abilityFour;
            MageType = mageType;
            TargetType = targetType;
        }
        public void Display()
        {
            WriteLine("Champion Information");
            WriteLine(Name); WriteLine(Lane); WriteLine(Passive);
            WriteLine(AbilityOne); WriteLine(AbilityTwo);
            WriteLine(AbilityThree); WriteLine(AbilityFour);
            WriteLine(MageType); WriteLine(TargetType);
        }
    }

}