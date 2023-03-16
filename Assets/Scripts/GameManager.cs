using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score;
    public static int highScore;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;

    public Animator fadeScreen;

    private void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", highScore);
        highScoreText.text = "High Score:\n\n" + highScore.ToString();
    }

    public void StartGame()
    {
        fadeScreen.SetTrigger("FadeOut");
        StartCoroutine(LoadLevel(1));
    }

    public void Retry()
    {
        fadeScreen.SetTrigger("FadeOut");
        StartCoroutine(LoadLevel(1));
    }

    public void Quit()
    {
        fadeScreen.SetTrigger("FadeOut");
        StartCoroutine(LoadLevel(0));
    }

    public void QuitGame()
    {
        Application.Quit();
    }

        public void AddScore()
    {
        score += 1;
        scoreText.text = score.ToString();

        if(score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();
        }
    }

    public IEnumerator LoadLevel(int levelToLoad)
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(levelToLoad);
    }

}
