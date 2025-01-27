using UnityEngine;

public class TransformController : MonoBehaviour
{

    private void Update()
    {
        // Move the target GameObject
        var x = Mathf.PingPong(t: Time.time, length: 3);
        var p = new Vector3(x: 0, y: x, z: 0);
            transform.position = p;

        // Rotate target GameObject
        transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime);
    }
}
