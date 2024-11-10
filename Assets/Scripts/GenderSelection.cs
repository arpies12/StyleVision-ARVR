using UnityEngine;
using UnityEngine.SceneManagement;

public class GenderSelection : MonoBehaviour
{
    public void OnMaleButtonClicked()
    {
        SceneManager.LoadScene("MaleFaceShapeSelection");
    }

    public void OnFemaleButtonClicked()
    {
        SceneManager.LoadScene("FemaleFaceShapeSelection");
    }
}
