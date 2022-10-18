using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public Transform Level;
    public float Sensitivity;

    private Vector3 _previousMousePozition;

    void Update()
    {

       if  (Input.GetMouseButton(0))
        {
            Vector3 delta = Input.mousePosition - _previousMousePozition;
            Level.Rotate(0, -delta.x * Sensitivity, 0);
        }
        _previousMousePozition = Input.mousePosition;
    }
}
