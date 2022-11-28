using UnityEngine;

public class EventManager : MonoBehaviour
{
    // Birden fazla metodu ayný anda çalýþtýrmak için yapýlan yapýlardýr.
    // Alt alta metodlarý yazmak yerine oluþturulan event içerisnde += yaparak eklenir.
    public delegate void OurEventDelegate();
    public static event OurEventDelegate OurEvent;
    private void Start()
    {
        OurEvent += PrintEventManager;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OurEvent();
        }
    }
    private void PrintEventManager()
    {
        Debug.Log("Event Manager'dan geliyor.. => " + gameObject.name);
    }
}
