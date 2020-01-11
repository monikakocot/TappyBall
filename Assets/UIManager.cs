using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour
{

    public static UIManager instance;
    public Text scoreText;
    public GameObject gameOverPanel;
    public GameObject startUI;
    public GameObject gameOverText;
    public Text highScoreText;
    // Start is called before the first frame update

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = ScoreManager.instance.score.ToString();
    }

    public void GameStart()
    {
        startUI.SetActive(false);
    }
    public void GameOver()
    {
        gameOverText.SetActive(true);
        highScoreText.text = "HighScore: " + PlayerPrefs.GetInt("HighScore").ToString();
        gameOverPanel.SetActive(true);
    }

    public void Replay ()
    {
        SceneManager.LoadScene("level1");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
