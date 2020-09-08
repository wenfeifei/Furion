﻿// -----------------------------------------------------------------------------
// Fur 是 .NET 5 平台下极易入门、极速开发的 Web 应用框架。
// Copyright © 2020 Fur, Baiqian Co.,Ltd.
//
// 框架名称：Fur
// 框架作者：百小僧
// 框架版本：1.0.0
// 源码地址：https://gitee.com/monksoul/Fur 
// 开源协议：Apache-2.0（http://www.apache.org/licenses/LICENSE-2.0）
// -----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Data;

namespace Fur.DatabaseAccessor
{
    /// <summary>
    /// 存储过程输出返回值
    /// </summary>
    public sealed class ProcedureOutput
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public ProcedureOutput()
        {
            OutputValues = new Dictionary<string, object>();
        }

        /// <summary>
        /// 输出值
        /// </summary>
        public Dictionary<string, object> OutputValues { get; set; }

        /// <summary>
        /// 返回值
        /// </summary>
        public object ReturnValue { get; set; }

        /// <summary>
        /// 结果集
        /// </summary>
        public DataSet Result { get; set; }
    }
}
