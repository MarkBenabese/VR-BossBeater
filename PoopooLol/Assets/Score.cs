using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score = 0;
    public Text text;

    public void Add(int amount)
    {
        score += amount;
        UpdateDisplay();
    }

    void Start()
    {
        score = 0;
    }

    void UpdateDisplay()
    {
        text.text = "Score " + score;
    }
}