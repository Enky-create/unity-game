using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyBuilder : Tower
{
    [SerializeField] private Cell _cell;
    [SerializeField] private ISkillable _cellConstructor;
    private void Awake()
    {
        _health = 150.0f;
        _cellConstructor = new CrossCellsConstructor(_cell, this.transform, size);
    }
    public override void UseSkill() 
    {
        _cellConstructor.Activate();
    }
    public override void DeactivateSkill() 
    {
        _cellConstructor.Deactivate();
    }
}
