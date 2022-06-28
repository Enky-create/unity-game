using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossCellsConstructor :  ICellConstructor 
{
    
    public void Set(Vector2Int gridSize, Tower tower)
    {
        for (int x=0; x<gridSize.x; x++)
        {
            MonoBehaviour.Instantiate(tower._cell,
                new Vector3(x, 0, tower.transform.position.z),
                Quaternion.identity,
                tower.transform);
        }
        for (int y = 0; y < gridSize.y; y++)
        {
            MonoBehaviour.Instantiate(tower._cell,
                new Vector3(tower.transform.position.x, 0, y),
                Quaternion.identity,
                tower.transform);
        }
    }

    public void Show(Vector2Int gridSize, Tower tower)
    {
       
    } 
}
