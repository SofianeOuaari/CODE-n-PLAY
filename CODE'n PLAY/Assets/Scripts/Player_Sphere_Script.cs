using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Sphere_Script : MonoBehaviour
{
    public float max_z = 45;
    public float min_z = -60;
    public float max_x = 125;
    public float min_x = -125;
    private int score = 0;
    private Vector3 pos;
    private float speed = 500f;
    
    // Use this for initialization
    void Start()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = new Color32(250, 5, 100, 250);
        
      
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            pos.z += speed * Time.deltaTime;
        }
        else

        {
            
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                pos.z -= speed * Time.deltaTime;
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    pos.x += speed * Time.deltaTime;
                }
                else
                {
                    if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {
                        pos.x -= speed * Time.deltaTime;
                    }
                }
            }
        }
        if (pos.z > max_z)
        {
            pos.z = min_z;
        }
        else
        {
            if (pos.z < min_z)
            {
                pos.z = max_z;
            }

        }
        if (pos.x > max_x)
        {
            pos.x = min_x;
        }
        else
        {
            if (pos.x < min_x)
            {
                pos.x = max_x;
            }
        }
        transform.position = pos;
       
       
        
    }
    public void score_increment()
    {
        score++;
    }
    public int get_score()
    {
        return this.score;
    }
}
