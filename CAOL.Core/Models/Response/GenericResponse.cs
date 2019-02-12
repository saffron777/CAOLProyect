using System;
using System.Collections.Generic;
using System.Text;

namespace CAOL.Core.Models.Response
{
    public class GenericResponse<T> where T: class
    {
        public List<T> Data { get; set; }

        public ErrorResponse Error { get; set; }
    }
}
