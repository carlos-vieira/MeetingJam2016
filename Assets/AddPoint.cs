using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace AssemblyCSharp {

	[RequireComponent(typeof(AudioSource))]
	public class AddPoint : MonoBehaviour {

		public Rigidbody rb;
		private Text txtDeadHumans;
		private Button btnUpgradeWeapon;
		private Text txtUpgradeWeapon;
		private AudioSource bgmIntro;
		public AudioClip song1;

		// Use this for initialization
		void Start () {
			rb = GetComponent<Rigidbody>();

			var bgm1 = GameObject.Find("bgm_1").GetComponent<AudioSource>();
			bgm1.Play();
		}

		// Update is called once per frame
		void Update () {
		}

		void OnMouseDown(){
			//Destroy objects
			Vector3 p = rb.transform.position;
			p.x = 8;
			rb.transform.position = p;

			//Set text
			this.txtDeadHumans = GameObject.Find("txt_deadHumans").GetComponent<Text>();
			this.txtDeadHumans.text = "" + (int.Parse(this.txtDeadHumans.text) + Variables.points);

			var score = int.Parse(this.txtDeadHumans.text);

			//Start Song
			if(score == 1) {
				var bgm1 = GameObject.Find("bgm_1").GetComponent<AudioSource>();
				bgm1.Stop();
				var bgm2 = GameObject.Find("bgm_2").GetComponent<AudioSource>();
				bgm2.Play ();
			}

			//Show first button
			if(score > 10 && Variables.points == 1){
				var bgm2 = GameObject.Find("bgm_2").GetComponent<AudioSource>();
				bgm2.Stop();
				var bgm3 = GameObject.Find("bgm_3").GetComponent<AudioSource>();
				bgm3.Play ();

				this.btnUpgradeWeapon = GameObject.Find("btn_upgradeWeapon").GetComponent<Button>();
				this.txtUpgradeWeapon = GameObject.Find("txt_upgradeWeapon").GetComponent<Text>();

				this.btnUpgradeWeapon.interactable = true;
				this.txtUpgradeWeapon.text = "Novo Upgrade!";
			}

			//Show second button
			else if(score > 6000 && Variables.points == 200){
				var bgm3 = GameObject.Find("bgm_3").GetComponent<AudioSource>();
				bgm3.Stop();
				var bgm4 = GameObject.Find("bgm_4").GetComponent<AudioSource>();
				bgm4.Play ();

				this.btnUpgradeWeapon = GameObject.Find("btn_upgradeWeapon").GetComponent<Button>();
				this.txtUpgradeWeapon = GameObject.Find("txt_upgradeWeapon").GetComponent<Text>();

				this.btnUpgradeWeapon.interactable = true;
				this.txtUpgradeWeapon.text = "Novo Upgrade!";
			}
		}
	}
}