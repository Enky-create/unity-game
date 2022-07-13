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
    void Set(Transform transform, Vector2Int size);
    void Destroy();
}
public interface ISkillable
{
    void Activate();
    void Deactivate();
}