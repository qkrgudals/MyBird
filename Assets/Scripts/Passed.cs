using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passed : MonoBehaviour
{

    GameManager gameManager;
    GameObject soundManager;

    // Start is called before the first frame update
    void Start()
    {
        soundManager = GameObject.Find("Sound Manager");    
       gameManager=FindObjectOfType<GameManager>();
    }

    // Update is called once per frame

    private void OnTriggerExit2D(Collider2D collision)
    {
        soundManager.GetComponent<SoundManager>().SoundPlay("PASS");
        gameManager.SetScore();
    }
}
