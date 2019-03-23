using UnityEngine;

public class ChangingAppearence : MonoBehaviour
{
    public SpriteRenderer Part;
    public Sprite[] Options;
    public int Index;

    private void Update()
    {
        for (int i = 0; i < Options.Length; i++)
        {
            if (i == Index)
            {
                Part.sprite = Options[i];
            }
        }
    }

    public void Swap()
    {
        if(Index< Options.Length - 1)
        {
            Index++;
        }
        else
        {
            Index = 0;
        }
    }
}
