using UnityEngine;

public class Player : MonoBehaviour
{
    [Tooltip("Vitesse de déplacement.")]
    [Range(1, 100)] public float _speed;
    private CharacterController _controller;
    private float gravityValue = -9.81f, v, h;
    private Vector3 playerVelocity;


    private void Awake() {
        _controller = GetComponent<CharacterController>();
    }


    void Update()
    {
        Vector3 move = Vector3.zero;
        v = 0;
        h = 0;
        v += Input.GetAxis("Vertical");
        h += Input.GetAxis("Horizontal");
        move += transform.forward * v * _speed * Time.deltaTime;
        move += transform.right * h * _speed * Time.deltaTime;
        _controller.Move(move);

        playerVelocity.y += gravityValue * Time.deltaTime;
        _controller.Move(playerVelocity * Time.deltaTime);
        RotateCamera();
    }
    
    [Tooltip("Sensibilité de la souris. Peut être modifiée par le joueur dans les paramètres.")]
    [Range(0.1f, 9f)] [SerializeField] float CameraSensitivity = 2f;

    [Tooltip("Limite de la rotation verticale de la caméra. Ne peut pas dépasser 90.")]
    [Range(0f, 90f)]
    [SerializeField]
    float yRotationLimit = 88f;

    Vector2 rotation = Vector2.zero;
    
    void RotateCamera()
    {
        rotation.x += Input.GetAxis("Mouse X") * CameraSensitivity;
        rotation.y += Input.GetAxis("Mouse Y") * CameraSensitivity;
        rotation.y = Mathf.Clamp(rotation.y, -yRotationLimit, yRotationLimit);
        var xQuat = Quaternion.AngleAxis(rotation.x, Vector3.up);
        var yQuat = Quaternion.AngleAxis(rotation.y, Vector3.left);

        transform.localRotation = xQuat * yQuat;
    }
    
}