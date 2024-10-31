using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeatthZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("player in");
            other.gameObject.GetComponent<PlayerHealth>().TakeDeath();
        }
    }
}
