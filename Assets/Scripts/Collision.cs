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
        //�׾��ٴ� ���� ȿ�� �÷���
        if (collision.gameObject.tag == "Player")
        {
            soundManager.GetComponent<SoundManager>().SoundPlay("DIE");
        }
        //���� �ڸ�??

    }
    
}
