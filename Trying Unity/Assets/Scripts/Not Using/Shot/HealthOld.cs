using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthOld : MonoBehaviour
{
    [SerializeField]
    private int hp = 1;
    [SerializeField]
    private bool isEnemy = true;
    public void Damage(int damageCount)
    {
        hp -= damageCount;
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Shot shot = collision.gameObject.GetComponent<Shot>();
        if (shot != null && shot.isEnemyShoted != isEnemy)
        {
            Damage(shot.damage);
            Destroy(shot.gameObject);
        }
    }
}
