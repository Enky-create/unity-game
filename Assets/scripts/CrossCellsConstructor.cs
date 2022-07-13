using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossCellsConstructor : ISkillable
{
    private Transform transform;
    private Vector2Int size;
    private Cell _original;
    private Cell _cellLeft;
    private Cell _cellTop;
    private Cell _cellRight;
    private Cell _cellBottom;

    public void Deactivate()
    {
        if(_cellLeft != null)
        {
            MonoBehaviour.Destroy(_cellLeft.gameObject);
        }
        if (_cellTop != null)
        {
            MonoBehaviour.Destroy(_cellTop.gameObject);
        }
        if (_cellRight != null)
        {
            MonoBehaviour.Destroy(_cellRight.gameObject);
        }
        if (_cellBottom != null)
        {
            MonoBehaviour.Destroy(_cellBottom.gameObject);
        }
    }

    public void Activate()
    {
        var gridSize = TowerManager.GetGridSize();
        var cell = _original;
        var positionX = transform.position.x;
        var positionY = transform.position.y;
        var leftSize =  transform.position.x - size.x;
        var RightSize = gridSize.x -transform.transform.position.x;
        var UpSize = gridSize.y - size.y - transform.position.z;
        var BottomSize = transform.position.z - size.y;

        // leftCell
        cell.transform.localScale = new Vector3(leftSize, 0.01f, 1);
        _cellLeft = MonoBehaviour.Instantiate(cell,
               new Vector3(transform.position.x- size.x - leftSize/2, 
               0.01f, 
               transform.position.z),
               Quaternion.identity);
        // RightCell
        cell.transform.localScale = new Vector3(RightSize, 0.01f, 1);
        _cellRight = MonoBehaviour.Instantiate(cell,
               new Vector3(transform.position.x + size.x + RightSize / 2,
               0.01f,
               transform.position.z),
               Quaternion.identity);

        // UpCell
        cell.transform.localScale = new Vector3(UpSize, 0.01f, 1);
        _cellTop = MonoBehaviour.Instantiate(_original,
                new Vector3(transform.position.x,
                0.01f, 
                transform.position.z + size.y + UpSize / 2),
                 Quaternion.Euler(0, 90, 0));
        // BottomCell
        cell.transform.localScale = new Vector3(BottomSize, 0.01f, 1);
        _cellBottom = MonoBehaviour.Instantiate(_original,
                new Vector3(transform.position.x,
                0.01f,
               transform.position.z - size.y - BottomSize / 2),
                 Quaternion.Euler(0, 90, 0));
    }

    public CrossCellsConstructor(Cell cell,
        Transform transform,
        Vector2Int size)
    {
        _original = cell;
        this.transform = transform;
        this.size = size;
    }

}
