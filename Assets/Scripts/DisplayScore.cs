using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisplayScore : MonoBehaviour
{
    public int pScore = 0;

    public Text curText;

    void Update()
    {
        curText.text = pScore.ToString();
    }

    public void addScore()
    {
        pScore += 10;
    }
}
