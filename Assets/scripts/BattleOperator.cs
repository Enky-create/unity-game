using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleOperator : IOperator
{
    private Camera _mainCamera;
    private Transform _cameraTransform;
    
    public void MoveCamera()
    {
        _mainCamera.transform.position = new Vector3(14f,26f,15f); 
        _mainCamera.transform.rotation = new Quaternion(90f,0f,0f,90f);
    }

    public void ResetCamera()
    {
        _mainCamera.transform.position = new Vector3(14.88f, 11.03f, -7.13f); ;
        _mainCamera.transform.rotation= Quaternion.Euler(26f, 0f, 0f);
    }
    public BattleOperator(Camera camera)
    {
        _mainCamera = camera;
        _cameraTransform = camera.transform;
    }
}
