using FinTsNet.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinTsNet
{
    public class SessionData
    {
        public string SystemId { get; set; }
    }

    public class UserData
    {
        public string UserId { get; set; }
        public int Blz { get; set; }
        public string Pin { get; set; }
    }

    public class ConnectionData
    {
        public string Url { get; set; }
        public string ProductId { get; set; }
        public string ProductVersion { get; set; }
    }

    public class TransactionFactory
    {
        private readonly ConnectionData connection;
        private readonly SessionData session;
        private readonly UserData user;

        public TransactionFactory(ConnectionData connection, SessionData session, UserData user)
        {
            this.connection = connection;
            this.session = session;
            this.user = user;
        }

        public Envelope<SynchronizationMessage> Sync(Hksyn.Query query)
        {
            var date = DateTime.Now;
            var sync = new SynchronizationMessage(session.SystemId, date, user.Blz, user.UserId, connection.ProductId, connection.ProductVersion, query, user.Pin);
            var env = new Envelope<SynchronizationMessage>(sync, date, user.Blz, user.UserId, session.SystemId);
            return env;
        }


    }
}
