using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy_Script : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

        GetComponent<MeshRenderer>().material.color = new Color32((byte)(Random.Range(0, 255)), (byte)Random.Range(0, 255), (byte)Random.Range(0, 255), (byte)Random.Range(0, 255));
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        if (GameObject.FindWithTag("Player") != null)
        {
            if (other.gameObject.tag == "Player")
            {
                other.gameObject.GetComponent<Player_Sphere_Script>().score_increment();
                Destroy(gameObject);
            }
        }
    }
}
