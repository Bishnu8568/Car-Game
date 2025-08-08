using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarFollower : MonoBehaviour
{
    public Transform carTransform;
    // Start is called before the first frame update
    void LateUpdate()
    {
        transform.position = new Vector3(carTransform.position.x, carTransform.position.y, -10f);
        
    }
}