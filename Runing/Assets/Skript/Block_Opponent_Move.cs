using UnityEngine;

public class Block_Opponent_Move : MonoBehaviour
{
    public static float speed = 0.15f;

    // Update is called once per frame
    void Update()
    {
        // AddForce () ������������ �������� ������� ����, ������������ ��� ���������
        transform.Translate(0, 0, -0.2f);
    }
}
