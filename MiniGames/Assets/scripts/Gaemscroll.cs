using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
public class Gaemscroll : MonoBehaviour
{
    public Image selectedImage;
    public Image rightImage;
    public Image leftImage;
    public Sprite[] levelImages;
    public int currentDiddlerIndex = 0;
    public imageshadethingcontroller lowtaperfadeeeee;

    private string[] acceptedAsses = new string[] {"Trump1"};
    private bool IstrumpAssMaster = false;

    void Update()
    {
        selectedImage.sprite = levelImages[((currentDiddlerIndex % levelImages.Length) + levelImages.Length) % levelImages.Length];
        rightImage.sprite = levelImages[(((currentDiddlerIndex + 1) % levelImages.Length) + levelImages.Length) % levelImages.Length];
        leftImage.sprite = levelImages[(((currentDiddlerIndex - 1) % levelImages.Length) + levelImages.Length) % levelImages.Length];

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
            IstrumpAssMaster = false;

            foreach (string assMaster in acceptedAsses)
            {
                if (assMaster == levelImages[((currentDiddlerIndex % levelImages.Length) + levelImages.Length) % levelImages.Length].name)
                {
                    StartCoroutine(ChangeScene(assMaster));
                    IstrumpAssMaster = true;
                    break;
                }
            }

            if (!IstrumpAssMaster)
            {
                Debug.Log("hejhejproblemenoscene");
            }
        }
        
    }
    private IEnumerator ChangeScene(string sceneName)
    {
        lowtaperfadeeeee.LowTaperFadeIn();

        yield return new WaitForSeconds(lowtaperfadeeeee.fadetime);

        SceneManager.LoadScene(sceneName);
    }
     void Start()
    {
        lowtaperfadeeeee.gameObject.SetActive(true);
        lowtaperfadeeeee.LowTaperFadeOut();
        
    }
}
