namespace AdvancedTooltips.Samples
{
    using Core;
    using TMPro;
    using UnityEngine;
    using UnityEngine.EventSystems;
    [AddComponentMenu("AdvancedTooltips/Advanced text")]
    public class AdvancedTextPointerHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        [SerializeField] private Sprite backgroundSprite;
        [SerializeField] private Color backgroundColor;

        [SerializeField] private Sprite icon;
        [SerializeField] private Color colorOfIcon = Color.white;
        [SerializeField] private Color colorOfTheText = Color.white;

        [SerializeField] private string text = "Test";
        [SerializeField] private float fontSize = 20;
        [Tooltip("if empty will be using default font"), SerializeField] private TMP_FontAsset font;

        public void OnPointerEnter(PointerEventData eventData)
        {
            TooltipsStatic.ShowNew();

            TooltipsStatic.JustText(icon, colorOfIcon, text, colorOfTheText, customLayout: /* use default one */ null, font, fontSize);
            TooltipsStatic.CustomizeBackground(backgroundSprite, backgroundColor);
        }



        public void OnPointerExit(PointerEventData eventData)
        {
            TooltipsStatic.HideUI();
        }
    }
}