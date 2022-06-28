using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovable
{
    void Move();
}
public interface IOperator
{
    void MoveCamera();
    void ResetCamera();
}
public interface ICellConstructor
{
    void Show(Vector2Int gridSize, Tower tower);
    void Set(Vector2Int gridSize, Tower tower);
}