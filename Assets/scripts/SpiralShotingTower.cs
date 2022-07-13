using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiralShotingTower : Tower
{
    [SerializeField] private Orb _orb;
    [SerializeField] private ISkillable _skill;
    private void Awake()
    {
        _skill = new SpiralShotingSkill(_orb, this.transform, this.size);
    }

}
