using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    Rigidbody2D rb;
    public bool gplayer;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if(gplayer)
            rb.velocity = new Vector2(2f, 0f);
        else
            rb.velocity = new Vector2(-2f, 0f);
    }
    
}
