using UnityEngine;

public class Wheel : MonoBehaviour
{
    [SerializeField] Transform wheelTransform;

    [SerializeField] bool isSteer;
    [SerializeField] bool isInvertSteer;
    [SerializeField] bool isPower;

    [SerializeField] float steerAngle;
    [SerializeField] float motorToque;

    WheelCollider wheelCollider;

    void Start()
    {
        wheelCollider = GetComponent<WheelCollider>();
    }

    void Update()
    {
        wheelCollider.GetWorldPose(out Vector3 pos, out Quaternion rotate);
        wheelTransform.position = pos;
        wheelTransform.rotation = rotate*Quaternion.Euler(0,-90f,0);
    }

    void FixedUpdate()
    {
        if(isSteer)
        {
            wheelCollider.steerAngle = steerAngle * (isInvertSteer ? -1: 1);
        }
        if(isPower)
        {
            wheelCollider.motorTorque = motorToque;
        }
    }

    public void ChangeMotorTorque(float value)
    {
        motorToque = value;
    }

    public void ChangeSteerAngle(float value)
    {
        steerAngle = value;
    }
}
