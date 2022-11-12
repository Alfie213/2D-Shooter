using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Header("Parametrs")]
    [SerializeField] private int damage = 40;
    [SerializeField] private GameObject hitEffect;
    [SerializeField] private Transform spawnParent;
    private void OnCollisionEnter2D(Collision2D hitInfo)
    {
        Debug.Log(hitInfo.transform.name);
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity, spawnParent);
        Destroy(effect, 0.5f);
        Destroy(gameObject);

        Health enemy = hitInfo.transform.GetComponent<Health>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
    }
    void Start()
    {
        Destroy(gameObject, 1);
    }
}
