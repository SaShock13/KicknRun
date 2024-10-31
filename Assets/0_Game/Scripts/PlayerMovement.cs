using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField,Range(4,7)] float runSpeed = 5f;

    public void Move(Vector3 direction)
    {          
        transform.position += direction * runSpeed * Time.deltaTime;
    }
}
