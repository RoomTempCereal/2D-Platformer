using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target; // drag to insoector
    Vector3 tempVec3 = new Vector3(); // Temporary vector 3.

    void LateUpdate()
    {
        // If the target is active in the scene, set the x camera position to target.
        if (Target != null)
        {

            //z axis
            tempVec3.x = Target.position.x;
            tempVec3.y = this.transform.position.y;
            tempVec3.z = this.transform.position.z;
            this.transform.position = tempVec3;
            
            //y axis
            tempVec3.y = Target.position.y;
            tempVec3.z = this.transform.position.z;
            tempVec3.x = this.transform.position.x;
            this.transform.position = tempVec3;
        }

    }
}
