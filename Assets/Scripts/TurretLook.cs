using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretLook : MonoBehaviour
{
    public Transform Target;
    public float RotationSpeed;
    private Quaternion lookRotation;
    private Vector3 targetDirection;


    // Update is called once per frame
    void Update()
    {
        lookRotation = Quaternion.LookRotation(Target.position - transform.position);
        transform.rotation = lookRotation;

    }
}
