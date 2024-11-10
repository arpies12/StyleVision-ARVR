using UnityEngine;
using UnityEngine.SceneManagement;

public class FemaleFaceShapeSelection : MonoBehaviour
{
    public static string selectedFaceShape;

    public void OnOvalButtonClicked()
    {
        selectedFaceShape = "Oval";
        SceneManager.LoadScene("FemaleHairStyleSuggestion");
    }

    public void OnRoundButtonClicked()
    {
        selectedFaceShape = "Round";
        SceneManager.LoadScene("FemaleHairStyleSuggestion");
    }

    public void OnSquareButtonClicked()
    {
        selectedFaceShape = "Square";
        SceneManager.LoadScene("FemaleHairStyleSuggestion");
    }

    public void OnDiamondButtonClicked()
    {
        selectedFaceShape = "Diamond";
        SceneManager.LoadScene("FemaleHairStyleSuggestion");
    }

    public void OnHeartButtonClicked()
    {
        selectedFaceShape = "Heart";
        SceneManager.LoadScene("FemaleHairStyleSuggestion");
    }
}
