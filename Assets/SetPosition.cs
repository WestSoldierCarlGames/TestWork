using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetPosition : MonoBehaviour
{
    public Slider x;
    public Slider y;
    public Slider z;
    public static SetPosition Instance;
    [SerializeField] Button set;
    // Start is called before the first frame update
    void Start()
    {
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
}