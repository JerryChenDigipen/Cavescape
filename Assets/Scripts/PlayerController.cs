using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed; 
    public float jumpPower;
    private float moveInput;
    private int jumpCounter;
    public float dashSpeed;
    private float dashTime;
    public float startDashTime;
    private int direction; 
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        dashTime = startDashTime;
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput* moveSpeed, rb.velocity.y);
        Jump();
        Dash();
    }

    void Jump(){
        if (Input.GetButtonDown("Jump") && jumpCounter > 0) {
            rb.velocity = new Vector2(rb.velocity.x, 0f);
            rb.AddForce(new Vector2(0f, jumpPower), ForceMode2D.Impulse);
            jumpCounter--;
        }
    }
    public void resetJump(){
        jumpCounter = 2;
    }
    void Dash(){
        if (true){
            float moveInput = Input.GetAxis("Horizontal");
            if (direction == 0){
                if (Input.GetKeyDown(KeyCode.LeftShift)){
                    if (moveInput < 0){
                        direction = 1;
                    }
                    if (moveInput > 0){
                        direction = 2;
                    }
                }
            }
            else {
                if (dashTime <= 0){
                    direction = 0;
                    dashTime = startDashTime;
                    rb.velocity = Vector2.zero;
                }
                else{
                    dashTime -= Time.deltaTime;
                    if (direction == 1){
                        rb.velocity = Vector2.left * dashSpeed;
                    }
                    else if (direction == 2){
                        rb.velocity = Vector2.right * dashSpeed;
                    }
        }

            }
        }
    }
}
