using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestWeapon : Weapon
{
    public GameObject bulletPrefab;

    public override void Attack()
    {
        GameObject bullet = Instantiate(bulletPrefab, transform);
        Rigidbody2D bulletRigid = bullet.GetComponent<Rigidbody2D>();
        bulletRigid.AddForce(Vector2.right * BulletSpeed, ForceMode2D.Impulse);
    }

    public override void Skill()
    {
        print("스킬이 없어...");
    }
}
