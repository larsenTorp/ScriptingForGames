using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Color newCOlor = Color.red;

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Renderer>().material.color = newCOlor;
    }
}
