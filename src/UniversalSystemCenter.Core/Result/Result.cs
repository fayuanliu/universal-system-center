using Newtonsoft.Json;

namespace UniversalSystemCenter.Core.Result
{
    public class Result
    {
        public Result()
        {
            ResultEnum = ResultEnum.Error;
        }

        public Result(string message)
        {
            ResultEnum = ResultEnum.Error;
            this.Message = message;
        }

        public Result(ResultEnum result,string message,object data = null)
        {
            ResultEnum = result;
            Message = message;
            Data = data;
        }

        /// <summary>
        /// 操作结果
        /// </summary>
        [JsonProperty("result")]
        public ResultEnum ResultEnum { get; set; }

        /// <summary>
        /// 操作code
        /// </summary>
        [JsonProperty("code")]
        public int Code { get; set; }

        /// <summary>
        /// 提示信息
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// 返回数据
        /// </summary>
        [JsonProperty("data")]
        public object Data { get; set; }
    }
}
