using UnityEngine;

public class Dropper : MonoBehaviour
{
    Rigidbody MyRigidbody;
    void Awake()
    {
        gameObject.SetActive(false);
    }
    void Start()
    {
        MyRigidbody = GetComponent<Rigidbody>();
        MyRigidbody.useGravity = true;
    }
}
