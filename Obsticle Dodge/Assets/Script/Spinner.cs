using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float YspinSpeed = 0f;
    [SerializeField] float XspinSpeed = 0f;
    [SerializeField] float ZspinSpeed = 0f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(XspinSpeed, YspinSpeed, ZspinSpeed);
    }
}
