using UnityEngine;

public class RotationEffect : MonoBehaviour
{
    public float meatMult = 5f;
    public float angleMult = 10f;
    void Update()
    {
        float meat = Mathf.Sin(Time.time) * meatMult;
        float angle = Mathf.Sin(Time.time) * angleMult;
        float tilt = Mathf.Sin(Time.time * meat) * angle;
        gameObject.transform.localRotation = Quaternion.Euler(0, 0, tilt);
        
    }
}
