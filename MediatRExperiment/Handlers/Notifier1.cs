﻿using MediatR;
using MediatRExperiment.Messages;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRExperiment.Handlers
{
    public class Notifier1 : INotificationHandler<NotificationMessage>
    {
        public Task Handle(NotificationMessage notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Debugging from Notifier 1. Message  : {notification.NotifyText} ");
            return Task.CompletedTask;
        }
    }
}
