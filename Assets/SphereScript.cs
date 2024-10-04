using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    private const float MAX_POWER = 100.0f;

    private Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float randomX = Random.Range(-MAX_POWER, MAX_POWER);
            float randomY = Random.Range(-MAX_POWER, MAX_POWER);
            float randomZ = Random.Range(-MAX_POWER, MAX_POWER);

            rigidBody.AddForce(new Vector3(randomX, randomY, randomZ));
        }
    }
}
