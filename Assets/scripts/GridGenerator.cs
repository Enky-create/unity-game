using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class GridGenerator : MonoBehaviour
{
    [SerializeField] private Vector2Int _gridSize;
    [SerializeField] private Cell _prefab;
    [SerializeField] private float _offset;
    [SerializeField] private Transform _parent;
    private Vector3 cellSize;

    void Start()
    {
        cellSize = _prefab.GetComponent<MeshRenderer>().bounds.size;
        GameObject floor = GameObject.FindGameObjectWithTag("Floor");
        var floorSize = floor.GetComponent<MeshRenderer>().bounds.size;
        GenerateGrid(floorSize.x, floorSize.z);
    }

    [ContextMenu ("Generate Grid")]
    private void GenerateGrid(float floorX, float floorZ)
    {
        var halfX = floorX/2.2;
        var halfZ = floorZ/2.2;
        for(int x = -(int)halfX; x < _gridSize.x -(int)halfX; x++)
        {
            for (int y = -(int)halfZ; y < _gridSize.y - (int)halfZ; y++) 
            { 
                var position = new Vector3(x*(cellSize.x+_offset),0,y* (cellSize.z + _offset));
                var cell = Instantiate(_prefab,position,Quaternion.identity, _parent);
                cell.name = $"X = {x} Y = {y}";
            } 
        }
    }
}

