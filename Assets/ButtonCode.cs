using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonCode : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI text;

    private void Start()
    {
        text.text = score.ToString();
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
        score += toChange;
        if (score < 0)
            score = 0;
        text.text = score.ToString();
    }

    public void RandomScore()
    {
        changeScore(Random.Range(-25, 25));
    }

}
