using UnityEngine;

public class FemaleHairStyleSuggestion : MonoBehaviour
{
    public GameObject ovalHairStyles;
    public GameObject roundHairStyles;
    public GameObject squareHairStyles;
    public GameObject diamondHairStyles;
    public GameObject heartHairStyles;

    void Start()
    {
        DeactivateAllPanels();

        if (FemaleFaceShapeSelection.selectedFaceShape == "Oval") ovalHairStyles.SetActive(true);
        else if (FemaleFaceShapeSelection.selectedFaceShape == "Round") roundHairStyles.SetActive(true);
        else if (FemaleFaceShapeSelection.selectedFaceShape == "Square") squareHairStyles.SetActive(true);
        else if (FemaleFaceShapeSelection.selectedFaceShape == "Diamond") diamondHairStyles.SetActive(true);
        else if (FemaleFaceShapeSelection.selectedFaceShape == "Heart") heartHairStyles.SetActive(true);
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
