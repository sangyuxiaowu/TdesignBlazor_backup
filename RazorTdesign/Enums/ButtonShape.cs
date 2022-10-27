using System.ComponentModel;

namespace RazorTdesign.Components
{
    public enum ButtonShape
    {
        /// <summary>
        /// 矩形
        /// </summary>
        [Description("rectangle")]
        Rectangle,

        /// <summary>
        /// 正方形
        /// </summary>
        [Description("square")]
        Square,

        /// <summary>
        /// 圆角矩形
        /// </summary>
        [Description("round")]
        Round,

        /// <summary>
        /// 圆形
        /// </summary>
        [Description("circle")]
        Circle
    }
}
