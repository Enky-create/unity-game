using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] private Renderer _renderer;
    public Vector2Int size = Vector2Int.one;
    [SerializeField] private Orb _orb;
    public void SetTransparent (bool isAvailable)
    {
        if (isAvailable)
        {
            _renderer.material.color =  Color.green;
        }
        else
        {
            _renderer.material.color = Color.red;
        }
    }
    public void SetNormalColor()
    {
        _renderer.material.color = Color.white;
    }

    private void OnDrawGizmos()
    {
        for (int x=0; x<size.x; x++)
        {
            for(int y=0; y < size.y; y++)
            {
                Gizmos.color = Color.cyan;
                Gizmos.DrawCube(transform.position + new Vector3(x, 0, y), new Vector3(1, .1f, 1));
            }
        }
    }
    void Start()
    {
        InvokeRepeating("SpawnOrb",1f,1f);
    }

    // Update is called once per frame
    void Update()
    {
       

    }
    void SpawnOrb()
    {
        Instantiate(_orb, transform.position+new Vector3(0,4,0), Quaternion.identity);
    }
}
