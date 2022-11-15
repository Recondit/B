using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public float moveSpeed = 5f;
    public InputAction playerControls;

    Vector2 moveDirection = Vector2.zero;

    private void OnEnable(){
        playerControls.Enable();
    }


    private void OnDisable(){
        playerControls.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = playerControls.ReadValue<Vector2>();
    }


    private void FixedUpdate(){
        rb.velocity = new Vector2(moveDirection.x * moveSpeed , moveDirection.y * moveSpeed);
    }
}
