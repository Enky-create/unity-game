using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossCellsConstructor :  ICellConstructor 
{
    private Cell _cellX;
    private Cell _cellY;

    public void Destroy()
    {
        if(_cellX != null)
        {
            MonoBehaviour.Destroy(_cellX.gameObject);
        }
        if (_cellY != null)
        {
            MonoBehaviour.Destroy(_cellY.gameObject);
        }
        
    }

    public void Show(Vector2Int gridSize, Tower tower)
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
        Destroy();
        var cell = tower._cell;
        var positionX = tower.transform.position.x;
        var positionY = tower.transform.position.y;
        cell.transform.localScale = new Vector3(gridSize.x, 0.01f,1);
         _cellX = MonoBehaviour.Instantiate(cell,
                new Vector3(gridSize.x / 2, 0.01f, tower.transform.position.z),
                Quaternion.identity);

         _cellY = MonoBehaviour.Instantiate(tower._cell,
                new Vector3(tower.transform.position.x, 0.01f, gridSize.y / 2),
                 Quaternion.Euler(0,90,0));
    }

    public void Set(Vector2Int gridSize, Tower tower)
    {
        if (Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
        {
            
            Show(gridSize, tower);
            
        }
    }
}
