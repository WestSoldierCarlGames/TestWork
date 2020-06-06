using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace toolmanager
{
    public class ConfirmPanel : MonoBehaviour
    {
        [SerializeField] Button no;
        [SerializeField] Button yes;
        public static ConfirmPanel Instance;
        // Start is called before the first frame update
        void Awake()
        {
            Instance = this;
            no.onClick.AddListener(Reject);
            yes.onClick.AddListener(Confirm);
            gameObject.SetActive(false);
        }
        public delegate void ConfirmPanelButtonPressed(bool yes); // Добавить новый делегат
        public event ConfirmPanelButtonPressed OnConfirmPanelButtonPressed; // Создать на его основе событие
        void Confirm()
        {

            OnConfirmPanelButtonPressed?.Invoke(true);
            gameObject.SetActive(false);
        }
        void Reject()
        {

            OnConfirmPanelButtonPressed?.Invoke(false);
            gameObject.SetActive(false);
        }
    }
}