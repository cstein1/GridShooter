using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGenerator : MonoBehaviour {

    public GameObject gtile;
    public GameObject btile;
    public List<GameObject> ggrid = new List<GameObject>();
    public List<GameObject> bgrid = new List<GameObject>();
    // Use this for initialization
    void Start () {
        float scale = 1.6f;

        for (int i = 0; i<3; i++)
        {
            for (int j = -1; j<2; j++)
            {
                Vector3 v = new Vector3(i*scale, j* scale, 0);
                GameObject sqr = Instantiate(gtile, v, Quaternion.identity);
                sqr.transform.parent = this.transform;
                bgrid.Add(sqr);
            }
        }

        for (int i = -3; i < 0; i++)
        {
            for (int j = -1; j < 2; j++)
            {
                Vector3 v = new Vector3(i* scale, j* scale, 0);
                GameObject sqr = Instantiate(btile, v, Quaternion.identity);
                sqr.transform.parent = this.transform;
                ggrid.Add(sqr);
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    float map(float value, float istart, float istop, float ostart, float ostop)
    {
        return ostart + (ostop - ostart) * ((value - istart) / (istop - istart));
    }
}