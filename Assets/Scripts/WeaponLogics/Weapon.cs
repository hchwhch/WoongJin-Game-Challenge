using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : Item
{
    //���� ���ݷ�
    public int Power { get; private set; } = 1;

    //���� źȯ ���ǵ�
    public float BulletSpeed { get; private set; } = 10;

    //���� �⺻���� ���ð�
    public float AttackCoolTime { get; private set; } = 0.5f;
    
    //��ų ��Ÿ��
    public float SkillCoolTime { get; private set; }

    abstract public void Attack();
    abstract public void Skill();
}
