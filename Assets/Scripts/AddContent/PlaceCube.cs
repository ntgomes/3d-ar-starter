using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceCube : MonoBehaviour
{
    public GameObject cubeToPlace;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) { // If I press left click on my mouse...
            
        }
    }
}


///////
// CODE BLOCK BANK
//
// Use the below lines of code to help complete this script!
// 
// 1. Generate the cube to place:
//        Instantiate(cubeToPlace, new Vector3(hit.point.x, hit.point.y + 1.0f, hit.point.z), Quaternion.identity);
// 
// 2. Cast a line from the camera to the mouse's click, used to indicate where the mouse clicked:
//        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//
// 3. If the line drawn from the camera to the mouse's click touches something
//        if (Physics.Raycast (ray, out hit)) { }
//
// 4. Needed in order to check if a line from a camera touches something
//        RaycastHit hit = new RaycastHit();
//////
