using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiralShotingSkill : ISkillable
{
    [SerializeField]
    private float cooldown = 2.0f;
    [SerializeField]
    private Orb _orb;
    [SerializeField]
    private Transform _parent;
    [SerializeField]
    private Vector2Int size;
    public void Activate()
    {
        _orb.SetDamage(50);
        MonoBehaviour.Instantiate(_orb, _parent.position+new Vector3(-size.x, 4, size.y/2), Quaternion.identity);
    }

    public void Deactivate()
    {
        throw new System.NotImplementedException();
    }
    public SpiralShotingSkill(Orb _orb,
        Transform _parent,
        Vector2Int size)
    {
        this._orb = _orb;
        this._parent = _parent;
        this.size = size;
    }
}
