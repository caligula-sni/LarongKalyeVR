using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 3f;

    void Update()
    {
        var gamepad = Gamepad.current;
        if (gamepad == null) return;

        Vector2 move = gamepad.leftStick.ReadValue();
        transform.Translate(new Vector3(move.x, 0, move.y) * moveSpeed * Time.deltaTime);

        if (gamepad.buttonSouth.wasPressedThisFrame)
        {
            Debug.Log("Button Pressed! Example: Tag, Jump, etc.");
        }
    }
}
