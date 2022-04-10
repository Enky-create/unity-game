using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takeDamage : MonoBehaviour
{
    public int damage = 0;
    private void OnCollisionEnter(Collision collision)
    {
        player player = collision.gameObject.GetComponent<player>();
        player.uplateHealth(-1*damage);
    }
}
