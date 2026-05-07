using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float MovmentSpeed = 5;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        float MovmentHorizontal = Input.GetAxis("Horizontal");
        float MovmentVertical = Input.GetAxis("Vertical");
        
        transform.Translate(MovmentHorizontal * MovmentSpeed * Time.deltaTime, 0, MovmentVertical * MovmentSpeed * Time.deltaTime);
    }
}
