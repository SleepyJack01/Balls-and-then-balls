using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    [SerializeField] Transform respawnPoint;
    private Transform playerTransform;

    private void Awake() 
    {
        playerTransform = GetComponent<Transform>();
    }

    private void Update() 
    {
        if (playerTransform.position.y < -20)
        {
            playerTransform.position = respawnPoint.position;
        }
    }
}
