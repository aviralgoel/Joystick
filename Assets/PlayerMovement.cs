using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector2 Movement;
    public float walkingSpeed;
    public Transform CenterEyeView;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);

        Vector3 forward = CenterEyeView.forward;
        Vector3 right = CenterEyeView.right;

        forward.y = 0; right.y = 0;


        transform.position += forward * walkingSpeed * Movement.y * Time.deltaTime;
        transform.position += right * walkingSpeed * Movement.x * Time.deltaTime;
    }
}
