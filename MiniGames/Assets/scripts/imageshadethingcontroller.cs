using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class imageshadethingcontroller : MonoBehaviour
{
    public float fadetime = 1f;
    private Image foto;

    private Color whentimebegantherewasthecolor;

    private Coroutine coroutine;

    void Awake()
    {
        foto = GetComponent<Image>();
        if (foto == null)
        {
            Debug.Log("foto went boom");
            return;
        }
        whentimebegantherewasthecolor = foto.color;
    }

    public void LowTaperFadeIn()
    {
        Startfade(whentimebegantherewasthecolor.a);
    }

    public void LowTaperFadeOut()
    {
        Startfade(0f);
    }

    private IEnumerator FadeAschtonHall(float TargetAlphaomgfuckinalfasocrazyy)
    {
        float seconds = 0f;
        float startAlpha = foto.color.a;

        while (seconds < fadetime)
        {
            seconds += Time.deltaTime;

            Color retardedColor = foto.color;
            float t = seconds / fadetime;
            retardedColor.a = Mathf.Lerp(startAlpha, TargetAlphaomgfuckinalfasocrazyy, t);
            foto.color = retardedColor;

            yield return null;
        }
        Color finalcountdowndododododododododoooooodooooooo = foto.color;
        finalcountdowndododododododododoooooodooooooo.a = TargetAlphaomgfuckinalfasocrazyy;
        foto.color = finalcountdowndododododododododoooooodooooooo;
    }

    private void Startfade(float TargetAlphaomgfuckinalfasocrazyy)
    {
        if(coroutine == null)
        {
            StopCoroutine(FadeAschtonHall(TargetAlphaomgfuckinalfasocrazyy));
        }
        coroutine = StartCoroutine(FadeAschtonHall(TargetAlphaomgfuckinalfasocrazyy));
    }

}
