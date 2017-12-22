using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour {
    Animator ani;
    Rigidbody2D body;
    public float jumpHeight;
    bool isGround;
    // Use this for initialization
    void Start () {
        // ani = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        fly();
	}
    void fly() {
        if (Input.GetKeyDown(KeyCode.F) && isGround) {
            body.AddForce(new Vector2(0, jumpHeight),ForceMode2D.Impulse);
        }
    }
    void attack() {
        if (Input.GetMouseButtonDown(0))
        {
            
           
            Debug.Log("att");
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "floor") {
            isGround = true;
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "floor")
        {
            isGround = false;
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "human") {
            //change sprite

        }
    }
}
