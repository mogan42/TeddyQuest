using UnityEngine;
using System.Collections;
public class Movement : MonoBehaviour
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
    Damage  DeadCheck;
    bool dead;
    void Start()
    {
        DeadCheck = GetComponent<Damage>();
        PausedMenu.gameObject.SetActive(false);
       Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
        dead = false;
    }

    void Update()
    {
        dead = DeadCheck.DeathChecker();
        if (Input.GetKeyDown(mouseLockKey) && !dead)
        {
            Debug.Log(dead);
            Debug.Log(DeadCheck.DeathChecker());
            if (Cursor.lockState == CursorLockMode.Locked)
            {
                Cursor.lockState = CursorLockMode.None;
                Time.timeScale = 0;
                PausedMenu.gameObject.SetActive(true);
                Debug.Log("Unlocked cursor");
            }
            else if (Cursor.lockState == CursorLockMode.None)
            {
                Cursor.lockState = CursorLockMode.Locked;
                Time.timeScale = 1;
                PausedMenu.gameObject.SetActive(false);
                Debug.Log("Locked cursor");
            }
        }
        if (Time.timeScale == 1)
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