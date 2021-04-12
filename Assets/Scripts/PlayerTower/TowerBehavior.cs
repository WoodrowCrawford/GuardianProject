using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBehavior : MonoBehaviour
{
    public float health = 10;
    public bool gameover;

    // Start is called before the first frame update
    void Start()
    {
        health = 10;
        gameover = false;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (health <= 0)
        {
            gameover = true;
            GameObject.Destroy(this);
        }
    }
}
