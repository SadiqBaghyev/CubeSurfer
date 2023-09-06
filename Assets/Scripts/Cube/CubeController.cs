using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private PlayerStackController playerStackController;

    private Vector3 direction = Vector3.back;
    private bool isStack = false;
    private RaycastHit hit;
    
    private void Start()
    {
        playerStackController = GameObject.FindObjectOfType<PlayerStackController>();
    }

    private void FixedUpdate()
    {
        SetCubeRaycast();
    }

    private void SetCubeRaycast()
    {

        if (Physics.Raycast(transform.position, direction, out hit, 1f))
        {
            if (!isStack)
            {
                isStack = true;
                playerStackController.AddBlockStack(gameObject);
                SetDirection();
            }

            if (hit.transform.name == "ObstacleCube")
            {
                playerStackController.MinusBlock(gameObject);
            }
        }
    }

    private void SetDirection()
    {
        direction = Vector3.forward;
    }

}
