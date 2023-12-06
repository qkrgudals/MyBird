using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerDie : MonoBehaviour
{
    GameObject soundManager;
    // Start is called before the first frame update
    void Start()
    {
        soundManager = GameObject.Find("Sound Manager");
    }
    private void Update()
    {
        if(transform.position.x <= -2.3f)
        {
            soundManager.GetComponent<SoundManager>().SoundPlay("DIE");
            StartCoroutine(GameOver());
        }
    }
    IEnumerator GameOver() {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("GameOver");
    }

}
