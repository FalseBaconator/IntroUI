using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{

    public int score;

    // Start is called before the first frame update
    void Awake()
    {
        GameObject[] these = GameObject.FindGameObjectsWithTag(gameObject.tag);
        if (these.Length > 1)
            Destroy(this);
        DontDestroyOnLoad(this);
    }


}
