using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;

    [SerializeField] private float moveSpeed;
    [SerializeField] private float forwardHorizontalMovementSpeed;
    [SerializeField] private float horizontalLimit;

    private float newPositionX;
    
    private void FixedUpdate()
    {
        SetPlayerForwardMovement();
        SetPlayerHorizontalMovement();
    }

    private void SetPlayerForwardMovement()
    {
        transform.Translate(Vector3.down * moveSpeed * Time.fixedDeltaTime);
    }
    private void SetPlayerHorizontalMovement()
    {
        newPositionX = transform.position.x + playerController.XMove * moveSpeed * Time.fixedDeltaTime;
        newPositionX = Mathf.Clamp(newPositionX, -6, horizontalLimit);
        transform.position = new Vector3(newPositionX, transform.position.y, transform.position.z);
    }
}
