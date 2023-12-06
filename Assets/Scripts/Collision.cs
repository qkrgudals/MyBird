using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    GameObject soundManager;
    // Start is called before the first frame update
    void Start()
    {
        soundManager = GameObject.Find("Sound Manager");
    }

   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //죽었다는 사운드 효과 플레이
        if (collision.gameObject.tag == "Player")
        {
            soundManager.GetComponent<SoundManager>().SoundPlay("DIE");
        }
        //죽음 자리??

    }
    
}
