using UnityEngine;

public class HealthContainer : MonoBehaviour
{
    public SimpleFloatData healthData;

    private void Start()
    {
        healthData.SetValue(1);
    }

    public void reduceHealth(float amount)
    { 
        healthData.UpdateValue(amount);
    }
}
