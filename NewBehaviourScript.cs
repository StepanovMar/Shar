using UnityEngine;
using UnityEngine.UI;

public class MagicBall : MonoBehaviour
{
    public Text answerText;
    public string[] answers =
        {
            "��, �������!",
            "���, �������!",
            "��������...",
            "�������� ����� �����.",
            "�� ���� ������� ������.",
            "������ ��������.",
            "� �� ������ � ����.",
            "����� �� ���������.",
            "������ ��� ��� �����.",
            "����� ����.",
            "�� �����, ��� ��� ������� ����."
        };

    private void Start()
    {
        answerText.text = ""; // ������� ����� ��� �������
    }

    public void ShakeMagicBall()
    {
        int randomIndex = Random.Range(0, answers.Length); // �������� ��������� ����� �� �������
        string randomAnswer = answers[randomIndex];
        answerText.text = randomAnswer; // ������� ��������� �����
    }
}
