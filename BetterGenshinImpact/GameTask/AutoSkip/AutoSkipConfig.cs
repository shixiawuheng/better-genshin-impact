﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterGenshinImpact.GameTask.AutoSkip
{
    /// <summary>
    /// 自动跳过剧情配置
    /// </summary>
    [Serializable]
    public class AutoSkipConfig
    {
        /// <summary>
        /// 触发器是否启用
        /// 启用后：
        /// 1. 快速跳过对话
        /// 2. 自动点击一个识别到的选项
        /// 3. 黑屏过长自动点击跳过
        /// </summary>
        public bool Enable { get; set; } = true;

        /// <summary>
        /// 快速跳过对话
        /// </summary>
        public bool QuicklySkipConversations { get; set; } = true;
    }
}