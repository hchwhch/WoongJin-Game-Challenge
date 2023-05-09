using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : Item
{
    //무기 공격력
    public int Power { get; private set; } = 1;

    //무기 탄환 스피드
    public float BulletSpeed { get; private set; } = 10;

    //무기 기본공격 대기시간
    public float AttackCoolTime { get; private set; } = 0.5f;
    
    //스킬 쿨타임
    public float SkillCoolTime { get; private set; }

    abstract public void Attack();
    abstract public void Skill();
}
