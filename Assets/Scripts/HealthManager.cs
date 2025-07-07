using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using
UnityEngine.SceneManagement;


public class HealthManager : MonoBehaviour
{
    public int healthPoints;
    public int maxHealthPoints;
    public UiManager uiManager;
    public GameObject LooseTxt;
    public GameObject Player;
    void Start()
    {
        healthPoints = maxHealthPoints;
        uiManager = FindObjectOfType<UiManager>();
        LooseTxt.SetActive(false);
    }

    void Update()
    {

    }
    public void TakeDamage(int damagePoints)
    {
        if (healthPoints > damagePoints)
        {
            healthPoints -= damagePoints;
            uiManager.UpdateHealth(healthPoints);
        }
        else
        {

            uiManager.UpdateHealth(0);
            LooseTxt.SetActive(true);
            Debug.Log("Game Over");
            Invoke(nameof(RestartGame), 1f);
        }
    }
    void RestartGame()
    {
        SceneManager.LoadScene("FPS parkour");
    }

}
