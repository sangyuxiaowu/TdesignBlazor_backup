using System.ComponentModel;

namespace RazorTdesign.Components
{
    public enum ButtonType
    {
        /// <summary>
        /// 正常按钮
        /// </summary>
        [Description("button")]
        Button,

        /// <summary>
        /// 提交按钮
        /// </summary>
        [Description("submit")]
        Submit,

        /// <summary>
        /// 重置按钮
        /// </summary>
        [Description("reset")]
        Reset
    }
}
