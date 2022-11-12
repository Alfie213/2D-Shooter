using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float speed;
    [SerializeField] private float stoppingDistance;
    [SerializeField] private float retreatDistance;

    [Header("Shooting")]
    [SerializeField] private float shootingRate;
    private float shootCooldown;

    [Header("Bullet")]
    [SerializeField] private GameObject projectile;
    private Transform player;

    [Header("Parametrs")]
    [SerializeField] private Transform firePoint;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform spawnParent;
    private Vector2 playerpos;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        shootCooldown = shootingRate;
    }
    void Update()
    {
        if (player != null)
        {
            if (Vector2.Distance(transform.position, player.position) > stoppingDistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            }
            else if (Vector2.Distance(transform.position, player.position) < stoppingDistance && Vector2.Distance(transform.position, player.position) > retreatDistance)
            {
                transform.position = this.transform.position;
            }
            else if (Vector2.Distance(transform.position, player.transform.position) < retreatDistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
            }

            if (shootCooldown <= 0)
            {
                Instantiate(projectile, firePoint.position, transform.rotation, spawnParent);
                shootCooldown = shootingRate;
            }
            else
            {
                shootCooldown -= Time.deltaTime;
            }
        }
    }
    void FixedUpdate()
    {
        if (player != null)
        {
            playerpos = new Vector2(player.position.x, player.position.y);
            Vector2 lookDir = playerpos - rb.position;
            float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
            rb.rotation = angle;
        }
    }
}
