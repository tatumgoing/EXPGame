using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
//using System.Diagnostics;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public GameManager manager;

    public float moveSpeed=5;
    public GameObject target;

    public bool inLight=false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!inLight && !manager.gameOver && manager.gameStart)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, moveSpeed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            manager.GameOver();
        }
    }

    public float GetDistance()
    {
        return Vector3.Distance(transform.position, target.transform.position);
    }

}
