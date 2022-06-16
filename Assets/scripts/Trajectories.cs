using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public abstract class Trajectories : MonoBehaviour
//{
//    protected float _angle = 50.0f;
//    protected float _speed = 15.0f;
//    protected float _rotationSpeed = 16.0f;
//    protected float _offset = -1;
//    protected float _offsetChange = 0.008f;
//    protected float _destroyOffset = 7f;
//    protected void InitParameters(float angle, float speed, float rotationSpeed,
//        float offset, float offsetChange, float destroyOffset)
//    {
//        _angle = angle;
//        _speed = speed;
//        _rotationSpeed = rotationSpeed;
//        _offset = offset;
//        _offsetChange = offsetChange;
//        _destroyOffset = destroyOffset;
//    } 
//}
public class SpiralTrajectory : MonoBehaviour, IMovable
{
    protected float _angle = 50.0f;
    protected float _speed = 7.0f;
    protected float _rotationSpeed = 16.0f;
    protected float _offset = -1;
    protected float _offsetChange = 0.5f;
    protected Vector3 destroyPosition;
    protected float _destroyOffset = 4f;
    private Transform _parentTransform;
    public void Move()
    {  
        _offset += _offsetChange * Time.deltaTime;
        _parentTransform.Translate(new Vector3(0, 0, 1 + _offset) * _speed * Time.deltaTime);
        _parentTransform.Rotate(Vector3.up, _angle * Time.deltaTime * _rotationSpeed);
    }
    public SpiralTrajectory(Transform parentTransform)
    {
        _parentTransform = parentTransform;
    }
}