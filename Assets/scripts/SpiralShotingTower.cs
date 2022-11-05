using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiralShotingTower : Tower
{
    [SerializeField] private Orb _orb;
    [SerializeField] private ISkillable _skill;
    private static ObjectPool<PoolObject> _orbPool;
    private void Awake()
    {
        _orbPool = new ObjectPool<PoolObject>(_orb.gameObject);
        _skill = new SpiralShotingSkill(_orb, this.transform, this.size);
    }
    private void Update()
    {
        _orbPool.PullGameObject(this.transform.position,Quaternion.identity);
    }
}
