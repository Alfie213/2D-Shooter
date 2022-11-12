using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public int damage { get; private set; } = 10;
    [SerializeField]
    private int lifeTime = 7;
    public bool isEnemyShoted = false;
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }
}
