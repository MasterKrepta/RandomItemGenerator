using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomItemGenerator
{
    class Program
    {
        static void Main(string[] args) {

            
            
            Item itemToCreate = new Item();


            while(true){
                string finalWeapon = CreateWeaponName(itemToCreate);

                Console.WriteLine("\n" + finalWeapon);
                Console.ReadKey();
            }

          

        }

        private static string CreateWeaponName(Item tocreate) {
            string finalName = "";
            Modifier listOfNames = new Modifier();
            int qIndex = new Random().Next(0, listOfNames.Quality.Length);
            int wIndex = new Random().Next(0, tocreate.WeaponTypes.Length);
            int secondIndex = new Random().Next(0, listOfNames.ofModifier.Length);
            int finalIndex = new Random().Next(0, listOfNames.FinalNoun.Length);
            string weaponType;
            string secondModifier;
            string final;
            

            finalName = listOfNames.Quality[qIndex] + " " + tocreate.WeaponTypes[wIndex] + " " + listOfNames.ofModifier[secondIndex] + " " + listOfNames.FinalNoun[finalIndex];
            
            return finalName;
        }
    }
}
