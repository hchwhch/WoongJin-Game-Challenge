using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int HP { get; private set; } = 100;
    public int Speed { get; private set; } = 10;
    public string name;

    public SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Bullet")
        {
            OnHit(collision.gameObject);

            Destroy(collision.gameObject);
        }
    }

    void OnHit(GameObject bullet)
    {
        Bullet bulletLogic = bullet.GetComponent<Bullet>();

        HP -= bulletLogic.power;
        if(HP <= 0)
        {
            gameObject.SetActive(false);
        }

        HitEffect();
    }

    void HitEffect()
    {
        spriteRenderer.color = new Color(1.0f, 1.0f, 1.0f, 0.2f);
        Invoke("ReturnToOrigin", 0.1f);
    }

    void ReturnToOrigin()
    {
        spriteRenderer.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
    }
}
