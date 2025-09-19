using UnityEngine;

[CreateAssetMenu(fileName = "New Ingredient", menuName = "Alchemy/Alchemical Property")]
public class AlchemicalProperty : ScriptableObject
{
    [Tooltip("The display name of the property")]
    public string propertyName;

    [Tooltip("A color to associate this property with")]
    public Color32 propertyColor = new Color32(255, 255, 255, 255);
}
