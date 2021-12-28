﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Adv.Server.Packets.Master
{
    class ClientJoinGameServerPacket : MasterPacket
    {
        public int Id { get; set; }
        
        public ClientJoinGameServerPacket(List<byte> rawData) : base(rawData)
        {
        }
    }
}
