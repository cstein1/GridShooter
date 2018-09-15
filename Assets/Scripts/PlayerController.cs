using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    List<GameObject> ggrid;
    int xind;
    int yind;
	// Use this for initialization
	void Start () {
        ggrid = GameObject.Find("Platform").GetComponent<TileGenerator>().ggrid;
        xind = 0;
        yind = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("d") && yind < 2)
        {
            yind += 1;
        }
        if(Input.GetKeyDown("w") && xind < 2)
        {
            xind += 1;
        }
        if(Input.GetKeyDown("a") && yind > 0)
        {
            yind -= 1;
        }
        if(Input.GetKeyDown("s") && xind > 0)
        {
            xind -= 1;
        }
        this.transform.position = ggrid[yind*3+xind].transform.position; //yind * 2 + xind

    }
}
