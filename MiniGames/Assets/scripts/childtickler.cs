using System.Collections;
using System.Numerics;
using System.Threading;
using Microsoft.Unity.VisualStudio.Editor;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class childtickler : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D rb;
    public TMP_Text loseText;
    public GameObject loseimage;

    
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        // Launch the ball in a random diagonal direction
        Launch();
    }

    void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        
        rb.linearVelocity = new UnityEngine.Vector2(x * speed, y * speed);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "DeathTrigger")
        {
            loseText.enabled = true;
            loseimage.SetActive(true);
            StartCoroutine(ReturnToMenu());
        }
    }
    private IEnumerator ReturnToMenu()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Der grose fiddler");

    }
}