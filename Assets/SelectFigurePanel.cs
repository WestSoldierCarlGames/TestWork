using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectFigurePanel : MonoBehaviour
{
    [SerializeField]Button cube_btn;
    [SerializeField] Button sphere_btn;
    [SerializeField] Button capsule_btn;
    [SerializeField] Button cylinder_btn;
    [SerializeField] GameObject sphere;
    [SerializeField] GameObject cube;
    [SerializeField] GameObject cylinder;
    [SerializeField] GameObject capsule;

    // Start is called before the first frame update
    void Awake()
    {
        sphere_btn.onClick.AddListener(() => toolmanager.ToolManager.Instance.SelectObject(sphere));//selected = sphere); //= objects[1]);// ;/ ;
        cube_btn.onClick.AddListener(() => toolmanager.ToolManager.Instance.SelectObject(cube));
        cylinder_btn.onClick.AddListener(() => toolmanager.ToolManager.Instance.SelectObject(cylinder));
        capsule_btn.onClick.AddListener(() => toolmanager.ToolManager.Instance.SelectObject(capsule));
    }

}

