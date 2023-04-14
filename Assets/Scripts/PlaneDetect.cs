using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneDetect : MonoBehaviour
{
    public GameObject plane;

    public float threshold = 40.0f;

    // Update is called once per frame
    void Update()
    {
        if(Camera.main.transform.eulerAngles.y > (-1 * threshold) && Camera.main.transform.eulerAngles.y < threshold) {
            plane.SetActive(true);
        } else {
            plane.SetActive(false);
        }
    }
}
