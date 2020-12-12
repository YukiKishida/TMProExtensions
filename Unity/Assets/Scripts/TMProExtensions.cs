using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Ykishida.Unity.Utils
{
    #region Extensions
    /// <summary>
    ///  TMPro 拡張用 クラス
    /// </summary>
    public static class TMProExtensions
    {
        /// <summary>
        ///  TextMeshProに数字を表示時、GC発生無しでテキスト更新する。
        /// （SetTextメソッドを利用した場合、UnityEditor上でGCが観測されるため）
        ///  ※ 常用対数利用のため、負の値は未サポートです。
        /// </summary>
        /// <param name="num">表示させたい数字</param>
        /// <param name="maxDigit">表示させたい数字のMax桁数の配列</param>
        public static void SetTextNonAlloc(this TextMeshProUGUI tmPro, int num, int[] maxDigit)
        {
            var digit = (num == 0) ? 1 : ((int)Mathf.Log10(num) + 1);
            for (int i = digit - 1; i >= 0; i--)
            {
                maxDigit[i] = (num % 10) + 48;
                num /= 10;
            }
            tmPro.SetCharArray(maxDigit, 0, digit);
        }
    }
    #endregion
}