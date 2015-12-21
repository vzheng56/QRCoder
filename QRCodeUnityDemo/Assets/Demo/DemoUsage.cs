using UnityEngine;
using System.Collections;
using UnityEngine.UI;

using QRCoder;

public class DemoUsage : MonoBehaviour {

	public RawImage textureUI; 
	public InputField fieldText;
	private string fieldTextContent;
	// Use this for initialization
	void Start () {

	}

	public void QRGet(){
		QRCodeGenerator qrGenerator = new QRCodeGenerator();
		QRCodeData qrCodeData = qrGenerator.CreateQrCode(fieldTextContent, QRCodeGenerator.ECCLevel.Q);
		UnityQRCode qrCode = new UnityQRCode(qrCodeData);
		Texture2D qrCodeImage = qrCode.GetGraphic(20);
		textureUI.texture = qrCodeImage;
	}
	// Update is called once per frame
	void Update () {

		if (fieldText != null) {
			fieldTextContent = fieldText.text;
		}
	}
}
