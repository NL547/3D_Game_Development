using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicLightRotate : MonoBehaviour
{
    public float rotation;

    public Transform DynamicLight;

    void Start()
    {
        rotation = 0.3f;
    }

    void Update()
    {
        DynamicLight.Rotate(rotation * new Vector3(1, 0, 0));
    }
}
