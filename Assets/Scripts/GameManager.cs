using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Net.Sockets;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
     int score = 0;
     int bestScore = 0;
  
    //[SerializeField]
    static TextMeshProUGUI scoreText;
    //GameObject scoreText;
    private void Awake()
    {
        //var managerCnt=FindObjectsOfType<GameManager>();
        scoreText = GameObject.FindGameObjectWithTag("GameScore").GetComponent<TextMeshProUGUI>();
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
       
        //score = 0;
       // scoreText = GameObject.FindGameObjectWithTag("GameScore").GetComponent<TextMeshProUGUI>();
    }
  

    // Update is called once per frame
    void FixedUpdate()
    {
        
        scoreText.text = "Score:"+ score.ToString();
    }

    public void SetScore()
    {
        score++;
        if (score >= bestScore)
        {
            bestScore = score;
        }
    }

    public void InitScore()
    {
        score = 0;
    }
    public int GetScore()
    {
        return score;
    }

    public int GetBestScore()
    {
        return bestScore;
    }
  
}
