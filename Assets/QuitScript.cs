using UnityEngine;
using UnityEngine.EventSystems;

public class Quit : MonoBehaviour, IPointerClickHandler
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public void OnPointerClick(PointerEventData eventData)
    {
        QuitGame();
    }
    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
