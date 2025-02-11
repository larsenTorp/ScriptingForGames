using UnityEngine;

public class ApplyForce : MonoBehaviour
{
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();


        rb.AddForce(Vector3.up * 500);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        rb.AddForce(Vector3.up * 200);
    }

}
