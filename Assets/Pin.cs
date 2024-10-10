using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    public bool hasFallen = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
       // Debug.Log("PIN COLLIDED WITH: " + other.gameObject.name);
        if (other.gameObject.tag == "Alley" || other.gameObject.tag == "PitFloor" || other.gameObject.tag == "PitWall")
        {
            hasFallen = true;
        }
       // Debug.Log("PIN NAME: " + gameObject.name + "   HAS FALLEN? " + hasFallen);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
