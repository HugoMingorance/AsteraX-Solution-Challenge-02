using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    
    private int score = 0;
    public TextMeshProUGUI scoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void increaseScore(int increment)
    {
        
        score += increment;
        Debug.Log("Current number of score" + score);
        scoreText.text = "Score: " + score;

    }
}
