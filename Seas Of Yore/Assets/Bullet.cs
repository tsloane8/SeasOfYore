using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20;
    public float bulletDamage = 1;
    private float bulletDeathDelay = 1.5f;

    void Update()
    {
        bulletDeathDelay -= Time.deltaTime;

        transform.Translate(Vector2.up * speed * Time.deltaTime);

        if(bulletDeathDelay <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var _enemy = collision.gameObject.GetComponent<Enemy>();

        if (collision.gameObject.tag == "Enemy")
        {
            _enemy.TakeDamage(bulletDamage);
            Destroy(gameObject);
        }
    }
}
