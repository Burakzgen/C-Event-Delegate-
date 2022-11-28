using UnityEngine;

public class EventManager : MonoBehaviour
{
    // Birden fazla metodu ayn� anda �al��t�rmak i�in yap�lan yap�lard�r.
    // Alt alta metodlar� yazmak yerine olu�turulan event i�erisnde += yaparak eklenir.
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
