using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.Analytics;

public class GameController : MonoBehaviour
{
    public GameObject player;
    
    private int score = 0;
    public TextMeshProUGUI scoreText;

    private int jumps = 3;
    public TextMeshProUGUI jumpsText;

    public float rangex;
    public float rangey;
    
    public GameObject GameOverPanel;
    public TextMeshProUGUI GameOverText;
    public TextMeshProUGUI PressRToRestart;

    
    // Start is called before the first frame update
    void Start()
    {
        
        player = GameObject.FindGameObjectWithTag("Player");
        
        GameOverPanel.SetActive(false);
        GameOverText.text = "";
        PressRToRestart.text = "";
        
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
        
        player.GetComponent<PlayerShip>().Respawn(rangex, rangey);
        
    }

    public void gameOver()
    {
        Debug.Log("Game Over");
        GameOverPanel.SetActive(true);
        GameOverText.text = "GAME OVER";
        PressRToRestart.text = "PRESS R TO RESTART";
        Destroy(player);
    }
    
}
