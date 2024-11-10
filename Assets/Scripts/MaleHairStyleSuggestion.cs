using UnityEngine;

public class MaleHairStyleSuggestion : MonoBehaviour
{
    public GameObject ovalHairStyles;
    public GameObject roundHairStyles;
    public GameObject squareHairStyles;
    public GameObject diamondHairStyles;
    public GameObject heartHairStyles;

    void Start()
    {
        DeactivateAllPanels();

        if (MaleFaceShapeSelection.selectedFaceShape == "Oval") ovalHairStyles.SetActive(true);
        else if (MaleFaceShapeSelection.selectedFaceShape == "Round") roundHairStyles.SetActive(true);
        else if (MaleFaceShapeSelection.selectedFaceShape == "Square") squareHairStyles.SetActive(true);
        else if (MaleFaceShapeSelection.selectedFaceShape == "Diamond") diamondHairStyles.SetActive(true);
        else if (MaleFaceShapeSelection.selectedFaceShape == "Heart") heartHairStyles.SetActive(true);
    }

    void DeactivateAllPanels()
    {
        ovalHairStyles.SetActive(false);
        roundHairStyles.SetActive(false);
        squareHairStyles.SetActive(false);
        diamondHairStyles.SetActive(false);
        heartHairStyles.SetActive(false);
    }
}
