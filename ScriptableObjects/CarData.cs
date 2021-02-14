﻿namespace Conibear {
	using UnityEngine;

	[CreateAssetMenu(menuName = "CarData")]
	public class CarData : ScriptableObject {
		#region SerializeField

		[Header("Prefab")]
		[SerializeField]
		private GameObject m_CarModelPrefab = null;

		[Header("Rigidbody Settings")]
		[SerializeField]
		[Range(0.01f, 1000f)]
		private float m_Mass = 100;

		[SerializeField]
		[Range(0.01f, 1000f)]
		private float m_GroundDrag = 100;

		[SerializeField]
		[Range(0.01f, 1000f)]
		private float m_AirDrag = 100;
		
		[SerializeField]
		[Range(0.01f, 1000f)]
		private float m_GroundAngularDrag = 100;
		
		[SerializeField]
		[Range(0.01f, 1000f)]
		private float m_AirAngularDrag = 100;
		
		[Header("Force")]
		[SerializeField]
		[Range(10, 50)]
		public float m_ForwardForce = 20;

		[SerializeField]
		[Range(5, 25)]
		public float m_ReverseForce = 10;

		[SerializeField]
		[Range(5, 25)]
		public float m_Torque = 50;

		#endregion


		





		#region Public Propertiess

		public GameObject CarModelPrefab {
			get {
				if (m_CarModelPrefab == null) {
					Print.Error("CarModelPrefab null!");
					m_CarModelPrefab = new GameObject("Error Car");
				}

				return m_CarModelPrefab;
			}
		}

		public float Mass {
			get {
				if (m_Mass <= 0) {
					m_Mass = 0.01f;
				}

				return m_Mass;
			}
		}

		

		#endregion


		#region Public Methods

		public void Constructor(GameObject carModelPrefab, float mass) {
			{
				m_CarModelPrefab = carModelPrefab;
				m_Mass = mass;
			}
		}

		#endregion
	}
}