using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private GameManager gameManager;

    private int score = 0;

    bool collidedWithPins = false;

    private AudioSource audioSource;

    public AudioClip strikeSound;

    public AudioClip spareSound;

    public AudioClip gutterSound;

    int frameNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PitFloor")
        {
            //Pin[] pins = FindObjectsOfType<Pin>();

            StopAllCoroutines();
            StartCoroutine(CheckPinsAfterDelay());
        }
        else if (collision.gameObject.tag == "Pin")
        {
            if (!collidedWithPins)
            {
                audioSource.PlayOneShot(strikeSound);
                collidedWithPins = true;
            }
        }
    }

    IEnumerator CheckPinsAfterDelay()
    {
        yield return new WaitForSeconds(3.0f);
        gameManager.CheckPins();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
