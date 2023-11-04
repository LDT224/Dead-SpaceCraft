using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject pnlEndGame;
    public Button btnReplay;
    public Text txtScore;
    public Text txtEndScore;
    public Text txtHighScore;
    public int gameScore;
    public Button btnMenu;
    public AdsManager ads;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        pnlEndGame.SetActive(false);
        txtHighScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        //ads.ShowBanner();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void GetPoint()
    {
        gameScore++;
        txtScore.text = "Score: " + gameScore.ToString();
        if (gameScore > PlayerPrefs.GetInt("HighScore", 0)) 
        {
            PlayerPrefs.SetInt("HighScore",gameScore);
            txtHighScore.text = gameScore.ToString();
        }
    }
    
    public void ReplayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    public void EndGame()
    {
        Time.timeScale = 0;
        pnlEndGame.SetActive(true);
        txtScore.text = "";
        txtEndScore.text = "Score: " + gameScore.ToString();
        txtHighScore.text = "High Score: " + PlayerPrefs.GetInt("HighScore",0);
        if(gameScore > 15)
        {
            //ads.PlayAd();
        }
    }
}
