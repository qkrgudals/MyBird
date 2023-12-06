using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    GameManager gameManager;

    [SerializeField]
    TextMeshProUGUI score;

    [SerializeField]
    TextMeshProUGUI bestScore;

    [SerializeField]
    PipeMoving pipeMovingScript;

    void Start()
    {
        gameManager = GameManager.instance;
        score.text = "Score: " + gameManager.GetScore().ToString();
        bestScore.text = "Best score: " + gameManager.GetBestScore().ToString();
    }

    public void Restart()
    {
        GameManager.instance.InitScore();
        // Remove this line, as it creates a new local variable, shadowing the class member.
        // PipeMoving pipeMovingScript = FindObjectOfType<PipeMoving>();
        pipeMovingScript.ResetSpeed();
        SceneManager.LoadScene("Play");
    }

    public void Close()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
