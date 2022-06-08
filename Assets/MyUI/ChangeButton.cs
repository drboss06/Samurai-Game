using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ChangeButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    
    public Button butt;
    public Sprite[] buttonImages;
    private Image oldIm;
    private Image newIm;
    public Image im;

    void Start()
    {
        butt = this.GetComponent<Button>();
        im = GetComponent<Image>();
    }
    public void OnPointerEnter(PointerEventData eventData)
    {       
        im.sprite = buttonImages[0];
   }
 
    public void OnPointerExit(PointerEventData eventData)
    {
        im.sprite = buttonImages[1];
    }
}
