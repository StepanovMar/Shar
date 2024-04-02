using UnityEngine;
using UnityEngine.UI;

public class MagicBall : MonoBehaviour
{
    public Text answerText;
    public string[] answers =
        {
            "Да, конечно!",
            "Нет, никогда!",
            "Возможно...",
            "Попробуй снова позже.",
            "Не могу сказать сейчас.",
            "Вполне вероятно.",
            "Я не уверен в этом.",
            "Лучше не спрашивай.",
            "Спроси еще раз позже.",
            "Может быть.",
            "Не думаю, что это хорошая идея."
        };

    private void Start()
    {
        answerText.text = ""; // Очищаем текст при запуске
    }

    public void ShakeMagicBall()
    {
        int randomIndex = Random.Range(0, answers.Length); // Выбираем случайный ответ из массива
        string randomAnswer = answers[randomIndex];
        answerText.text = randomAnswer; // Выводим выбранный ответ
    }
}
