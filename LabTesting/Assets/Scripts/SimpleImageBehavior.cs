using UnityEngine;
using UnityEngine.UI;

public class SimpleImageBehavior : MonoBehaviour
{

    private Image imageObj;
    public SimpleFloatData dataObj;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        imageObj = GetComponent<Image>();
    }

    public void UpdateWithFloatData()
    {
        imageObj.fillAmount = dataObj.value;
    }

    private void Update()
    {
        UpdateWithFloatData();
    }
}
