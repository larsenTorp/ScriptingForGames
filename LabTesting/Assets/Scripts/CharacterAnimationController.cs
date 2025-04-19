using JetBrains.Annotations;
using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    private Animator animator;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleAnimations();
    }

    private void HandleAnimations()
    {
        // Handle Idling and Running
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            animator.SetTrigger(name: "Run");
        }
        else
        {
            animator.SetTrigger("Idle");
        }

        // Handle Jumping
        if (Input.GetButtonDown("Jump"))
        {
            animator.SetTrigger(name: "Jump");
        }

        // Handle Wall Jumping
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger(name: "Jump");
        }

        //Triggers Hit
        if (Input.GetKeyDown(KeyCode.H))
        {
            animator.SetTrigger(name: "Hit");
        }
    }
}
