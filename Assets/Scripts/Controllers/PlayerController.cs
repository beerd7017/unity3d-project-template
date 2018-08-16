using Assets.Scripts.Models;
using UnityEngine;

namespace Assets.Scripts.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        public Player Player;

        // Use this for initialization
        void Start()
        {
            Debug.Log(Player.Name);

            Debug.Log(Player.Stats.Level);
            Debug.Log(Player.Stats.Xp);
            Debug.Log(Player.Stats.Hp);
            Debug.Log(Player.Stats.Mp);
            Debug.Log(Player.Stats.Str);
            Debug.Log(Player.Stats.Agl);
            Debug.Log(Player.Stats.Int);
            Debug.Log(Player.Stats.Vit);
            Debug.Log(Player.Stats.Lck);
            Debug.Log(Player.Stats.Atk);
            Debug.Log(Player.Stats.Def);
            Debug.Log(Player.Stats.HitPercent);
            Debug.Log(Player.Stats.EvadePercent);
            Debug.Log(Player.Stats.Md);

            foreach (var weapon in Player.Inventory.Weapons)
            {
                Debug.Log(weapon.ItemName);
                Debug.Log(weapon.Cost);
                Debug.Log(weapon.Value);

            }

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}