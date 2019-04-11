using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Canon_Ball_Script : MonoBehaviour {
    private int c;
    private GameObject player;
    private Vector3 pos;
    private float speed = 15f;
    private float counter = 0f;
	// Use this for initialization
	void Start () {
        c = Random.Range(0, 2);
        player = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        if (player != null)
        {


            pos = transform.position;

            if (c == 0)
            {
                pos.x += speed * Time.deltaTime;
                if (pos.x > player.GetComponent<Player_Sphere_Script>().max_x + 15)
                {
                    speed = -speed;
                }
                else
                {
                    if (pos.x < player.GetComponent<Player_Sphere_Script>().min_x - 15)
                    {
                        speed = -speed;
                    }
                }
                pos.x += speed * Time.deltaTime;
            }
            if (c == 1)
            {

                if (pos.z > player.GetComponent<Player_Sphere_Script>().max_z)
                {
                    speed = -speed;
                }
                else
                {
                    if (pos.z < player.GetComponent<Player_Sphere_Script>().min_z)
                    {
                        speed = -speed;
                    }
                }
                pos.z += speed * Time.deltaTime;
            }
            transform.position = pos;
            counter += Time.deltaTime;
            if (counter > 10f)
            {
                Destroy(gameObject);
            }
            if (Random.Range(0, 10) * Time.deltaTime == 5)
            {
                speed++;
            }
        }
        
	}
    public void OnTriggerEnter(Collider other)
    {
        
            if ((gameObject != null) && (other.gameObject.tag == "Player"))

            {
               
                Destroy(other.gameObject);
                SceneManager.LoadScene("Game_Over");
            }
        
    }
}
