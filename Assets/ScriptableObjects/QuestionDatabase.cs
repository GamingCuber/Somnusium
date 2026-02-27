using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

[CreateAssetMenu(fileName = "QuestionDatabase", menuName = "Scriptable Objects/QuestionDatabase")]
public class QuestionDatabase : ScriptableObject
{
    public Sprite[] questionImages;
    public string[] questionTexts;
    public string[] option1Texts;
    public string[] option2Texts;
    public string[] option3Texts;
    public string[] option4Texts;
    public int[] correctOptions;
}
