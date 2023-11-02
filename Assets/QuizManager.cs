using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

using System.Threading;
public class QuizManager : MonoBehaviour
{
    public List<QuestionAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public Text QuestionTxt;

    public int Count;
    private void Start()
    {

        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("StartYwY");
        if (QnA.Count > 0)//3
        {
            generateQuestion();
        }
      //o_O
    }

    public void correct() 
    {
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }
    void SetAnswer()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];

            if (QnA[currentQuestion].CorrectAnswer == i + 1) 
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
        }
    }

    


    void generateQuestion()
    {

        if (QnA.Count > 0) //3
        {
            currentQuestion = Random.Range(0, QnA.Count);

            QuestionTxt.text = QnA[currentQuestion].Question;
            SetAnswer();
        }
        else
        {
            SceneManager.LoadScene("Ending");
        }
    }
}
