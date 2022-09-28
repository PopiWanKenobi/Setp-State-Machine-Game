using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KB
{
    public class EnemyStats : CharacterStats
    {
        void Start()
        {
            maxHealth = SetMaxHealthFromHealthLevel();
            currentHealth = maxHealth;

        }

        private int SetMaxHealthFromHealthLevel()
        {
            maxHealth = healthLevel * 10;
            return maxHealth;
        }

        public void TakeDamage(int damage)
        {
            currentHealth = currentHealth - damage;

            if (currentHealth <= 0)
            {
                currentHealth = 0;
                //handle player dealth
            }
        }
    }

}

