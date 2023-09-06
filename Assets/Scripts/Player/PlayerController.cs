using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float xMove;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float forwardHorizontalMovementSpeed;
    [SerializeField] private float horizontalLimit;

    
    public float XMove
    {
        get { return xMove; }
    }
    void Update()
    {
        HandlePlayerHorizontalMove();
    }
    private void HandlePlayerHorizontalMove()
    {
        if (Input.GetMouseButton(0))
        {

            xMove = 1;
            
        }
        else if (Input.GetMouseButton(1))
        {
            xMove = -1;
        }
        else
        {
            xMove = 0;
        }
    }
   
}
