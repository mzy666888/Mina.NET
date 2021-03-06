﻿using System;
using Mina.Core.Session;

namespace Mina.Filter.Codec
{
    /// <summary>
    /// An abstract <see cref="IProtocolEncoder"/> implementation for those who don't have any
    /// resources to dispose.
    /// </summary>
    public abstract class ProtocolEncoderAdapter : IProtocolEncoder
    {
        public abstract void Encode(IoSession session, Object message, IProtocolEncoderOutput output);

        public virtual void Dispose(IoSession session)
        {
            // Do nothing
        }
    }
}
