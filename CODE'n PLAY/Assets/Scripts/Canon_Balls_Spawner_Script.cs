using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon_Balls_Spawner_Script : MonoBehaviour {
    [SerializeField] private GameObject canonballs;
    private float max_z_e;
    private float min_z_e;
    private float max_x_e;
    private float min_x_e;
    private float timer = 10f;
    // Use this for initialization
    void Start () {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        max_z_e = player.GetComponent<Player_Sphere_Script>().max_z;
        min_z_e = player.GetComponent<Player_Sphere_Script>().min_z;
        max_x_e = player.GetComponent<Player_Sphere_Script>().max_x;
        min_x_e = player.GetComponent<Player_Sphere_Script>().min_x;
        StartCoroutine(Canon_Spawner());
	}
	
	// Update is called once per frame
	void Update () {
		if(timer>6f && Random.Range(1, 5) * Time.deltaTime == 1)
        {
            timer -= 0.1f;
        }
	}
    IEnumerator Canon_Spawner()
    {
        while (true)
        {
           
            Instantiate(canonballs, new Vector3(Random.Range(min_x_e, max_x_e), 7.1f, Random.Range(min_z_e, max_z_e)), Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(3f, timer));
        }
    }
}
