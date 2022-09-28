using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DamagePlayer : MonoBehaviour
{
    public int damage = 25;
    public bool hasAttacked = false;

    private void OnTriggerEnter(Collider other)
    {
        if (hasAttacked == false)
        {
            PlayerStats playerStats = other.GetComponent<PlayerStats>();

            if (playerStats != null)
            {
                playerStats.TakeDamage(damage);
                hasAttacked = true;
            }
        }
    }
}
