using UnityEngine;

public class Movement: MonoBehaviour
{
    private float verticalVelocity;
    public float gravity = 7.0f;
    public float jumpForce = 2.0f;
    public float speed = 5.0f;
    public KeyCode jumpKey = KeyCode.Space;
    public KeyCode mouseLockKey = KeyCode.Escape;
    bool lockstate = true;
    public float turnSpeedx = 10;
    public float turnSpeedy = 10;
    public Camera playerCamera;
    public float maxCameraHeight = 240;
    public float minCameraHeight = 120;

    void Start()
    {
       Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {

        CharacterController controller = GetComponent<CharacterController>();
        verticalVelocity -= gravity * Time.deltaTime;
        float angle = Input.GetAxis("Mouse X") * turnSpeedx * Time.deltaTime;
        transform.Rotate(Vector3.up, angle);
        float yAngle = Input.GetAxis("Mouse Y") * turnSpeedy * Time.deltaTime;
        playerCamera.transform.Rotate(Vector3.right, -yAngle);
        if (playerCamera.transform.localRotation.eulerAngles.x < 360 - maxCameraHeight && playerCamera.transform.localRotation.eulerAngles.x > 180)
        { 
            playerCamera.transform.localRotation = Quaternion.Euler(-maxCameraHeight, 0, 0);
        }
        if (playerCamera.transform.localRotation.eulerAngles.x > -minCameraHeight && playerCamera.transform.localRotation.eulerAngles.x < 180)
        {
            playerCamera.transform.localRotation = Quaternion.Euler(-minCameraHeight, 0, 0);
        }
        Debug.Log(minCameraHeight);
        if (Input.GetKeyDown(jumpKey) && controller.isGrounded)
        {

            verticalVelocity = jumpForce;
        }
        if(Input.GetKeyDown(mouseLockKey))
        {
            if (lockstate == false)
            {
                Cursor.lockState = CursorLockMode.Locked;
                lockstate = true;
            }
             
            else if (lockstate == true)
            {
                Cursor.lockState = CursorLockMode.None;
                lockstate = false;
            }
        }
        Vector3 moveVector = Vector3.zero;
        moveVector = new Vector3(Input.GetAxis("Horizontal"), verticalVelocity, Input.GetAxis("Vertical"));
        moveVector = transform.TransformDirection(moveVector);
        moveVector *= speed;
        controller.Move(moveVector * Time.deltaTime);

    }
}