﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    List<GameObject> ggrid,bgrid;
    int xind;
    int yind;
    public bool gplayer;
    GameObject gScore;
    GameObject bScore;
    int gscore;
    int bscore;

	// Use this for initialization
	void Start () {
        gscore = 0;
        bscore = 0;
        if (gplayer)
        {
            ggrid = GameObject.Find("Platform").GetComponent<TileGenerator>().ggrid;
            xind = 0;
            yind = 0;
            bScore = GameObject.Find("bScore");
        } else
        {
            bgrid = GameObject.Find("Platform").GetComponent<TileGenerator>().bgrid;
            xind = 2;
            yind = 2;
            gScore = GameObject.Find("gScore");
            
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (gplayer)
        {
            if (Input.GetKeyDown("d") && yind < 2)
            {
                yind += 1;
            }
            if (Input.GetKeyDown("w") && xind < 2)
            {
                xind += 1;
            }
            if (Input.GetKeyDown("a") && yind > 0)
            {
                yind -= 1;
            }
            if (Input.GetKeyDown("s") && xind > 0)
            {
                xind -= 1;
            }
            Vector2 v = ggrid[yind * 3 + xind].transform.position;
            this.transform.position = new Vector3(v.x, v.y, -1); 
        } else
        {
            if (Input.GetKeyDown("right") && yind < 2)
            {
                yind += 1;
            }
            if (Input.GetKeyDown("up") && xind < 2)
            {
                xind += 1;
            }
            if (Input.GetKeyDown("left") && yind > 0)
            {
                yind -= 1;
            }
            if (Input.GetKeyDown("down") && xind > 0)
            {
                xind -= 1;
            }
            Vector2 v = bgrid[yind * 3 + xind].transform.position;
            this.transform.position = new Vector3(v.x,v.y,-1);
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "Bullet(Clone)" && coll.gameObject.transform.GetComponent<Bullet>().gplayer != gplayer)
        {
            //this.GetComponent<SpriteRenderer>().color = Color.black;
            if (gplayer)
            {
                bscore += 1;
                bScore.GetComponent<TextMesh>().text = "Score: " + bscore.ToString();
            } else
            {
                gscore += 1;
                gScore.GetComponent<TextMesh>().text = "Score: " + gscore.ToString();
            }
            Destroy(coll.gameObject);
        }
    }
}
