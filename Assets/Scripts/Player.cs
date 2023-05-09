using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rigidbody2D;

    //스피드
    public int Speed { get; private set; } = 10;

    //목숨
    public int Life { get; private set; } = 3;

    //공격력
    public int Power { get; private set; } = 1;

    //가지고 있는 무기
    List<Weapon> haveWeapons = new List<Weapon>();

    //장착한 무기
    public Weapon[] equipedWeapons = new Weapon[2];

    //무기 기본공격 현재 대기시간
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

    //키받이
    void GetKey()
    {
        Move(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    //플레이어 이동
    void Move(float horizontalValue, float verticalValue)
    {
        rigidbody2D.velocity = new Vector2(horizontalValue, verticalValue) * Speed;
    }

    //기본공격 딜레이
    void AttackDelay()
    {
        //현재 대기시간 증가
        curAttackDelay += Time.deltaTime;

        //최대 대기시간 도달시 공격 실행
        if(curAttackDelay >= equipedWeapons[0].AttackCoolTime)
        {
            Attack();
            curAttackDelay = 0.0f;
        }
    }

    //기본공격
    void Attack()
    {
        equipedWeapons[0].Attack();
    }
}
