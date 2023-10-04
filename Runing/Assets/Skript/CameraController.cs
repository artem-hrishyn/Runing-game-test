using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform MainCamera;  // ������ ������
    public Transform Player;      // ������ Player

    void Awake() => MainCamera.position = new Vector3(Player.position.x, 6.21f, Player.position.z - 19.6f);

    void FixedUpdate() => MainCamera.position = new Vector3(Player.position.x, 6.21f, Player.position.z - 19.6f);
}