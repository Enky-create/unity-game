using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossCellsConstructor :  ICellConstructor 
{
    [SerializeField] private Cell _cell;
    public void Set(Vector2Int gridSize, Tower tower)
    {
        //for (float x = 0; x < gridSize.x; x+=2f)
        //{
        //    MonoBehaviour.Instantiate(tower._cell,
        //        new Vector3(x, 0.01f, tower.transform.position.z),
        //        Quaternion.identity);
        //}
        //for (float y = 0; y < gridSize.y; y += 2f)
        //{
        //    MonoBehaviour.Instantiate(tower._cell,
        //        new Vector3(tower.transform.position.x, 0.01f, y),
        //        Quaternion.identity);
        //}
        var cell = tower._cell;
        cell.transform.localScale = new Vector3(gridSize.x, 0.01f,1);
        MonoBehaviour.Instantiate(cell,
                new Vector3(gridSize.x / 2, 0.01f, tower.transform.position.z),
                Quaternion.identity);
       
        MonoBehaviour.Instantiate(tower._cell,
                new Vector3(tower.transform.position.x, 0.01f, gridSize.y / 2),
                 Quaternion.Euler(0,90,0));
    }

    public void Show(Vector2Int gridSize, Tower tower)
    {

    }
}
