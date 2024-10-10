using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;
        Debug.Log("ADD " + scoreToAdd + " TO THE SCORE");
        Debug.Log("NEW SCORE: " + score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
