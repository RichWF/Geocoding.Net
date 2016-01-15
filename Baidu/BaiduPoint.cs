using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geocoding.Net.Baidu
{
    public class BaiduPoint
    {
        //返回结果状态值， 成功返回0
        public int status { get; set; }

        public BaiduPointResult result { get; set; }
    }

    public class BaiduPointResult
    {
        //经纬度坐标
        public BaiduPointLocation location { get; set; }
        //位置的附加信息，是否精确查找。1为精确查找，即准确打点；0为不精确，即模糊打点。
        public int precise { get; set; }
        //可信度，描述打点准确度
        public int confidence { get; set; }
        //地址类型
        public string level { get; set; }
    }

    public class BaiduPointLocation
    {
        public double lng { get; set; }

        public double lat { get; set; }
    }
}
