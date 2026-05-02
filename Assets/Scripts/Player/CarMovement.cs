using UnityEngine;

public class CarMovement : MonoBehaviour
{
   [SerializeField] Transform center;

   [SerializeField] float motorTorque;
   [SerializeField] float maxSteer;
   
   float horizontal;
   float vertical;

   Rigidbody rb;
   
   [SerializeField] Wheel[] wheels;

   void Start()
   {
      rb = GetComponent<Rigidbody>();
      rb.centerOfMass = center.localPosition;
      wheels = GetComponentsInChildren<Wheel>();
   }

   void Update()
   {
      horizontal = Input.GetAxis("Horizontal");
      vertical = Input.GetAxis("Vertical");
      foreach(Wheel wh in wheels)
      {
         wh.ChangeSteerAngle(horizontal * maxSteer);
         wh.ChangeMotorTorque(-vertical * motorTorque);
      }
   }
}
