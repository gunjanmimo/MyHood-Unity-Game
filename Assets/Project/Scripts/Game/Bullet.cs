﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;
    public float lifeDuration = 2f;
    private float lifeTimer;
    public int damage = 5;
    private bool shotByPlayer;
    public bool ShotByPlayer { get { return shotByPlayer; } set { shotByPlayer = value; } }


    // Start is called before the first frame update
    void OnEnable()
    {
        lifeTimer = lifeDuration;


    }

    // Update is called once per frame
    void Update()
    {
        // make the bullet move
        transform.position += transform.forward * speed * Time.deltaTime;
        // check if the bullet should be destroyed
        lifeTimer -= Time.deltaTime;
        if (lifeTimer <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
