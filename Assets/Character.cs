using UnityEngine;

public class Character : MonoBehaviour
{
    private void Start()
    {
        EventManager.OurEvent += PrintCharacter;
    }
    private void PrintCharacter()
    {
        Debug.Log("Character Metodundan Geliyor.. => " + gameObject.name);
    }
}
