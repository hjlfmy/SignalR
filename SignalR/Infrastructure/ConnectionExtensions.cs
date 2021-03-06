﻿using System.Threading.Tasks;

namespace SignalR.Infrastructure
{
    internal static class ConnectionExtensions
    {
        public static Task Close(this ITransportConnection connection, string connectionId)
        {
            var command = new Command
            {
                Type = CommandType.Disconnect
            };

            return connection.Send(connectionId, command);
        }

        public static Task Abort(this ITransportConnection connection, string connectionId)
        {
            var command = new Command
            {
                Type = CommandType.Abort
            };

            return connection.Send(connectionId, command);
        }
    }
}
