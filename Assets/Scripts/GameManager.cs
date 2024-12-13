using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    [Header("UI")]

    public GameObject gameOverUI;
    public GameObject winGameUI;
    public GameObject startGameUI;

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
        
    }

    public void GameOver()
    {
        gameOverUI.SetActive(true);
    }

    public void WinGame()
    {
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
        lanternCount++;
        textLantern.text = lanternCount.ToString() + " / " + lanterns.Count.ToString();
    } 
}
