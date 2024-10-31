using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject playerPrefab;
    //private PlayerMovement movement;
    //private PlayerInput input;


    private void Awake()
    {
        //input = GetComponent<PlayerInput>();
        //input.MoveEvent += Move;
        Instantiate(playerPrefab, transform);
    }



    private void Move()
    {
        //movement.Move();
    }

    private void OnDestroy()
    {
        //input.MoveEvent -= Move;
    }
}
