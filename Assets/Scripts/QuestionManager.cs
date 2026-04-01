using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuestionManager : MonoBehaviour
{
    private int selectedOption;
    private int correctOption;

    public Image questionImage;
    public PlayerData playerData;
    public QuestionDatabase questionDatabase;
    
    public TMP_Text questionText;
    public TMP_Text option1Text;
    public TMP_Text option2Text;
    public TMP_Text option3Text;
    public TMP_Text option4Text;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int index = playerData.currentQuestionIndex;
        questionImage.sprite = questionDatabase.questionImages[index];
        questionText.text = questionDatabase.questionTexts[index];
        option1Text.text = questionDatabase.option1Texts[index];
        option2Text.text = questionDatabase.option2Texts[index];
        option3Text.text = questionDatabase.option3Texts[index];
        option4Text.text = questionDatabase.option4Texts[index];
        correctOption = questionDatabase.correctOptions[index];

    }

    

    public void onOptionSelected(int option)
    {
        selectedOption = option;
        checkAnswer();
    }

    private void checkAnswer()
    {
        if (selectedOption == correctOption)
        {
            Debug.Log("Correct Answer!");
            Invoke(nameof(GoToLevelScene), 3f);
        }
        else
        {
            Debug.Log("Incorrect Answer!");
            Invoke(nameof(GoToLoseScene), 3f);
        }
    }

    private void GoToLoseScene()
    {
        SceneManager.LoadScene("LossScreen");
    }
    private void GoToLevelScene()
    {
        SceneManager.LoadScene(playerData.currentLevel);
    }
}
