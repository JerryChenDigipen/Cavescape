using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator animator;
    public bool faceRight;
    private float moveInput;
    // Start is called before the first frame update
    void Start()
    {
        faceRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        if (moveInput > 0.1f){
            animator.SetBool("FaceRight", true);
        }
        else if (moveInput < -0.1f) {
            animator.SetBool("FaceRight", false);
        }
        animator.SetFloat("Speed", Mathf.Abs(moveInput));
    }
}
