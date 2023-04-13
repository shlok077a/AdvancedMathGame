using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public GameObject cross;
    
    public GameObject operatorr;
    public GameObject operatorr2;
    public GameObject operaterr3;
    public GameObject operaterr4;
    public static string operaterrr = "none";

    public void Quit()
    {
        Application.Quit();
    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // 1
    public void Addition()
    {
        operaterrr = "Add";
        SceneManager.LoadScene("Easy");
    }
    public void Subtract()
    {
        operaterrr = "Subtract";
        SceneManager.LoadScene("Easy");
    }
    public void Multiply()
    {
        operaterrr = "Multiply";
        SceneManager.LoadScene("Easy");
    }
    public void Division()
    {
        operaterrr = "Division";
        SceneManager.LoadScene("Easy");
    }
    
    // 2
    public void Addition2()
    {
        operaterrr = "Add2";
        SceneManager.LoadScene("Level2");
    }
    public void Subtract2()
    {
        operaterrr = "Subtract2";
        SceneManager.LoadScene("Level2");
    }
    public void Division2()
    {
        operaterrr = "Division2";
        SceneManager.LoadScene("Level2");
    }
    public void Multiply2()
    {
        operaterrr = "Multiply2";
        SceneManager.LoadScene("Level2");
    }
    
    // 3
    public void Addition3()
    {
        operaterrr = "Add3";
        SceneManager.LoadScene("Level3");
    }
    public void Subtract3()
    {
        operaterrr = "Subtract3";
        SceneManager.LoadScene("Level3");
    }
    public void Division3()
    {
        operaterrr = "Division3";
        SceneManager.LoadScene("Level3");
    }
    public void Multiply3()
    {
        operaterrr = "Multiply3";
        SceneManager.LoadScene("Level3");
    }
     
    // 4
    public void Addition4()
    {
        operaterrr = "Add4";
        SceneManager.LoadScene("Level4");
    }
    public void Subtract4()
    {
        operaterrr = "Subtract4";
        SceneManager.LoadScene("Level4");
    }
    public void Division4()
    {
        operaterrr = "Division4";
        SceneManager.LoadScene("Level4");
    }
    public void Multiply4()
    {
        operaterrr = "Multiply4";
        SceneManager.LoadScene("Level4");
    }

    public void Cross()
    {
        cross.SetActive(false);
    }
    public void NOsCross()
    {
        cross.SetActive(true);
    }
    public void Cross1()
    {
        operatorr.SetActive(false);
    }
    public void Cross2()
    {
        operatorr2.SetActive(false);
    }
    public void Cross3()
    {
        operaterr3.SetActive(false);
    }
    public void Cross4()
    {
        operaterr4.SetActive(false);
    }
    public void OpenOperator()
    {
        operatorr.SetActive(true);
    }

    public void OpenOperator2()
    {
        operatorr2.SetActive(true);
    }

    public void OpenOperator3()
    {
        operaterr3.SetActive(true);
    }

    public void OpenOperator4()
    {
        operaterr4.SetActive(true);
    }
}
