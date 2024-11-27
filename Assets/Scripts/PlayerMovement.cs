using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Scripting.APIUpdating;

public class PlayerMovement : MonoBehaviour
{
    [Header("References")]
    [SerializeField] public Rigidbody rb;
    
    [Header("Movement")]
    [SerializeField] private float moveForce = 10f;
    private Vector2 moveDirection;

    private void FixedUpdate()
    {
        // apply force to the rigidbody
        rb.AddForce(new Vector3(moveDirection.x, 0, moveDirection.y) * moveForce);
    }

    public void MovePlayer(InputAction.CallbackContext context)
    {
        moveDirection = context.ReadValue<Vector2>();
    }

}
