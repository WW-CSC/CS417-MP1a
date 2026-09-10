using UnityEngine;
using UnityEngine.EventSystems;

public class ChangeView : MonoBehaviour, IPointerClickHandler
{
    public GameObject menu;
    
    public void OnPointerClick(PointerEventData eventData)
    {
        GoBack();
    }
    public void GoBack()
    {
        menu.SetActive(false);
    }

}
