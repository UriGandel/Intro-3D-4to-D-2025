using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class ScoreManager : MonoBehaviour
{
    public int score;
    public UiManager uiManager;
    public GameObject winTxt;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        uiManager = FindObjectOfType<UiManager>();
        winTxt.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void AddScore()
    {
            score++;
            uiManager.UpdateScore(score);
      
        
    }
    public void AddScore(int scorePoints)
    {
        if (score + scorePoints < 200)
        {
            score += scorePoints;
            uiManager.UpdateScore(score);
        } 
        else
        {
            winTxt.SetActive(true);
            Invoke(nameof(restartGame), 5f);
        }
        
    }
    void restartGame()
    {
        SceneManager.LoadScene("FPS parkour");

    }
}
