using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace AssemblyCSharp {
	public class UpgradeWeapon : MonoBehaviour {

		private Button btnUpgradeWeapon;
		private Text txtUpgradeWeapon;

		// Use this for initialization
		void Start () {
		
		}
		
		// Update is called once per frame
		void Update () {
		
		}

		// On Click Event
		public void Callback(){
			this.btnUpgradeWeapon = GetComponent<Button>();
			this.txtUpgradeWeapon = GameObject.Find("txt_upgradeWeapon").GetComponent<Text>();

			this.btnUpgradeWeapon.interactable = false;
			this.txtUpgradeWeapon.text = "Sem Upgrades...";

			if (Variables.points == 1) {
				Variables.points = 200;
			}

			else if (Variables.points == 200) {
				Variables.points = 64000;
			}

		}
	}
}