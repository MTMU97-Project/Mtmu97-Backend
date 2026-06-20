using Mtmu97.Application.Common.FileData;
using Mtmu97.Application.Common.Results;
using Mtmu97.Application.Features.Events.DTOs;
using Mtmu97.Application.Interfaces.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Mtmu97.Application.Features.Events.Commands
{
    public class CreateEventCommand : ICommand<Result<CreateEventResponseDto>>
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime EventDate { get; set; }
        public string Location { get; set; } = null!;
        public FileData? Image { get; set; }
    }
}
