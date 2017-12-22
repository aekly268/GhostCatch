using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour {
    public float speed;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        delete();
        scroll();
	}
    void scroll()
    {
        transform.position = new Vector2(transform.position.x - speed, transform.position.y);
    }
    void delete() {
        if (transform.position.x < Camera.main.transform.position.x - 14.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
