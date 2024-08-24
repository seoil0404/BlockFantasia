using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class StartButtonInput : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] Text ButtonText;
    public void OnPointerEnter(PointerEventData eventData)
    {
        ButtonText.color = Color.gray;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        ButtonText.color = Color.white;
    }
}
