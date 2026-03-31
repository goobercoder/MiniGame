using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class sector : MonoBehaviour
{
    private Color normalCocklor = new Color(118f/255f, 134f/255f, 0f);
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
        if (Input.GetKeyDown(KeyCode.Return))
        {
            ActivateItem(andNowWereOoon);
        }
    }
    public void ActivateItem(int i)
    {
        Debug.Log("vibraattori jonka nimi on tää on ny sun persees: " + consumptionary_button_products[i].text );

        if(consumptionary_button_products[i].text == "Start Shitty minigames")
        {
            SceneManager.LoadScene("Der grose fiddler");
        }
        else if(consumptionary_button_products[i].text == "Settings")
        {
            SceneManager.LoadScene("Der grose insel");
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
