using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rigidbody2D;

    //���ǵ�
    public int Speed { get; private set; } = 10;

    //���
    public int Life { get; private set; } = 3;

    //���ݷ�
    public int Power { get; private set; } = 1;

    //������ �ִ� ����
    List<Weapon> haveWeapons = new List<Weapon>();

    //������ ����
    public Weapon[] equipedWeapons = new Weapon[2];

    //���� �⺻���� ���� ���ð�
    public float curAttackDelay = 0.0f;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        GetKey();
        AttackDelay();
    }

    //Ű����
    void GetKey()
    {
        Move(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    //�÷��̾� �̵�
    void Move(float horizontalValue, float verticalValue)
    {
        rigidbody2D.velocity = new Vector2(horizontalValue, verticalValue) * Speed;
    }

    //�⺻���� ������
    void AttackDelay()
    {
        //���� ���ð� ����
        curAttackDelay += Time.deltaTime;

        //�ִ� ���ð� ���޽� ���� ����
        if(curAttackDelay >= equipedWeapons[0].AttackCoolTime)
        {
            Attack();
            curAttackDelay = 0.0f;
        }
    }

    //�⺻����
    void Attack()
    {
        equipedWeapons[0].Attack();
    }
}
