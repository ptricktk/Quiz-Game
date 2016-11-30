using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AnswerButon : MonoBehaviour {

    public Text answerText;

    private AnswerData answerData;
    private GameController gameController;

	// Use this for initialization
	void Start () {
        gameController = FindObjectOfType<GameController>();
	}

    public void Setup(AnswerData data)
    {
        answerData = data;
        answerText.text = answerData.answerText;
    }

    public void HandeClick()
    {
        gameController.AnswerButtonClicked(answerData.isCorrect);
    }


}
