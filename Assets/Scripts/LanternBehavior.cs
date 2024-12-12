using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LanternBehavior : MonoBehaviour
{
    public GameObject lanternLight;
    public Light myLight;

    public SphereCollider myCollider;

    public bool isOn;

    float endTime = 0;
    float t = 1;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        lanternLight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (endTime != 0 && Time.time > endTime)
        {
            enemy.gameObject.GetComponent<EnemyBehavior>().inLight = false;
            DisableLight();
        }

        if (isOn)
        {
            t -= 0.1f * Time.deltaTime;
            myLight.intensity= Mathf.Lerp(0, 1, t);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            lanternLight.SetActive(true);
            isOn = true;

            endTime = Time.time + 5;
            
        }
        if (other.gameObject.tag == "Enemy")
        {
            other.gameObject.GetComponent<EnemyBehavior>().inLight = true;
        }
    }


    public void DisableLight()
    {
        myCollider.gameObject.SetActive(false);
    }
}