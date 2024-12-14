using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    [Header("UI")]

    public GameObject gameOverUI;
    public GameObject winGameUI;
    public GameObject startGameUI;

    public AudioManager audioManager;

    [Header("Lanterns")]

    public TMP_Text textLantern;
    public List<GameObject> lanterns = new List<GameObject>();
    public int lanternCount= -1;

    [Header("Game State")]

    public bool gameOver = false;
    public bool gameStart = false;

    void Start()
    {
        gameOverUI.SetActive(false);
        winGameUI.SetActive(false);
        startGameUI.SetActive(true);


        UpdateCount();
    }
    void Update()
    {
        if(lanternCount >= lanterns.Count)
        {
            WinGame();
        }
    }

    public void GameOver()
    {
        if (!gameOver)
        {
            gameOverUI.SetActive(true);
            audioManager.PlayDeath();
        }
       
        gameOver = true;
    }

    public void WinGame()
    {
        gameStart = false;
        winGameUI.SetActive(true);
    }
    public void StartOver()
    {
        //resets game back to start. update to just restart the gameobject if time
        Debug.Log("Clicked");

        Scene gameScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(gameScene.name);

    }
    public void GameStart()
    {
        gameStart = true;
        startGameUI.SetActive(false);
    }

    public void UpdateCount()
    {
        if (lanternCount >= 0)
        {
            audioManager.PlayLantern();
        }
        lanternCount++;
        textLantern.text = lanternCount.ToString() + " / " + lanterns.Count.ToString();
    } 
}
