using System.ComponentModel;

namespace RazorTdesign.Components
{
    public enum ButtonVariant
    {
        /// <summary>
        /// 基础
        /// </summary>
        [Description("base")]
        Base,

        /// <summary>
        /// 线框
        /// </summary>
        [Description("outline")]
        Outline,

        /// <summary>
        /// 虚线
        /// </summary>
        [Description("dashed")]
        Dashed,

        /// <summary>
        /// 文字
        /// </summary>
        [Description("text")]
        Text
    }
}
