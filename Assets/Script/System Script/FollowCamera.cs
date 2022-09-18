using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject point;

    void Update()
    {
        transform.RotateAround
            (
               point.transform.position,
               Vector3.up,
               10 * Time.unscaledDeltaTime
            ); 
    }
}
