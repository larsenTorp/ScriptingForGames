using UnityEngine;
using TMPro;
using System.Globalization;

[RequireComponent(typeof(TextMeshProUGUI))]

public class SimpleTextMeshProBehavior : MonoBehaviour
{

    private TextMeshProUGUI textObj;
    public SimpleIntData dataObj;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        textObj = GetComponent<TextMeshProUGUI>();
        UpdateWithIntData();
    }

    public void UpdateWithIntData()
    {
        textObj.text = dataObj.value.ToString(CultureInfo.InvariantCulture);
    }

    public void Update()
    {
        UpdateWithIntData();
    }
}
