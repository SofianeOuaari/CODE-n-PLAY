using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_Cubes : MonoBehaviour {
    [SerializeField] private GameObject enemy;
    private float max_z_e;
    private float min_z_e;
    private float max_x_e;
    private float min_x_e;
	// Use this for initialization
	void Start () {
        StartCoroutine(Spawner_Cube());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
   public IEnumerator Spawner_Cube()
    {
        if (GameObject.FindWithTag("Player") != null)
        {
            while (true)
            {
                GameObject player = GameObject.FindGameObjectWithTag("Player");
                max_z_e = player.GetComponent<Player_Sphere_Script>().max_z;
                min_z_e = player.GetComponent<Player_Sphere_Script>().min_z;
                max_x_e = player.GetComponent<Player_Sphere_Script>().max_x;
                min_x_e = player.GetComponent<Player_Sphere_Script>().min_x;


                Instantiate(enemy, new Vector3(Random.Range(min_x_e, max_x_e), 7.1f, Random.Range(min_z_e, max_z_e)), Quaternion.identity);
                
                yield return new WaitForSeconds(Random.Range(5f, 8f));
            }
        }
    }
}
