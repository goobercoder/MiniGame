using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class EscapeTheEpteinIsland : MonoBehaviour, IPointerClickHandler
{
    private string Boat = "ACollectionOfButtons";
    public void OnPointerClick(PointerEventData eventData)
    {
        SceneManager.LoadScene(Boat);
    }
}
