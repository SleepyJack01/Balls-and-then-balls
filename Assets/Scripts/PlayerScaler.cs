using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScaler : MonoBehaviour
{
    [Header("References")]
    private Transform playerTransform;
    private Rigidbody playerRigidbody;

    [Header("Settings")]
    public float playerScale;
    [SerializeField] private float playerScaleSpeed = 1.0f;
    private float playerVelocity = 0.0f;


    private void Awake() 
    {
        playerTransform = GetComponent<Transform>();
        playerRigidbody = GetComponent<Rigidbody>();

        playerScale = playerTransform.localScale.x;
    }

    private void Update() 
    {
        playerVelocity = playerRigidbody.velocity.magnitude;

        //increase the players scale when moving. Increases faster when moving faster
        playerScale += playerVelocity * playerScaleSpeed * Time.deltaTime;
        
        playerTransform.localScale = new Vector3(playerScale, playerScale, playerScale);
    }
}
