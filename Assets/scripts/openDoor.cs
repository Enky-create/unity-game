using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour
{
    private Animator doorAnimator;

    void Start()
    {
        doorAnimator = GameObject.Find("Door").GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("player"))
        {
            doorAnimator.SetBool("isAnimated", true);
        }
    }
}
