using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMoving : MonoBehaviour
{
     GameObject soundManager;

    Rigidbody2D rb;
    float power = 3.5f;

    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        soundManager = GameObject.Find("Sound Manager");
    }

   
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            soundManager.GetComponent<SoundManager>().SoundPlay("JUMP");
            rb.velocity=Vector2.up*power;
        }
    }
    /*
    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(GameOver());
    }
    
    IEnumerator GameOver()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("GameOver");
    }
    */
}
