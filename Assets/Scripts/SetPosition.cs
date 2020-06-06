using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetPosition : MonoBehaviour
{
    private const string coordX = "x";
    private const string coordY = "y";
    private const string coordZ = "z";
    [SerializeField] Slider x;
    [SerializeField] Slider y;
    [SerializeField] Slider z;
    [SerializeField] Text currentX_txt;
    [SerializeField] Text currentY_txt;
    [SerializeField] Text currentZ_txt;
    public static SetPosition Instance;
    [SerializeField] Button set;
    // Start is called before the first frame update
    void Start()
    {
        x.onValueChanged.AddListener(delegate { ChangeValue(coordX); });
        y.onValueChanged.AddListener(delegate { ChangeValue(coordY); });
        z.onValueChanged.AddListener(delegate { ChangeValue(coordZ); });
        x.minValue = 0f;
        x.maxValue = 1f;
        x.value = 0.5f;
        y.minValue = 0f;
        y.maxValue = 1f;
        y.value = 0.5f;
        z.minValue = 0f;
        z.maxValue = 1f;
        z.value = 0.5f;
        set.onClick.AddListener(() => toolmanager.ToolManager.Instance.SetValues(x.value,y.value,z.value));
        gameObject.SetActive(false);

    }
    void ChangeValue(string coord)
    {
        switch (coord)
        {
            case "x":
                currentX_txt.text = x.value.ToString();
                break;
            case "y":
                currentY_txt.text = y.value.ToString();
                break;
            case "z":
                currentZ_txt.text = z.value.ToString();
                break;
        }
    }

}