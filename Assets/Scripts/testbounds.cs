using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace toolmanager {
    public class testbounds : MonoBehaviour
    { 
        // Update is called once per frame
        void OnMouseUpAsButton()
        {
            //Debug.Log()
            if(ToolManager.Instance.selected !=null)
                ToolManager.Instance.PutNew(gameObject);
    
        }
    }
}