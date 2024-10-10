using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private GameManager gameManager;

    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("BALL COLLIDED WITH: " + collision.gameObject.name);
        if (collision.gameObject.tag == "PitFloor")
        {
            Pin[] pins = FindObjectsOfType<Pin>();

            Debug.Log("PINS LENGTH: " + pins.Length);
            for (int i = 0; i < pins.Length; i++)
            {
                Debug.Log("PIN NAME: " + pins[i].gameObject.name + "   HAS FALLEN? " + pins[i].hasFallen);
                if (pins[i].hasFallen)
                {
                    score++;
                    Debug.Log("INCREMENT SCORE TO NEW SCORE: " + score);
                }
            }



            Debug.Log("THE BALL LANDED IN THE PIT!");
            if (gameManager != null)
            {
                gameManager.AddScore(score);
            }
            else
            {
                Debug.Log("I THINK YOU MIGHT BE MISSING A GAME MANAGER");
            }

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
