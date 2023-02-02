using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeOfDayAndNight : MonoBehaviour
{
    public float rotation;

    public Transform DirectionalLight;

    void Start()
    {
        rotation = 0.003f;
    }

    void Update()
    {
        DirectionalLight.Rotate(rotation * new Vector3(1, 0, 0));
    }
}

