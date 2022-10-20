using System.ComponentModel;

namespace RazorTdesign.Components
{
    /// <summary>
    /// Size 枚举类型
    /// </summary>
    public enum Size
    {
        /// <summary>
        /// 无设置
        /// </summary>
        None,

        /// <summary>
        /// small
        /// </summary>
        [Description("s")]
        Small,

        /// <summary>
        /// medium
        /// </summary>
        [Description("m")]
        Medium,

        /// <summary>
        /// large
        /// </summary>
        [Description("l")]
        Large,
    }
}
