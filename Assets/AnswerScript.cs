using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager quizManager;
    public void Answer()
    {
        if (isCorrect)
        {
            //Debug.Log("Ura, pobeda");
            quizManager.Count++;
            Debug.Log(quizManager.Count);
            quizManager.correct();
        }
        else
        {
            Debug.Log("DA BLYAT");
            quizManager.correct();
        }
    }


    public void Retry()
    {
        Debug.Log("Dawai zanowo, Misha, wse huinya");
        SceneManager.LoadScene("Base");
    }
}

