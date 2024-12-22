using Date;
using UnityEngine;

public class ChoiceIconsScript : MonoBehaviour
{
    public Sprite[] Sprites;
    public Sprite[] Backgrounds;

    public void ChoiceIcon(int num)
    {
        GameData.sprite = Sprites[num];
    }

    public void ChoiceBackground(int num)
    {
        GameData.background = Backgrounds[num];
    }
}