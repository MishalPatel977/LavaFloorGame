using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformRotate : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 rotateChange;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      transform.Rotate (rotateChange);  
    }
}
