using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class shipGame : MonoBehaviour
{
    public static shipGame instance;
    int currentScore = 0;
    int highscore = 0;

    public Text hud_score;
    public Text highscoreText;

    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        hud_score.text = currentScore.ToString() + " Points";
        highscoreText.text = "Highscore: " + highscore.ToString();
    }

    // Update is called once per frame


    public void AddScore()
    {
        currentScore += 1;
        hud_score.text = currentScore.ToString() + " Points";
        if (highscore < currentScore)
        {
            PlayerPrefs.SetInt("highscore", currentScore);
        }

    }
}
