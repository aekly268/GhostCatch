using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBG : MonoBehaviour {
    public GameObject BG;
    public float speed;
    bool once;
	// Use this for initialization
	void Start () {
        once = true;
        Debug.Log(BG.transform.position.x - transform.position.x);
    }
	
	// Update is called once per frame
	void Update () {
        if (Camera.main.transform.position.x > transform.position.x && once)
        {
            create();
            once = false;
        }
        scroll();
        delete();

    }
    void create() {
        Instantiate(BG, new Vector2(14.0f, transform.position.y), transform.rotation);
    }
    void scroll() {
        //transform.position=new Vector2(,)
        transform.position = new Vector2(transform.position.x-speed,transform.position.y);

    }
    void delete() {
        if (transform.position.x < Camera.main.transform.position.x - 14.0f) {
            Destroy(this.gameObject);
        }
    }
}
