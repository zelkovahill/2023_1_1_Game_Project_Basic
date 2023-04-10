using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wjdals : MonoBehaviour
{
    public GameObject Tile_001;
    public GameObject Tile_002;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                GameObject temp = (GameObject)Instantiate(Tile_001);
                temp.transform.position = new Vector3(i, 0, j);
            }
            for (int j = 10; j < 20; j++)
            {
                GameObject temp = (GameObject)Instantiate(Tile_002);
                temp.transform.position = new Vector3(i, 0, j);
            }
        }



    }
}
    
    // Update is called once per frame
   