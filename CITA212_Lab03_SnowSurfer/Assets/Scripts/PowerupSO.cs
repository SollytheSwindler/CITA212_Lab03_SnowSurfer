using UnityEngine;

[CreateAssetMenu(fileName = "Powerup", menuName = "PowerupSO")]
public class NewScriptableObjectScript : ScriptableObject
{
    [SerializeField] string powerupType;
    [SerializeField] float valueChange;
    [SerializeField] float time;
}
