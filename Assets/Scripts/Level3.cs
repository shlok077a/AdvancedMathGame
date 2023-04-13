using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Level3 : MonoBehaviour
{
    public AudioSource correct;
    public AudioSource wrong;
    public TextMeshProUGUI question1;
    public TextMeshProUGUI question2;
    public TextMeshProUGUI ans1;
    public TextMeshProUGUI ans2;
    public TextMeshProUGUI ans3;
    public TextMeshProUGUI rightWrongText;
    public TextMeshProUGUI OpeatorSign;
    public TextMeshProUGUI Total;
    public TextMeshProUGUI OutOf;
    public int TotalInt;
    public int OutofInt;

    public int[] PrimeNumbers;
    public int displayRandonQ1;
    public int displayRandonQ2;
    public int firstNumInProblem;
    public int SecNumInProblem;
    public int answ1;
    public int answ2;
    public int answ3;
    public int randomFakeAnsDecider;
    public int randomAnsPlacement;
    public int currAns;
    public int swap;

    void Start()
    {
        rightWrongText.enabled = false;
        if(SceneManagement.operaterrr == "Add3")
        {
            MakeMathQuestion();
        }
        if(SceneManagement.operaterrr == "Subtract3")
        {
            MakeMathQuestionSub();
        }
        if (SceneManagement.operaterrr == "Multiply3")
        {
            MakeMathQuestionMul();
        }
        if (SceneManagement.operaterrr == "Division3")
        {
            MakeMathQuestionDiv();
        }
    }

    void MakeMathQuestion()
    {
        displayRandonQ1 = Random.Range(100, 999);
        displayRandonQ2 = Random.Range(100, 999);

        firstNumInProblem = displayRandonQ1;
        SecNumInProblem = displayRandonQ2;

        answ1 = firstNumInProblem + SecNumInProblem;
        OpeatorSign.text = "+";
        randomFakeAnsDecider = Random.Range(0,2);

        question1.text = "" + firstNumInProblem;
        question2.text = "" + SecNumInProblem;

        if (randomFakeAnsDecider == 0)
        {
            answ2 = answ1 + Random.Range(1,5);
            answ3 = answ1 - Random.Range(1,5);
        }else
        {
            answ2 = answ1 - Random.Range(1,5);
            answ3 = answ1 + Random.Range(1,5);
        }

        randomAnsPlacement = Random.Range(0,3);

        if (randomAnsPlacement == 0)
        {
            ans1.text = "" + answ1;
            ans2.text = "" + answ2;
            ans3.text = "" + answ3;
            currAns = 0;
        }else if(randomAnsPlacement == 1)
        {
            ans1.text = "" + answ2;
            ans2.text = "" + answ1;
            ans3.text = "" + answ3;
            currAns = 1;
        } else
        {
            ans1.text = "" + answ3;
            ans2.text = "" + answ2;
            ans3.text = "" + answ1;
            currAns = 2;
        }
    }

    void MakeMathQuestionDiv()
    {
        displayRandonQ1 = Random.Range(50, 300);
        displayRandonQ2 = Random.Range(10, 50);

        while(displayRandonQ1 % displayRandonQ2 != 0)
        {
            displayRandonQ1 = Random.Range(50, 300);
            displayRandonQ2 = Random.Range(10, 50);
        }

        firstNumInProblem = displayRandonQ1;
        SecNumInProblem = displayRandonQ2;

        if(firstNumInProblem - SecNumInProblem < 0)
        {
            swap = SecNumInProblem;
            SecNumInProblem = firstNumInProblem;
            firstNumInProblem = swap;
        }

        answ1 = firstNumInProblem / SecNumInProblem;
        OpeatorSign.text = "÷";
        randomFakeAnsDecider = Random.Range(0,2);

        question1.text = "" + firstNumInProblem;
        question2.text = "" + SecNumInProblem;

        if (randomFakeAnsDecider == 0)
        {
            answ2 = answ1 + Random.Range(1,5);
            answ3 = answ1 - Random.Range(1,5);
        }else
        {
            answ2 = answ1 - Random.Range(1,5);
            answ3 = answ1 + Random.Range(1,5);
        }

        randomAnsPlacement = Random.Range(0,3);

        if (randomAnsPlacement == 0)
        {
            ans1.text = "" + answ1;
            ans2.text = "" + answ2;
            ans3.text = "" + answ3;
            currAns = 0;
        }else if(randomAnsPlacement == 1)
        {
            ans1.text = "" + answ2;
            ans2.text = "" + answ1;
            ans3.text = "" + answ3;
            currAns = 1;
        } else
        {
            ans1.text = "" + answ3;
            ans2.text = "" + answ2;
            ans3.text = "" + answ1;
            currAns = 2;
        }
    }
    void MakeMathQuestionMul()
    {
        displayRandonQ1 = Random.Range(10, 50);
        displayRandonQ2 = Random.Range(10, 30);

        firstNumInProblem = displayRandonQ1;
        SecNumInProblem = displayRandonQ2;

        answ1 = firstNumInProblem * SecNumInProblem;
        OpeatorSign.text = "x";
        randomFakeAnsDecider = Random.Range(0,2);

        question1.text = "" + firstNumInProblem;
        question2.text = "" + SecNumInProblem;

        if (randomFakeAnsDecider == 0)
        {
            answ2 = answ1 + Random.Range(1,5);
            answ3 = answ1 - Random.Range(1,5);
        }else
        {
            answ2 = answ1 - Random.Range(1,5);
            answ3 = answ1 + Random.Range(1,5);
        }

        randomAnsPlacement = Random.Range(0,3);

        if (randomAnsPlacement == 0)
        {
            ans1.text = "" + answ1;
            ans2.text = "" + answ2;
            ans3.text = "" + answ3;
            currAns = 0;
        }else if(randomAnsPlacement == 1)
        {
            ans1.text = "" + answ2;
            ans2.text = "" + answ1;
            ans3.text = "" + answ3;
            currAns = 1;
        } else
        {
            ans1.text = "" + answ3;
            ans2.text = "" + answ2;
            ans3.text = "" + answ1;
            currAns = 2;
        }
    }
    void MakeMathQuestionSub()
    {
        displayRandonQ1 = Random.Range(0, 999);
        displayRandonQ2 = Random.Range(0, 99);

        firstNumInProblem = displayRandonQ1;
        SecNumInProblem = displayRandonQ2;

        if(firstNumInProblem - SecNumInProblem < 0)
        {
            swap = SecNumInProblem;
            SecNumInProblem = firstNumInProblem;
            firstNumInProblem = swap;
        }

        answ1 = firstNumInProblem - SecNumInProblem;

        
        OpeatorSign.text = "-";
        randomFakeAnsDecider = Random.Range(0,2);

        question1.text = "" + firstNumInProblem;
        question2.text = "" + SecNumInProblem;

        if (randomFakeAnsDecider == 0)
        {
            answ2 = answ1 + Random.Range(1,2);
            answ3 = answ1 + Random.Range(3,5);
        }else
        {
            answ2 = answ1 + Random.Range(1,2);
            answ3 = answ1 + Random.Range(3,5);
        }

        randomAnsPlacement = Random.Range(0,3);

        if (randomAnsPlacement == 0)
        {
            ans1.text = "" + answ1;
            ans2.text = "" + answ2;
            ans3.text = "" + answ3;
            currAns = 0;
        }else if(randomAnsPlacement == 1)
        {
            ans1.text = "" + answ2;
            ans2.text = "" + answ1;
            ans3.text = "" + answ3;
            currAns = 1;
        } else
        {
            ans1.text = "" + answ3;
            ans2.text = "" + answ2;
            ans3.text = "" + answ1;
            currAns = 2;
        }
    }

    public void ButtonAns0()
    {
        if(currAns == 0)
        {
            rightWrongText.enabled = true;
            rightWrongText.color = Color.green;
            rightWrongText.text = ("Correct!");
            Invoke("NextQuestion", 1);
            TotalInt++;
            OutofInt++;
            Total.text = TotalInt.ToString();
            OutOf.text = OutofInt.ToString();
            correct.Play();
        }else
        {
            rightWrongText.enabled = true;
            rightWrongText.color = Color.red;
            rightWrongText.text = ("Wrong!");
            Invoke("NextQuestion", 1);
            TotalInt++;
            Total.text = TotalInt.ToString();
            wrong.Play();
        }
    }

    public void ButtonAns1()
    {
        if(currAns == 1)
        {
            rightWrongText.enabled = true;
            rightWrongText.color = Color.green;
            rightWrongText.text = ("Correct!");
            Invoke("NextQuestion", 1);
            TotalInt++;
            OutofInt++;
            Total.text = TotalInt.ToString();
            OutOf.text = OutofInt.ToString();
            correct.Play();
        }else
        {
            rightWrongText.enabled = true;
            rightWrongText.color = Color.red;
            rightWrongText.text = ("Wrong!");
            Invoke("NextQuestion", 1);
            TotalInt++;
            Total.text = TotalInt.ToString();
            wrong.Play();
        }
    }

    public void ButtonAns2()
    {
        if(currAns == 2)
        {
            rightWrongText.enabled = true;
            rightWrongText.color = Color.green;
            rightWrongText.text = ("Correct!");
            Invoke("NextQuestion", 1);
            TotalInt++;
            OutofInt++;
            Total.text = TotalInt.ToString();
            OutOf.text = OutofInt.ToString();
            correct.Play();
        }else
        {
            rightWrongText.enabled = true;
            rightWrongText.color = Color.red;
            rightWrongText.text = ("Wrong!");
            Invoke("NextQuestion", 1);
            TotalInt++;
            Total.text = TotalInt.ToString();
            wrong.Play();
        }
    }

    public void NextQuestion()
    {
        if (SceneManagement.operaterrr == "Add3")
        {
            rightWrongText.enabled = false;
            MakeMathQuestion();
        }   

        if (SceneManagement.operaterrr == "Subtract3")
        {
            rightWrongText.enabled = false;
            MakeMathQuestionSub();
        } 
        if(SceneManagement.operaterrr == "Multiply3")
        {
            rightWrongText.enabled = false;
            MakeMathQuestionMul();
        }
         if(SceneManagement.operaterrr == "Division3")
        {
            rightWrongText.enabled = false;
            MakeMathQuestionDiv();
        }      
    }
    public void BackButton()
    {
        SceneManager.LoadScene("DifficultyScene");
    }
}
