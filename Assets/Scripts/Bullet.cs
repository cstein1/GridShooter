using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    Rigidbody2D rb;
    public bool gplayer;
    float vel;
    int lifeTimer = 200;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        if (gplayer)
        {
            vel = 2f;
            this.GetComponent<SpriteRenderer>().color = Color.black;
        } else
        {
            vel = -2f;
            this.GetComponent<SpriteRenderer>().color = Color.white;
        }
	}
	
	// Update is called once per frame
	void Update () {
        rb.velocity = new Vector2(vel, 0f);
        lifeTimer -= 1;
        if(lifeTimer < 0) {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "Bullet(Clone)")
        {
            Destroy(gameObject);
        }
        //if ((coll.gameObject.name == "bPlayer" && !gplayer) || (coll.gameObject.name == "bPlayer" && gplayer))
        if (coll.gameObject.name == "bPlayer")
        {
            Debug.Log("hit");
            //coll.gameObject.GetComponent<SpriteRenderer>().sprite = ;
        }
    }
}
