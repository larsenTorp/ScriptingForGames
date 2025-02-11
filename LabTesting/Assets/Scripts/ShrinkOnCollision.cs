using UnityEngine;

public class ShrinkOnCollision : MonoBehaviour
{
    public float shrinkFactor = 0.99f;

    private void OnCollisionEnter(Collision collision)
    {
        
        transform.localScale *= shrinkFactor;
    }
}
