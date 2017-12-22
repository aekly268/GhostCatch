using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public GameObject human;
    public float timer;
    float ptime;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ptime += Time.deltaTime;
        if (ptime >= timer)
        {
            timer = timer + Random.Range(-0.5f, 0.5f);
            timer = Mathf.Clamp(timer, 0.8f, 3.0f);
                ptime = 0.0f;
                createHuman();
            
        }
	}
    void createHuman() {
        Instantiate(human, new Vector2(transform.position.x + 14.0f,human.transform.position.y), transform.rotation);
    }
}
