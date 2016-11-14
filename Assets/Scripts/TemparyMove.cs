using UnityEngine;
using System.Collections;

public class TemparyMove : MonoBehaviour
{

    private float verticalVelocity;
    public float gravity = 1.5f;
    public float jumpForce = 0.7f;
    public float speed = 4.0f;
    public float slowDownSpeed = 0.7f;
    public KeyCode jumpKey = KeyCode.Space;
    public KeyCode mouseLockKey = KeyCode.Escape;
    public float turnSpeedx = 80;
    public float turnSpeedy = 80;
    public Camera playerCamera;
    public float maxCameraHeight = 60;
    public float minCameraHeight = -60;
    public Canvas PausedMenu;
    private bool lockedstate;
    void Start()
    {
        PausedMenu.gameObject.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        lockedstate = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(mouseLockKey))
        {
            Debug.Log("key is pressed");
            if (lockedstate == true)
            {
                Cursor.lockState = CursorLockMode.None;
                Time.timeScale = 0;
                PausedMenu.gameObject.SetActive(true);
                Debug.Log("Unlocked cursor");
                lockedstate = false;
            }
            else if (lockedstate == false)
            {
                Cursor.lockState = CursorLockMode.Confined;
                Time.timeScale = 1;
                PausedMenu.gameObject.SetActive(false);
                Debug.Log("Locked cursor");
                lockedstate = true;
            }
        }
        if (Cursor.lockState != CursorLockMode.Locked)
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
            if (Input.GetKeyDown(jumpKey) && controller.isGrounded)
            {
                verticalVelocity = jumpForce;
            }

            Vector3 moveVector = Vector3.zero;
            moveVector = new Vector3(Input.GetAxis("Horizontal"), verticalVelocity, Input.GetAxis("Vertical"));
            moveVector = transform.TransformDirection(moveVector);
            moveVector *= speed;

            controller.Move(moveVector * Time.deltaTime);
            moveVector.x *= slowDownSpeed;
            moveVector.z *= slowDownSpeed;
            controller.Move(moveVector * Time.deltaTime);
        }

    }
}
