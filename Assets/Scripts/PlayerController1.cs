using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour {

    List<GameObject> bgrid;
    int xind;
    int yind;
	// Use this for initialization
	void Start () {
        bgrid = GameObject.Find("Platform").GetComponent<TileGenerator>().bgrid;
        xind = 2;
        yind = 2;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("right") && yind < 2)
        {
            yind += 1;
        }
        if(Input.GetKeyDown("up") && xind < 2)
        {
            xind += 1;
        }
        if(Input.GetKeyDown("left") && yind > 0)
        {
            yind -= 1;
        }
        if(Input.GetKeyDown("down") && xind > 0)
        {
            xind -= 1;
        }
        this.transform.position = bgrid[yind*3+xind].transform.position; //yind * 2 + xind

    }
}
