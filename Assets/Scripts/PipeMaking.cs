using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMaking : MonoBehaviour
{
    public GameObject pipe;
    float timer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newPipe = Instantiate(pipe);
        //newPipe.transform.localScale = new Vector3(1.0f, Random.Range(1.0f, 2.5f), 1.0f);
        newPipe.transform.position = new Vector3(0.0f, Random.Range(-1.5f, 2.3f), 0.0f);
        Destroy(newPipe, 8.0f);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
       
        if(timer>2.3f)
        {
            GameObject newPipe = Instantiate(pipe);
            //newPipe.transform.localScale = new Vector3(1.0f, Random.Range(1.0f, 2.5f), 1.0f);
            newPipe.transform.position = new Vector3(0.0f, Random.Range(-1.5f, 2.3f), 0.0f);
            Destroy(newPipe, 8.0f);

            timer = 0.0f;
        }
    }
}
