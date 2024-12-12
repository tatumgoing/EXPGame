using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Stacker : MonoBehaviour
{

    public List<GameObject> mazeTiles= new List<GameObject>();
    public float size;

    // Start is called before the first frame update
    void Start()
    {
        mazeTiles = mazeTiles.OrderBy(x => Random.value).ToList();


        float index = 0;
        foreach (GameObject tile in  mazeTiles)  
        {
            tile.transform.position= new Vector3(0,-1,-1*index*size);
            index++;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
