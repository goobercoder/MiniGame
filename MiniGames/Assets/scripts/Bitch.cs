using UnityEngine;

public class Bitch : MonoBehaviour
{
    public imageshadethingcontroller barber;

    
    void Start()
    {
        barber.gameObject.SetActive(true);
        barber.LowTaperFadeOut();
        
    }
}
