using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [Header("Parametrs")]
    [SerializeField] private int damage = 100;
    [SerializeField] private float speed = 20;
    [SerializeField] private GameObject hitEffect;
    [SerializeField] private Transform spawnParent;

    private Transform player;
    private Vector2 target;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        target = new Vector2(player.position.x, player.position.y);
    }
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime); // or targer --> player.position

        if (transform.position.x == target.x && transform.position.y == target.y)
        {
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D hitInfo)
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
}
