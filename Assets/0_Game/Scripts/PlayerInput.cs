using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInput : MonoBehaviour
{
    PlayerMovement movement;
    PlayerHealth health;

    private void Start()
    {
        movement = GetComponent<PlayerMovement>();
        health = GetComponent<PlayerHealth>();
    }

    void Update()
    {
        var x = Input.GetAxis("Horizontal");
        var y = Input.GetAxis("Vertical");
        if (x!=0 || y!=0)
        {
            movement.Move(new Vector3(x,0,y));
        }

        if(Input.GetKeyDown(KeyCode.Q))
        {
            health.DecreaseLifes();
        }
    }
}
