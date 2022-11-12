using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [Header("Parametrs")]
    [SerializeField] private int health = 100;
    [SerializeField] private GameObject deathEffect;
    [SerializeField] private Transform spawnParent;
    [SerializeField] private GameObject deathScreen;
    [SerializeField] public GameObject winScreen;
    private Transform enemy;
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }
    private void Die()
    {
        GameObject effect = Instantiate(deathEffect, transform.position, Quaternion.identity, spawnParent);
        Destroy(effect, 1f);
        Destroy(gameObject);
    }
    void OnDestroy()
    {
        if (deathScreen != null)
        {
            deathScreen.SetActive(true);
        }
    }
    void Update()
    {
        if (winScreen != null)
        {
            if (GameObject.FindGameObjectWithTag("Enemy") == null)
            {
                winScreen.SetActive(true);
            } 
        }
    }
}
