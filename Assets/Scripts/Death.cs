using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using Unity.VisualScripting;

public class Death : MonoBehaviour
{
    [SerializeField] Transform respawnPoint;
    private Transform playerTransform;
    [SerializeField] Rigidbody rb;

    private void Awake() 
    {
        playerTransform = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
    }

    public PlayerMovement GetPlayerMovement; 
    private void Update() 
    {
        if (playerTransform.position.y < -15)
        {
            SceneManager.LoadScene(0);
        }

        
    }
}
