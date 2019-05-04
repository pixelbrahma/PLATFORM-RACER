using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    private void FixedUpdate()
    {
        transform.position += new Vector3(0, 0.02f, 0);
    }
}
