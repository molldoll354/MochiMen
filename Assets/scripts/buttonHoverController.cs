using UnityEngine;  
using System.Collections;  
using UnityEngine.EventSystems;  
using UnityEngine.UI;

public class buttonHoverController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

	public Text Text;
	public Color hoverColor;
	public Color returnColor;
	public AudioClip sound;

	public void OnPointerEnter(PointerEventData eventData)
	{
		Text.color = hoverColor; //Or however you do your color
		Sound.me.PlaySound(sound, 1f);

	}

	public void OnPointerExit(PointerEventData eventData)
	{
		Text.color = returnColor; //Or however you do your color
	}
}