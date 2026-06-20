using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mtmu97.Application.Common.FileData
{
    public class FileData
    {
        public Stream Stream { get; set; } = null!;
        public string FileName { get; init; } = null!;
        public string ContentType { get; init; } = null!;
    }
}
