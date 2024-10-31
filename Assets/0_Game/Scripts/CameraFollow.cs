using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class CameraFollow : MonoBehaviour
{
    Transform cameraTransform;
    //[SerializeField] Transform playerTransform;
    [SerializeField] Vector3 cameraOffset;
    [Inject] private Player _player;

    private void Awake()
    {
        cameraTransform = transform;
    }

    //private void Inj(GameObject player)
    //{
    //    _player = player;
    //}


    void Update()
    {
        cameraTransform.position = _player.transform.position + cameraOffset;
        cameraTransform.LookAt(_player.transform.position);
    }
}
