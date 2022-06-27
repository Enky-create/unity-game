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
