using UnityEngine;

public class RotationEffect : MonoBehaviour
{
    public float meatMultMult = 15f;
    private float meatMult = 1f;
    public float angleMult = 10f;
    
    void Update()
    {
        float meat = Mathf.Sin(Time.time) * meatMult;
        float angle = Mathf.Sin(Time.time) * angleMult;
        float tilt = Mathf.Sin(Time.time * meat) * angle;
        gameObject.transform.localRotation = Quaternion.Euler(0, 0, tilt);
        meatMult = Random.Range(0f, 1f) * meatMultMult;
        
    }
}
