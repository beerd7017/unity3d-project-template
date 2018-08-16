using System.Collections.Generic;
using Assets.Scripts.Models.Items;
using UnityEngine;

namespace Assets.Scripts.Models
{
    public class PlayerInv : MonoBehaviour
    {
        public List<Weapon> Weapons = new List<Weapon>();
        public List<Armour> Armours;
        public List<Accessory> Accessories;
        public List<Potion> Potions;
        public List<CraftItem> CraftItems;
        public List<QuestItem> QuestItems;
        public List<AlchemyItem> AlchemyItems;
        public List<Rune> Runes;

        private void Start()
        {
            
        }
    }
}