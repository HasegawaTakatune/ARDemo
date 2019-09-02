using UnityEngine;

public class LookAtTarget : MonoBehaviour
{

    /// <summary>
    /// アニメータ格納
    /// </summary>
    private Animator animator;

    /// <summary>
    /// ターゲット
    /// </summary>
    private Transform target;
    
    /// <summary>
    /// 初期化
    /// </summary>
    private void Start()
    {
        animator = GetComponent<Animator>();
        target = Camera.main.transform;
    }

    /// <summary>
    /// Animatorコンポーネントが内部IKシステムを更新する直前に呼び出される
    /// アニメーションの動きが確定する前に呼び出される処理（イメージ）
    /// IK（インバースキネマティクス）
    /// </summary>
    /// <param name="layerIndex">レイヤーインデックス</param>
    private void OnAnimatorIK(int layerIndex)
    {
        // 追跡具合(重み)を調整する
        // weight:全体の重み　bodyWheitgh：体を動かす重み　headWeight：頭を動かす重み
        // eyesWeight：目を動かす重み　clampWeight：モーションの制限量
        animator.SetLookAtWeight(1.0f, 0.8f, 1.0f, 0.0f, 0f);
        animator.SetLookAtPosition(target.position);
    }
}
