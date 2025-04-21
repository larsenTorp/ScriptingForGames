using UnityEngine;

public class HealthContainer : MonoBehaviour
{
    public SimpleFloatData healthData;

    public void reduceHealth(float amount)
    { 
        healthData.UpdateValue(amount);
    }
}
