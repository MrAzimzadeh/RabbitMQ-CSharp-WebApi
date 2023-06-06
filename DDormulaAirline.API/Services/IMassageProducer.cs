using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DDormulaAirline.API.Services
{
    public interface IMassageProducer
    {
        public void SendingMessage<T>(T message);
    }
}