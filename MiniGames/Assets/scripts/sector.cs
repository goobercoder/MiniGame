using UnityEngine;
using TMPro;

public class sector : MonoBehaviour
{
    public Color normalCocklor = new Color(118, 134, 0);
    public Color erectCocklor = Color.purple;
    public TMP_Text[] consumptionary_button_products;
    private int andNowWereOoon = 0;
    
    void Start()
    {
        ChangeColoursUhImBriish();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            andNowWereOoon = (andNowWereOoon -1 + consumptionary_button_products.Length) % consumptionary_button_products.Length;
            ChangeColoursUhImBriish();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            andNowWereOoon = (andNowWereOoon +1) % consumptionary_button_products.Length;
            ChangeColoursUhImBriish();
        }
    }
    void ChangeColoursUhImBriish()
    {
        for(int i = 0; i < consumptionary_button_products.Length; i++) 
        {
            if(i == andNowWereOoon)
            {
                consumptionary_button_products[i].color = erectCocklor;
            }
            else
            {
                consumptionary_button_products[i].color = normalCocklor;
            }
        }
    }
}
