using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BtnType : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
  public BTNType currentType;
  public Transform buttonScale;
  Vector3 defaultScale;


  private void Start()
    {
        defaultScale = buttonScale.localScale;
    }
  public void OnBtnClick()
  {
    switch (currentType)
    {
       case BTNType.New:
         
         break;

       case BTNType.Continue:
         
         break;

       case BTNType.Option:
         
         break;

       case BTNType.Back:
         
         break;

       case BTNType.List:
         
         break;

       case BTNType.Quit:
         
         break;
        }
  }
  
  public void OnPointerEnter(PointerEventData eventData)
    {
        buttonScale.localScale = defaultScale*1.2f;
    }
  public void OnPointerExit(PointerEventData eventData)
    {
        buttonScale.localScale = defaultScale;
    }
}
