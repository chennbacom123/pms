
using CRS.Pms.Common.Dto;

namespace CRS.Pms.Server.Bussiness
{
    public class ResponseCreator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="code"></param>
        /// <param name="message"></param>
        /// <param name="pagingInfo"></param>
        /// <returns></returns>
        public static IResponseDto<T> CreateResponse<T>(
            T data,
            string code = "0",
            string message = "",
            IPagingDto pagingInfo = null)
        {
            var response = new ResponseDto<T>();
            response.Data = data;
            response.Code = code;
            response.Message = message;
            response.PageInfo = pagingInfo;
            return response;
        }
    }
}