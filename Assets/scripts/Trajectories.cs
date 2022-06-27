using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Trajectories
{
    protected float _speed ;
    protected float _offset ;
    protected float _offsetChange ;
    protected void InitParameters(float speed, 
        float offset, float offsetChange )
    {
       _speed = speed;
       _offset = offset;
       _offsetChange = offsetChange;
    }
}
public class SpiralTrajectory : Trajectories, IMovable
{
    private float _angle = 50.0f;
    private float _rotationSpeed = 10.0f;
    private Transform _parentTransform;
    public void Move()
    {  
        _offset += _offsetChange * Time.deltaTime;
        _parentTransform.Translate(new Vector3(0, 0, _speed + _offset) * Time.deltaTime);
        _parentTransform.Rotate(Vector3.up, _angle * Time.deltaTime * _rotationSpeed);
    }
    public SpiralTrajectory(Transform parentTransform)
    {
        InitParameters(speed:10.0f,
            offset:-1,
            offsetChange:5f);
        _parentTransform = parentTransform;
    }
}