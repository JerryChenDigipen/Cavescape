using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeMvmt : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
    }
    void OnTriggerEnter2D(Collider2D coll){
        if (coll.CompareTag("SlimeStopper")){
            moveSpeed *= -1;
        }
    }
}
