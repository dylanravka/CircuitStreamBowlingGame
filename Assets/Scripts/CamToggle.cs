using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamToggle : MonoBehaviour
{
    public Camera mainCam;
    public Camera pinCam;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            SwitchCamera(true);
        }
    }

    private void SwitchCamera(bool toPinCam)
    {
        pinCam.enabled = toPinCam;
        mainCam.enabled = !toPinCam;
        if (toPinCam)
        {
            StartCoroutine(SwitchToMainCamAfterDelay(3.0f));
        }
    }

    IEnumerator SwitchToMainCamAfterDelay(float pDelay)
    {
        yield return new WaitForSeconds(pDelay);
        SwitchCamera(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
