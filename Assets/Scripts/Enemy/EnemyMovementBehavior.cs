using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementBehavior : MonoBehaviour
{
    public float health = 1f;
    public float damage = 2f;
    public float speed = 3f;

    public float xPos = 1;
    public float yPos;

    public Rigidbody enemy;
    public Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        health = 1;
        damage = 2;
        speed = 3;
    }

    // Update is called once per frame
    void Update()
    {
        //This is used to make movement for the enemy
        xPos = enemy.velocity.x;
        yPos = enemy.velocity.y;

        direction = new Vector3(10, 0, 0) * Time.deltaTime;

        enemy.velocity = direction;
    }

    
}
