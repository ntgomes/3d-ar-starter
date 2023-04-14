using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractCube : MonoBehaviour
{
    public GameObject cubeToPlace;

    private Rigidbody interactingObj;

    private Ray ray;

    private RaycastHit hit;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // If I press left click on my mouse...
        {
            if (Physics.Raycast (ray, out hit)) // If the line from the camera to the mouse touched something on the scene...
            {
                if (hit.collider.gameObject.tag.Equals("Ground")) {
                    // TODO: Your code - Deactivate the interactingObj if there is one -> turn back on its gravity and then set it to null

                    // TODO: Your code - Then create the cubeToPlace at the mouse's position (hint: see PlaceCube.cs for how this is done)
                } else if (hit.collider.gameObject.tag.Equals("Interactable") && interactingObj == null) // If you clicked on an "Interactable" object
                {
                    interactingObj = hit.collider.gameObject.GetComponent<Rigidbody>(); // Set the interactingObject to the object you clicked on
                }
            } else 
            {
                // TODO: Your code - Deactivate the interactingObj if there is one -> turn back on its gravity and then set it to null
            }
        }
        


        // Bonus: What if you're right-clicking?
        //    https://docs.unity3d.com/ScriptReference/Input.GetMouseButtonDown.html
    }
}

///////
// CODE BLOCK BANK
//
// Use the below lines of code to help complete this script!
// 
// 1. Get the cube to move to where the mouse is if it's being interacted with:
//      if (interactingObj) 
//      {
//          interactingObj.useGravity = false;
//          interactingObj.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z));
//      }
// 
// 2. Cast a line from the camera to the mouse's click, used to indicate where the mouse clicked and if that line touches something:
//        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//        hit = new RaycastHit();
//
// 3. If the line drawn from the camera to the mouse's click touches something
//        if (Physics.Raycast (ray, out hit)) { }
//
//////