using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameManager manager;

    [Header("Input")]
    public float vertInput;
    public float horInput;

    [Header("Speeds")]
    public float moveSpeed = 10f;
    public float rotSpeed = 360f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!manager.gameOver)
        {
            HandleMovement();
        }
    }

    public void HandleMovement()
    {
        
        vertInput = Input.GetAxis("Vertical");
        horInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * vertInput * moveSpeed * Time.deltaTime);
        transform.Translate(Vector3.right * horInput * moveSpeed * Time.deltaTime);
        transform.localEulerAngles= new Vector3 (0,0,0);
       
    }
}
