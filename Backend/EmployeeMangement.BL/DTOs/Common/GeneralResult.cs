using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMangement.BL
{
    public class GeneralResult
    {
        public bool Success { get; set; }
        public ResultError[] Errors { get; set; } = [];
    }

    public class GeneralResult<T> : GeneralResult
    {
        public T? Data { get; set; }
    }

    public class ResultError
    {
        public string Code { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
    }

    public class PagedResult<T>
    {
        public List<T> Items { get; set; }
        public int TotalCount { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);
    }
}
