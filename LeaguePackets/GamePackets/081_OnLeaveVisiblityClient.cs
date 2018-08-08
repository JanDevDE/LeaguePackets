﻿using LeaguePackets.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace LeaguePackets.GamePackets
{
    public class OnLeaveVisiblityClient : GamePacket // 0x51
    {
        public override GamePacketID ID => GamePacketID.OnLeaveVisiblityClient;
        public static OnLeaveVisiblityClient CreateBody(PacketReader reader, ChannelID channelID, NetID senderNetID) 
        {
            var result = new OnLeaveVisiblityClient();
            result.SenderNetID = senderNetID;
            result.ChannelID = channelID;

            return result;
        }
        public override void WriteBody(PacketWriter writer) {}
    }
}