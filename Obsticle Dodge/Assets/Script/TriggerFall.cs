using UnityEngine;

public class TriggerFall : MonoBehaviour
{
    [SerializeField] GameObject FallObject;
    private void OnTriggerEnter(Collider other)

    {
        if(other.gameObject.tag == "Player")
        {
            FallObject.SetActive(true);
        }
    }
}
