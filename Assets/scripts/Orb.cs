using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : MonoBehaviour
{
    public float _damage = 20.0f;
    private IMovable _move;
    private Vector3 destroyPosition;
    private float _destroyRadius = 4f;
    private void Start()
    {
        _move = new SpiralTrajectory(transform);
        destroyPosition = new Vector3(transform.position.x + _destroyRadius, 0,
            transform.position.z + _destroyRadius);
    }
    void Update()
    {
        if (transform.position.x > destroyPosition.x &&
            transform.position.z > destroyPosition.z)
        {
            Destroy(gameObject);
        }
        _move.Move();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
