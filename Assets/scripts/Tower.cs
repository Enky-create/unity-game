using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    private GameObject _orb;
    private Vector3 destroyPosition;
    //public float destroyOffset = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        //destroyPosition = new Vector3(transform.position.x + destroyOffset, 0,
        //    transform.position.y + destroyOffset);
        _orb = GameObject.FindGameObjectWithTag("Orb");
    }

    // Update is called once per frame
    void Update()
    {
        //if ((_orb.transform.position.x > destroyPosition.x) &&
        //    (_orb.transform.position.z > destroyPosition.z))
        //{
        //    Destroy(_orb);
        //}

    }

}
