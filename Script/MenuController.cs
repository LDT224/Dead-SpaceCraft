using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
    public Button btnStart;
    public Text txtHighScore;
    public GameObject pnlHighScore;
    void Start()
    {
        pnlHighScore.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void HighScore()
    {
        pnlHighScore.SetActive(true);
        txtHighScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
}
