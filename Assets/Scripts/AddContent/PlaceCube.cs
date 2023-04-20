using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceCube : MonoBehaviour
{
    public GameObject cubeToPlace;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) { // Did I press left click on my mouse...
            // If so, then...

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // Create a line from the camera to where the mouse is
            RaycastHit hit = new RaycastHit(); // Used for checking if the line touches something

            if (Physics.Raycast (ray, out hit)) { // Does my line touch something where the mouse was? Like a plane?
                // If so, then...
                
            }

        }
    }
}


/*
  TODO: Copy and paste the below line of code inside the right place on the code above!
  Instantiate(cubeToPlace, new Vector3(hit.point.x, hit.point.y + 1.0f, hit.point.z), Quaternion.identity);
*/
