using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ButtonCode : MonoBehaviour
{
    GameObject scoreKeeper;
    public TextMeshProUGUI text;

    private void Start()
    {
        scoreKeeper = GameObject.FindGameObjectWithTag("ScoreKeeper");
        if(text != null)
            text.text = scoreKeeper.GetComponent<ScoreKeeper>().score.ToString();
    }

    public void Play()
    {
        Debug.Log("Play");
    }

    public void Credits()
    {
        Debug.Log("Credits");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void changeScore(int toChange)
    {
        scoreKeeper.GetComponent<ScoreKeeper>().score += toChange;
        if (scoreKeeper.GetComponent<ScoreKeeper>().score < 0)
            scoreKeeper.GetComponent<ScoreKeeper>().score = 0;
        text.text = scoreKeeper.GetComponent<ScoreKeeper>().score.ToString();
    }

    public void RandomScore()
    {
        changeScore(Random.Range(-25, 25));
    }

    public void ChangeScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }

}
