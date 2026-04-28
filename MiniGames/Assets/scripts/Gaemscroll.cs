using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class Gaemscroll : MonoBehaviour
{
    public Image selectedImage;
    public Image rightImage;
    public Image leftImage;
    public Sprite[] levelImages;
    public int currentDiddlerIndex = 0;

    void Update()
    {
        selectedImage.sprite = levelImages[currentDiddlerIndex];
        rightImage.sprite = levelImages[(currentDiddlerIndex + 1) % levelImages.Length];
        leftImage.sprite = levelImages[(currentDiddlerIndex - 1) % levelImages.Length];

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentDiddlerIndex++;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentDiddlerIndex--;
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("valitsit levelin" + levelImages[currentDiddlerIndex % levelImages.Length].name);
        }
    }
}
