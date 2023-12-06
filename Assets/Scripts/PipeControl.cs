using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeControl : MonoBehaviour
{
    public GameObject pipe;
    public GameObject pipe1;
    public GameObject pipe2;
    float timer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newPipe = Instantiate(pipe);
        GameObject newPipe1 = Instantiate(pipe1);
        GameObject newPipe2 = Instantiate(pipe2);

        newPipe.transform.position = new Vector3(3.9f, 0.0f, 0.0f);
        newPipe2.transform.position = new Vector3(3.9f, Random.Range(2.8f, 6.3f), 0.0f);
        if (newPipe2.transform.position.y <= 6.3f)
        {
            newPipe1.transform.position = new Vector3(3.9f, Random.Range(-5.0f, -1.8f), 0.0f);
        }
        else if (newPipe2.transform.position.y <= 5.4f)
        {
            newPipe1.transform.position = new Vector3(3.9f, Random.Range(-5.0f, -2.7f), 0.0f);
        }
        else if (newPipe2.transform.position.y <= 4.48f)
        {
            newPipe1.transform.position = new Vector3(3.9f, Random.Range(-5.0f, -3.78f), 0.0f);
        }
        else if (newPipe2.transform.position.y <= 3.75f)
        {
            newPipe1.transform.position = new Vector3(3.9f, Random.Range(-5.0f, -4.58f), 0.0f);
        }
        Destroy(newPipe1, 8.0f);
        Destroy(newPipe2, 8.0f);
        Destroy(newPipe, 8.0f);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
 
        if (timer > 2.3f)
        {
            GameObject newPipe = Instantiate(pipe);
            GameObject newPipe1 = Instantiate(pipe1);
            GameObject newPipe2 = Instantiate(pipe2);

            newPipe.transform.position = new Vector3(3.9f,0.0f, 0.0f);
            newPipe2.transform.position = new Vector3(3.9f, Random.Range(2.8f, 6.3f), 0.0f);
            if (newPipe2.transform.position.y <= 6.3f)
            {
                newPipe1.transform.position = new Vector3(3.9f, Random.Range(-5.0f, -1.8f), 0.0f);
            }
            else if (newPipe2.transform.position.y <= 5.4f)
            {
                newPipe1.transform.position = new Vector3(3.9f, Random.Range(-5.0f, -2.7f), 0.0f);
            }
            else if (newPipe2.transform.position.y <= 4.48f)
            {
                newPipe1.transform.position = new Vector3(3.9f, Random.Range(-5.0f, -3.68f), 0.0f);
            }
            else if (newPipe2.transform.position.y <= 3.65f)
            {
                newPipe1.transform.position = new Vector3(3.9f, Random.Range(-5.0f, -4.58f), 0.0f);
            }
            Destroy(newPipe1, 8.0f);
            Destroy(newPipe2, 8.0f);
            Destroy(newPipe, 8.0f);
            timer = 0.0f;
        }
    }
}
