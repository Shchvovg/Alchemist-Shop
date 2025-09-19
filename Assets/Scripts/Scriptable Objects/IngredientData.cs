using System.Collections.Generic;
using UnityEditor.EditorTools;
using UnityEngine;

[CreateAssetMenu(fileName = "IngredientData", menuName = "IngredientData")]
public class IngredientData : ScriptableObject
{
    [Tooltip("the display name of the ingredient.")]
    public string ingredientName;

    [Tooltip("The icon for this ingredient")]
    public Sprite icon;

    [Tooltip("The list of properties and their potencies of this ingredient")]
    public List<PropertyPotency> properties;
}
