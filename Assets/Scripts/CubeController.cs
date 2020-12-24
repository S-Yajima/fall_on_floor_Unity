using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * キューブのコントローラ
 * 床への落下検知後に姿勢を固定する
 */
public class CubeController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*
     * 衝突時に自動で実行される。
     * Collider is Trigger フラグが false の場合のみ実行される。
     * 入力: collision 衝突情報 (ここでは使用しない)
     */
    private void OnCollisionEnter(Collision collision)
    {
        // 床に落ちた瞬間にキューブの姿勢RigidbodyコンポーネントのisKinematicフラグにより固定する
        // Rigidbody
        // bool isKinematic : 物理演算の影響を受けるかどうかを示すフラグ
        GetComponent<Rigidbody>().isKinematic = true;

        /*
         * xyz位置と回転のフリーズによる姿勢の固定を試した。
         * 位置と姿勢の固定自体は正常に動作するが仕組みとして不安を感じるため
         * isKinematicにて姿勢の固定を行う
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX |
                                                RigidbodyConstraints.FreezePositionY |
                                                RigidbodyConstraints.FreezePositionZ |
                                                RigidbodyConstraints.FreezeRotationX |
                                                RigidbodyConstraints.FreezeRotationY |
                                                RigidbodyConstraints.FreezeRotationZ;
        */
    }
}
