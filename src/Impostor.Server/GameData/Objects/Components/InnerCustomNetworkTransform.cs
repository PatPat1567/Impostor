﻿using Impostor.Server.Net.Messages;

namespace Impostor.Server.GameData.Objects.Components
{
    public class InnerCustomNetworkTransform : InnerNetObject
    {
        public override void HandleRpc(byte callId, IMessageReader reader)
        {
            throw new System.NotImplementedException();
        }

        public override bool Serialize(IMessageWriter writer, bool initialState)
        {
            throw new System.NotImplementedException();
        }

        public override void Deserialize(IMessageReader reader, bool initialState)
        {
            throw new System.NotImplementedException();
        }
    }
}