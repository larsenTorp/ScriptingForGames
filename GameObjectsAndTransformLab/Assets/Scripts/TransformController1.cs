using UnityEngine;

public class TransformController : MonoBehaviour
{

    private void Update()
    {
        // Move the target GameObject
        var x = Mathf.PingPong(t: Time.time, length: 3);
        var r = Mathf.PingPong(t: Time.time, length: 9);
        var p = new Vector3(x: x, y: x, z: 0);
        transform.position = p;
 

        // Rotate target GameObject
        transform.Rotate(new Vector3(0, r*10, r*10) * Time.deltaTime);
    }
}
