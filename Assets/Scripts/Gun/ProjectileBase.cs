using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBase : MonoBehaviour
{
    public Vector3 direction;

    public float timeTodestroy = 2f;

    public float side = 1;

    public int damageAmount = 1;

    private void Awake()
    {
        Destroy(gameObject, timeTodestroy);
    }

    private void Update()
    {
        transform.Translate(direction * Time.deltaTime * side);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var enemy = collision.transform.GetComponent<EnemyBase>();

        if (enemy != null)
        {
            enemy.damage(damageAmount);
            Destroy(gameObject);
        }
    }
}
