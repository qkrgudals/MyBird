using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundAni : MonoBehaviour
{
    float speed = 4.0f;
   
    
    void Update()
    {
        transform.position += Vector3.left * speed*Time.deltaTime;

        if(transform.position.x<=-7.0f)
        {
            transform.position=new Vector3(6.8f,transform.position.y,transform.position.z);
        }
    }
}
