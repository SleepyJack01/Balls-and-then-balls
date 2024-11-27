using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteTowardsCamera : MonoBehaviour
{
    [SerializeField] private Transform cameraTransform;


    private void Awake() 
    {
        cameraTransform = Camera.main.transform;
    }

    private void Update() 
    {
        transform.LookAt(cameraTransform);
    }
}
