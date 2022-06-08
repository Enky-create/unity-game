using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGenerator : MonoBehaviour
{
    [SerializeField] private Vector2Int _gridSize;
    [SerializeField] private Cell _prefab;
    [SerializeField] private float _offset;
    [SerializeField] private Transform _parent;

    void Start()
    {
        GenerateGrid();
    }

    [ContextMenu ("Generate Grid")]
    private void GenerateGrid()
    {
        var cellSize = _prefab.GetComponent<MeshRenderer>().bounds.size;
        for(int x = 0; x < _gridSize.x; x++)
        {
            for (int y = 0; y<_gridSize.y; y++) 
            {
                var position = new Vector3(x*(cellSize.x+_offset),0,y* (cellSize.z + _offset));
                var cell = Instantiate(_prefab,position,Quaternion.identity, _parent);
                cell.name = $"X = {x} Y = {y}";
            } 
        }
    }
}

