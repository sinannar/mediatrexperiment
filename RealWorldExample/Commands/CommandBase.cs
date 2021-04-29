using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealWorldExample.Commands
{
    public class CommandBase<T> : IRequest<T> where T : class
    {

    }
}
