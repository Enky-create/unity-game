using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerManager : MonoBehaviour
{
    [SerializeField] private static Vector2Int _gridSize = new Vector2Int(30, 30);
    [SerializeField] private Tower _flyingTower;
    private Tower[,] _towers;
    private Camera _mainCamera;
    //private BattleOperator _operator;
    public static Vector2Int  GetGridSize()
    {
        return _gridSize;
    }
    void Awake()
    {
        _mainCamera = Camera.main;
        
        //_operator = new BattleOperator(_mainCamera);
        _towers = new Tower[_gridSize.x, _gridSize.y];
    }
    public void StartPlacingTower(Tower towerPrefab)
    {
        
        //_operator.MoveCamera();
        if (_flyingTower != null)
        {
            Destroy(_flyingTower.gameObject);
        }
        _flyingTower = Instantiate(towerPrefab);
        
    }
    // Update is called once per frame
    void Update()
    {
        if (_flyingTower != null)
        {
            var groundPlane = new Plane(Vector3.up, Vector3.zero);
            var ray = _mainCamera.ScreenPointToRay(Input.mousePosition);
            if (groundPlane.Raycast(ray, out float position))
            {
                Vector3 worldPosition = ray.GetPoint(position);
                int x = Mathf.RoundToInt(worldPosition.x);
                int y = Mathf.RoundToInt(worldPosition.z);
                
                bool isAvailable = true;
                
                if (x <= 0 || x > _gridSize.x - _flyingTower.size.x)
                {
                    isAvailable = false;
                }

                if (y <= 0 || y > _gridSize.y - _flyingTower.size.y)
                {
                    isAvailable = false;
                }

                

                if (isAvailable && IsPlacetaken(x, y))
                {
                    isAvailable = false;
                }

                if (Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
                {
                    _flyingTower.DeactivateSkill();
                    _flyingTower.UseSkill();
                }
                

                _flyingTower.transform.position = new Vector3(x,0,y);
               
                _flyingTower.SetTransparent(isAvailable);

                if (isAvailable && Input.GetMouseButtonUp(0))
                {
                    PlaceTower(x, y);
                }
            }
        }
    }
private bool IsPlacetaken(int placeX, int placeY)
    {
        for (int x = 0; x < _flyingTower.size.x; x++)
        {
            for (int y = 0; y < _flyingTower.size.y; y++)
            {
                if(_towers[placeX + x, placeY + y] != null) return true;
            }
        }
        return false;
    }
private void PlaceTower(int placeX, int placeY)
    {
        
        for (int x = 0; x<_flyingTower.size.x; x++)
        {
            for (int y = 0; y < _flyingTower.size.y; y++)
            {
                _towers[placeX + x, placeY + y] = _flyingTower;
            }
        }
        _flyingTower.SetNormalColor();
        _flyingTower.UseSkill();
        //_operator.ResetCamera();

        
        _flyingTower = null;
    }
}

