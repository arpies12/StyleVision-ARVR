using UnityEngine;
using UnityEngine.SceneManagement;

public class BackNavigation : MonoBehaviour
{
    // Function to go back to a specified previous scene
    public void GoBackToScene(string sceneName)
    {
        if (!string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.LogError("Scene name is empty or invalid.");
        }
    }

    // Class to hold the constant scene names
    public static class SceneNames
    {
        public const string SampleScene = "SampleScene";
        public const string MaleFaceShapeSelection = "MaleFaceShapeSelection";
        public const string FemaleFaceShapeSelection = "FemaleFaceShapeSelection";
        public const string MaleHairStyleSuggestion = "MaleHairStyleSuggestion";
        public const string FemaleHairStyleSuggestion = "FemaleHairStyleSuggestion";
    }
}
