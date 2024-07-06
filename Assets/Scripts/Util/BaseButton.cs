using UnityEngine;
using UnityEngine.EventSystems;  


public class BaseButton : MonoBehaviour,
IPointerClickHandler,  
IPointerDownHandler,  
IPointerUpHandler  {
    public void OnPßPointerUp(PointerEventData eventData){}  
    
    public System.Action onClickCallback;  

    [SerializeField] private CanvasGroup _canvasGroup;  

    public void OnPointerClick(PointerEventData eventData)  
    {
        onClickCallback?.Invoke();  
    }

    public void OnPointerDown(PointerEventData eventData)  
    {  
    }

    public void OnPointerUp(PointerEventData eventData)  
    {
    }
}
