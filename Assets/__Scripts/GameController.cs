using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.Analytics;

public class GameController : MonoBehaviour
{
    
    private int score = 0;
    public TextMeshProUGUI scoreText;

    private int jumps = 3;
    public TextMeshProUGUI jumpsText;
    
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (jumps <= 0)
        {
            gameOver();
        }
    }

    public void increaseScore(int increment)
    {
        
        score += increment;
        Debug.Log("Current number of score" + score);
        scoreText.text = "Score: " + score;

    }
    
    public void damage()
    {
        
        jumps -= 1;
        Debug.Log("Current number of jumps: " + jumps);
        jumpsText.text = "Jumps: " + jumps;
        
    }

    public void gameOver()
    {
        Debug.Log("Game Over");
    }
    
}
