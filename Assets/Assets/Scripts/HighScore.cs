using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text highScore;
    public int highScoree;
    void Start()
    {
        if(MergeFruit.score_count > highScoree)
        {
            highScoree = MergeFruit.score_count;
        }
        highScore.text = highScoree.ToString();
    }

    void Update()
    {
    }
}
