using UnityEngine;
using UnityEngine.InputSystem;
public class Movement : MonoBehaviour
{
    [SerializeField] InputAction thrust;
    [SerializeField] InputAction rotaion;
    [SerializeField] AudioClip mainEngine;
    [SerializeField] private float thrustStrength = 1000f;
    [SerializeField] private float rotationStrength = 10f;

    AudioSource audioSource;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        thrust.Enable();
        rotaion.Enable();
    }
    private void FixedUpdate()
    {
        ProssesThrust();
        ProssesRotation();
    }

    private void ProssesThrust()
    {
        if (thrust.IsPressed())
        {
            rb.AddRelativeForce(Vector3.up * thrustStrength * Time.fixedDeltaTime);
            if (!audioSource.isPlaying)
            {
                audioSource.PlayOneShot(mainEngine);
            }
        }
        else
        {
            audioSource.Stop();
        }
    }

    private void ProssesRotation()
    {
        float rotationInput = rotaion.ReadValue<float>();
        if (rotationInput < 0)
        {
            ApplyRotation(rotationStrength);
        }
        else if (rotationInput > 0)
        {
            ApplyRotation(-rotationStrength);
        }
    }

    private void ApplyRotation(float rotationThisFrame)
    {
        rb.freezeRotation = false;
        rb.AddRelativeTorque(Vector3.forward * rotationThisFrame * Time.fixedDeltaTime);
        rb.freezeRotation = true;
    }
}
