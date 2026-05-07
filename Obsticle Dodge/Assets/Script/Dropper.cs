using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 2f;
    MeshRenderer MyMeshRenderer;
    Rigidbody MyRigidbody;
        void Start()
    {
        MyMeshRenderer = GetComponent<MeshRenderer>();
        MyRigidbody = GetComponent<Rigidbody>();
        
        MyMeshRenderer.enabled = false;
        MyRigidbody.useGravity = false;
    }

    void Update()
    {
       if(Time.time > timeToWait)
       {
            MyRigidbody.useGravity = true;
            MyMeshRenderer.enabled = true;        
       }
    }
}
