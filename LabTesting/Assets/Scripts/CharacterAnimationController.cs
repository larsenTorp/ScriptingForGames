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
        //Triggers DoubleJump
        if (Input.GetButtonDown("Jump"))
        {
            animator.SetTrigger(name: "Jump");
        }
        else
        {
            animator.SetTrigger(name: "Idle");
        }

        //Triggers Hit
        if (Input.GetKeyDown(KeyCode.H))
        {
            animator.SetTrigger(name: "Hit");
        }
        else
        {
            animator.SetTrigger(name: "Idle");
        }

        //Triggers Fall
        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetTrigger(name: "Fall");
        }
        else
        {
            animator.SetTrigger(name: "Idle");
        }
    }
}
