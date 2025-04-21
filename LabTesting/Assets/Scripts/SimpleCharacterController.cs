using Unity.Properties;
using UnityEngine;
using UnityEngine.UIElements;

public class SimpleCharacterController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 8f;
    public float gravity = -9.81f;
    public SimpleFloatData jumps;

    private float jump;
    private CharacterController controller;
    private Vector3 velocity;
    private Transform thisTransform;
    


    void Start()
    {
        // Cache references to components
        controller = GetComponent<CharacterController>();
        thisTransform = transform;
    }


    private void Update()
    {
        MoveCharacter();
        ApplyGravity();
        KeepCharacterOnXAxis();
        jumps.value = jump / 2;
        
        if (controller.isGrounded)
        {
            jump = 2;
            velocity.y = 0f;
        }
    }

    private void MoveCharacter()
    {
        var moveInput = Input.GetAxis("Horizontal");
        var move = new Vector3(moveInput, 0f, 0f) * (moveSpeed * Time.deltaTime);
        controller.Move(move);

        // jumping
        if (Input.GetButtonDown("Jump") && jump > 0)
        {
            velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);
            jump -= 1;
        }
    }

    private void ApplyGravity()
    {
        if (!controller.isGrounded)
        {
            velocity.y += gravity * Time.deltaTime;
        }
        else
        {
            
        }

        // apply velocity to controller
        controller.Move(velocity * Time.deltaTime);
    }

    private void KeepCharacterOnXAxis()
    { 
        var currentPosition = thisTransform.position;
        currentPosition.z = 0f;
        thisTransform.position = currentPosition;  
    }
}
