using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreGame : MonoBehaviour
{
    public int Score;
    public Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Score >= 5)
        {
            YouWin();
            
        }
    }
    void YouWin()
    {
        ScoreText.text = "You win!";
        Time.timeScale = 0f;
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        AddScore();
    }
    void AddScore()
    {
        Score++;
        ScoreText.text = Score.ToString();
    }
    }

