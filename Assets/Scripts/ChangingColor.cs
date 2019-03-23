using UnityEngine;
using UnityEngine.UI;

public class ChangingColor : MonoBehaviour
{
    public GameObject HeadPanel;
    public SpriteRenderer Head;
    public Image SquareHeadImage;
    public Color[] HeadColors;
    public Color CurrentHeadColor = Color.white;

    public GameObject BodyPanel;
    public SpriteRenderer Body;
    public Image SquareBodyImage;
    public Color[] BodyColors;
    public Color CurrentBodyColor = Color.white;

    private Color OverrideHeadColor;
    private Color OverrideBodyColor;

    private void Awake()
    {
        OverrideHeadColor = CurrentHeadColor;
        OverrideBodyColor = CurrentBodyColor;
    }

    private void Update()
    {
        if (!OverrideHeadColor.Equals(CurrentHeadColor))
        {
            SquareHeadImage.color = CurrentHeadColor;
            Head.color = CurrentHeadColor;
            OverrideHeadColor = CurrentHeadColor;
        }

        if (!OverrideBodyColor.Equals(CurrentBodyColor))
        {
            SquareBodyImage.color = CurrentBodyColor;
            Body.color = CurrentBodyColor;
            OverrideBodyColor = CurrentBodyColor;
        }
    }

    public void ChangeHeadPanelState(bool state)
    {
        HeadPanel.SetActive(state);
    }

    public void ChangeBodyPanelState(bool state)
    {
        BodyPanel.SetActive(state);
    }

    public void ChangeHeadColor(int index)
    {
        CurrentHeadColor = HeadColors[index];
    }

    public void ChangeBodyColor(int index)
    {
        CurrentBodyColor = BodyColors[index];
    }
}
