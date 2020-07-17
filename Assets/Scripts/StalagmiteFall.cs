using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StalagmiteFall : MonoBehaviour
{
    private Rigidbody2D rb;
    Vector2 startPos;
    GameObject Player;
    public int yReset;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        startPos = this.transform.position;
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.bodyType == RigidbodyType2D.Static){
            if (Mathf.Abs(Player.transform.position.x - startPos.x) < 5){
                rb.bodyType = RigidbodyType2D.Dynamic;
            }
        }
        else
            if (rb.bodyType == RigidbodyType2D.Dynamic){
                if (this.transform.position.y < yReset){
                    Invoke("resetPosition", 1);
                }
            }    
    }
    void resetPosition()
    {
        this.transform.position = startPos;
        rb.bodyType = RigidbodyType2D.Static;
    }
}
