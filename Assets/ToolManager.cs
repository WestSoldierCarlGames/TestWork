using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace toolmanager
{
    public class ToolManager : MonoBehaviour
    {
        public static ToolManager Instance;
        public List<GameObject> figures = new List<GameObject>();
        public GameObject selected;
        bool positionSelected=false;

        public GameObject selectFigure;
        public GameObject selectPosition;
        public GameObject confirm;
        public float[] values = new float[3];

        // Start is called before the first frame update
        void Start()
        {
            Instance = this;
            ConfirmPanel.Instance.OnConfirmPanelButtonPressed += _buttonPressed;
        }
        public void SelectObject(GameObject figure)
        {
            selected = figure;
            selectFigure.SetActive(false);
            selectPosition.SetActive(true);

        }
        // Update is called once per frame
        public void PutNew(GameObject wall)
        {
            if (positionSelected)
            {
                Vector3 newPosition = CalculatePosition(wall);//new Vector3(wall.GetComponent<Renderer>().bounds.min.x+(wall.GetComponent<Renderer>().bounds.max.x - wall.GetComponent<Renderer>().bounds.min.x) * 0.7f, 0f, 0f);//sliderx.value
                var ogdf = Instantiate(selected);
                figures.Add(ogdf);
                ogdf.transform.position = newPosition;
                confirm.SetActive(true);
                selected = null;
            }

        }
        public void SetValues(float a, float b, float c)
        {
            values[0] = a;
            values[1] = b;
            values[2] = c;
            selectPosition.SetActive(false);
            positionSelected = true;
        }
        public void NotConfirmed()
        {
            Destroy(figures[figures.Count - 1]);
            figures.Remove(figures[figures.Count - 1]);
        }
        private void _buttonPressed(bool answer)
        {
            Debug.Log(figures.Count);
            if (!answer) NotConfirmed();
            positionSelected = false;
            //selectFigure.SetActive(true);
            
        }
        Vector3 CalculatePosition(GameObject wall)
        {
            Vector3 newPosition = new Vector3(wall.GetComponent<Renderer>().bounds.min.x + (wall.GetComponent<Renderer>().bounds.max.x
                - wall.GetComponent<Renderer>().bounds.min.x) * values[0],
                wall.GetComponent<Renderer>().bounds.min.y + (wall.GetComponent<Renderer>().bounds.max.y
                - wall.GetComponent<Renderer>().bounds.min.y) * values[1],
                wall.GetComponent<Renderer>().bounds.min.z + (wall.GetComponent<Renderer>().bounds.max.z
                - wall.GetComponent<Renderer>().bounds.min.z) * values[2]);//sliderx.value
            return newPosition;
        }
        public void SelectPanelOpen()
        {
            selectFigure.SetActive(true);
            positionSelected = false;
        }
    }
}
