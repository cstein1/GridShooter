using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour {

    public Bullet bullet;
    public List<Bullet> bullets;
    public float fireRate;
    private float lastShot = 0.0f;
    bool gplayer;

    // Use this for initialization
    void Start () {
        bullets = new List<Bullet>();
        gplayer = gameObject.transform.parent.GetComponent<PlayerController>().gplayer;
    }
	
	// Update is called once per frame
	void Update () {
        string str;
        if (gplayer)
            str = "space";
        else
            str = "return";
        if (Input.GetKeyDown(str) && Time.time > fireRate + lastShot)
        {
            lastShot = Time.time;
            var bull = Instantiate(bullet, new Vector3(this.transform.position.x, this.transform.position.y, -1), Quaternion.identity);
            bull.gplayer = gplayer;
            bullets.Add(bull);
        }
    }
}
