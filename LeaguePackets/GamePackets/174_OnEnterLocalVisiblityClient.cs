﻿using LeaguePackets.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using LeaguePackets.CommonData;

namespace LeaguePackets.GamePackets
{
    public class OnEnterLocalVisiblityClient : GamePacket // 0xAE
    {
        public override GamePacketID ID => GamePacketID.OnEnterLocalVisiblityClient;
        public List<GamePacket> Packets { get; set; } = new List<GamePacket>();
        public LocalVisibilityData LocalVisibilityData { get; set; } = new LocalVisibilityDataUnknown();

        public OnEnterLocalVisiblityClient(){}

        public OnEnterLocalVisiblityClient(PacketReader reader, ChannelID channelID, NetID senderNetID)
        {
            this.SenderNetID = senderNetID;
            this.ChannelID = channelID;

            int totalSize = (ushort)(reader.ReadUInt16() & 0x1FFF);
            for (; totalSize > 0;)
            {
                ushort size = reader.ReadUInt16();
                byte[] data = reader.ReadBytes(size);
                using (var reader2 = new PacketReader(new MemoryStream(data)))
                {
                    this.Packets.Add(GamePacket.CreateGamePacket(reader2, channelID));
                }
                totalSize -= 2;
                totalSize -= size;
            }
            this.LocalVisibilityData = reader.ReadLocalVisibilityData();
            this.ExtraBytes = reader.ReadLeft();
        }

        public override void WriteBody(PacketWriter writer)
        {
            byte[] buffer = new byte[0];
            using (var stream = new MemoryStream())
            {
                using (var writer2 = new PacketWriter(stream, true))
                {
                    foreach (var packet in Packets)
                    {
                        var data = packet.GetBytes();
                        if (data.Length > 0x1FFF)
                        {
                            throw new IOException("Packet too big!");
                        }
                        writer.WriteUInt16((ushort)data.Length);
                        writer.WriteBytes(data);
                    }
                }
                buffer = new byte[stream.Length];
                Buffer.BlockCopy(stream.GetBuffer(), 0, buffer, 0, buffer.Length);
            }
            if (buffer.Length > 0x1FFF)
            {
                throw new IOException("Packet data too big!");
            }
            writer.WriteUInt16((ushort)(buffer.Length & 0x1FFF));
            writer.WriteBytes(buffer);
            writer.WriteLocalVisibilityData(LocalVisibilityData);
        }
    }
}
