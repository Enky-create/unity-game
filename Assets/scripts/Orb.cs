using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : MonoBehaviour
{
    public float _damage = 200.0f;
    public float _angle = 35.0f;
    public float _speed = 10.0f;
    public float _rotationSpeed = 10.0f;
    public float _offset;
    //public Vector3 _movePosition;
    private Vector3 destroyPosition;
    public float destroyOffset = 0.005f;
    private void Start()
    {
        destroyPosition = new Vector3(transform.position.x + destroyOffset, 0,
            transform.position.z + destroyOffset);
        //_movePosition = new Vector3(transform.position.x, 0, transform.position.z);
    }
    void Update()
    {
       // _movePosition.z += _offset * Time.deltaTime;
        _offset+=0.008f;
        transform.Translate(new Vector3(0,0,1 + _offset) * _speed * Time.deltaTime);
        transform.Rotate(Vector3.up, _angle * Time.deltaTime * _rotationSpeed);

        if ((transform.position.x > destroyPosition.x) &&
            (transform.position.z > destroyPosition.z))
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("suka");
            Destroy(other.gameObject);
        }
    }
}
