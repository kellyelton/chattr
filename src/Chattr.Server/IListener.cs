using System;
using System.Collections.Generic;

namespace Chattr.Server
{
    public delegate void OnData(byte[] data);

    public interface IListener : IRunnable
    {
        event OnData OnData;
    }

    public interface IDataIdentity
        : IComparable<IDataIdentity>, IComparer<IDataIdentity>
        , IComparable<IUser>, IComparer<IUser>
    {

    }

    public interface IMessage
    {
        long Id { get; }
        string Message { get; }
        IUser From { get; }
        IUser To { get; }
    }

    public interface IUser
    {
        long Id { get; }
        IDataIdentity DataId { get; }
        string Name { get; }
    }

    public interface IRoom : IUser
    {

    }
}