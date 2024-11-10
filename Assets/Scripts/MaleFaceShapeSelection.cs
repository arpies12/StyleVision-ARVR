using UnityEngine;
using UnityEngine.SceneManagement;

public class MaleFaceShapeSelection : MonoBehaviour
{
    public static string selectedFaceShape;

    public void OnOvalButtonClicked()
    {
        selectedFaceShape = "Oval";
        SceneManager.LoadScene("MaleHairStyleSuggestion");
    }

    public void OnRoundButtonClicked()
    {
        selectedFaceShape = "Round";
        SceneManager.LoadScene("MaleHairStyleSuggestion");
    }

    public void OnSquareButtonClicked()
    {
        selectedFaceShape = "Square";
        SceneManager.LoadScene("MaleHairStyleSuggestion");
    }

    public void OnDiamondButtonClicked()
    {
        selectedFaceShape = "Diamond";
        SceneManager.LoadScene("MaleHairStyleSuggestion");
    }

    public void OnHeartButtonClicked()
    {
        selectedFaceShape = "Heart";
        SceneManager.LoadScene("MaleHairStyleSuggestion");
    }
}
