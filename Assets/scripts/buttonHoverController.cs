using UnityEngine;  
using System.Collections;  
using UnityEngine.EventSystems;  
using UnityEngine.UI;

public class buttonHoverController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

	public Text Text;
	public Color color;
	public AudioClip sound;

	public void OnPointerEnter(PointerEventData eventData)
	{
		Text.color = color; //Or however you do your color

	}

	public void OnPointerExit(PointerEventData eventData)
	{
		Text.color = Color.black; //Or however you do your color
	}
}