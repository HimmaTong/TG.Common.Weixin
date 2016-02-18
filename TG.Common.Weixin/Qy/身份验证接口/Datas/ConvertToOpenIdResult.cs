﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TG.Common.Weixin.Qy.Datas
{
    /// <summary>
    /// userid转换成openid接口返回的Json结果
    /// </summary>
    public class ConvertToOpenIdResult : JsonResult
    {
        /// <summary>
        /// 企业号成员userid对应的openid，若有传参agentid，则是针对该agentid的openid。否则是针对企业号corpid的openid
        /// </summary>
        public string openid { get; set; }
        /// <summary>
        /// 应用的appid，若请求包中不包含agentid则不返回appid。该appid在使用微信红包时会用到
        /// </summary>
        public string appid { get; set; }
    }
}
