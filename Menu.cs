using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

   
    void Update()
    {if (Input.GetKey(KeyCode.Space))
       {
        SceneManager.LoadScene(1);
       }

      if (Input.GetKey("escape"))  // если нажата клавиша Esc (Escape)
      {
            Application.Quit();    // закрыть приложение
      }
    }

}
