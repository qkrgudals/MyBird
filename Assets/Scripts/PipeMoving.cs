using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoving : MonoBehaviour
{
   
    public static float speed = 2.0f;
    // Start is called before the first frame update
    float timer = 0.0f;

    // Update is called once per frame
    void Update()
    {
        
        timer += Time.deltaTime;
        if (timer > 5.0f)
        {
            speed *= 1.05f;
         
            timer = 0.0f;
        
        }
        if (speed >= 21.0f) {
            speed = 20.0f;
        }

        transform.position += Vector3.left * speed * Time.deltaTime;
        Debug.Log(speed);
    }
    public void ResetSpeed()
    {
        speed = 2.0f;
    }
  
}
