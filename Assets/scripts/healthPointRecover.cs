using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthPointRecover : MonoBehaviour
{
    public GameObject healthContainer;
    public int healthPoint = 10;
    private void OnCollisionEnter(Collision collision)
    {
        player player = collision.gameObject.GetComponent<player>();
        player.uplateHealth(healthPoint);
        Destroy(healthContainer);
    }
}