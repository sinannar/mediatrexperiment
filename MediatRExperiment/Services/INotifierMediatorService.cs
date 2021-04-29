using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatRExperiment.Services
{
    public interface INotifierMediatorService
    {
        void Notify(string notifyText);
    }
}
