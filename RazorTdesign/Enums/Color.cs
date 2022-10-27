using System.ComponentModel;

namespace RazorTdesign.Components
{
    public enum Color
    {
        /// <summary>
        /// 默认色
        /// </summary>
        [Description("default")]
        Default,

        /// <summary>
        /// 品牌色
        /// </summary>
        [Description("primary")]
        Primary,

        /// <summary>
        /// 成功色
        /// </summary>
        [Description("success")]
        Success,

        /// <summary>
        /// 危险色
        /// </summary>
        [Description("danger")]
        Danger,

        /// <summary>
        /// 警告色
        /// </summary>
        [Description("warning")]
        Warning
    }
}
